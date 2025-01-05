using GroceryStore.Model;
using GroceryStore.OtherProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.Views.AdminView
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string account = txbAccount.Text;
            string fullname = txbName.Text;
            string email = txbEmail.Text;
            string phone = txbPhone.Text;
            string password = txbPassword.Text;
            string imgname = txbImgLink.Text;
            bool gender = cboGender.SelectedIndex == 0 ? false : true;


            if (string.IsNullOrEmpty(fullname))
            {
                lblError.Text = "Tên không được để trống";
                return;
            }

            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, @"^\+?[0-9]{8,12}$"))
            {
                lblError.Text = "Vui lòng nhập đúng định dạng số điện thoại";
                return;
            }

            try
            {
                using (var context = new AppDBContext())
                {
                    bool phoneExists = context.Users.Any(c => c.PhoneNumber == phone);
                    bool emailExists = context.Users.Any (c => c.Email == email);

                    if (phoneExists)
                    {
                        lblError.Text = "Số điện thoại này đã tồn tại";
                        return;
                    }

                    if (emailExists)
                    {
                        lblError.Text = "Email đã tồn tại";
                        return;
                    }

                    User user = new User
                    {
                        UserName = account,
                        Email = email,
                        PhoneNumber = phone,
                        FullName = fullname,
                        Password = HashPassword._HashPassword(password),
                        Gender = gender,
                        CreatedAt = DateTime.Now,
                        ImgLink = string.IsNullOrEmpty(imgname) ? "default.png" : imgname
                    };

                    context.Users.Add(user);
                    SendAccountEmail(email, fullname, account, password);
                    context.SaveChanges();

                    MessageBox.Show("Employee Account Created");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            string relativePath = @"Resource/UserImages";
            string absolutePath = Path.Combine(Application.StartupPath, relativePath);

            openFileDialog1.InitialDirectory = absolutePath; // Sử dụng đường dẫn tuyệt đối của thư mục Resource

            // Cấu hình các tùy chọn khác nếu cần
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Lọc hình ảnh
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.RestoreDirectory = true;
            // Hiển thị OpenFileDialog và xử lý kết quả
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn ảnh được chọn
                string imgPath = openFileDialog1.FileName;

                // Lấy tên ảnh
                string imgName = Path.GetFileName(imgPath); // Chỉ lấy tên tệp
                string destinationPath = Path.Combine(absolutePath, imgName); // Đường dẫn đích trong Resource/Images



                if (imgPath.StartsWith(absolutePath, StringComparison.OrdinalIgnoreCase) || File.Exists(destinationPath))
                {
                    destinationPath = Path.Combine(absolutePath, imgName); // Dùng trực tiếp đường dẫn đích
                }
                else
                {
                    try
                    {
                        File.Copy(imgPath, destinationPath);
                        // CopyImageToProjectResourceFolder(imgPath, imgName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Failed to copy image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Hiển thị tên ảnh và ảnh trong PictureBox
                txbImgLink.Text = imgName;
                picEmployeeImage.Image = Image.FromFile(destinationPath);
            }
        }
        private bool SendAccountEmail(string toEmail, string username, string account, string password)
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
                            + $"- Tên đăng nhập: {account}\n"
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
