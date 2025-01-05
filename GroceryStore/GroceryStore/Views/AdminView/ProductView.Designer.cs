namespace GroceryStore.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSearch = new Button();
            txbSearch = new TextBox();
            tableProducts = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colSellPrice = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            tabMenuWork = new TabControl();
            tabAdd = new TabPage();
            txbAddImgLink = new TextBox();
            cbxSupplier_tabAdd = new ComboBox();
            label11 = new Label();
            btnSaveNewProduct = new Button();
            btnSelectImage = new Button();
            picAddProdImage = new PictureBox();
            label7 = new Label();
            cbxCategory_tabAdd = new ComboBox();
            label6 = new Label();
            txbAddDescription = new TextBox();
            txbAddQuantity = new TextBox();
            txbAddSellPrice = new TextBox();
            txbAddName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabDelete = new TabPage();
            btnDelProducts = new Button();
            tableChooseProduct = new DataGridView();
            colChooseToDel = new DataGridViewTextBoxColumn();
            tabUpdate = new TabPage();
            txbUpdateImgLink = new TextBox();
            cbxSupplier_tabUpdate = new ComboBox();
            label12 = new Label();
            btnUpdateProd = new Button();
            btnUpdateImage = new Button();
            picUpdateProdImage = new PictureBox();
            label13 = new Label();
            cbxCategory_tabUpdate = new ComboBox();
            label14 = new Label();
            txbUpdateDescription = new TextBox();
            txbUpdateSellPrice = new TextBox();
            txbUpdateName = new TextBox();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            cbxArrange = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            label8 = new Label();
            label9 = new Label();
            lblCurrPage = new Label();
            label10 = new Label();
            lblMaxPage = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            btnArrange = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableProducts).BeginInit();
            panel4.SuspendLayout();
            tabMenuWork.SuspendLayout();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAddProdImage).BeginInit();
            tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableChooseProduct).BeginInit();
            tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUpdateProdImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 55);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(12, 70);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 3);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txbSearch);
            panel3.Location = new Point(34, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 44);
            panel3.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(329, 1);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 40);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 14F);
            txbSearch.Location = new Point(3, 3);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Find Product Here";
            txbSearch.Size = new Size(326, 36);
            txbSearch.TabIndex = 0;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // tableProducts
            // 
            tableProducts.AllowUserToAddRows = false;
            tableProducts.AllowUserToDeleteRows = false;
            tableProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableProducts.ColumnHeadersHeight = 29;
            tableProducts.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colQuantity, colSellPrice, colDescription });
            tableProducts.Location = new Point(15, 136);
            tableProducts.Name = "tableProducts";
            tableProducts.ReadOnly = true;
            tableProducts.RowHeadersWidth = 51;
            tableProducts.ScrollBars = ScrollBars.None;
            tableProducts.Size = new Size(1221, 522);
            tableProducts.TabIndex = 3;
            tableProducts.SelectionChanged += tableProducts_SelectionChanged;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 350;
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 125;
            // 
            // colSellPrice
            // 
            colSellPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSellPrice.HeaderText = "Sell Price";
            colSellPrice.MinimumWidth = 6;
            colSellPrice.Name = "colSellPrice";
            colSellPrice.ReadOnly = true;
            colSellPrice.Width = 125;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabMenuWork);
            panel4.Location = new Point(15, 681);
            panel4.Name = "panel4";
            panel4.Size = new Size(1221, 207);
            panel4.TabIndex = 4;
            // 
            // tabMenuWork
            // 
            tabMenuWork.Controls.Add(tabAdd);
            tabMenuWork.Controls.Add(tabDelete);
            tabMenuWork.Controls.Add(tabUpdate);
            tabMenuWork.Dock = DockStyle.Fill;
            tabMenuWork.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabMenuWork.ItemSize = new Size(120, 25);
            tabMenuWork.Location = new Point(0, 0);
            tabMenuWork.Name = "tabMenuWork";
            tabMenuWork.SelectedIndex = 0;
            tabMenuWork.Size = new Size(1221, 207);
            tabMenuWork.SizeMode = TabSizeMode.Fixed;
            tabMenuWork.TabIndex = 0;
            tabMenuWork.SelectedIndexChanged += tabMenuWork_SelectedIndexChanged;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(txbAddImgLink);
            tabAdd.Controls.Add(cbxSupplier_tabAdd);
            tabAdd.Controls.Add(label11);
            tabAdd.Controls.Add(btnSaveNewProduct);
            tabAdd.Controls.Add(btnSelectImage);
            tabAdd.Controls.Add(picAddProdImage);
            tabAdd.Controls.Add(label7);
            tabAdd.Controls.Add(cbxCategory_tabAdd);
            tabAdd.Controls.Add(label6);
            tabAdd.Controls.Add(txbAddDescription);
            tabAdd.Controls.Add(txbAddQuantity);
            tabAdd.Controls.Add(txbAddSellPrice);
            tabAdd.Controls.Add(txbAddName);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(label4);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(label2);
            tabAdd.Font = new Font("Tahoma", 9F);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(1213, 174);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "Add";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // txbAddImgLink
            // 
            txbAddImgLink.Location = new Point(914, 44);
            txbAddImgLink.Name = "txbAddImgLink";
            txbAddImgLink.Size = new Size(267, 26);
            txbAddImgLink.TabIndex = 16;
            // 
            // cbxSupplier_tabAdd
            // 
            cbxSupplier_tabAdd.FormattingEnabled = true;
            cbxSupplier_tabAdd.Location = new Point(513, 120);
            cbxSupplier_tabAdd.Name = "cbxSupplier_tabAdd";
            cbxSupplier_tabAdd.Size = new Size(209, 26);
            cbxSupplier_tabAdd.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(392, 123);
            label11.Name = "label11";
            label11.Size = new Size(62, 18);
            label11.TabIndex = 14;
            label11.Text = "Supplier:";
            // 
            // btnSaveNewProduct
            // 
            btnSaveNewProduct.BackColor = Color.Lime;
            btnSaveNewProduct.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveNewProduct.Location = new Point(823, 102);
            btnSaveNewProduct.Name = "btnSaveNewProduct";
            btnSaveNewProduct.Size = new Size(185, 44);
            btnSaveNewProduct.TabIndex = 13;
            btnSaveNewProduct.Text = "Add Product";
            btnSaveNewProduct.UseVisualStyleBackColor = false;
            btnSaveNewProduct.Click += btnSaveNewProduct_Click;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(914, 12);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(109, 29);
            btnSelectImage.TabIndex = 12;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // picAddProdImage
            // 
            picAddProdImage.Location = new Point(823, 10);
            picAddProdImage.Name = "picAddProdImage";
            picAddProdImage.Size = new Size(80, 80);
            picAddProdImage.SizeMode = PictureBoxSizeMode.Zoom;
            picAddProdImage.TabIndex = 11;
            picAddProdImage.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(756, 15);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 10;
            label7.Text = "Image: ";
            // 
            // cbxCategory_tabAdd
            // 
            cbxCategory_tabAdd.FormattingEnabled = true;
            cbxCategory_tabAdd.Location = new Point(513, 76);
            cbxCategory_tabAdd.Name = "cbxCategory_tabAdd";
            cbxCategory_tabAdd.Size = new Size(209, 26);
            cbxCategory_tabAdd.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 79);
            label6.Name = "label6";
            label6.Size = new Size(72, 18);
            label6.TabIndex = 8;
            label6.Text = "Category:";
            // 
            // txbAddDescription
            // 
            txbAddDescription.Location = new Point(512, 10);
            txbAddDescription.Multiline = true;
            txbAddDescription.Name = "txbAddDescription";
            txbAddDescription.ScrollBars = ScrollBars.Vertical;
            txbAddDescription.Size = new Size(210, 60);
            txbAddDescription.TabIndex = 7;
            // 
            // txbAddQuantity
            // 
            txbAddQuantity.Location = new Point(134, 114);
            txbAddQuantity.Name = "txbAddQuantity";
            txbAddQuantity.Size = new Size(210, 26);
            txbAddQuantity.TabIndex = 5;
            // 
            // txbAddSellPrice
            // 
            txbAddSellPrice.Location = new Point(134, 64);
            txbAddSellPrice.Name = "txbAddSellPrice";
            txbAddSellPrice.Size = new Size(210, 26);
            txbAddSellPrice.TabIndex = 3;
            // 
            // txbAddName
            // 
            txbAddName.Location = new Point(134, 15);
            txbAddName.Name = "txbAddName";
            txbAddName.Size = new Size(210, 26);
            txbAddName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 18);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 6;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 117);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 67);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 2;
            label3.Text = "Sell Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 18);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // tabDelete
            // 
            tabDelete.Controls.Add(btnDelProducts);
            tabDelete.Controls.Add(tableChooseProduct);
            tabDelete.Location = new Point(4, 29);
            tabDelete.Name = "tabDelete";
            tabDelete.Padding = new Padding(3);
            tabDelete.Size = new Size(1213, 174);
            tabDelete.TabIndex = 1;
            tabDelete.Text = "Delete";
            tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelProducts
            // 
            btnDelProducts.BackColor = Color.IndianRed;
            btnDelProducts.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            btnDelProducts.Location = new Point(530, 15);
            btnDelProducts.Name = "btnDelProducts";
            btnDelProducts.Size = new Size(135, 41);
            btnDelProducts.TabIndex = 1;
            btnDelProducts.Text = "Delete";
            btnDelProducts.UseVisualStyleBackColor = false;
            btnDelProducts.Click += btnDelProducts_Click;
            // 
            // tableChooseProduct
            // 
            tableChooseProduct.AllowUserToAddRows = false;
            tableChooseProduct.AllowUserToDeleteRows = false;
            tableChooseProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableChooseProduct.Columns.AddRange(new DataGridViewColumn[] { colChooseToDel });
            tableChooseProduct.Location = new Point(89, 0);
            tableChooseProduct.Name = "tableChooseProduct";
            tableChooseProduct.ReadOnly = true;
            tableChooseProduct.RowHeadersWidth = 51;
            tableChooseProduct.Size = new Size(348, 171);
            tableChooseProduct.TabIndex = 0;
            // 
            // colChooseToDel
            // 
            colChooseToDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colChooseToDel.HeaderText = "Product you choose";
            colChooseToDel.MinimumWidth = 6;
            colChooseToDel.Name = "colChooseToDel";
            colChooseToDel.ReadOnly = true;
            // 
            // tabUpdate
            // 
            tabUpdate.Controls.Add(txbUpdateImgLink);
            tabUpdate.Controls.Add(cbxSupplier_tabUpdate);
            tabUpdate.Controls.Add(label12);
            tabUpdate.Controls.Add(btnUpdateProd);
            tabUpdate.Controls.Add(btnUpdateImage);
            tabUpdate.Controls.Add(picUpdateProdImage);
            tabUpdate.Controls.Add(label13);
            tabUpdate.Controls.Add(cbxCategory_tabUpdate);
            tabUpdate.Controls.Add(label14);
            tabUpdate.Controls.Add(txbUpdateDescription);
            tabUpdate.Controls.Add(txbUpdateSellPrice);
            tabUpdate.Controls.Add(txbUpdateName);
            tabUpdate.Controls.Add(label15);
            tabUpdate.Controls.Add(label17);
            tabUpdate.Controls.Add(label18);
            tabUpdate.Font = new Font("Tahoma", 9F);
            tabUpdate.Location = new Point(4, 29);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Size = new Size(1213, 174);
            tabUpdate.TabIndex = 2;
            tabUpdate.Text = "Update";
            tabUpdate.UseVisualStyleBackColor = true;
            // 
            // txbUpdateImgLink
            // 
            txbUpdateImgLink.Location = new Point(914, 44);
            txbUpdateImgLink.Name = "txbUpdateImgLink";
            txbUpdateImgLink.Size = new Size(267, 26);
            txbUpdateImgLink.TabIndex = 33;
            // 
            // cbxSupplier_tabUpdate
            // 
            cbxSupplier_tabUpdate.FormattingEnabled = true;
            cbxSupplier_tabUpdate.Location = new Point(513, 120);
            cbxSupplier_tabUpdate.Name = "cbxSupplier_tabUpdate";
            cbxSupplier_tabUpdate.Size = new Size(209, 26);
            cbxSupplier_tabUpdate.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(392, 123);
            label12.Name = "label12";
            label12.Size = new Size(62, 18);
            label12.TabIndex = 31;
            label12.Text = "Supplier:";
            // 
            // btnUpdateProd
            // 
            btnUpdateProd.BackColor = Color.Lime;
            btnUpdateProd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProd.Location = new Point(823, 102);
            btnUpdateProd.Name = "btnUpdateProd";
            btnUpdateProd.Size = new Size(185, 44);
            btnUpdateProd.TabIndex = 30;
            btnUpdateProd.Text = "Update";
            btnUpdateProd.UseVisualStyleBackColor = false;
            btnUpdateProd.Click += btnUpdateProd_Click;
            // 
            // btnUpdateImage
            // 
            btnUpdateImage.Location = new Point(914, 12);
            btnUpdateImage.Name = "btnUpdateImage";
            btnUpdateImage.Size = new Size(112, 29);
            btnUpdateImage.TabIndex = 29;
            btnUpdateImage.Text = "Update Image";
            btnUpdateImage.UseVisualStyleBackColor = true;
            btnUpdateImage.Click += btnUpdateImage_Click;
            // 
            // picUpdateProdImage
            // 
            picUpdateProdImage.Location = new Point(823, 10);
            picUpdateProdImage.Name = "picUpdateProdImage";
            picUpdateProdImage.Size = new Size(80, 80);
            picUpdateProdImage.SizeMode = PictureBoxSizeMode.Zoom;
            picUpdateProdImage.TabIndex = 28;
            picUpdateProdImage.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(756, 15);
            label13.Name = "label13";
            label13.Size = new Size(61, 18);
            label13.TabIndex = 27;
            label13.Text = "Image: ";
            // 
            // cbxCategory_tabUpdate
            // 
            cbxCategory_tabUpdate.FormattingEnabled = true;
            cbxCategory_tabUpdate.Location = new Point(513, 76);
            cbxCategory_tabUpdate.Name = "cbxCategory_tabUpdate";
            cbxCategory_tabUpdate.Size = new Size(209, 26);
            cbxCategory_tabUpdate.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(393, 79);
            label14.Name = "label14";
            label14.Size = new Size(72, 18);
            label14.TabIndex = 25;
            label14.Text = "Category:";
            // 
            // txbUpdateDescription
            // 
            txbUpdateDescription.Location = new Point(512, 10);
            txbUpdateDescription.Multiline = true;
            txbUpdateDescription.Name = "txbUpdateDescription";
            txbUpdateDescription.ScrollBars = ScrollBars.Vertical;
            txbUpdateDescription.Size = new Size(210, 60);
            txbUpdateDescription.TabIndex = 24;
            // 
            // txbUpdateSellPrice
            // 
            txbUpdateSellPrice.Location = new Point(134, 64);
            txbUpdateSellPrice.Name = "txbUpdateSellPrice";
            txbUpdateSellPrice.Size = new Size(210, 26);
            txbUpdateSellPrice.TabIndex = 20;
            // 
            // txbUpdateName
            // 
            txbUpdateName.Location = new Point(134, 15);
            txbUpdateName.Name = "txbUpdateName";
            txbUpdateName.Size = new Size(210, 26);
            txbUpdateName.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(393, 18);
            label15.Name = "label15";
            label15.Size = new Size(83, 18);
            label15.TabIndex = 23;
            label15.Text = "Description:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 67);
            label17.Name = "label17";
            label17.Size = new Size(68, 18);
            label17.TabIndex = 19;
            label17.Text = "Sell Price:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 18);
            label18.Name = "label18";
            label18.Size = new Size(52, 18);
            label18.TabIndex = 17;
            label18.Text = "Name:";
            // 
            // cbxArrange
            // 
            cbxArrange.FormattingEnabled = true;
            cbxArrange.Items.AddRange(new object[] { "Giá (từ thấp đến cao)", "Giá (từ cao đến thấp)", "Tên (A-Z)", "Tên (Z-A)" });
            cbxArrange.Location = new Point(843, 92);
            cbxArrange.Name = "cbxArrange";
            cbxArrange.Size = new Size(257, 28);
            cbxArrange.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.RestoreDirectory = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(736, 95);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 6;
            label8.Text = "Arrange with: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(431, 95);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 7;
            label9.Text = "Page: ";
            // 
            // lblCurrPage
            // 
            lblCurrPage.AutoSize = true;
            lblCurrPage.Location = new Point(530, 97);
            lblCurrPage.Name = "lblCurrPage";
            lblCurrPage.Size = new Size(17, 20);
            lblCurrPage.TabIndex = 9;
            lblCurrPage.Text = "1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(565, 97);
            label10.Name = "label10";
            label10.Size = new Size(26, 20);
            label10.TabIndex = 10;
            label10.Text = "on";
            // 
            // lblMaxPage
            // 
            lblMaxPage.AutoSize = true;
            lblMaxPage.Location = new Point(617, 97);
            lblMaxPage.Name = "lblMaxPage";
            lblMaxPage.Size = new Size(37, 20);
            lblMaxPage.TabIndex = 11;
            lblMaxPage.Text = "max";
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.Location = new Point(670, 91);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(32, 32);
            btnNext.TabIndex = 12;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackgroundImage = (Image)resources.GetObject("btnPrev.BackgroundImage");
            btnPrev.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrev.Location = new Point(492, 91);
            btnPrev.Margin = new Padding(0);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(32, 32);
            btnPrev.TabIndex = 8;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnArrange
            // 
            btnArrange.Location = new Point(1106, 91);
            btnArrange.Name = "btnArrange";
            btnArrange.Size = new Size(80, 29);
            btnArrange.TabIndex = 13;
            btnArrange.Text = "Arrange";
            btnArrange.UseVisualStyleBackColor = true;
            btnArrange.Click += btnArrange_Click;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 900);
            Controls.Add(btnArrange);
            Controls.Add(btnNext);
            Controls.Add(lblMaxPage);
            Controls.Add(label10);
            Controls.Add(lblCurrPage);
            Controls.Add(btnPrev);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cbxArrange);
            Controls.Add(panel4);
            Controls.Add(tableProducts);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            // FormBorderStyle = FormBorderStyle.None;
            Name = "ProductView";
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableProducts).EndInit();
            panel4.ResumeLayout(false);
            tabMenuWork.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAddProdImage).EndInit();
            tabDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableChooseProduct).EndInit();
            tabUpdate.ResumeLayout(false);
            tabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUpdateProdImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txbSearch;
        private Button btnSearch;
        private DataGridView tableProducts;
        private Panel panel4;
        private ComboBox cbxArrange;
        private OpenFileDialog openFileDialog1;
        private Label label8;
        private Label label9;
        private Label lblCurrPage;
        private Label label10;
        private Label lblMaxPage;
        private Button btnNext;
        private Button btnPrev;
        private TabControl tabMenuWork;
        private TabPage tabAdd;
        private Button btnSaveNewProduct;
        private Button btnSelectImage;
        private PictureBox picAddProdImage;
        private Label label7;
        private ComboBox cbxCategory_tabAdd;
        private Label label6;
        private TextBox txbAddDescription;
        private TextBox txbAddQuantity;
        private TextBox txbAddSellPrice;
        private TextBox txbAddName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabDelete;
        private TabPage tabUpdate;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colSellPrice;
        private DataGridViewTextBoxColumn colDescription;
        private Button btnArrange;
        private ComboBox cbxSupplier_tabAdd;
        private Label label11;
        private TextBox txbAddImgLink;
        private DataGridView tableChooseProduct;
        private DataGridViewTextBoxColumn colChooseToDel;
        private Button btnDelProducts;
        private TextBox txbUpdateImgLink;
        private ComboBox cbxSupplier_tabUpdate;
        private Label label12;
        private Button btnUpdateProd;
        private Button btnUpdateImage;
        private PictureBox picUpdateProdImage;
        private Label label13;
        private ComboBox cbxCategory_tabUpdate;
        private Label label14;
        private TextBox txbUpdateDescription;
        private TextBox txbUpdateSellPrice;
        private TextBox txbUpdateName;
        private Label label15;
        private Label label17;
        private Label label18;
    }
}