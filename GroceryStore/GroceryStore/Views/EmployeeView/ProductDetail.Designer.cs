namespace GroceryStore.Views
{
    partial class ProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlProductDetail = new Panel();
            btnPurchase = new Button();
            txbQuantity = new TextBox();
            btnIncIndex = new Button();
            btnDescIndex = new Button();
            txbSellPrice = new TextBox();
            label1 = new Label();
            lblProdName = new Label();
            picProdImage = new PictureBox();
            pnlProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProdImage).BeginInit();
            SuspendLayout();
            // 
            // pnlProductDetail
            // 
            pnlProductDetail.BackColor = SystemColors.GradientActiveCaption;
            pnlProductDetail.Controls.Add(btnPurchase);
            pnlProductDetail.Controls.Add(txbQuantity);
            pnlProductDetail.Controls.Add(btnIncIndex);
            pnlProductDetail.Controls.Add(btnDescIndex);
            pnlProductDetail.Controls.Add(txbSellPrice);
            pnlProductDetail.Controls.Add(label1);
            pnlProductDetail.Controls.Add(lblProdName);
            pnlProductDetail.Controls.Add(picProdImage);
            pnlProductDetail.Location = new Point(3, 0);
            pnlProductDetail.Margin = new Padding(5);
            pnlProductDetail.Name = "pnlProductDetail";
            pnlProductDetail.Size = new Size(293, 207);
            pnlProductDetail.TabIndex = 0;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.Lime;
            btnPurchase.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(43, 142);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(213, 42);
            btnPurchase.TabIndex = 17;
            btnPurchase.Text = "Add-in Purchase";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // txbQuantity
            // 
            txbQuantity.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbQuantity.Location = new Point(91, 110);
            txbQuantity.Name = "txbQuantity";
            txbQuantity.Size = new Size(104, 26);
            txbQuantity.TabIndex = 16;
            txbQuantity.Text = "1";
            txbQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIncIndex
            // 
            btnIncIndex.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncIndex.Location = new Point(201, 110);
            btnIncIndex.Name = "btnIncIndex";
            btnIncIndex.Size = new Size(32, 29);
            btnIncIndex.TabIndex = 15;
            btnIncIndex.Text = "+";
            btnIncIndex.UseVisualStyleBackColor = true;
            btnIncIndex.Click += btnIncIndex_Click;
            // 
            // btnDescIndex
            // 
            btnDescIndex.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescIndex.Location = new Point(55, 110);
            btnDescIndex.Name = "btnDescIndex";
            btnDescIndex.Size = new Size(30, 29);
            btnDescIndex.TabIndex = 14;
            btnDescIndex.Text = "-";
            btnDescIndex.UseVisualStyleBackColor = true;
            btnDescIndex.Click += btnDescIndex_Click;
            // 
            // txbSellPrice
            // 
            txbSellPrice.Location = new Point(153, 41);
            txbSellPrice.Name = "txbSellPrice";
            txbSellPrice.ReadOnly = true;
            txbSellPrice.Size = new Size(125, 26);
            txbSellPrice.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 18);
            label1.TabIndex = 12;
            label1.Text = "Giá: ";
            // 
            // lblProdName
            // 
            lblProdName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdName.Location = new Point(14, 2);
            lblProdName.Margin = new Padding(0);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(273, 23);
            lblProdName.TabIndex = 11;
            lblProdName.Text = "Sản phẩm 1";
            lblProdName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picProdImage
            // 
            picProdImage.Location = new Point(29, 28);
            picProdImage.Name = "picProdImage";
            picProdImage.Size = new Size(72, 68);
            picProdImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picProdImage.TabIndex = 10;
            picProdImage.TabStop = false;
            // 
            // ProductDetail
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(300, 210);
            Controls.Add(pnlProductDetail);
            Font = new Font("Tahoma", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDetail";
            Text = "ProductDetail";
            pnlProductDetail.ResumeLayout(false);
            pnlProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProdImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlProductDetail;
        private Button btnPurchase;
        private TextBox txbQuantity;
        private Button btnIncIndex;
        private Button btnDescIndex;
        private TextBox txbSellPrice;
        private Label label1;
        private Label lblProdName;
        private PictureBox picProdImage;
    }
}