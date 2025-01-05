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
        private bool isDataSaved = false; // Biến để theo dõi trạng thái lưu dữ liệu

        public ImportProduct()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.FormClosing += ImportProduct_FormClosing;
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

        private void dataGridViewQuantity_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) // Cột "Số lượng"
            {
                var row = dataGridViewQuantity.Rows[e.RowIndex];
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal sellPrice = Convert.ToDecimal(row.Cells["SellPrice"].Value);
                row.Cells["TotalPrice"].Value = quantity * sellPrice;
            }
        }

        private void SaveImportData(int? userId)
        {
            if (userId == null)
            {
                MessageBox.Show("UserID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy người dùng với UserID này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var import = new Import
                {
                    ImportDate = DateTime.Now,
                    TotalCost = dataGridViewQuantity.Rows.Cast<DataGridViewRow>()
                                 .Sum(row => Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["SellPrice"].Value)),
                    UserID = userId // Lưu UserID vào Import
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

                    var importDetail = new ImportDetail
                    {
                        ImportID = import.ImportID,
                        ProductID = productId,
                        SupplierID = supplierId,
                        Quantity = quantity,
                        UnitPrice = unitPrice
                    };

                    context.ImportDetails.Add(importDetail);

                    var product = context.Products.FirstOrDefault(p => p.ProductID == productId);
                    if (product != null)
                    {
                        product.Stock += quantity;
                    }
                }

                context.SaveChanges();
            }

            isDataSaved = true; // Đánh dấu là dữ liệu đã được lưu
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

        private void ImportProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataSaved) // Nếu dữ liệu chưa được lưu
            {
                var result = MessageBox.Show("Dữ liệu chưa được lưu! Bạn có chắc chắn muốn thoát không?",
                                             "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy việc đóng form nếu chọn "No"
                }
                // Nếu chọn "Yes", cho phép form đóng mà không lưu dữ liệu
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào có giá trị "Quantity" bằng 0
            foreach (DataGridViewRow row in dataGridViewQuantity.Rows)
            {
                if (row.Cells["Quantity"].Value != null && Convert.ToInt32(row.Cells["Quantity"].Value) == 0)
                {
                    MessageBox.Show("Số lượng phải khác 0! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ngừng thực hiện việc lưu
                }
            }

            // Kiểm tra nếu không có dữ liệu
            if (dataGridViewQuantity.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giả sử bạn lấy được UserID của người dùng hiện tại
            int? currentUserId = CurrentUser.UserID;

            if (currentUserId == null)
            {
                MessageBox.Show("Không có người dùng đăng nhập hoặc UserID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tất cả số lượng hợp lệ, tiếp tục lưu
            SaveImportData(currentUserId);

            MessageBox.Show("Lưu dữ liệu và cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa dữ liệu trong DataGridView sau khi lưu
            dataGridViewQuantity.Rows.Clear();

            isDataSaved = true; // Đánh dấu dữ liệu đã được lưu

            // Đóng form sau khi lưu
            this.Close();
        }

        private void ImportProduct_Load(object sender, EventArgs e)
        {
            this.FormClosing += ImportProduct_FormClosing; // Đăng ký sự kiện FormClosing
        }
    }


}
