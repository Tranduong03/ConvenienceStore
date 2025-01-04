using GroceryStore.Model;
using GroceryStore.OtherProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.Views.AdminView
{
    public partial class ImportProduct : Form
    {
        public ImportProduct()
        {
            InitializeComponent();
            InitializeDataGridView();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            productListForm.Owner = this; // Truyền tham chiếu của ImportProduct
            productListForm.ShowDialog();
        }


        private void InitializeDataGridView()
        {
            dataGridViewQuantity.Columns.Add("ProductID", "Mã Sản Phẩm");
            dataGridViewQuantity.Columns.Add("ProductName", "Tên Sản Phẩm");
            dataGridViewQuantity.Columns.Add("SupplierID", "Mã Nhà Cung Cấp");
            dataGridViewQuantity.Columns.Add("SupplierName", "Tên Nhà Cung Cấp");
            dataGridViewQuantity.Columns.Add("Quantity", "Số Lượng");
            dataGridViewQuantity.Columns.Add("SellPrice", "Giá Mua");
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) // Cột "Số lượng"
            {
                var row = dataGridViewQuantity.Rows[e.RowIndex];
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal sellPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value);
                row.Cells["TotalPrice"].Value = quantity * sellPrice;
            }
        }

        private void SaveImportData()
        {
            using (var context = new AppDBContext())
            {
                // Tạo Import mới
                var import = new Import
                {
                    ImportDate = DateTime.Now,
                    TotalCost = dataGridViewQuantity.Rows.Cast<DataGridViewRow>()
                                 .Sum(row => Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["SellPrice"].Value))
                };

                context.Imports.Add(import);
                context.SaveChanges();

                foreach (DataGridViewRow row in dataGridViewQuantity.Rows)
                {
                    if (row.Cells["ProductID"].Value == null || row.Cells["SupplierID"].Value == null) continue;

                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    int supplierId = Convert.ToInt32(row.Cells["SupplierID"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value);

                    // Tạo ImportDetail mới
                    var importDetail = new ImportDetail
                    {
                        ImportID = import.ImportID,
                        ProductID = productId,
                        SupplierID = supplierId, // Thêm SupplierID
                        Quantity = quantity,
                        UnitPrice = unitPrice
                    };

                    context.ImportDetails.Add(importDetail);

                    // Cập nhật Stock trong bảng Product
                    var product = context.Products.FirstOrDefault(p => p.ProductID == productId);
                    if (product != null)
                    {
                        product.Stock += quantity; // Cộng thêm số lượng vào Stock
                    }
                }

                context.SaveChanges();
            }
        }



        public void AddProductToGrid(Product product, Supplier supplier)
        {
            dataGridViewQuantity.Rows.Add(
                product.ProductID,
                product.ProductName,
                supplier.SupplierID,
                supplier.SupplierName,
                0, // Số lượng mặc định là 0
                product.SellPrice
            );
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (dataGridViewQuantity.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveImportData();
                MessageBox.Show("Lưu dữ liệu và cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu trong DataGridView
                dataGridViewQuantity.Rows.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


    }
}
