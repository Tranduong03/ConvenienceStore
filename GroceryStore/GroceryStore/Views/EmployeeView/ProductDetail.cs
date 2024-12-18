using GroceryStore.Model;
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
    public partial class ProductDetail : Form // Đảm bảo lớp ProductDetail là public
    {
        Product prod = new Product();

        public ProductDetail()
        {
            InitializeComponent();
        }

        internal ProductDetail(Product product)
        {
            InitializeComponent();
            prod = product;
            lblProdName.Text = prod.Name;
            txbSellPrice.Text = prod.SellPrice.ToString();
            picProdImage.ImageLocation = Path.Combine("Resource", "Images", product.ImageLink);
        }

        private void btnDescIndex_Click(object sender, EventArgs e)
        {
            txbQuantity.Text = Math.Max(1, int.Parse(txbQuantity.Text) - 1).ToString();
        }

        private void btnIncIndex_Click(object sender, EventArgs e)
        {
            txbQuantity.Text = Math.Min(int.Parse(txbQuantity.Text) + 1, prod.Quantity).ToString();
        }

        // Sự kiện public để truyền thông tin về sản phẩm và số lượng
        internal event Action<Product, int> OnProductPurchased;

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txbQuantity.Text); // Lấy số lượng từ txbQuantity

            // Gọi sự kiện và truyền thông tin sản phẩm và số lượng
            OnProductPurchased?.Invoke(prod, quantity);
        }
    }

}
