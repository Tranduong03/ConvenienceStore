namespace GroceryStore.Views.AdminView
{
    partial class EmployeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetail));
            groupBox1 = new GroupBox();
            btnResetPassword = new Button();
            btnDelete = new Button();
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
            openFileDialog1 = new OpenFileDialog();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeeImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnResetPassword);
            groupBox1.Controls.Add(btnDelete);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 685);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = SystemColors.ActiveBorder;
            btnResetPassword.Location = new Point(105, 620);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(299, 59);
            btnResetPassword.TabIndex = 74;
            btnResetPassword.Text = "Thiết lập lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Location = new Point(6, 620);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 59);
            btnDelete.TabIndex = 73;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.BackColor = Color.Lime;
            btnSaveInfo.Location = new Point(410, 620);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(90, 59);
            btnSaveInfo.TabIndex = 72;
            btnSaveInfo.Text = "Lưu";
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(461, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.TabIndex = 75;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // EmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 709);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDetail";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployeeImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnSaveInfo;
        private TextBox txbImgLink;
        private Button btnSelectImage;
        private PictureBox picEmployeeImage;
        private Label label2;
        private Label label15;
        private Label label16;
        private Label label5;
        private Label label14;
        private TextBox txbEmail;
        private TextBox txbName;
        private Label label6;
        private TextBox txbPhone;
        private Label label7;
        private Label label13;
        private Label label8;
        private Label label12;
        private TextBox txbAddress;
        private ComboBox cboGender;
        private Button btnResetPassword;
        private OpenFileDialog openFileDialog1;
        private Button btnBack;
    }
}