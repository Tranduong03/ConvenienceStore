namespace GroceryStore.Views
{
    partial class EmployeeDetailInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetailInfo));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnSavePassword = new Button();
            label17 = new Label();
            txbRePassword = new TextBox();
            label19 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            txbNewPassword = new TextBox();
            txbPassword = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            btnSaveInfo = new Button();
            txbImgLink = new TextBox();
            btnSelectImage = new Button();
            picEmployeeImage = new PictureBox();
            label2 = new Label();
            label15 = new Label();
            label16 = new Label();
            label5 = new Label();
            label14 = new Label();
            txbEmail = new TextBox();
            txbName = new TextBox();
            label6 = new Label();
            txbPhone = new TextBox();
            label7 = new Label();
            label13 = new Label();
            label8 = new Label();
            label12 = new Label();
            txbAddress = new TextBox();
            cboGender = new ComboBox();
            lblWarning = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeeImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 9);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 55);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 10);
            label1.Name = "label1";
            label1.Size = new Size(187, 36);
            label1.TabIndex = 1;
            label1.Text = "Personal info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblWarning);
            panel2.Location = new Point(9, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1232, 821);
            panel2.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSavePassword);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txbRePassword);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txbNewPassword);
            groupBox2.Controls.Add(txbPassword);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(622, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(573, 736);
            groupBox2.TabIndex = 69;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đổi mật khẩu";
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.Lime;
            btnSavePassword.Location = new Point(156, 337);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(224, 61);
            btnSavePassword.TabIndex = 73;
            btnSavePassword.Text = "Đổi mật khẩu";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 12F);
            label17.Location = new Point(64, 219);
            label17.Name = "label17";
            label17.Size = new Size(173, 24);
            label17.TabIndex = 73;
            label17.Text = "Nhập lại mật khẩu";
            // 
            // txbRePassword
            // 
            txbRePassword.Font = new Font("Tahoma", 12F);
            txbRePassword.Location = new Point(64, 246);
            txbRePassword.Name = "txbRePassword";
            txbRePassword.Size = new Size(376, 32);
            txbRePassword.TabIndex = 74;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 12F);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(246, 219);
            label19.Name = "label19";
            label19.Size = new Size(21, 24);
            label19.TabIndex = 75;
            label19.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(64, 44);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 70;
            label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(64, 130);
            label4.Name = "label4";
            label4.Size = new Size(131, 24);
            label4.TabIndex = 67;
            label4.Text = "Mật khẩu mới";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(195, 44);
            label9.Name = "label9";
            label9.Size = new Size(21, 24);
            label9.TabIndex = 72;
            label9.Text = "*";
            // 
            // txbNewPassword
            // 
            txbNewPassword.Font = new Font("Tahoma", 12F);
            txbNewPassword.Location = new Point(64, 157);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(376, 32);
            txbNewPassword.TabIndex = 68;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Tahoma", 12F);
            txbPassword.Location = new Point(64, 71);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(376, 32);
            txbPassword.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(195, 129);
            label10.Name = "label10";
            label10.Size = new Size(21, 24);
            label10.TabIndex = 69;
            label10.Text = "*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveInfo);
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
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txbAddress);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 736);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.BackColor = Color.Lime;
            btnSaveInfo.Location = new Point(164, 643);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(189, 61);
            btnSaveInfo.TabIndex = 72;
            btnSaveInfo.Text = "Save";
            btnSaveInfo.UseVisualStyleBackColor = false;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // txbImgLink
            // 
            txbImgLink.Location = new Point(118, 389);
            txbImgLink.Name = "txbImgLink";
            txbImgLink.Size = new Size(287, 35);
            txbImgLink.TabIndex = 71;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new Font("Tahoma", 12F);
            btnSelectImage.Location = new Point(164, 439);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(112, 34);
            btnSelectImage.TabIndex = 70;
            btnSelectImage.Text = "Chọn ảnh";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // picEmployeeImage
            // 
            picEmployeeImage.Location = new Point(32, 439);
            picEmployeeImage.Name = "picEmployeeImage";
            picEmployeeImage.Size = new Size(126, 124);
            picEmployeeImage.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployeeImage.TabIndex = 69;
            picEmployeeImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(32, 395);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 68;
            label2.Text = "Image: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F);
            label15.Location = new Point(29, 44);
            label15.Name = "label15";
            label15.Size = new Size(137, 24);
            label15.TabIndex = 64;
            label15.Text = "Tên nhân viên";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 12F);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(160, 209);
            label16.Name = "label16";
            label16.Size = new Size(21, 24);
            label16.TabIndex = 67;
            label16.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(32, 129);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 50;
            label5.Text = "Địa chỉ email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(160, 44);
            label14.Name = "label14";
            label14.Size = new Size(21, 24);
            label14.TabIndex = 66;
            label14.Text = "*";
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Tahoma", 12F);
            txbEmail.Location = new Point(29, 157);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(376, 32);
            txbEmail.TabIndex = 51;
            // 
            // txbName
            // 
            txbName.Font = new Font("Tahoma", 12F);
            txbName.Location = new Point(29, 71);
            txbName.Name = "txbName";
            txbName.Size = new Size(376, 32);
            txbName.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(31, 209);
            label6.Name = "label6";
            label6.Size = new Size(127, 24);
            label6.TabIndex = 52;
            label6.Text = "Số điện thoại";
            // 
            // txbPhone
            // 
            txbPhone.Font = new Font("Tahoma", 12F);
            txbPhone.Location = new Point(31, 246);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(184, 32);
            txbPhone.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(221, 209);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 54;
            label7.Text = "Giới tính";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(311, 209);
            label13.Name = "label13";
            label13.Size = new Size(21, 24);
            label13.TabIndex = 62;
            label13.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.Location = new Point(32, 310);
            label8.Name = "label8";
            label8.Size = new Size(56, 24);
            label8.TabIndex = 55;
            label8.Text = "Nơi ở";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(160, 129);
            label12.Name = "label12";
            label12.Size = new Size(21, 24);
            label12.TabIndex = 61;
            label12.Text = "*";
            // 
            // txbAddress
            // 
            txbAddress.Font = new Font("Tahoma", 12F);
            txbAddress.Location = new Point(31, 337);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(374, 32);
            txbAddress.TabIndex = 56;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Tahoma", 12F);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Phi nhị giới" });
            cboGender.Location = new Point(221, 246);
            cboGender.Margin = new Padding(0);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(184, 32);
            cboGender.TabIndex = 57;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(428, 608);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(10, 0, 0, 0);
            lblWarning.Size = new Size(10, 20);
            lblWarning.TabIndex = 63;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmployeeDetailInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 900);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDetailInfo";
            Text = "CustomerDetailInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeeImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label16;
        private Label label14;
        private TextBox txbName;
        private Label label15;
        private Label lblWarning;
        private Label label13;
        private Label label12;
        private ComboBox cboGender;
        private TextBox txbAddress;
        private Label label8;
        private Label label7;
        private TextBox txbPhone;
        private Label label6;
        private TextBox txbEmail;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txbImgLink;
        private Button btnSelectImage;
        private PictureBox picEmployeeImage;
        private Label label2;
        private Label label17;
        private TextBox txbRePassword;
        private Label label19;
        private Label label3;
        private Label label4;
        private Label label9;
        private TextBox txbNewPassword;
        private TextBox txbPassword;
        private Label label10;
        private Button btnSavePassword;
        private Button btnSaveInfo;
        private OpenFileDialog openFileDialog1;
    }
}