namespace GroceryStore.Views
{
    partial class Login_Child
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Child));
            pnlLogin = new Panel();
            lblWarning = new Label();
            linkForgotPassword = new LinkLabel();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox5 = new PictureBox();
            txbPassword = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            txbAccount = new TextBox();
            timerWarning = new System.Windows.Forms.Timer(components);
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblWarning);
            pnlLogin.Controls.Add(linkForgotPassword);
            pnlLogin.Controls.Add(chkShowPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(tableLayoutPanel3);
            pnlLogin.Controls.Add(tableLayoutPanel2);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(400, 650);
            pnlLogin.TabIndex = 2;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 9F);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(3, 365);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(20, 0, 0, 0);
            lblWarning.Size = new Size(20, 20);
            lblWarning.TabIndex = 9;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(277, 396);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(109, 20);
            linkForgotPassword.TabIndex = 6;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Quên mật khẩu";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(22, 396);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(127, 24);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(69, 431);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(261, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(124, 71);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1621618F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.83784F));
            tableLayoutPanel3.Controls.Add(pictureBox5, 0, 0);
            tableLayoutPanel3.Controls.Add(txbPassword, 1, 0);
            tableLayoutPanel3.Location = new Point(16, 309);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(370, 45);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 13F);
            txbPassword.ForeColor = Color.Gray;
            txbPassword.Location = new Point(48, 3);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(317, 36);
            txbPassword.TabIndex = 0;
            txbPassword.Text = "Password";
            txbPassword.UseSystemPasswordChar = true;
            txbPassword.Enter += txbPassword_Enter;
            txbPassword.KeyPress += txbPassword_KeyPress;
            txbPassword.Leave += txbPassword_Leave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1621618F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.83784F));
            tableLayoutPanel2.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel2.Controls.Add(txbAccount, 1, 0);
            tableLayoutPanel2.Location = new Point(16, 239);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(370, 45);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // txbAccount
            // 
            txbAccount.Font = new Font("Segoe UI", 13F);
            txbAccount.ForeColor = Color.Gray;
            txbAccount.Location = new Point(48, 3);
            txbAccount.Name = "txbAccount";
            txbAccount.Size = new Size(317, 36);
            txbAccount.TabIndex = 0;
            txbAccount.Text = "Email hoặc số điện thoại";
            txbAccount.Enter += txbAccount_Enter;
            txbAccount.Leave += txbAccount_Leave;
            // 
            // timerWarning
            // 
            timerWarning.Interval = 3000;
            timerWarning.Tick += timerWarning_Tick;
            // 
            // Login_Child
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(400, 650);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Login_Child";
            Text = "Login_Child";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlLogin;
        private LinkLabel linkForgotPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox5;
        private TextBox txbPassword;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txbAccount;
        private PictureBox pictureBox4;
        private Label lblWarning;
        private System.Windows.Forms.Timer timerWarning;
    }
}