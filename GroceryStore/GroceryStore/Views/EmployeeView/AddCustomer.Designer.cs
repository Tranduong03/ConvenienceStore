namespace GroceryStore.Views
{
    partial class AddCustomer
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
            label16 = new Label();
            label14 = new Label();
            txbName = new TextBox();
            label15 = new Label();
            lblWarning = new Label();
            label13 = new Label();
            label12 = new Label();
            cboGender = new ComboBox();
            txbAddress = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txbPhone = new TextBox();
            label6 = new Label();
            txbEmail = new TextBox();
            label5 = new Label();
            btnAddCustomer = new Button();
            label1 = new Label();
            btnReturn = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(233, 275);
            label16.Name = "label16";
            label16.Size = new Size(15, 19);
            label16.TabIndex = 66;
            label16.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(256, 102);
            label14.Name = "label14";
            label14.Size = new Size(15, 19);
            label14.TabIndex = 65;
            label14.Text = "*";
            // 
            // txbName
            // 
            txbName.Location = new Point(113, 127);
            txbName.Name = "txbName";
            txbName.Size = new Size(376, 27);
            txbName.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 10.8F);
            label15.Location = new Point(113, 102);
            label15.Name = "label15";
            label15.Size = new Size(137, 22);
            label15.TabIndex = 63;
            label15.Text = "Tên khách hàng";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(112, 476);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(10, 0, 0, 0);
            lblWarning.Size = new Size(10, 20);
            lblWarning.TabIndex = 62;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(383, 275);
            label13.Name = "label13";
            label13.Size = new Size(15, 19);
            label13.TabIndex = 61;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(224, 190);
            label12.Name = "label12";
            label12.Size = new Size(15, 19);
            label12.TabIndex = 60;
            label12.Text = "*";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Phi nhị giới" });
            cboGender.Location = new Point(302, 300);
            cboGender.Margin = new Padding(0);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(184, 28);
            cboGender.TabIndex = 56;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(112, 394);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(374, 27);
            txbAddress.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F);
            label8.Location = new Point(112, 369);
            label8.Name = "label8";
            label8.Size = new Size(52, 22);
            label8.TabIndex = 54;
            label8.Text = "Nơi ở";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F);
            label7.Location = new Point(303, 275);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 53;
            label7.Text = "Giới tính";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(112, 300);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(184, 27);
            txbPhone.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F);
            label6.Location = new Point(113, 275);
            label6.Name = "label6";
            label6.Size = new Size(114, 22);
            label6.TabIndex = 51;
            label6.Text = "Số điện thoại";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(111, 215);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(376, 27);
            txbEmail.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F);
            label5.Location = new Point(111, 190);
            label5.Name = "label5";
            label5.Size = new Size(111, 22);
            label5.TabIndex = 49;
            label5.Text = "Địa chỉ email";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ActiveCaption;
            btnAddCustomer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(334, 471);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(201, 49);
            btnAddCustomer.TabIndex = 67;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 69;
            label1.Text = "Thêm khách hàng";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.ActiveBorder;
            btnReturn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(70, 471);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(201, 49);
            btnReturn.TabIndex = 70;
            btnReturn.Text = "Trở về";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(117, 433);
            lblError.Name = "lblError";
            lblError.Size = new Size(30, 20);
            lblError.TabIndex = 71;
            lblError.Text = "Lỗi";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(lblError);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(btnAddCustomer);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(txbName);
            Controls.Add(label15);
            Controls.Add(lblWarning);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(cboGender);
            Controls.Add(txbAddress);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txbPhone);
            Controls.Add(label6);
            Controls.Add(txbEmail);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button btnAddCustomer;
        private Label label1;
        private Button btnReturn;
        private Label lblError;
    }
}