using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GroceryStore.OtherProcess;
using GroceryStore.Model;

namespace GroceryStore.Views
{
    public partial class Register_Child : Form
    {
        public Register_Child()
        {
            InitializeComponent();
        }


        public Panel GetPanel()
        {
            return pnlRegister;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPassword.Checked)
            {
                txbPassword.UseSystemPasswordChar = true;
                txbRePassword.UseSystemPasswordChar = true;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = false;
                txbRePassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = this.Owner as Welcome;
            if (this.Owner is Welcome)
            {
                var login_Form = new Login_Child();
                mainForm.LoadFormIntoPanel();
            }
        }

        // Làm việc với button submit Form đăng kí
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (var context = new AppDBContext()) // Đảm bảo khởi tạo context
                {
                    if (context.Users.Any(u => u.Account == txbAccount.Text.Trim()))
                    {
                        lblWarning.Text = "Tài khoản đã tồn tại!";
                        StartWarningTimer();
                        return;
                    }

                    if (context.Users.Any(u => u.Email == txbEmail.Text.Trim()))
                    {
                        lblWarning.Text = "Email đã tồn tại";
                        StartWarningTimer();
                        return;
                    }

                    // Tiếp tục xử lý đăng ký
                    var user = new User
                    {
                        UserName = txbName.Text.Trim(),
                        Account = txbAccount.Text.Trim(),
                        Password = BCrypt.Net.BCrypt.HashPassword(txbPassword.Text.Trim()),
                        Email = txbEmail.Text.Trim(),
                        PhoneNumber = string.IsNullOrWhiteSpace(txbPhone.Text) ? null : txbPhone.Text.Trim(),
                        Gender = cboGender.SelectedIndex,
                        Address = txbAddress.Text.Trim() != string.Empty ? txbAddress.Text.Trim(): "none",
                        ImgLink = "default.jpg"
                    };

                    context.Users.Add(user);
                    context.SaveChanges();

                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();

                    this.Close();
                }


            }
        }

        // Validation
        private bool Validation()
        {
            var validations = new List<(Func<bool> ValidationFunc, string ErrorMessage)>
            {
                (() => !string.IsNullOrWhiteSpace(txbName.Text), "Tên không được để trống."),
                (() => !string.IsNullOrWhiteSpace(txbAccount.Text), "Tài khoản không được để trống."),
                (() => !txbAccount.Text.Contains(' '), "Tài khoản không được chứa khoảng trắng."),
                (() => Regex.IsMatch(txbAccount.Text, @"^[a-zA-Z0-9_]+$"), "Tài khoản không được chứa ký tự đặc biệt."),
                (() => txbPassword.Text.Length > 0, "Mật khẩu không được để trống."),
                (() => txbPassword.Text.Length <= 32, "Mật khẩu phải dưới 32 ký tự."),
                (() => txbRePassword.Text == txbPassword.Text, "Mật khẩu nhập lại phải giống với mật khẩu trên."),
                (() => Regex.IsMatch(txbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"), "Email không hợp lệ."),
                (() => Regex.IsMatch(txbPhone.Text, @"^\+?[\d\s]{8,12}$"),
                      "Số điện thoại phải từ 8 đến 12 ký tự.")
            };

            foreach (var validation in validations)
            {
                if (!validation.ValidationFunc())
                {
                    lblWarning.Text = validation.ErrorMessage; // Hiển thị lỗi
                    StartWarningTimer();
                    return false; // Dừng kiểm tra và trả về false
                }
            }

            lblWarning.Text = string.Empty; // Xóa cảnh báo nếu hợp lệ
            return true;
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
