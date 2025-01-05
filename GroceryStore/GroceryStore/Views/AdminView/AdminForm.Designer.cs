namespace GroceryStore.Views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            sidebarMenu = new FlowLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btnDashboard = new Button();
            panel2 = new Panel();
            btnProduct = new Button();
            panel3 = new Panel();
            btnCustomer = new Button();
            panel8 = new Panel();
            btnEmployee = new Button();
            panel4 = new Panel();
            btnBillHistory = new Button();
            panel9 = new Panel();
            btnImport = new Button();
            panel5 = new Panel();
            btnExit = new Button();
            pnlWork = new Panel();
            sidebarMenu.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarMenu
            // 
            sidebarMenu.AutoScroll = true;
            sidebarMenu.BackColor = Color.FromArgb(37, 150, 190);
            sidebarMenu.Controls.Add(panel6);
            sidebarMenu.Controls.Add(panel1);
            sidebarMenu.Controls.Add(panel2);
            sidebarMenu.Controls.Add(panel3);
            sidebarMenu.Controls.Add(panel8);
            sidebarMenu.Controls.Add(panel4);
            sidebarMenu.Controls.Add(panel9);
            sidebarMenu.Controls.Add(panel5);
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.Margin = new Padding(0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(350, 900);
            sidebarMenu.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(label1);
            panel6.Font = new Font("Tahoma", 14F);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 300);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(label2);
            panel7.Location = new Point(3, 232);
            panel7.Name = "panel7";
            panel7.Size = new Size(347, 45);
            panel7.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(129, 8);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 2;
            label2.Text = "ADMIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(113, 188);
            label1.Name = "label1";
            label1.Size = new Size(123, 29);
            label1.TabIndex = 1;
            label1.Text = "WELCOME";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(25, 320);
            panel1.Margin = new Padding(25, 20, 0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 64);
            panel1.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ActiveCaption;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(30, 0, 0, 0);
            btnDashboard.Size = new Size(300, 64);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "        Bảng thông tin";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProduct);
            panel2.Location = new Point(25, 404);
            panel2.Margin = new Padding(25, 20, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 64);
            panel2.TabIndex = 3;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.ActiveCaption;
            btnProduct.Dock = DockStyle.Fill;
            btnProduct.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 0);
            btnProduct.Margin = new Padding(0);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(30, 0, 0, 0);
            btnProduct.Size = new Size(300, 64);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "        Sản phẩm";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCustomer);
            panel3.Location = new Point(25, 488);
            panel3.Margin = new Padding(25, 20, 0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 64);
            panel3.TabIndex = 3;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.ActiveCaption;
            btnCustomer.Dock = DockStyle.Fill;
            btnCustomer.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 0);
            btnCustomer.Margin = new Padding(0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(30, 0, 0, 0);
            btnCustomer.Size = new Size(300, 64);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "        Khách hàng";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnEmployee);
            panel8.Location = new Point(25, 572);
            panel8.Margin = new Padding(25, 20, 0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 64);
            panel8.TabIndex = 4;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = SystemColors.ActiveCaption;
            btnEmployee.Dock = DockStyle.Fill;
            btnEmployee.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 0);
            btnEmployee.Margin = new Padding(0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(30, 0, 0, 0);
            btnEmployee.Size = new Size(300, 64);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "        Nhân viên";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBillHistory);
            panel4.Location = new Point(25, 656);
            panel4.Margin = new Padding(25, 20, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 64);
            panel4.TabIndex = 3;
            // 
            // btnBillHistory
            // 
            btnBillHistory.BackColor = SystemColors.ActiveCaption;
            btnBillHistory.Dock = DockStyle.Fill;
            btnBillHistory.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnBillHistory.Image = (Image)resources.GetObject("btnBillHistory.Image");
            btnBillHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnBillHistory.Location = new Point(0, 0);
            btnBillHistory.Margin = new Padding(0);
            btnBillHistory.Name = "btnBillHistory";
            btnBillHistory.Padding = new Padding(30, 0, 0, 0);
            btnBillHistory.Size = new Size(300, 64);
            btnBillHistory.TabIndex = 2;
            btnBillHistory.Text = "        Hóa đơn";
            btnBillHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnBillHistory.UseVisualStyleBackColor = false;
            btnBillHistory.Click += btnBillHistory_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnImport);
            panel9.Location = new Point(25, 740);
            panel9.Margin = new Padding(25, 20, 0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(300, 64);
            panel9.TabIndex = 4;
            // 
            // btnImport
            // 
            btnImport.BackColor = SystemColors.ActiveCaption;
            btnImport.Dock = DockStyle.Fill;
            btnImport.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImport.Location = new Point(0, 0);
            btnImport.Margin = new Padding(0);
            btnImport.Name = "btnImport";
            btnImport.Padding = new Padding(30, 0, 0, 0);
            btnImport.Size = new Size(300, 64);
            btnImport.TabIndex = 2;
            btnImport.Text = "        Nhập hàng";
            btnImport.TextAlign = ContentAlignment.MiddleLeft;
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnExit);
            panel5.Location = new Point(25, 824);
            panel5.Margin = new Padding(25, 20, 0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 64);
            panel5.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Dock = DockStyle.Fill;
            btnExit.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(30, 0, 0, 0);
            btnExit.Size = new Size(300, 64);
            btnExit.TabIndex = 2;
            btnExit.Text = "        Thoát";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlWork
            // 
            pnlWork.Location = new Point(350, 0);
            pnlWork.Margin = new Padding(0);
            pnlWork.Name = "pnlWork";
            pnlWork.Size = new Size(1250, 900);
            pnlWork.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1598, 900);
            Controls.Add(pnlWork);
            Controls.Add(sidebarMenu);
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            sidebarMenu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebarMenu;
        private Panel panel1;
        private Button btnDashboard;
        private Panel panel2;
        private Button btnProduct;
        private Panel panel3;
        private Button btnCustomer;
        private Panel panel4;
        private Button btnBillHistory;
        private Panel panel5;
        private Button btnExit;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnlWork;
        private Panel panel8;
        private Button btnEmployee;
        private Panel panel9;
        private Button btnImport;
    }
}