using GroceryStore.OtherProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.Views
{
    public partial class Login_Child : Form
    {
        public Login_Child()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return pnlLogin;
        }

        // Làm việc với trường nhập Account
        private void txbAccount_Enter(object sender, EventArgs e)
        {
            if (txbAccount.Text == "Email hoặc số điện thoại")
            {
                txbAccount.Text = "";
                txbAccount.ForeColor = Color.Black;
            }
        }

        private void txbAccount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbAccount.Text))
            {
                txbAccount.Text = "Email hoặc số điện thoại";
                txbAccount.ForeColor = Color.Gray;
            }
        }

        // Làm việc với trường nhập Password
        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.Black;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                txbPassword.Text = "Password";
                txbPassword.ForeColor = Color.Gray;
            }
        }

        // Làm việc với checkbox hiện  mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Làm việc chuyển Form
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = this.Owner as Welcome;
            if (mainForm != null)
            {
                var registerForm = new Register_Child();
                mainForm.LoadFormIntoPanel();
            }

        }

        // Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // mặc định tài khoản admin
            // adminDKD
            // 1

            if(txbAccount.Text == "adminDKD" && txbPassword.Text == "1")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Close();
            }

            // nếu không, lấy tài khoản từ CSDL
            using (var context = new AppDBContext())
            {
                // Lấy dữ liệu từ form
                string accountOrEmail = txbAccount.Text.Trim();
                string password = txbPassword.Text.Trim();

                // Tìm kiếm người dùng theo Account hoặc Email
                var user = context.Users.FirstOrDefault(u =>
                    u.Account == accountOrEmail || u.Email == accountOrEmail);

                if (user == null)
                {
                    lblWarning.Text = "Tài khoản hoặc email không tồn tại!";
                    StartWarningTimer();
                    return;
                }

                // Kiểm tra mật khẩu
                if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    lblWarning.Text = "Mật khẩu không chính xác!";
                    StartWarningTimer();
                    return;
                }
                
                // Đăng nhập thành công
                MainForm mainForm = new MainForm(user); // Hoặc truyền dữ liệu nếu cần
                this.Close();
                mainForm.Show(); // Mở MainForm
            }
        }

        private void timerWarning_Tick(object sender, EventArgs e)
        {
            timerWarning.Stop(); // Dừng Timer
            lblWarning.Text = string.Empty; // Xóa nội dung cảnh báo
        }
        private void StartWarningTimer()
        {
            timerWarning.Stop(); // Dừng lại nếu Timer đang chạy
            timerWarning.Start(); // Khởi động Timer
        }


    }
}
