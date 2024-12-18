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

namespace GroceryStore.Views
{
    public partial class EmployeeProductView : UserControl
    {
        User employee = new User();
        private Dictionary<Product, int> purchasedProducts = new Dictionary<Product, int>();

        public EmployeeProductView()
        {
            InitializeComponent();

            tableProdToBuy.CellClick += tableProdToBuy_CellClick;
        }

        internal EmployeeProductView(User user)
        {
            InitializeComponent();
            employee = user;
            tableProdToBuy.CellClick += tableProdToBuy_CellClick;

            btnPurchase.Enabled = false;
        }
        /*  View xem và mua sản phẩm, việc load form cho nhiều sản phẩm phức tạp nên tạo panel thủ công để xem
         * 
         * 
         */



        private void LoadProductPanels()
        {
            flpListProduct.Controls.Clear(); // Xóa các panel cũ

            using (var context = new AppDBContext())
            {
                var products = context.Products.ToList(); // Lấy danh sách sản phẩm


                foreach (var product in products)
                {
                    ProductDetail prodShow = new ProductDetail(product);

                    // Đăng ký sự kiện khi người dùng nhấn btnPurchase
                    prodShow.OnProductPurchased += ProductPurchasedHandler;

                    Panel pnlProduct = prodShow.pnlProductDetail;
                    flpListProduct.Controls.Add(pnlProduct); // Thêm panel vào FlowLayoutPanel
                }

            }
        }

        // Xử lý sự kiện khi sản phẩm được mua (xử lí từ Form ProductDetail)
        private void ProductPurchasedHandler(Product product, int quantity)
        {
            // Lưu thông tin sản phẩm và số lượng vào Dictionary hoặc xử lý theo yêu cầu
            if (purchasedProducts.ContainsKey(product))
            {
                purchasedProducts[product] += quantity; // Cập nhật số lượng nếu sản phẩm đã có trong danh sách
            }
            else
            {
                purchasedProducts.Add(product, quantity); // Thêm sản phẩm mới vào danh sách
            }

            UpdateDataGridView();
        }
        /*
         * Xử lí bảng hiện sản phẩm đã mua và tổng tiền
         * 
         */
        private void UpdateDataGridView()
        {
            // Giả sử bạn đang sử dụng DataGridView để hiển thị các sản phẩm đã mua
            tableProdToBuy.Rows.Clear(); // Xóa các dòng cũ trong bảng
            int totalPurchase = 0;

            foreach (var item in purchasedProducts)
            {
                Product product = item.Key;
                int quantity = item.Value;
                int cost = product.SellPrice * quantity;

                totalPurchase += cost;

                // Thêm dòng mới vào DataGridView
                tableProdToBuy.Rows.Add(product.Name, quantity, cost);
            }
            txbSumCost.Text = totalPurchase.ToString();
        }

        // Xử lí sự kiện nhấn button xóa sản phẩm trên bảng
        private void tableProdToBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào cột Xóa
            if (e.ColumnIndex == tableProdToBuy.Columns["colDelete"].Index && e.RowIndex >= 0)
            {
                // Lấy tên sản phẩm từ dòng hiện tại
                string productName = tableProdToBuy.Rows[e.RowIndex].Cells["colProdName"].Value.ToString();

                // Tìm sản phẩm trong Dictionary và xóa nó
                var productToRemove = purchasedProducts.Keys.FirstOrDefault(p => p.Name == productName);
                if (productToRemove != null)
                {
                    purchasedProducts.Remove(productToRemove); // Xóa khỏi Dictionary

                    // Cập nhật DataGridView
                    UpdateDataGridView();
                }

            }
        }
        private void EmployeeProductView_Load(object sender, EventArgs e)
        {
            using (var context = new AppDBContext())
            {
                var categories = context.Categories.ToList();

                // Thêm mục "Tất cả" với giá trị là 0
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryID";
                cbxCategory.Items.Add(new { CategoryID = 0, CategoryName = "Tất cả" });

                // Thêm các danh mục từ cơ sở dữ liệu
                foreach (var category in categories)
                {
                    cbxCategory.Items.Add(new { CategoryID = category.CategoryID, CategoryName = category.Name });
                }
            }

            cbxCategory.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            LoadProductPanels();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy CategoryID được chọn từ ComboBox
            int selectedCategoryID = (cbxCategory.SelectedItem as dynamic).CategoryID;

            flpListProduct.Controls.Clear(); // Xóa các panel cũ

            using (var context = new AppDBContext())
            {
                // Lấy toàn bộ sản phẩm
                var products = context.Products.ToList();

                // Nếu không chọn "Tất cả", lọc theo CategoryID
                if (selectedCategoryID != 0)
                {
                    products = products.Where(p => p.CategoryID == selectedCategoryID).ToList();
                }

                // Hiển thị các sản phẩm đã lọc
                foreach (var product in products)
                {
                    ProductDetail prodShow = new ProductDetail(product);

                    // Đăng ký sự kiện khi nhấn btnPurchase
                    prodShow.OnProductPurchased += ProductPurchasedHandler;

                    Panel pnlProduct = prodShow.pnlProductDetail;
                    flpListProduct.Controls.Add(pnlProduct); // Thêm panel vào FlowLayoutPanel
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txbSearch.Text.Trim(); // Từ khóa tìm kiếm
            int selectedCategoryID = (cbxCategory.SelectedItem as dynamic)?.CategoryID ?? 0; // Lấy CategoryID từ ComboBox

            flpListProduct.Controls.Clear(); // Xóa các panel cũ

            using (var context = new AppDBContext())
            {
                // Truy vấn ban đầu lấy tất cả sản phẩm
                var query = context.Products.AsQueryable();

                // Áp dụng điều kiện lọc theo danh mục nếu không phải "Tất cả"
                if (selectedCategoryID != 0)
                {
                    query = query.Where(p => p.CategoryID == selectedCategoryID);
                }

                // Áp dụng điều kiện tìm kiếm theo từ khóa (Name hoặc Description)
                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(p => p.Name.Contains(keyword) || p.Description.Contains(keyword));
                }

                // Lấy danh sách sản phẩm đã lọc
                var filteredProducts = query.ToList();

                // Hiển thị sản phẩm đã lọc vào flpListProduct
                foreach (var product in filteredProducts)
                {
                    ProductDetail prodShow = new ProductDetail(product);

                    // Đăng ký sự kiện khi nhấn btnPurchase
                    prodShow.OnProductPurchased += ProductPurchasedHandler;

                    Panel pnlProduct = prodShow.pnlProductDetail;
                    flpListProduct.Controls.Add(pnlProduct); // Thêm panel vào FlowLayoutPanel
                }

                // Thông báo nếu không tìm thấy sản phẩm nào
                if (filteredProducts.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            if (addCustomer.ShowDialog() == DialogResult.OK)
            {
                txbCustomerID.Text = addCustomer.Tag.ToString();
            }

        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            ChooseCustomer choose = new ChooseCustomer();
            if (choose.ShowDialog() == DialogResult.OK)
            {
                txbCustomerID.Text = choose.Tag.ToString(); 
            }
        }

        private void txbReceived_TextChanged(object sender, EventArgs e)
        {
            txbRefund.Text = string.Empty;
            int received = int.Parse(txbReceived.Text == string.Empty ? "0" : txbReceived.Text);
            int sumCost = int.Parse(txbSumCost.Text == string.Empty ? "0" : txbSumCost.Text);
            int refund = received - sumCost;
            if (refund < 0 || sumCost == 0)
            {
                txbRefund.Text = "0";
                btnPurchase.Enabled = false;
            }
            else
            {
                txbRefund.Text = refund.ToString();
                btnPurchase.Enabled = true;

            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
 
            // Kiểm tra và gán CustomerID (0 nếu là khách vãng lai)
            int customerId = 0;

            if (!string.IsNullOrEmpty(txbCustomerID.Text))
            {
                customerId = int.Parse(txbCustomerID.Text);
            }

            // Tạo hóa đơn mới
            var newBill = new Bill
            {
                CustomerID = customerId,
                UserID = employee.UserID, // ID nhân viên
                BillDate = DateTime.Now,
                TotalCost = purchasedProducts.Sum(p => p.Key.SellPrice * p.Value) // Tổng tiền
            };
            MessageBox.Show(employee.UserID.ToString());

            // Sử dụng context để lưu dữ liệu vào DB
            using (var context = new AppDBContext())
            {
                context.Bills.Add(newBill);
                context.SaveChanges(); // Lưu hóa đơn trước để lấy ID

                // Thêm chi tiết hóa đơn và cập nhật kho
                foreach (var item in purchasedProducts)
                {
                    var product = item.Key;   // Sản phẩm
                    var quantity = item.Value; // Số lượng mua

                    // Thêm chi tiết hóa đơn
                    var billDetail = new BillDetail
                    {
                        BillId = newBill.BillId,
                        ProductID = product.ProductID,
                        Quantity = quantity,
                        SellPrice = product.SellPrice
                    };
                    context.BillDetails.Add(billDetail);

                    // Cập nhật số lượng sản phẩm trong kho
                    var productInDb = context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
                    if (productInDb != null)
                    {
                        if (productInDb.Quantity < quantity)
                        {
                            MessageBox.Show($"Sản phẩm {product.Name} không đủ số lượng trong kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        productInDb.Quantity -= quantity; // Trừ số lượng sản phẩm trong kho
                    }
                }

                // Lưu các thay đổi vào DB
                context.SaveChanges();
            }

            // Thông báo thành công
            MessageBox.Show("Thanh toán thành công! Hóa đơn đã được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset giao diện
            purchasedProducts.Clear();
            UpdateDataGridView();
            txbReceived.Text = string.Empty;
            txbRefund.Text = string.Empty;
            txbCustomerID.Text = string.Empty;
        }

    }
}
