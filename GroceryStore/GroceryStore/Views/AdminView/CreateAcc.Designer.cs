namespace GroceryStore.Views.AdminView
{
    partial class CreateAcc
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtFullname = new TextBox();
            txtAccount = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            dateTimePickerWorkday = new DateTimePicker();
            btnCreate = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(91, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 0;
            label1.Text = "Tạo tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 120);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 155);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 306);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày vào làm";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(122, 82);
            txtFullname.Margin = new Padding(2, 2, 2, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(178, 27);
            txtFullname.TabIndex = 7;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(122, 115);
            txtAccount.Margin = new Padding(2, 2, 2, 2);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(178, 27);
            txtAccount.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(122, 150);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(178, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 188);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 27);
            txtEmail.TabIndex = 10;
            // 
            // dateTimePickerWorkday
            // 
            dateTimePickerWorkday.Location = new Point(122, 306);
            dateTimePickerWorkday.Margin = new Padding(2, 2, 2, 2);
            dateTimePickerWorkday.Name = "dateTimePickerWorkday";
            dateTimePickerWorkday.Size = new Size(178, 27);
            dateTimePickerWorkday.TabIndex = 12;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(102, 354);
            btnCreate.Margin = new Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(90, 27);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(47, 231);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(178, 231);
            radioButton2.Margin = new Padding(2, 2, 2, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // CreateAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 389);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnCreate);
            Controls.Add(dateTimePickerWorkday);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAccount);
            Controls.Add(txtFullname);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreateAcc";
            Text = "CreateAcc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtFullname;
        private TextBox txtAccount;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private DateTimePicker dateTimePickerWorkday;
        private Button btnCreate;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}