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
            LoadProducts();
            LoadSuppliers();
        }

        private void LoadProducts()
        {
            using (var context = new AppDBContext())
            {
                dataGridViewProducts.DataSource = context.Products.ToList();
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

            if (cbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy sản phẩm đã chọn
            var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
            var selectedSupplier = (Supplier)cbSupplier.SelectedItem;

            // Gửi dữ liệu về ImportProduct (giả sử bạn truyền qua constructor)
            ImportProduct parentForm = (ImportProduct)this.Owner;
            parentForm.AddProductToGrid(selectedProduct, selectedSupplier);

            this.Close(); // Đóng form sau khi chọn
        }

    }
}
