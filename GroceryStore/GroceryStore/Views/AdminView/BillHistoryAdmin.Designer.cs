namespace GroceryStore.Views.AdminView
{
    partial class BillHistoryAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillHistoryAdmin));
            btnFillWithDay = new Button();
            dtpEnd = new DateTimePicker();
            label3 = new Label();
            dtpStart = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            txbCustomerSearch = new TextBox();
            tableBillHistory = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tableBillDetail = new DataGridView();
            lblTotalCost = new Label();
            label12 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            lblEmployeeName = new Label();
            label15 = new Label();
            lblCustomerName = new Label();
            label13 = new Label();
            lblBillDate = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            txbEmployeeSearch = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableBillHistory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableBillDetail).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnFillWithDay
            // 
            btnFillWithDay.Location = new Point(514, 148);
            btnFillWithDay.Name = "btnFillWithDay";
            btnFillWithDay.Size = new Size(132, 31);
            btnFillWithDay.TabIndex = 80;
            btnFillWithDay.Text = "Lọc";
            btnFillWithDay.UseVisualStyleBackColor = true;
            btnFillWithDay.Click += btnFillWithDay_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(321, 152);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(161, 27);
            dtpEnd.TabIndex = 85;
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 155);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 84;
            label3.Text = "to :";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(103, 152);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(161, 27);
            dtpStart.TabIndex = 83;
            dtpStart.ValueChanged += dtpStart_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 155);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 82;
            label1.Text = "Fill with:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbCustomerSearch);
            panel3.Location = new Point(19, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 36);
            panel3.TabIndex = 81;
            // 
            // txbCustomerSearch
            // 
            txbCustomerSearch.Font = new Font("Tahoma", 10F);
            txbCustomerSearch.Location = new Point(2, 3);
            txbCustomerSearch.Name = "txbCustomerSearch";
            txbCustomerSearch.PlaceholderText = "Find Customer Here";
            txbCustomerSearch.Size = new Size(291, 28);
            txbCustomerSearch.TabIndex = 0;
            // 
            // tableBillHistory
            // 
            tableBillHistory.AllowUserToAddRows = false;
            tableBillHistory.AllowUserToDeleteRows = false;
            tableBillHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableBillHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBillHistory.Location = new Point(19, 200);
            tableBillHistory.MultiSelect = false;
            tableBillHistory.Name = "tableBillHistory";
            tableBillHistory.ReadOnly = true;
            tableBillHistory.RowHeadersVisible = false;
            tableBillHistory.RowHeadersWidth = 51;
            tableBillHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableBillHistory.Size = new Size(739, 683);
            tableBillHistory.TabIndex = 79;
            tableBillHistory.SelectionChanged += tableBillHistory_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(5, 16);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 55);
            panel2.TabIndex = 86;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 9);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 1;
            label2.Text = "Bill History";
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
            // tableBillDetail
            // 
            tableBillDetail.AllowUserToAddRows = false;
            tableBillDetail.AllowUserToDeleteRows = false;
            tableBillDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableBillDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBillDetail.Location = new Point(773, 390);
            tableBillDetail.Name = "tableBillDetail";
            tableBillDetail.ReadOnly = true;
            tableBillDetail.RowHeadersVisible = false;
            tableBillDetail.RowHeadersWidth = 51;
            tableBillDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableBillDetail.Size = new Size(461, 370);
            tableBillDetail.TabIndex = 98;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(1007, 795);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(74, 31);
            lblTotalCost.TabIndex = 97;
            lblTotalCost.Text = "00000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1305, 591);
            label12.Name = "label12";
            label12.Size = new Size(56, 28);
            label12.TabIndex = 96;
            label12.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(805, 795);
            label11.Name = "label11";
            label11.Size = new Size(170, 28);
            label11.TabIndex = 95;
            label11.Text = "Tổng thanh toán";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(805, 779);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 2);
            panel1.TabIndex = 87;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(1154, 263);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(78, 23);
            lblEmployeeName.TabIndex = 94;
            lblEmployeeName.Text = "1/1/2025";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(1046, 263);
            label15.Name = "label15";
            label15.Size = new Size(92, 23);
            label15.TabIndex = 93;
            label15.Text = "Nhân viên:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(881, 299);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(78, 23);
            lblCustomerName.TabIndex = 92;
            lblCustomerName.Text = "1/1/2025";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(773, 299);
            label13.Name = "label13";
            label13.Size = new Size(105, 23);
            label13.TabIndex = 91;
            label13.Text = "Khách hàng:";
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillDate.Location = new Point(881, 263);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(78, 23);
            lblBillDate.TabIndex = 90;
            lblBillDate.Text = "1/1/2025";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(773, 263);
            label10.Name = "label10";
            label10.Size = new Size(84, 23);
            label10.TabIndex = 89;
            label10.Text = "Ngày tạo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(773, 200);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 88;
            label9.Text = "Chi tiết hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1134, 797);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 99;
            label4.Text = "VND";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbEmployeeSearch);
            panel4.Location = new Point(19, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 36);
            panel4.TabIndex = 82;
            // 
            // txbEmployeeSearch
            // 
            txbEmployeeSearch.Font = new Font("Tahoma", 10F);
            txbEmployeeSearch.Location = new Point(2, 3);
            txbEmployeeSearch.Name = "txbEmployeeSearch";
            txbEmployeeSearch.PlaceholderText = "Find Employee Here";
            txbEmployeeSearch.Size = new Size(291, 28);
            txbEmployeeSearch.TabIndex = 0;
            // 
            // BillHistoryAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(tableBillDetail);
            Controls.Add(lblTotalCost);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(lblEmployeeName);
            Controls.Add(label15);
            Controls.Add(lblCustomerName);
            Controls.Add(label13);
            Controls.Add(lblBillDate);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(btnFillWithDay);
            Controls.Add(dtpEnd);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(tableBillHistory);
            Name = "BillHistoryAdmin";
            Size = new Size(1250, 900);
            Load += BillHistoryAdmin_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableBillHistory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableBillDetail).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFillWithDay;
        private DateTimePicker dtpEnd;
        private Label label3;
        private DateTimePicker dtpStart;
        private Label label1;
        private Panel panel3;
        private TextBox txbCustomerSearch;
        private DataGridView tableBillHistory;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView tableBillDetail;
        private Label lblTotalCost;
        private Label label12;
        private Label label11;
        private Panel panel1;
        private Label lblEmployeeName;
        private Label label15;
        private Label lblCustomerName;
        private Label label13;
        private Label lblBillDate;
        private Label label10;
        private Label label9;
        private Label label4;
        private Panel panel4;
        private TextBox txbEmployeeSearch;
    }
}
