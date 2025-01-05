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
            ((System.ComponentModel.ISupportInitialize)tableImportHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableImportDetail).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            this.Load += new EventHandler(Import_Product_Load);

            // 
            // btnFillWithDay
            // 
            btnFillWithDay.Location = new Point(422, 146);
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
            dtpEnd.Location = new Point(234, 146);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(161, 31);
            dtpEnd.TabIndex = 84;
            dtpEnd.MaxDate = DateTime.Now;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 149);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 83;
            label3.Text = "to :";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(9, 146);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(161, 31);
            dtpStart.TabIndex = 82;
            dtpStart.MaxDate = DateTime.Now;
            // 
            // tableImportHistory
            // 
            tableImportHistory.AllowUserToAddRows = false;
            tableImportHistory.AllowUserToDeleteRows = false;
            tableImportHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableImportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportHistory.Location = new Point(3, 211);
            tableImportHistory.MultiSelect = false;
            tableImportHistory.Name = "tableImportHistory";
            tableImportHistory.ReadOnly = true;
            tableImportHistory.RowHeadersVisible = false;
            tableImportHistory.RowHeadersWidth = 51;
            tableImportHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableImportHistory.Size = new Size(628, 686);
            tableImportHistory.TabIndex = 79;
            tableImportHistory.SelectionChanged += tableImportHistory_SelectionChanged;
            // 
            // tableImportDetail
            // 
            tableImportDetail.AllowUserToAddRows = false;
            tableImportDetail.AllowUserToDeleteRows = false;
            tableImportDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableImportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableImportDetail.Location = new Point(646, 289);
            tableImportDetail.Name = "tableImportDetail";
            tableImportDetail.ReadOnly = true;
            tableImportDetail.RowHeadersVisible = false;
            tableImportDetail.RowHeadersWidth = 51;
            tableImportDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableImportDetail.Size = new Size(590, 590);
            tableImportDetail.TabIndex = 91;
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImportDate.Location = new Point(754, 245);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(95, 30);
            lblImportDate.TabIndex = 87;
            lblImportDate.Text = "1/1/2025";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(646, 245);
            label10.Name = "label10";
            label10.Size = new Size(103, 30);
            label10.TabIndex = 86;
            label10.Text = "Ngày tạo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(646, 208);
            label9.Name = "label9";
            label9.Size = new Size(223, 32);
            label9.TabIndex = 85;
            label9.Text = "Chi tiết nhập hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNewImport);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(6, 10);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 55);
            panel2.TabIndex = 92;
            // 
            // btnNewImport
            // 
            btnNewImport.Location = new Point(1076, 9);
            btnNewImport.Name = "btnNewImport";
            btnNewImport.Size = new Size(162, 35);
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
            label2.Location = new Point(57, 8);
            label2.Name = "label2";
            label2.Size = new Size(249, 43);
            label2.TabIndex = 1;
            label2.Text = "Import History";
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
            // Import_Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(tableImportDetail);
            Controls.Add(lblImportDate);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnFillWithDay);
            Controls.Add(dtpEnd);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(tableImportHistory);
            Name = "Import_Product";
            Size = new Size(1250, 900);
            ((System.ComponentModel.ISupportInitialize)tableImportHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableImportDetail).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
