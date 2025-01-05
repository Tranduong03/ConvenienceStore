using System;
using System.Linq;
using System.Windows.Forms;
using GroceryStore.Model;
using GroceryStore.OtherProcess;

namespace GroceryStore.Views.AdminView
{
    public partial class ProductListForm : Form
    {
        public Product SelectedProduct { get; private set; }

        public ProductListForm()
        {
            InitializeComponent();

        }

        private void LoadProducts()
        {
            using (var context = new AppDBContext())
            {
                dataGridViewProducts.DataSource = null;
                dataGridViewProducts.DataSource = context.Products
                                                         .Where(p => p.SupplierID == cbSupplier.SelectedIndex + 1)
                                                         .Select(p => new
                                                         {
                                                             ProductID = p.ProductID,
                                                             ProductName = p.ProductName
                                                         })
                                                         .ToList();
                dataGridViewProducts.Columns["ProductID"].HeaderText = "ID";
                dataGridViewProducts.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            }
        }

        private void LoadSuppliers()
        {
            using (var db = new AppDBContext())
            {
                var suppliers = db.Suppliers.ToList();
                cbSupplier.DataSource = suppliers;
                cbSupplier.DisplayMember = "SupplierName"; // Tên cột trong bảng Supplier
                cbSupplier.ValueMember = "SupplierID";    // ID nhà cung cấp
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn sản phẩm hoặc nhà cung cấp
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var context = new AppDBContext();

            if (cbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int productID = (int)dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value;
            var selectedProduct = (Product)context.Products.FirstOrDefault(p => p.ProductID == productID);
            var selectedSupplier = (Supplier)cbSupplier.SelectedItem;

            // Gửi dữ liệu về ImportProduct (giả sử bạn truyền qua constructor)
            AddImportProduct parentForm = (AddImportProduct)this.Owner;
            parentForm.AddProductToGrid(selectedProduct, selectedSupplier);

            this.Close(); // Đóng form sau khi chọn
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadProducts();
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
