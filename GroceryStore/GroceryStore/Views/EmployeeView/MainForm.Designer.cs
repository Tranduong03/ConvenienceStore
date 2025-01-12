namespace GroceryStore.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidebarMenu = new FlowLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            lblCustomerName = new Label();
            picImgLink = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnBuy = new Button();
            panel3 = new Panel();
            btnDetailInfo = new Button();
            panel4 = new Panel();
            btnBillHistory = new Button();
            panel5 = new Panel();
            btnExit = new Button();
            pnlWork = new Panel();
            sidebarMenu.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImgLink).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = Color.FromArgb(37, 150, 190);
            sidebarMenu.Controls.Add(panel6);
            sidebarMenu.Controls.Add(panel2);
            sidebarMenu.Controls.Add(panel3);
            sidebarMenu.Controls.Add(panel4);
            sidebarMenu.Controls.Add(panel5);
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.Margin = new Padding(0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(350, 900);
            sidebarMenu.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(picImgLink);
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
            panel7.Controls.Add(lblCustomerName);
            panel7.Location = new Point(3, 232);
            panel7.Name = "panel7";
            panel7.Size = new Size(347, 45);
            panel7.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(128, 8);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(87, 29);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "ADMIN";
            lblCustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImgLink
            // 
            picImgLink.Image = (Image)resources.GetObject("picImgLink.Image");
            picImgLink.Location = new Point(113, 53);
            picImgLink.Name = "picImgLink";
            picImgLink.Size = new Size(125, 116);
            picImgLink.SizeMode = PictureBoxSizeMode.Zoom;
            picImgLink.TabIndex = 0;
            picImgLink.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 188);
            label1.Name = "label1";
            label1.Size = new Size(250, 29);
            label1.TabIndex = 1;
            label1.Text = "MỘT NGÀY TỐT LÀNH";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuy);
            panel2.Location = new Point(25, 320);
            panel2.Margin = new Padding(25, 20, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 64);
            panel2.TabIndex = 3;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(37, 150, 190);
            btnBuy.Dock = DockStyle.Fill;
            btnBuy.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnBuy.Image = (Image)resources.GetObject("btnBuy.Image");
            btnBuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuy.Location = new Point(0, 0);
            btnBuy.Margin = new Padding(0);
            btnBuy.Name = "btnBuy";
            btnBuy.Padding = new Padding(30, 0, 0, 0);
            btnBuy.Size = new Size(300, 64);
            btnBuy.TabIndex = 2;
            btnBuy.Text = "        Bán hàng";
            btnBuy.TextAlign = ContentAlignment.MiddleLeft;
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDetailInfo);
            panel3.Location = new Point(25, 404);
            panel3.Margin = new Padding(25, 20, 0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 64);
            panel3.TabIndex = 3;
            // 
            // btnDetailInfo
            // 
            btnDetailInfo.BackColor = Color.FromArgb(37, 150, 190);
            btnDetailInfo.Dock = DockStyle.Fill;
            btnDetailInfo.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            btnDetailInfo.Image = (Image)resources.GetObject("btnDetailInfo.Image");
            btnDetailInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetailInfo.Location = new Point(0, 0);
            btnDetailInfo.Margin = new Padding(0);
            btnDetailInfo.Name = "btnDetailInfo";
            btnDetailInfo.Padding = new Padding(30, 0, 0, 0);
            btnDetailInfo.Size = new Size(300, 64);
            btnDetailInfo.TabIndex = 2;
            btnDetailInfo.Text = "        Hồ sơ cá nhân";
            btnDetailInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnDetailInfo.UseVisualStyleBackColor = false;
            btnDetailInfo.Click += btnDetailInfo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBillHistory);
            panel4.Location = new Point(25, 488);
            panel4.Margin = new Padding(25, 20, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 64);
            panel4.TabIndex = 3;
            // 
            // btnBillHistory
            // 
            btnBillHistory.BackColor = Color.FromArgb(37, 150, 190);
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
            btnBillHistory.Text = "        Lịch sử hóa đơn";
            btnBillHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnBillHistory.UseVisualStyleBackColor = false;
            btnBillHistory.Click += btnBillHistory_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnExit);
            panel5.Location = new Point(25, 572);
            panel5.Margin = new Padding(25, 20, 0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 64);
            panel5.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(37, 150, 190);
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
            pnlWork.Dock = DockStyle.Right;
            pnlWork.Location = new Point(350, 0);
            pnlWork.Margin = new Padding(0);
            pnlWork.Name = "pnlWork";
            pnlWork.Size = new Size(1250, 900);
            pnlWork.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1600, 900);
            Controls.Add(pnlWork);
            Controls.Add(sidebarMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flash Shop";
            sidebarMenu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImgLink).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebarMenu;
        private Panel panel6;
        private Panel panel7;
        private Label lblCustomerName;
        private PictureBox picImgLink;
        private Label label1;
        private Panel panel2;
        private Button btnBuy;
        private Panel panel3;
        private Button btnDetailInfo;
        private Panel panel4;
        private Button btnBillHistory;
        private Panel panel5;
        private Button btnExit;
        private Panel pnlWork;
    }
}