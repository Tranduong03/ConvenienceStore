namespace GroceryStore.Views.AdminView
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            cboGender = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label7 = new Label();
            txbPhone = new TextBox();
            label6 = new Label();
            txbName = new TextBox();
            txbEmail = new TextBox();
            label14 = new Label();
            label5 = new Label();
            label16 = new Label();
            label15 = new Label();
            label2 = new Label();
            picEmployeeImage = new PictureBox();
            btnSelectImage = new Button();
            txbImgLink = new TextBox();
            btnAddEmployee = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            lblError = new Label();
            label4 = new Label();
            label9 = new Label();
            txbPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txbAccount = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picEmployeeImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Tahoma", 12F);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(214, 367);
            cboGender.Margin = new Padding(0);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(184, 32);
            cboGender.TabIndex = 57;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(155, 258);
            label12.Name = "label12";
            label12.Size = new Size(21, 24);
            label12.TabIndex = 61;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(304, 330);
            label13.Name = "label13";
            label13.Size = new Size(21, 24);
            label13.TabIndex = 62;
            label13.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(214, 330);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 54;
            label7.Text = "Giới tính";
            // 
            // txbPhone
            // 
            txbPhone.Font = new Font("Tahoma", 12F);
            txbPhone.Location = new Point(24, 367);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(184, 32);
            txbPhone.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(24, 330);
            label6.Name = "label6";
            label6.Size = new Size(127, 24);
            label6.TabIndex = 52;
            label6.Text = "Số điện thoại";
            // 
            // txbName
            // 
            txbName.Font = new Font("Tahoma", 12F);
            txbName.Location = new Point(24, 214);
            txbName.Name = "txbName";
            txbName.Size = new Size(376, 32);
            txbName.TabIndex = 65;
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Tahoma", 12F);
            txbEmail.Location = new Point(24, 286);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(376, 32);
            txbEmail.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(155, 187);
            label14.Name = "label14";
            label14.Size = new Size(21, 24);
            label14.TabIndex = 66;
            label14.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(27, 258);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 50;
            label5.Text = "Địa chỉ email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 12F);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(153, 330);
            label16.Name = "label16";
            label16.Size = new Size(21, 24);
            label16.TabIndex = 67;
            label16.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F);
            label15.Location = new Point(24, 187);
            label15.Name = "label15";
            label15.Size = new Size(137, 24);
            label15.TabIndex = 64;
            label15.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(26, 416);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 68;
            label2.Text = "Ảnh: ";
            // 
            // picEmployeeImage
            // 
            picEmployeeImage.Location = new Point(28, 454);
            picEmployeeImage.Name = "picEmployeeImage";
            picEmployeeImage.Size = new Size(126, 124);
            picEmployeeImage.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployeeImage.TabIndex = 69;
            picEmployeeImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new Font("Tahoma", 12F);
            btnSelectImage.Location = new Point(160, 454);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(112, 34);
            btnSelectImage.TabIndex = 70;
            btnSelectImage.Text = "Chọn ảnh";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // txbImgLink
            // 
            txbImgLink.Location = new Point(112, 410);
            txbImgLink.Name = "txbImgLink";
            txbImgLink.Size = new Size(287, 35);
            txbImgLink.TabIndex = 71;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.Lime;
            btnAddEmployee.Location = new Point(6, 621);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(494, 59);
            btnAddEmployee.TabIndex = 72;
            btnAddEmployee.Text = "Lưu";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(452, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.TabIndex = 75;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblError);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txbPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbAccount);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnAddEmployee);
            groupBox1.Controls.Add(txbImgLink);
            groupBox1.Controls.Add(btnSelectImage);
            groupBox1.Controls.Add(picEmployeeImage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txbEmail);
            groupBox1.Controls.Add(txbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txbPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 696);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = SystemColors.Control;
            lblError.Font = new Font("Tahoma", 10F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(27, 590);
            lblError.Name = "lblError";
            lblError.Size = new Size(54, 21);
            lblError.TabIndex = 82;
            lblError.Text = "label8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(28, 115);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 79;
            label4.Text = "Mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(126, 115);
            label9.Name = "label9";
            label9.Size = new Size(21, 24);
            label9.TabIndex = 81;
            label9.Text = "*";
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Tahoma", 12F);
            txbPassword.Location = new Point(28, 142);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(376, 32);
            txbPassword.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(133, 24);
            label1.TabIndex = 76;
            label1.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(160, 44);
            label3.Name = "label3";
            label3.Size = new Size(21, 24);
            label3.TabIndex = 78;
            label3.Text = "*";
            // 
            // txbAccount
            // 
            txbAccount.Font = new Font("Tahoma", 12F);
            txbAccount.Location = new Point(28, 71);
            txbAccount.Name = "txbAccount";
            txbAccount.Size = new Size(376, 32);
            txbAccount.TabIndex = 77;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddEmployee
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(537, 716);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)picEmployeeImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboGender;
        private Label label12;
        private Label label13;
        private Label label7;
        private TextBox txbPhone;
        private Label label6;
        private TextBox txbName;
        private TextBox txbEmail;
        private Label label14;
        private Label label5;
        private Label label16;
        private Label label15;
        private Label label2;
        private PictureBox picEmployeeImage;
        private Button btnSelectImage;
        private TextBox txbImgLink;
        private Button btnAddEmployee;
        private Button btnBack;
        private GroupBox groupBox1;
        private Label label4;
        private Label label9;
        private TextBox txbPassword;
        private Label label1;
        private Label label3;
        private TextBox txbAccount;
        private Label lblError;
        private OpenFileDialog openFileDialog1;
    }
}