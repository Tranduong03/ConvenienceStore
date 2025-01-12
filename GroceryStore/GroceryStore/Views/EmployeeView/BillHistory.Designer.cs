namespace GroceryStore.Views.EmployeeView
{
    partial class BillHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillHistory));
            tableBillHistory = new DataGridView();
            pnlBillPrint = new Panel();
            tableBillDetail = new DataGridView();
            label14 = new Label();
            panel5 = new Panel();
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
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txbSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnPrintBill = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dtpStart = new DateTimePicker();
            label3 = new Label();
            dtpEnd = new DateTimePicker();
            btnFillWithDay = new Button();
            ((System.ComponentModel.ISupportInitialize)tableBillHistory).BeginInit();
            pnlBillPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableBillDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableBillHistory
            // 
            tableBillHistory.AllowUserToAddRows = false;
            tableBillHistory.AllowUserToDeleteRows = false;
            tableBillHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableBillHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBillHistory.Location = new Point(3, 211);
            tableBillHistory.MultiSelect = false;
            tableBillHistory.Name = "tableBillHistory";
            tableBillHistory.ReadOnly = true;
            tableBillHistory.RowHeadersVisible = false;
            tableBillHistory.RowHeadersWidth = 51;
            tableBillHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableBillHistory.Size = new Size(628, 686);
            tableBillHistory.TabIndex = 0;
            tableBillHistory.SelectionChanged += tableBillHistory_SelectionChanged;
            // 
            // pnlBillPrint
            // 
            pnlBillPrint.Controls.Add(tableBillDetail);
            pnlBillPrint.Controls.Add(label14);
            pnlBillPrint.Controls.Add(panel5);
            pnlBillPrint.Controls.Add(lblTotalCost);
            pnlBillPrint.Controls.Add(label12);
            pnlBillPrint.Controls.Add(label11);
            pnlBillPrint.Controls.Add(panel1);
            pnlBillPrint.Controls.Add(lblEmployeeName);
            pnlBillPrint.Controls.Add(label15);
            pnlBillPrint.Controls.Add(lblCustomerName);
            pnlBillPrint.Controls.Add(label13);
            pnlBillPrint.Controls.Add(lblBillDate);
            pnlBillPrint.Controls.Add(label10);
            pnlBillPrint.Controls.Add(label9);
            pnlBillPrint.Controls.Add(panel4);
            pnlBillPrint.Controls.Add(label8);
            pnlBillPrint.Controls.Add(label7);
            pnlBillPrint.Controls.Add(label6);
            pnlBillPrint.Controls.Add(label5);
            pnlBillPrint.Controls.Add(label4);
            pnlBillPrint.Controls.Add(pictureBox2);
            pnlBillPrint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBillPrint.Location = new Point(637, 86);
            pnlBillPrint.Name = "pnlBillPrint";
            pnlBillPrint.Size = new Size(607, 811);
            pnlBillPrint.TabIndex = 1;
            // 
            // tableBillDetail
            // 
            tableBillDetail.AllowUserToAddRows = false;
            tableBillDetail.AllowUserToDeleteRows = false;
            tableBillDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableBillDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBillDetail.Location = new Point(7, 266);
            tableBillDetail.Name = "tableBillDetail";
            tableBillDetail.ReadOnly = true;
            tableBillDetail.RowHeadersVisible = false;
            tableBillDetail.RowHeadersWidth = 51;
            tableBillDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableBillDetail.Size = new Size(590, 370);
            tableBillDetail.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(196, 761);
            label14.Name = "label14";
            label14.Size = new Size(217, 28);
            label14.TabIndex = 17;
            label14.Text = "CẢM ƠN QUÝ KHÁCH";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(7, 747);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(590, 2);
            panel5.TabIndex = 8;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(378, 674);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(74, 31);
            lblTotalCost.TabIndex = 16;
            lblTotalCost.Text = "00000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(548, 674);
            label12.Name = "label12";
            label12.Size = new Size(56, 28);
            label12.TabIndex = 15;
            label12.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(176, 674);
            label11.Name = "label11";
            label11.Size = new Size(170, 28);
            label11.TabIndex = 14;
            label11.Text = "Tổng thanh toán";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(7, 649);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 2);
            panel1.TabIndex = 7;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(397, 193);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(78, 23);
            lblEmployeeName.TabIndex = 13;
            lblEmployeeName.Text = "1/1/2025";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(289, 193);
            label15.Name = "label15";
            label15.Size = new Size(92, 23);
            label15.TabIndex = 12;
            label15.Text = "Nhân viên:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(124, 229);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(78, 23);
            lblCustomerName.TabIndex = 11;
            lblCustomerName.Text = "1/1/2025";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(16, 229);
            label13.Name = "label13";
            label13.Size = new Size(105, 23);
            label13.TabIndex = 10;
            label13.Text = "Khách hàng:";
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillDate.Location = new Point(124, 193);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(78, 23);
            lblBillDate.TabIndex = 9;
            lblBillDate.Text = "1/1/2025";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 193);
            label10.Name = "label10";
            label10.Size = new Size(84, 23);
            label10.TabIndex = 8;
            label10.Text = "Ngày tạo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 156);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 7;
            label9.Text = "Chi tiết hóa đơn";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(7, 141);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 2);
            panel4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(147, 106);
            label8.Name = "label8";
            label8.Size = new Size(199, 20);
            label8.TabIndex = 5;
            label8.Text = "Email: flashshop@email.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 86);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 4;
            label7.Text = "Phone : 0389837777";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 64);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 3;
            label6.Text = "Thủ Đức, TPHCM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 42);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 2;
            label5.Text = "450 Lê Văn Việt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 20);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 1;
            label4.Text = "Flash Store";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbSearch);
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 36);
            panel3.TabIndex = 74;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 10F);
            txbSearch.Location = new Point(3, 3);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Tìm theo khách hàng";
            txbSearch.Size = new Size(291, 28);
            txbSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 152);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 75;
            label1.Text = "Lọc từ:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPrintBill);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(6, 12);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 55);
            panel2.TabIndex = 22;
            // 
            // btnPrintBill
            // 
            btnPrintBill.Location = new Point(1076, 9);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(162, 35);
            btnPrintBill.TabIndex = 2;
            btnPrintBill.Text = "In hóa đơn";
            btnPrintBill.UseVisualStyleBackColor = true;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 8);
            label2.Name = "label2";
            label2.Size = new Size(341, 36);
            label2.TabIndex = 1;
            label2.Text = "Lịch sử hóa đơn cá nhân";
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
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(87, 149);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(161, 28);
            dtpStart.TabIndex = 76;
            dtpStart.ValueChanged += dtpStart_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 152);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 77;
            label3.Text = "đến:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(305, 149);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(161, 28);
            dtpEnd.TabIndex = 78;
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
            // 
            // btnFillWithDay
            // 
            btnFillWithDay.Location = new Point(303, 104);
            btnFillWithDay.Name = "btnFillWithDay";
            btnFillWithDay.Size = new Size(132, 31);
            btnFillWithDay.TabIndex = 3;
            btnFillWithDay.Text = "Lọc";
            btnFillWithDay.UseVisualStyleBackColor = true;
            btnFillWithDay.Click += btnFillWithDay_Click;
            // 
            // BillHistory
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(btnFillWithDay);
            Controls.Add(dtpEnd);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(pnlBillPrint);
            Controls.Add(tableBillHistory);
            Font = new Font("Tahoma", 10F);
            Name = "BillHistory";
            Size = new Size(1250, 900);
            Load += BillHistory_Load;
            ((System.ComponentModel.ISupportInitialize)tableBillHistory).EndInit();
            pnlBillPrint.ResumeLayout(false);
            pnlBillPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableBillDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableBillHistory;
        private Panel pnlBillPrint;
        private DataGridViewTextBoxColumn colTotalPrice;
        private Panel panel3;
        private TextBox txbSearch;
        private Label label1;
        private Panel panel2;
        private Button btnPrintBill;
        private Label label2;
        private PictureBox pictureBox1;
        private DateTimePicker dtpStart;
        private Label label3;
        private DateTimePicker dtpEnd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label8;
        private Label label10;
        private Label label9;
        private Panel panel1;
        private Label lblEmployeeName;
        private Label label15;
        private Label lblCustomerName;
        private Label label13;
        private Label lblBillDate;
        private Label label14;
        private Panel panel5;
        private Label lblTotalCost;
        private Label label12;
        private Label label11;
        private DataGridView tableBillDetail;
        private Button btnFillWithDay;
    }
}
