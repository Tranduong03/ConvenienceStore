namespace GroceryStore.Views.AdminView
{
    partial class EmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flpEmployeeView = new FlowLayoutPanel();
            btnSearch = new Button();
            txbSearch = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 8);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 50);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(993, 3);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(228, 43);
            button1.TabIndex = 2;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 36);
            label1.TabIndex = 1;
            label1.Text = "Employee Manage";
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
            flpEmployeeView.Location = new Point(87, 116);
            flpEmployeeView.Margin = new Padding(0);
            flpEmployeeView.Name = "flpEmployeeView";
            flpEmployeeView.Size = new Size(1070, 650);
            flpEmployeeView.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(416, 76);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(34, 30);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Tahoma", 10F);
            txbSearch.Location = new Point(87, 76);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Find Employee Here";
            txbSearch.Size = new Size(326, 28);
            txbSearch.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 11F);
            button2.Location = new Point(416, 808);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 5;
            button2.Text = "Trước";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 11F);
            button3.Location = new Point(755, 810);
            button3.Name = "button3";
            button3.Size = new Size(94, 36);
            button3.TabIndex = 6;
            button3.Text = "Sau";
            button3.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11F);
            label3.Location = new Point(600, 815);
            label3.Name = "label3";
            label3.Size = new Size(20, 23);
            label3.TabIndex = 9;
            label3.Text = "1";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F);
            label5.Location = new Point(667, 815);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 11;
            label5.Text = "max";
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(flpEmployeeView);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9F);
            Name = "EmployeeView";
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
        private Button button1;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button button2;
        private Button button3;
        private Label label2;
        public FlowLayoutPanel flpEmployeeView;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}