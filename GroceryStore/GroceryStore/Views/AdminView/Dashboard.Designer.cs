namespace GroceryStore.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnlChart = new Panel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblBillCount = new Label();
            lblMonthlyProfit = new Label();
            label4 = new Label();
            label6 = new Label();
            lblWeeklyProfit = new Label();
            groupBox2 = new GroupBox();
            tableTop5Customer = new DataGridView();
            groupBox3 = new GroupBox();
            pictureBox8 = new PictureBox();
            lblSupplierCount = new Label();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            lblProductCount = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            pictureBox7 = new PictureBox();
            lblEmployeeCount = new Label();
            lblCustomerCount = new Label();
            label9 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlChart.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableTop5Customer).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(5, 10);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 55);
            panel2.TabIndex = 87;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 8);
            label2.Name = "label2";
            label2.Size = new Size(158, 36);
            label2.TabIndex = 1;
            label2.Text = "Dashboard";
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
            // pnlChart
            // 
            pnlChart.Controls.Add(plotView1);
            pnlChart.Location = new Point(5, 359);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(843, 515);
            pnlChart.TabIndex = 89;
            // 
            // plotView1
            // 
            plotView1.BackColor = SystemColors.ActiveCaption;
            plotView1.Dock = DockStyle.Fill;
            plotView1.Location = new Point(0, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(843, 515);
            plotView1.TabIndex = 0;
            plotView1.Text = "Doanh thu theo tháng";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(lblBillCount);
            groupBox1.Controls.Add(lblMonthlyProfit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblWeeklyProfit);
            groupBox1.Font = new Font("Tahoma", 12F);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 235);
            groupBox1.TabIndex = 90;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doanh thu cửa hàng";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 147);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 99;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(480, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 98;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 33);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 91;
            label1.Text = "Số hóa đơn";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // lblBillCount
            // 
            lblBillCount.AutoSize = true;
            lblBillCount.Location = new Point(75, 65);
            lblBillCount.Name = "lblBillCount";
            lblBillCount.Size = new Size(80, 24);
            lblBillCount.TabIndex = 92;
            lblBillCount.Text = "Number";
            // 
            // lblMonthlyProfit
            // 
            lblMonthlyProfit.AutoSize = true;
            lblMonthlyProfit.Location = new Point(77, 184);
            lblMonthlyProfit.Name = "lblMonthlyProfit";
            lblMonthlyProfit.Size = new Size(80, 24);
            lblMonthlyProfit.TabIndex = 96;
            lblMonthlyProfit.Text = "Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(560, 33);
            label4.Name = "label4";
            label4.Size = new Size(247, 25);
            label4.TabIndex = 93;
            label4.Text = "Lợi nhuận trong 7 ngày qua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(77, 147);
            label6.Name = "label6";
            label6.Size = new Size(240, 25);
            label6.TabIndex = 95;
            label6.Text = "Lợi nhuận trong tháng qua";
            // 
            // lblWeeklyProfit
            // 
            lblWeeklyProfit.AutoSize = true;
            lblWeeklyProfit.Location = new Point(560, 65);
            lblWeeklyProfit.Name = "lblWeeklyProfit";
            lblWeeklyProfit.Size = new Size(21, 24);
            lblWeeklyProfit.TabIndex = 94;
            lblWeeklyProfit.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableTop5Customer);
            groupBox2.Font = new Font("Tahoma", 12F);
            groupBox2.Location = new Point(854, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 235);
            groupBox2.TabIndex = 100;
            groupBox2.TabStop = false;
            groupBox2.Text = "Top 5 khách hàng ";
            // 
            // tableTop5Customer
            // 
            tableTop5Customer.AllowUserToAddRows = false;
            tableTop5Customer.AllowUserToDeleteRows = false;
            tableTop5Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableTop5Customer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableTop5Customer.ColumnHeadersHeight = 29;
            tableTop5Customer.Location = new Point(26, 44);
            tableTop5Customer.MultiSelect = false;
            tableTop5Customer.Name = "tableTop5Customer";
            tableTop5Customer.ReadOnly = true;
            tableTop5Customer.RowHeadersVisible = false;
            tableTop5Customer.RowHeadersWidth = 51;
            tableTop5Customer.Size = new Size(337, 173);
            tableTop5Customer.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(pictureBox8);
            groupBox3.Controls.Add(lblSupplierCount);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(pictureBox6);
            groupBox3.Controls.Add(lblProductCount);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(pictureBox7);
            groupBox3.Controls.Add(lblEmployeeCount);
            groupBox3.Controls.Add(lblCustomerCount);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Tahoma", 12F);
            groupBox3.Location = new Point(854, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 515);
            groupBox3.TabIndex = 100;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số lượng";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(6, 366);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(63, 61);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 105;
            pictureBox8.TabStop = false;
            // 
            // lblSupplierCount
            // 
            lblSupplierCount.AutoSize = true;
            lblSupplierCount.Location = new Point(77, 403);
            lblSupplierCount.Name = "lblSupplierCount";
            lblSupplierCount.Size = new Size(80, 24);
            lblSupplierCount.TabIndex = 104;
            lblSupplierCount.Text = "Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 366);
            label8.Name = "label8";
            label8.Size = new Size(96, 25);
            label8.TabIndex = 103;
            label8.Text = "Số đối tác";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(6, 254);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(63, 61);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 102;
            pictureBox6.TabStop = false;
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Location = new Point(77, 291);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(80, 24);
            lblProductCount.TabIndex = 101;
            lblProductCount.Text = "Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 254);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 100;
            label7.Text = "Số sản phẩm";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(6, 143);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 99;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 33);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 91;
            label3.Text = "Số nhân viên";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(6, 33);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 97;
            pictureBox7.TabStop = false;
            // 
            // lblEmployeeCount
            // 
            lblEmployeeCount.AutoSize = true;
            lblEmployeeCount.Location = new Point(75, 65);
            lblEmployeeCount.Name = "lblEmployeeCount";
            lblEmployeeCount.Size = new Size(80, 24);
            lblEmployeeCount.TabIndex = 92;
            lblEmployeeCount.Text = "Number";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Location = new Point(77, 180);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(80, 24);
            lblCustomerCount.TabIndex = 96;
            lblCustomerCount.Text = "Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(77, 143);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 95;
            label9.Text = "Số khách hàng";
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlChart);
            Controls.Add(panel2);
            Name = "Dashboard";
            Size = new Size(1250, 900);
            Load += Dashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlChart.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableTop5Customer).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel pnlChart;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private GroupBox groupBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label lblBillCount;
        private Label lblMonthlyProfit;
        private Label label4;
        private Label label6;
        private Label lblWeeklyProfit;
        private GroupBox groupBox2;
        private DataGridView tableTop5Customer;
        private GroupBox groupBox3;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox7;
        private Label lblEmployeeCount;
        private Label lblCustomerCount;
        private Label label9;
        private PictureBox pictureBox8;
        private Label lblSupplierCount;
        private Label label8;
        private PictureBox pictureBox6;
        private Label lblProductCount;
        private Label label7;
    }
}