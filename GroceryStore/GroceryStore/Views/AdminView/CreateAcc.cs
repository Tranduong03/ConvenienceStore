using System;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using GroceryStore.Model;
using GroceryStore.OtherProcess;
using System.Windows.Forms;

namespace GroceryStore.Views.AdminView
{
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
            dateTimePickerWorkday.Value = DateTime.Now; // Ngày vào làm mặc định là hôm nay
            dateTimePickerWorkday.Enabled = false;     // Không cho phép chỉnh sửa
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string fullName = txtFullname.Text;
            string username = txtAccount.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            DateTime workDate = dateTimePickerWorkday.Value;
            int gender = radioButton1.Checked ? 0 : 1; 

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Tên đăng nhập, số điện thoại và email là bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(phone, @"^\+?[0-9]{8,12}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo tài khoản mới
            string defaultPassword = "1234";
            string hashedPassword = HashPassword._HashPassword(defaultPassword);

            var newUser = new User
            {
                FullName = fullName,
                UserName = username,
                Password = hashedPassword,
                Email = email,
                PhoneNumber = phone,
                Gender = gender == 0 ? false: true,
                ImgLink = null,
                CreatedAt = workDate
            };

            // Lưu vào cơ sở dữ liệu
            using (var db = new AppDBContext())
            {
                // Kiểm tra trùng tên đăng nhập hoặc email
                if (db.Users.Any(u => u.UserName == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (db.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("Email đã tồn tại, vui lòng nhập email khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.Users.Add(newUser);
                SendAccountEmail(email, username, defaultPassword);
                db.SaveChanges();
            }

            
        }

        private bool SendAccountEmail(string toEmail, string username, string password)
        {
            try
            {
                // Cấu hình gửi email
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("phiduong10ccva@gmail.com", "cymuoqpswlikcawv"),
                    EnableSsl = true,
                };

                string subject = "Thông tin tài khoản của bạn";
                string body = $"Chào bạn {username},\n\n"
                            + $"Thông tin tài khoản của bạn như sau:\n"
                            + $"- Tên đăng nhập: {username}\n"
                            + $"- Mật khẩu: {password}\n\n"
                            + "Vui lòng đổi mật khẩu sau khi đăng nhập lần đầu.\n\n"
                            + "Trân trọng,\nFlash Shop";

                smtpClient.Send("phiduong10ccva@gmail.com", toEmail, subject, body);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi gửi email: {ex.Message}");
                return false;
            }
        }
    }
}
