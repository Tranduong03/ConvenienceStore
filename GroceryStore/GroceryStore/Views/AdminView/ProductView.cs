using System;
using System.Linq;
using System.Windows.Forms;
using GroceryStore.Model;
using GroceryStore.OtherProcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace GroceryStore.Views
{
    public partial class ProductView : Form
    {
        private int currentPage = 1; // Trang hiện tại
        private int pageSize = 17;   // Số sản phẩm trên mỗi trang
        private int totalPages;      // Tổng số trang
        private int currentSellPrice = 0;
        // Constructor
        public ProductView()
        {
            InitializeComponent();
            InitializeSearchAutoComplete();
            LoadProductData();  // Gọi phương thức tải dữ liệu khi form khởi tạo
            LoadCategoryData();
            LoadSupplierData();
        }
        // Cho phép chọn multiselect ở tab cần chọn
        private void tabMenuWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMenuWork.SelectedTab.Name)
            {
                case "tabAdd":
                case "tabDelete":
                    tableProducts.MultiSelect = true; // Bật MultiSelect
                    tableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Đảm bảo chế độ chọn cả hàng
                    break;

                case "tabUpdate":
                case "tabImport":
                    tableProducts.MultiSelect = false; // Tắt MultiSelect
                    tableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chế độ chọn cả hàng
                    break;
            }
        }
        // tìm kiếm auto complete trên tên sản phẩm
        private void InitializeSearchAutoComplete()
        {
            using (var context = new AppDBContext())
            {
                // Lấy tất cả tên sản phẩm từ cơ sở dữ liệu
                var productNames = context.Products
                                          .Select(p => p.Name)
                                          .ToList();

                // Cài đặt AutoComplete cho TextBox
                txbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Hiển thị gợi ý khi gõ
                txbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource; // Sử dụng nguồn tùy chỉnh
                txbSearch.AutoCompleteCustomSource.AddRange(productNames.ToArray()); // Thêm các tên sản phẩm vào nguồn
            }
        }
        // Lấy dữ liệu nhà cung cấp
        private void LoadSupplierData()
        {
            using (var context = new AppDBContext())
            {
                var suppliers = context.Suppliers.ToList();
                cbxSupplier_tabAdd.DataSource = suppliers;
                cbxSupplier_tabAdd.DisplayMember = "Name";
                cbxSupplier_tabAdd.ValueMember = "SupplierID";

                cbxSupplier_tabUpdate.DataSource = suppliers;
                cbxSupplier_tabUpdate.DisplayMember = "Name";
                cbxSupplier_tabUpdate.ValueMember = "SupplierID";

            }
        }
        // Lấy dữ liệu loại mặt hàng
        private void LoadCategoryData()
        {
            using (var context = new AppDBContext())
            {
                var categories = context.Categories.ToList();
                cbxCategory_tabAdd.DataSource = categories;
                cbxCategory_tabAdd.DisplayMember = "Name";
                cbxCategory_tabAdd.ValueMember = "CategoryID";

                cbxCategory_tabUpdate.DataSource = categories;
                cbxCategory_tabUpdate.DisplayMember = "Name";
                cbxCategory_tabUpdate.ValueMember = "CategoryID";
            }
        }

        // Phương thức tải dữ liệu sản phẩm từ cơ sở dữ liệu và hiển thị vào DataGridView

        private void LoadProductData()
        {
            string searchQuery = txbSearch.Text; // Lấy từ khóa tìm kiếm
            string sortOrder = cbxArrange.SelectedItem?.ToString() ?? "Giá (từ thấp đến cao)"; // Lấy cách sắp xếp

            using (var context = new AppDBContext())
            {
                var productData = from p in context.Products
                                  join c in context.Categories on p.CategoryID equals c.CategoryID
                                  where p.Name.Contains(searchQuery) // Tìm kiếm theo tên sản phẩm
                                  select new
                                  {
                                      ProductID = p.ProductID,
                                      ProductName = p.Name,
                                      CategoryName = c.Name,
                                      p.Quantity,
                                      p.SellPrice,
                                      Description = p.Description,
                                      CategoryID = p.CategoryID // Giữ nguyên CategoryID
                                  };


                // Tính tổng số trang
                totalPages = (int)Math.Ceiling(productData.Count() / (double)pageSize);

                // Lấy dữ liệu cho trang hiện tại
                var pageData = productData.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

                // Xóa dữ liệu hiện tại trong DataGridView (nếu có)
                tableProducts.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                foreach (var item in pageData)
                {
                    tableProducts.Rows.Add(item.ProductName, item.CategoryName, item.Quantity, item.SellPrice, item.Description != string.Empty ? item.Description : "None");
                }

                // Cập nhật thông tin trang hiện tại và tổng số trang
                lblCurrPage.Text = currentPage.ToString();
                lblMaxPage.Text = totalPages.ToString();

                // Bật/tắt các nút điều hướng
                btnPrev.Enabled = currentPage > 1;  // Nếu không phải trang đầu tiên, bật nút "Prev"
                btnNext.Enabled = currentPage < totalPages;  // Nếu không phải trang cuối cùng, bật nút "Next"
            }
        }




        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadProductData();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadProductData();
            }

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadProductData();
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadProductData();
        }
        /*
        *
        *   Kết thúc xử lí trên bảng 
        *
        *   Lấy thông tin xử lí thêm sản phẩm
        *
        *
        */
        private void btnSaveNewProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbAddName.Text) || cbxCategory_tabAdd.SelectedItem == null || cbxSupplier_tabAdd.SelectedItem == null ||
        string.IsNullOrEmpty(txbAddQuantity.Text) || string.IsNullOrEmpty(txbAddSellPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            // Lấy dữ liệu từ các control
            string productName = txbAddName.Text;
            int categoryId = (cbxCategory_tabAdd.SelectedItem as Category).CategoryID; // Giả sử bạn đã gán giá trị đúng cho ComboBox Category
            int quantity = int.Parse(txbAddQuantity.Text);
            int sellPrice = int.Parse(txbAddSellPrice.Text);
            string description = txbAddDescription.Text != string.Empty ? txbAddDescription.Text : "None" ;
            string imgLink = txbAddImgLink.Text != string.Empty ? txbAddImgLink.Text : "none.png"; // Đường dẫn ảnh (hoặc tên tệp ảnh)
            int supplierId = (cbxSupplier_tabAdd.SelectedItem as Supplier).SupplierID; // Giả sử bạn đã gán giá trị đúng cho ComboBox Supplier

            // Tạo đối tượng Product mới
            var newProduct = new Product
            {
                Name = productName,
                CategoryID = categoryId,
                Quantity = quantity,
                SellPrice = sellPrice,
                Description = description,
                ImageLink = imgLink, // Đường dẫn tương đối của ảnh hoặc tên ảnh
                SupplierID = supplierId
            };

            // Lưu sản phẩm vào cơ sở dữ liệu thông qua Entity Framework
            using (var context = new AppDBContext()) // ApplicationDbContext là DbContext của bạn
            {
                context.Products.Add(newProduct); // Thêm sản phẩm mới vào DbSet Products
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }

            MessageBox.Show("Sản phẩm đã được lưu thành công!");

            // Sau khi lưu, có thể làm mới DataGridView hoặc thực hiện các hành động khác
            LoadProductData();
        }


        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            string relativePath = @"Resource/Images";
            string absolutePath = Path.Combine(Application.StartupPath, relativePath);

            openFileDialog1.InitialDirectory = absolutePath; // Sử dụng đường dẫn tuyệt đối của thư mục Resource

            // Cấu hình các tùy chọn khác nếu cần
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Lọc hình ảnh
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.RestoreDirectory = true;
            // Hiển thị OpenFileDialog và xử lý kết quả
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn ảnh được chọn
                string imgPath = openFileDialog1.FileName;

                // Lấy tên ảnh
                string imgName = Path.GetFileName(imgPath); // Chỉ lấy tên tệp
                string destinationPath = Path.Combine(absolutePath, imgName); // Đường dẫn đích trong Resource/Images



                if (imgPath.StartsWith(absolutePath, StringComparison.OrdinalIgnoreCase) || File.Exists(destinationPath))
                {
                    destinationPath = Path.Combine(absolutePath, imgName); // Dùng trực tiếp đường dẫn đích
                }
                else
                {
                    try
                    {
                        File.Copy(imgPath, destinationPath);
                        // CopyImageToProjectResourceFolder(imgPath, imgName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Failed to copy image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Hiển thị tên ảnh và ảnh trong PictureBox
                txbAddImgLink.Text = imgName;
                picAddProdImage.Image = Image.FromFile(destinationPath);
            }
        }


        /*
         *  Kết thúc làm việc với tab thêm sản phẩm (Add)
         *  
         * 
         *  Làm việc với tab bỏ sản phẩm
         */

        // Hiển thị sp đã chọn vào bảng nhỏ
        private void tableProducts_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn trong DataGridView
            if (tableProducts.SelectedRows.Count > 0)
            {
                var selectedRows = tableProducts.SelectedRows;

                if (tabMenuWork.SelectedTab == tabDelete)
                {
                    // Xử lý cho tabDelete - chọn nhiều sản phẩm
                    var productNames = selectedRows
                        .Cast<DataGridViewRow>() // Ép kiểu DataGridViewRow
                        .Select(row => row.Cells["colName"].Value?.ToString()) // Lấy tên sản phẩm
                        .Where(name => !string.IsNullOrEmpty(name)) // Loại bỏ tên null hoặc rỗng
                        .ToList(); // Chuyển sang danh sách

                    HandleDeleteTab(productNames); // Gọi hàm xử lý
                }
                else if (selectedRows.Count == 1)
                {
                    var selectedRow = selectedRows[0];

                    string productName = selectedRow.Cells["colName"].Value?.ToString();

                    if (!string.IsNullOrEmpty(productName))
                    {
                        if (tabMenuWork.SelectedTab == tabUpdate)
                        {
                            // Xử lý cho tabUpdate
                            HandleUpdateTab(productName);
                        }
                        else if (tabMenuWork.SelectedTab == tabImport)
                        {
                            HandleImportTab(productName);
                        }
                    }
                }
            }
        }

        private void btnDelProducts_Click(object sender, EventArgs e)
        {
            // Xác nhận người dùng có chắc chắn muốn xóa
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa các sản phẩm đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (var context = new AppDBContext())
                {
                    // Duyệt qua danh sách sản phẩm trong tableChooseProduct
                    foreach (DataGridViewRow row in tableChooseProduct.Rows)
                    {
                        var productNameCell = row.Cells["colChooseToDel"].Value;

                        if (productNameCell != null && !string.IsNullOrEmpty(productNameCell.ToString()))
                        {
                            string productName = productNameCell.ToString();

                            // Tìm sản phẩm trong cơ sở dữ liệu
                            var productToDelete = context.Products.FirstOrDefault(p => p.Name == productName);

                            if (productToDelete != null)
                            {
                                // Kiểm tra ImgLink và xử lý nếu cần thiết
                                if (string.IsNullOrEmpty(productToDelete.ImageLink))
                                {
                                    // ImgLink là null hoặc rỗng, có thể tiếp tục xóa mà không gặp vấn đề
                                    context.Products.Remove(productToDelete);
                                }
                                else
                                {
                                    // Nếu cần, xử lý ImgLink ở đây (ví dụ: xóa ảnh trong thư mục nếu cần)
                                    context.Products.Remove(productToDelete);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Không tìm thấy sản phẩm có tên {productName}.");
                            }
                        }
                    }

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                }

                // Xóa hàng đã chọn khỏi tableProducts và tableChooseProduct
                foreach (DataGridViewRow selectedRow in tableProducts.SelectedRows)
                {
                    tableProducts.Rows.Remove(selectedRow); // Xóa khỏi tableProducts
                }

                tableChooseProduct.Rows.Clear(); // Xóa tất cả sản phẩm trong bảng nhỏ

                MessageBox.Show("Đã xóa thành công các sản phẩm đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại dữ liệu trong tableProducts
                LoadProductData();
            }
        }

        private void HandleDeleteTab(IEnumerable<string> productNames)
        {
            // Xóa dữ liệu cũ trong bảng nhỏ (tableChooseProduct)
            tableChooseProduct.Rows.Clear();

            // Duyệt qua danh sách tên sản phẩm và thêm vào bảng nhỏ
            foreach (var productName in productNames)
            {
                tableChooseProduct.Rows.Add(productName);
            }
        }

        private void HandleUpdateTab(string productName)
        {
            using (var context = new AppDBContext())
            {
                var product = context.Products
                                     .Include(p => p.Category)
                                     .Include(p => p.Supplier)
                                     .FirstOrDefault(p => p.Name == productName);

                if (product != null)
                {
                    // Hiển thị thông tin sản phẩm trong các điều khiển của tabUpdate
                    txbUpdateName.Text = product.Name;
                    txbUpdateSellPrice.Text = product.SellPrice.ToString("F2");
                    txbUpdateDescription.Text = string.IsNullOrEmpty(product.Description) ? "None" : product.Description;
                    txbUpdateImgLink.Text = string.IsNullOrEmpty(product.ImageLink) ? "none.png" : product.ImageLink;

                    // Cập nhật ComboBox cho danh mục
                    cbxCategory_tabUpdate.SelectedValue = product.CategoryID;
                    cbxSupplier_tabUpdate.SelectedValue = product.SupplierID;

                    // Cập nhật ComboBox cho nhà cung cấp
                    if (product.Supplier != null)
                    {
                        cbxSupplier_tabUpdate.SelectedItem = product.Supplier.Name;
                    }
                    else
                    {
                        cbxSupplier_tabUpdate.SelectedIndex = -1; // Không chọn gì nếu không có nhà cung cấp
                    }

                    // Hiển thị ảnh sản phẩm trong PictureBox
                    if (!string.IsNullOrEmpty(product.ImageLink))
                    {
                        string relativePath = Path.Combine("Resource", "Images", product.ImageLink);
                        string absolutePath = Path.Combine(Application.StartupPath, relativePath);

                        try
                        {
                            if (File.Exists(absolutePath))
                            {
                                picUpdateProdImage.Image = Image.FromFile(absolutePath);
                            }
                            else
                            {
                                MessageBox.Show("Image file not found in Resource/Images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                picUpdateProdImage.Image = null; // Xóa ảnh nếu tệp không tồn tại
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picUpdateProdImage.Image = null;
                        }
                    }
                    else
                    {
                        string relativePath = Path.Combine("Resource", "Images", "none.png");
                        string absolutePath = Path.Combine(Application.StartupPath, relativePath);
                        picUpdateProdImage.Image = Image.FromFile(absolutePath); // Xóa ảnh nếu không có liên kết
                    }
                }
            }
        }

        private void HandleImportTab(string productName)
        {
            // Kiểm tra nếu có hàng được chọn trong bảng
            if (tableProducts.SelectedRows.Count > 0)
            {
                var selectedRow = tableProducts.SelectedRows[0]; // Lấy hàng đầu tiên được chọn
                int sellPrice = Convert.ToInt32(selectedRow.Cells["colSellPrice"].Value);


                // Hiển thị tên sản phẩm lên TextBox
                txbImportProdName.Text = productName;
                currentSellPrice = sellPrice;
            }
            else
            {
                // Xóa dữ liệu nếu không có sản phẩm được chọn
                txbImportProdName.Text = string.Empty;
                currentSellPrice = 0;
            }
        }


        /*
         * 
         *  Kết thúc làm việc với tab xóa sản phẩm
         * 
         * Bắt đầu với cập nhật lại sản phẩm
         */

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            string relativePath = @"Resource/Images";
            string absolutePath = Path.Combine(Application.StartupPath, relativePath);

            openFileDialog1.InitialDirectory = absolutePath; // Sử dụng đường dẫn tuyệt đối của thư mục Resource

            // Cấu hình các tùy chọn khác nếu cần
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Lọc hình ảnh
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.RestoreDirectory = true;
            // Hiển thị OpenFileDialog và xử lý kết quả
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn ảnh được chọn
                string imgPath = openFileDialog1.FileName;

                // Lấy tên ảnh
                string imgName = Path.GetFileName(imgPath); // Chỉ lấy tên tệp
                string destinationPath = Path.Combine(absolutePath, imgName); // Đường dẫn đích trong Resource/Images



                if (imgPath.StartsWith(absolutePath, StringComparison.OrdinalIgnoreCase) || File.Exists(destinationPath))
                {
                    destinationPath = Path.Combine(absolutePath, imgName); // Dùng trực tiếp đường dẫn đích
                }
                else
                {
                    try
                    {
                        File.Copy(imgPath, destinationPath);
                        // CopyImageToProjectResourceFolder(imgPath, imgName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Failed to copy image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Hiển thị tên ảnh và ảnh trong PictureBox
                txbUpdateImgLink.Text = imgName;
                picUpdateProdImage.Image = Image.FromFile(destinationPath);
            }
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trong tabUpdate
            string updatedName = txbUpdateName.Text.Trim();
            string updatedSellPriceText = txbUpdateSellPrice.Text.Trim();
            string updatedDescription = txbUpdateDescription.Text.Trim();

            // Lấy Category từ ComboBox
            GroceryStore.Model.Category selectedCategory = cbxCategory_tabUpdate.SelectedItem as GroceryStore.Model.Category;
            string updatedCategory = selectedCategory?.Name;  // Lấy tên danh mục từ đối tượng Category

            // Lấy Supplier từ ComboBox
            GroceryStore.Model.Supplier selectedSupplier = cbxSupplier_tabUpdate.SelectedItem as GroceryStore.Model.Supplier;
            string updatedSupplier = selectedSupplier?.Name;  // Lấy tên nhà cung cấp từ đối tượng Supplier

            string updatedImageLink = txbUpdateImgLink.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(updatedName) ||
                string.IsNullOrEmpty(updatedSellPriceText) ||
                string.IsNullOrEmpty(updatedCategory) ||
                string.IsNullOrEmpty(updatedSupplier))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(updatedSellPriceText, out int updatedSellPrice) || updatedSellPrice <= 0)
            {
                MessageBox.Show("Giá bán phải là số dương hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên sản phẩm từ cột colName
            DataGridViewRow selectedRow = tableProducts.SelectedRows[0];
            string productName = selectedRow.Cells["colName"].Value?.ToString();

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Không thể tìm thấy tên sản phẩm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Truy vấn ProductID từ cơ sở dữ liệu dựa trên tên sản phẩm
            int productId;
            using (var context = new AppDBContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Name == productName);
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                productId = product.ProductID;

                // Cập nhật thông tin sản phẩm
                product.Name = updatedName;
                product.SellPrice = updatedSellPrice;
                product.Description = string.IsNullOrEmpty(updatedDescription) ? "None" : updatedDescription;

                // Truy vấn danh mục (Category) bằng cách sử dụng tên danh mục
                var category = context.Categories
                                      .FirstOrDefault(c => c.Name.ToLower() == updatedCategory.ToLower());
                if (category != null)
                {
                    product.CategoryID = category.CategoryID;
                }
                else
                {
                    MessageBox.Show("Danh mục không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Truy vấn nhà cung cấp (Supplier) bằng cách sử dụng tên nhà cung cấp
                var supplier = context.Suppliers
                                      .FirstOrDefault(s => s.Name.ToLower() == updatedSupplier.ToLower());

                if (supplier != null)
                {
                    product.SupplierID = supplier.SupplierID;
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật đường dẫn ảnh
                product.ImageLink = updatedImageLink ?? "none.png" ;

                try
                {
                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    // Thông báo thành công
                    MessageBox.Show("Cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới dữ liệu hiển thị
                    LoadProductData(); // Gọi lại phương thức tải dữ liệu sản phẩm
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        /* 
         * 
         * Kết thúc làm việc với tab Update, bắt đầu nhập hàng ở tab import
         * 
         */

        private void txbImportQuantity_TextChanged(object sender, EventArgs e)
        {
            if (currentSellPrice <= 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txbImportQuantity.Text.Trim(), out int quantity) && quantity > 0)
            {
                int totalCost = currentSellPrice * quantity;
                txbCost.Text = totalCost.ToString();
            }
            else
            {
                txbCost.Text = "0.00";
            }
        }

        private void btnImportProd_Click(object sender, EventArgs e)
{
    // Kiểm tra dữ liệu nhập
    if (string.IsNullOrEmpty(txbImportProdName.Text.Trim()) ||
        string.IsNullOrEmpty(txbImportQuantity.Text.Trim()) ||
        !int.TryParse(txbImportQuantity.Text.Trim(), out int importQuantity) ||
        importQuantity <= 0)
    {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // Lấy thông tin từ các điều khiển
    string productName = txbImportProdName.Text.Trim();
    int cost = currentSellPrice * importQuantity; // Giá nhập dựa trên giá bán

    using (var context = new AppDBContext())
    {
        // Tìm sản phẩm trong bảng Products
        var product = context.Products.FirstOrDefault(p => p.Name == productName);
        if (product == null)
        {
            MessageBox.Show("Không tìm thấy sản phẩm trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Lấy SupplierID từ sản phẩm
        int supplierId = product.SupplierID;

        // Cập nhật số lượng sản phẩm
        product.Quantity += importQuantity;

        // Lưu lịch sử nhập hàng vào bảng ImportProduct
        var importProduct = new Import
        {
            ProductID = product.ProductID,
            SupplierID = supplierId,
            Quantity = importQuantity,
            Cost = cost, // Chuyển đổi sang kiểu int nếu cần
            ImportAt = DateTime.Now // Thời gian nhập
        };

        context.ImportProducts.Add(importProduct);

        try
        {
            // Lưu thay đổi vào cơ sở dữ liệu
            context.SaveChanges();

            // Thông báo thành công
            MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Làm mới dữ liệu hiển thị
            LoadProductData();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Đã xảy ra lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

    }
}
 