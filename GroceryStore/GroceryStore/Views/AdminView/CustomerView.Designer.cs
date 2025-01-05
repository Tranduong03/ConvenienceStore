namespace GroceryStore.Views.AdminView
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableCustomerList = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnSearch = new Button();
            txbSearch = new TextBox();
            lblMaxPage = new Label();
            label4 = new Label();
            lblCurrentPage = new Label();
            label2 = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            groupBox1 = new GroupBox();
            btnCancelAdd = new Button();
            lblError = new Label();
            btnAddCustomer = new Button();
            label16 = new Label();
            label14 = new Label();
            txbName = new TextBox();
            label15 = new Label();
            lblWarning = new Label();
            label13 = new Label();
            cboGender = new ComboBox();
            label7 = new Label();
            txbPhone = new TextBox();
            label8 = new Label();
            btnSaveChange = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableCustomerList).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(17, 9);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 55);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(255, 36);
            label1.TabIndex = 1;
            label1.Text = "Customer Manage";
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
            // tableCustomerList
            // 
            tableCustomerList.AllowUserToAddRows = false;
            tableCustomerList.AllowUserToDeleteRows = false;
            tableCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCustomerList.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colCustomerName, colPhone });
            tableCustomerList.Location = new Point(17, 135);
            tableCustomerList.Name = "tableCustomerList";
            tableCustomerList.RowHeadersVisible = false;
            tableCustomerList.RowHeadersWidth = 51;
            tableCustomerList.ScrollBars = ScrollBars.Vertical;
            tableCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCustomerList.Size = new Size(563, 659);
            tableCustomerList.TabIndex = 72;
            tableCustomerList.CellValidating += tableCustomerList_CellValidating;
            tableCustomerList.CellValueChanged += tableCustomerList_CellValueChanged;
            // 
            // colCustomerID
            // 
            colCustomerID.HeaderText = "ID";
            colCustomerID.MinimumWidth = 6;
            colCustomerID.Name = "colCustomerID";
            colCustomerID.Width = 60;
            // 
            // colCustomerName
            // 
            colCustomerName.HeaderText = "Tên";
            colCustomerName.MinimumWidth = 6;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.Width = 300;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Số điện thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 200;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txbSearch);
            panel3.Location = new Point(17, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 34);
            panel3.TabIndex = 73;
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
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 10F);
            txbSearch.Location = new Point(3, 3);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Find Customer Here";
            txbSearch.Size = new Size(323, 28);
            txbSearch.TabIndex = 0;
            // 
            // lblMaxPage
            // 
            lblMaxPage.AutoSize = true;
            lblMaxPage.Font = new Font("Tahoma", 11F);
            lblMaxPage.Location = new Point(298, 823);
            lblMaxPage.Name = "lblMaxPage";
            lblMaxPage.Size = new Size(45, 23);
            lblMaxPage.TabIndex = 79;
            lblMaxPage.Text = "max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11F);
            label4.Location = new Point(275, 823);
            label4.Name = "label4";
            label4.Size = new Size(17, 23);
            label4.TabIndex = 78;
            label4.Text = "/";
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Tahoma", 11F);
            lblCurrentPage.Location = new Point(231, 823);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(20, 23);
            lblCurrentPage.TabIndex = 77;
            lblCurrentPage.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F);
            label2.Location = new Point(163, 825);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 76;
            label2.Text = "Trang: ";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Tahoma", 11F);
            btnNext.Location = new Point(386, 818);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 36);
            btnNext.TabIndex = 75;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Tahoma", 11F);
            btnPrev.Location = new Point(47, 816);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 36);
            btnPrev.TabIndex = 74;
            btnPrev.Text = "Trước";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelAdd);
            groupBox1.Controls.Add(lblError);
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txbName);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(lblWarning);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txbPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(628, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 280);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.Image = (Image)resources.GetObject("btnCancelAdd.Image");
            btnCancelAdd.Location = new Point(496, 12);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(58, 51);
            btnCancelAdd.TabIndex = 86;
            btnCancelAdd.UseVisualStyleBackColor = true;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(52, 186);
            lblError.Name = "lblError";
            lblError.Size = new Size(30, 20);
            lblError.TabIndex = 85;
            lblError.Text = "Lỗi";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ActiveCaption;
            btnAddCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(31, 209);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(154, 49);
            btnAddCustomer.TabIndex = 82;
            btnAddCustomer.Text = "Thêm khách";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(143, 113);
            label16.Name = "label16";
            label16.Size = new Size(15, 19);
            label16.TabIndex = 81;
            label16.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(165, 41);
            label14.Name = "label14";
            label14.Size = new Size(15, 19);
            label14.TabIndex = 80;
            label14.Text = "*";
            // 
            // txbName
            // 
            txbName.Location = new Point(22, 66);
            txbName.Name = "txbName";
            txbName.Size = new Size(376, 30);
            txbName.TabIndex = 79;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 10.8F);
            label15.Location = new Point(22, 41);
            label15.Name = "label15";
            label15.Size = new Size(137, 22);
            label15.TabIndex = 78;
            label15.Text = "Tên khách hàng";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(47, 229);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(10, 0, 0, 0);
            lblWarning.Size = new Size(10, 23);
            lblWarning.TabIndex = 77;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(293, 113);
            label13.Name = "label13";
            label13.Size = new Size(15, 19);
            label13.TabIndex = 76;
            label13.Text = "*";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(212, 138);
            cboGender.Margin = new Padding(0);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(184, 30);
            cboGender.TabIndex = 75;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F);
            label7.Location = new Point(213, 113);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 74;
            label7.Text = "Giới tính";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(22, 138);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(184, 30);
            txbPhone.TabIndex = 73;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F);
            label8.Location = new Point(23, 113);
            label8.Name = "label8";
            label8.Size = new Size(114, 22);
            label8.TabIndex = 72;
            label8.Text = "Số điện thoại";
            // 
            // btnSaveChange
            // 
            btnSaveChange.BackColor = Color.Lime;
            btnSaveChange.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnSaveChange.Location = new Point(921, 447);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(149, 52);
            btnSaveChange.TabIndex = 82;
            btnSaveChange.Text = "Lưu thay đổi";
            btnSaveChange.UseVisualStyleBackColor = false;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Aqua;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(664, 447);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 49);
            btnAdd.TabIndex = 86;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // CustomerView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(btnAdd);
            Controls.Add(btnSaveChange);
            Controls.Add(groupBox1);
            Controls.Add(lblMaxPage);
            Controls.Add(label4);
            Controls.Add(lblCurrentPage);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(panel3);
            Controls.Add(tableCustomerList);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomerView";
            Size = new Size(1250, 900);
            Load += CustomerView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableCustomerList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView tableCustomerList;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colPhone;
        private Panel panel3;
        private Button btnSearch;
        private TextBox txbSearch;
        private Label lblMaxPage;
        private Label label4;
        private Label lblCurrentPage;
        private Label label2;
        private Button btnNext;
        private Button btnPrev;
        private GroupBox groupBox1;
        private Label lblError;
        private Button btnAddCustomer;
        private Label label16;
        private Label label14;
        private TextBox txbName;
        private Label label15;
        private Label lblWarning;
        private Label label13;
        private ComboBox cboGender;
        private Label label7;
        private TextBox txbPhone;
        private Label label8;
        private Button btnSaveChange;
        private Button btnAdd;
        private Button btnCancelAdd;
    }
}