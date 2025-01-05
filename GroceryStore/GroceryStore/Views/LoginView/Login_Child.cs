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

        // Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDBContext())
            {
                // Lấy dữ liệu từ form
                string accountOrEmail = txbAccount.Text.Trim();
                string password = txbPassword.Text.Trim();

                if (accountOrEmail == "1" && password == "1") // Thử nghiệm đóng mở form, không quan trọng
                {
                    AdminForm adm = new AdminForm();

                    var welcome_Form = this.Owner as Welcome;
                    welcome_Form?.Hide(); // Đóng form Welcome nếu nó đang mở
                    adm.FormClosed += (s, args) => welcome_Form.Close();
                    adm.Show();
                    this.Close();
                    return; // Kết thúc phương thức tại đây nếu dùng thử nghiệm
                }

                // Tìm kiếm người dùng theo Account hoặc Email
                var user = context.Users.FirstOrDefault(u =>
                    u.UserName == accountOrEmail || u.Email == accountOrEmail);

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

                // Lưu UserID vào CurrentUser trong OtherProcess
                CurrentUser.UserID = user.UserID;

                Form nextForm;
                // Đăng nhập thành công với ADMIN role
                if (user.Role)
                {
                    nextForm = new AdminForm(user);
                }
                else // Đăng nhập bằng nhân viên
                {
                    nextForm = new MainForm(user);
                }

                var welcomeForm = this.Owner as Welcome;
                welcomeForm.Hide(); // Ẩn Welcome thay vì đóng ngay
                nextForm.FormClosed += (s, args) => welcomeForm.Close(); // Đóng Welcome khi form mới đóng
                nextForm.Show(); // Hiển thị form mới
                this.Close(); // Đóng Login_Child
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
