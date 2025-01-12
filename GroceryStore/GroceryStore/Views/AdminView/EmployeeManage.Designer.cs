namespace GroceryStore.Views.AdminView
{
    partial class EmployeeManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManage));
            panel1 = new Panel();
            btnAddEmployee = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flpEmployeeView = new FlowLayoutPanel();
            btnSearch = new Button();
            txbSearch = new TextBox();
            btnPrev = new Button();
            btnNext = new Button();
            label2 = new Label();
            lblCurrentPage = new Label();
            label4 = new Label();
            lblMaxPage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddEmployee);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 8);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 50);
            panel1.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.Chartreuse;
            btnAddEmployee.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAddEmployee.Location = new Point(993, 3);
            btnAddEmployee.Margin = new Padding(0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(228, 43);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.Text = "Thêm nhân viên";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 36);
            label1.TabIndex = 1;
            label1.Text = "Quản lý nhân viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 43);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flpEmployeeView
            // 
            flpEmployeeView.AutoScroll = true;
            flpEmployeeView.Location = new Point(140, 116);
            flpEmployeeView.Margin = new Padding(0);
            flpEmployeeView.Name = "flpEmployeeView";
            flpEmployeeView.Size = new Size(977, 650);
            flpEmployeeView.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(486, 76);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(34, 30);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 10F);
            txbSearch.Location = new Point(157, 76);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Tìm nhân viên tại đây";
            txbSearch.Size = new Size(326, 28);
            txbSearch.TabIndex = 3;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Tahoma", 11F);
            btnPrev.Location = new Point(416, 808);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 36);
            btnPrev.TabIndex = 5;
            btnPrev.Text = "Trước";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Tahoma", 11F);
            btnNext.Location = new Point(755, 810);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 36);
            btnNext.TabIndex = 6;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F);
            label2.Location = new Point(532, 817);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 8;
            label2.Text = "Trang: ";
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Tahoma", 11F);
            lblCurrentPage.Location = new Point(600, 815);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(20, 23);
            lblCurrentPage.TabIndex = 9;
            lblCurrentPage.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11F);
            label4.Location = new Point(644, 815);
            label4.Name = "label4";
            label4.Size = new Size(17, 23);
            label4.TabIndex = 10;
            label4.Text = "/";
            // 
            // lblMaxPage
            // 
            lblMaxPage.AutoSize = true;
            lblMaxPage.Font = new Font("Tahoma", 11F);
            lblMaxPage.Location = new Point(667, 815);
            lblMaxPage.Name = "lblMaxPage";
            lblMaxPage.Size = new Size(45, 23);
            lblMaxPage.TabIndex = 11;
            lblMaxPage.Text = "max";
            // 
            // EmployeeManage
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMaxPage);
            Controls.Add(label4);
            Controls.Add(lblCurrentPage);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(flpEmployeeView);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9F);
            Name = "EmployeeManage";
            Size = new Size(1250, 900);
            Load += EmployeeView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAddEmployee;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button btnPrev;
        private Button btnNext;
        private Label label2;
        public FlowLayoutPanel flpEmployeeView;
        private Label lblCurrentPage;
        private Label label4;
        private Label lblMaxPage;
    }
}