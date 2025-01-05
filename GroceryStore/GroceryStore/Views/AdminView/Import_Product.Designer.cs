namespace GroceryStore.Views.AdminView
{
    partial class Import_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_Product));
            btnFillWithDay = new Button();
            dtpEnd = new DateTimePicker();
            label3 = new Label();
            dtpStart = new DateTimePicker();
            tableImportHistory = new DataGridView();
            tableImportDetail = new DataGridView();
            lblImportDate = new Label();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            btnNewImport = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblTotalCost = new Label();
            label12 = new Label();
            label11 = new Label();
            pnlDetailImport = new Panel();
            btnPrintImport = new Button();
            ((System.ComponentModel.ISupportInitialize)tableImportHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableImportDetail).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDetailImport.SuspendLayout();
            SuspendLayout();
            // 
            // btnFillWithDay
            // 
            btnFillWithDay.Location = new Point(466, 128);
            btnFillWithDay.Margin = new Padding(2);
            btnFillWithDay.Name = "btnFillWithDay";
            btnFillWithDay.Size = new Size(106, 25);
            btnFillWithDay.TabIndex = 80;
            btnFillWithDay.Text = "Lọc";
            btnFillWithDay.UseVisualStyleBackColor = true;
            btnFillWithDay.Click += btnFillWithDay_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(315, 128);
            dtpEnd.Margin = new Padding(2);
            dtpEnd.MaxDate = new DateTime(2025, 1, 5, 18, 52, 43, 797);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(130, 27);
            dtpEnd.TabIndex = 84;
            dtpEnd.Value = new DateTime(2025, 1, 5, 18, 52, 43, 797);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 83;
            label3.Text = "to :";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(135, 128);
            dtpStart.Margin = new Padding(2);
            dtpStart.MaxDate = new DateTime(2025, 1, 5, 18, 52, 43, 798);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(130, 27);
            dtpStart.TabIndex = 82;
            dtpStart.Value = new DateTime(2025, 1, 5, 18, 52, 43, 798);
            // 
            // tableImportHistory
            // 
            tableImportHistory.AllowUserToAddRows = false;
            tableImportHistory.AllowUserToDeleteRows = false;
            tableImportHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableImportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportHistory.Location = new Point(2, 169);
            tableImportHistory.Margin = new Padding(2);
            tableImportHistory.MultiSelect = false;
            tableImportHistory.Name = "tableImportHistory";
            tableImportHistory.ReadOnly = true;
            tableImportHistory.RowHeadersVisible = false;
            tableImportHistory.RowHeadersWidth = 51;
            tableImportHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableImportHistory.Size = new Size(661, 721);
            tableImportHistory.TabIndex = 79;
            tableImportHistory.SelectionChanged += tableImportHistory_SelectionChanged;
            // 
            // tableImportDetail
            // 
            tableImportDetail.AllowUserToAddRows = false;
            tableImportDetail.AllowUserToDeleteRows = false;
            tableImportDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableImportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportDetail.Location = new Point(6, 90);
            tableImportDetail.Margin = new Padding(2);
            tableImportDetail.Name = "tableImportDetail";
            tableImportDetail.ReadOnly = true;
            tableImportDetail.RowHeadersVisible = false;
            tableImportDetail.RowHeadersWidth = 51;
            tableImportDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableImportDetail.Size = new Size(555, 555);
            tableImportDetail.TabIndex = 91;
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImportDate.Location = new Point(191, 55);
            lblImportDate.Margin = new Padding(2, 0, 2, 0);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(78, 23);
            lblImportDate.TabIndex = 87;
            lblImportDate.Text = "1/1/2025";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(89, 55);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 23);
            label10.TabIndex = 86;
            label10.Text = "Ngày nhập:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(89, 13);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(187, 28);
            label9.TabIndex = 85;
            label9.Text = "Chi tiết nhập hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNewImport);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(5, 8);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1233, 54);
            panel2.TabIndex = 92;
            // 
            // btnNewImport
            // 
            btnNewImport.Location = new Point(1093, 6);
            btnNewImport.Margin = new Padding(2);
            btnNewImport.Name = "btnNewImport";
            btnNewImport.Size = new Size(138, 36);
            btnNewImport.TabIndex = 2;
            btnNewImport.Text = "New Import";
            btnNewImport.UseVisualStyleBackColor = true;
            btnNewImport.Click += btnNewImport_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 36);
            label2.TabIndex = 1;
            label2.Text = "Import History";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(249, 663);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(74, 31);
            lblTotalCost.TabIndex = 95;
            lblTotalCost.Text = "00000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(419, 663);
            label12.Name = "label12";
            label12.Size = new Size(56, 28);
            label12.TabIndex = 94;
            label12.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(47, 663);
            label11.Name = "label11";
            label11.Size = new Size(170, 28);
            label11.TabIndex = 93;
            label11.Text = "Tổng thanh toán";
            // 
            // pnlDetailImport
            // 
            pnlDetailImport.Controls.Add(btnPrintImport);
            pnlDetailImport.Controls.Add(label9);
            pnlDetailImport.Controls.Add(lblTotalCost);
            pnlDetailImport.Controls.Add(label10);
            pnlDetailImport.Controls.Add(label12);
            pnlDetailImport.Controls.Add(lblImportDate);
            pnlDetailImport.Controls.Add(label11);
            pnlDetailImport.Controls.Add(tableImportDetail);
            pnlDetailImport.Location = new Point(668, 169);
            pnlDetailImport.Name = "pnlDetailImport";
            pnlDetailImport.Size = new Size(568, 721);
            pnlDetailImport.TabIndex = 96;
            // 
            // btnPrintImport
            // 
            btnPrintImport.Location = new Point(383, 26);
            btnPrintImport.Margin = new Padding(2);
            btnPrintImport.Name = "btnPrintImport";
            btnPrintImport.Size = new Size(138, 36);
            btnPrintImport.TabIndex = 3;
            btnPrintImport.Text = "Print Import";
            btnPrintImport.UseVisualStyleBackColor = true;
            btnPrintImport.Click += btnPrintImport_Click;
            // 
            // Import_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDetailImport);
            Controls.Add(panel2);
            Controls.Add(btnFillWithDay);
            Controls.Add(dtpEnd);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(tableImportHistory);
            Margin = new Padding(2);
            Name = "Import_Product";
            Size = new Size(1250, 900);
            Load += Import_Product_Load;
            ((System.ComponentModel.ISupportInitialize)tableImportHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableImportDetail).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDetailImport.ResumeLayout(false);
            pnlDetailImport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFillWithDay;
        private DateTimePicker dtpEnd;
        private Label label3;
        private DateTimePicker dtpStart;
        private DataGridView tableImportHistory;
        private DataGridView tableImportDetail;
        private Label lblImportDate;
        private Label label10;
        private Label label9;
        private Panel panel2;
        private Button btnNewImport;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblTotalCost;
        private Label label12;
        private Label label11;
        private Panel pnlDetailImport;
        private Button btnPrintImport;
    }
}
