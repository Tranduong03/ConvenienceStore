namespace GroceryStore.Views
{
    partial class EmployeeProductView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeProductView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cbxCategory = new ComboBox();
            label6 = new Label();
            panel1 = new Panel();
            btnChooseCustomer = new Button();
            btnAddCustomer = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnSearch = new Button();
            txbSearch = new TextBox();
            label2 = new Label();
            flpListProduct = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            flpListBuy = new FlowLayoutPanel();
            tableProdToBuy = new DataGridView();
            colProdName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colCost = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            panel4 = new Panel();
            txbCustomerID = new TextBox();
            label8 = new Label();
            txbRefund = new TextBox();
            label7 = new Label();
            txbReceived = new TextBox();
            label5 = new Label();
            btnPurchase = new Button();
            txbSumCost = new TextBox();
            label4 = new Label();
            initalCreateBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flpListBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableProdToBuy).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)initalCreateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(674, 86);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(254, 26);
            cbxCategory.TabIndex = 17;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 89);
            label6.Name = "label6";
            label6.Size = new Size(38, 18);
            label6.TabIndex = 16;
            label6.Text = "Loại:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChooseCustomer);
            panel1.Controls.Add(btnAddCustomer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 55);
            panel1.TabIndex = 21;
            // 
            // btnChooseCustomer
            // 
            btnChooseCustomer.BackColor = SystemColors.ScrollBar;
            btnChooseCustomer.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnChooseCustomer.Location = new Point(1052, 8);
            btnChooseCustomer.Name = "btnChooseCustomer";
            btnChooseCustomer.Size = new Size(166, 43);
            btnChooseCustomer.TabIndex = 3;
            btnChooseCustomer.Text = "Chọn khách";
            btnChooseCustomer.UseVisualStyleBackColor = false;
            btnChooseCustomer.Click += btnChooseCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ActiveCaption;
            btnAddCustomer.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(848, 8);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(185, 43);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Thêm khách";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(117, 36);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txbSearch);
            panel3.Location = new Point(9, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 34);
            panel3.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(329, 1);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 30);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 10F);
            txbSearch.Location = new Point(3, 3);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Find Product Here";
            txbSearch.Size = new Size(326, 28);
            txbSearch.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(465, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 23;
            label2.Text = "Lọc theo";
            // 
            // flpListProduct
            // 
            flpListProduct.AutoScroll = true;
            flpListProduct.Location = new Point(9, 135);
            flpListProduct.Margin = new Padding(0);
            flpListProduct.Name = "flpListProduct";
            flpListProduct.Size = new Size(930, 756);
            flpListProduct.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(flpListBuy);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(942, 86);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 805);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 49);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(302, 49);
            label3.TabIndex = 0;
            label3.Text = "THANH TOÁN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpListBuy
            // 
            flpListBuy.Controls.Add(tableProdToBuy);
            flpListBuy.FlowDirection = FlowDirection.TopDown;
            flpListBuy.Location = new Point(0, 49);
            flpListBuy.Margin = new Padding(0);
            flpListBuy.Name = "flpListBuy";
            flpListBuy.Size = new Size(296, 470);
            flpListBuy.TabIndex = 1;
            // 
            // tableProdToBuy
            // 
            tableProdToBuy.AllowUserToAddRows = false;
            tableProdToBuy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            tableProdToBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableProdToBuy.Columns.AddRange(new DataGridViewColumn[] { colProdName, colQuantity, colCost, colDelete });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableProdToBuy.DefaultCellStyle = dataGridViewCellStyle1;
            tableProdToBuy.Location = new Point(0, 0);
            tableProdToBuy.Margin = new Padding(0);
            tableProdToBuy.Name = "tableProdToBuy";
            tableProdToBuy.ReadOnly = true;
            tableProdToBuy.RowHeadersVisible = false;
            tableProdToBuy.RowHeadersWidth = 51;
            tableProdToBuy.Size = new Size(296, 470);
            tableProdToBuy.TabIndex = 0;
            // 
            // colProdName
            // 
            colProdName.HeaderText = "Tên";
            colProdName.MinimumWidth = 6;
            colProdName.Name = "colProdName";
            colProdName.ReadOnly = true;
            colProdName.Width = 140;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "SL";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 40;
            // 
            // colCost
            // 
            colCost.HeaderText = "Giá";
            colCost.MinimumWidth = 6;
            colCost.Name = "colCost";
            colCost.ReadOnly = true;
            colCost.Width = 60;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Xóa";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(txbCustomerID);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txbRefund);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txbReceived);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnPurchase);
            panel4.Controls.Add(txbSumCost);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 519);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 286);
            panel4.TabIndex = 2;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Font = new Font("Tahoma", 11F);
            txbCustomerID.Location = new Point(132, 184);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.ReadOnly = true;
            txbCustomerID.Size = new Size(156, 30);
            txbCustomerID.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 187);
            label8.Name = "label8";
            label8.Size = new Size(96, 22);
            label8.TabIndex = 7;
            label8.Text = "ID Khách";
            // 
            // txbRefund
            // 
            txbRefund.Font = new Font("Tahoma", 11F);
            txbRefund.Location = new Point(132, 138);
            txbRefund.Name = "txbRefund";
            txbRefund.ReadOnly = true;
            txbRefund.Size = new Size(156, 30);
            txbRefund.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 141);
            label7.Name = "label7";
            label7.Size = new Size(66, 22);
            label7.TabIndex = 5;
            label7.Text = "Trả lại";
            // 
            // txbReceived
            // 
            txbReceived.Font = new Font("Tahoma", 11F);
            txbReceived.Location = new Point(132, 87);
            txbReceived.Name = "txbReceived";
            txbReceived.Size = new Size(156, 30);
            txbReceived.TabIndex = 4;
            txbReceived.TextChanged += txbReceived_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 90);
            label5.Name = "label5";
            label5.Size = new Size(101, 22);
            label5.TabIndex = 3;
            label5.Text = "Tiền nhận";
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.Lime;
            btnPurchase.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(2, 236);
            btnPurchase.Margin = new Padding(0);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(294, 50);
            btnPurchase.TabIndex = 2;
            btnPurchase.Text = "Thanh toán";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // txbSumCost
            // 
            txbSumCost.Font = new Font("Tahoma", 11F);
            txbSumCost.Location = new Point(132, 29);
            txbSumCost.Name = "txbSumCost";
            txbSumCost.ReadOnly = true;
            txbSumCost.Size = new Size(156, 30);
            txbSumCost.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 32);
            label4.Name = "label4";
            label4.Size = new Size(95, 22);
            label4.TabIndex = 0;
            label4.Text = "Tổng tiền";
            // 
            // EmployeeProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flpListProduct);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(cbxCategory);
            Controls.Add(label6);
            Font = new Font("Tahoma", 9F);
            Name = "EmployeeProductView";
            Size = new Size(1250, 900);
            Load += EmployeeProductView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flpListBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableProdToBuy).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)initalCreateBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxCategory;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnSearch;
        private TextBox txbSearch;
        private Label label2;
        public FlowLayoutPanel flpListProduct;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flpListBuy;
        private DataGridView tableProdToBuy;
        private DataGridViewTextBoxColumn colProdName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colCost;
        private DataGridViewButtonColumn colDelete;
        private Panel panel4;
        private Label label4;
        private TextBox txbSumCost;
        private Button btnPurchase;
        private TextBox txbRefund;
        private Label label7;
        private TextBox txbReceived;
        private Label label5;
        private BindingSource initalCreateBindingSource;
        private TextBox txbCustomerID;
        private Label label8;
        private Button btnChooseCustomer;
        private Button btnAddCustomer;
    }
}