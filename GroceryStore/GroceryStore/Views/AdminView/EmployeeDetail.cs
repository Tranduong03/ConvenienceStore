using GroceryStore.Model;
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

namespace GroceryStore.Views.AdminView
{
    public partial class EmployeeDetail : Form
    {
        User user = new User();
        private bool isAnyChanged = false;
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        internal EmployeeDetail(User u)
        {
            InitializeComponent();
            user = u;
            LoadEmployeeDetail();
        }
        private void LoadEmployeeDetail()
        {
            txbName.Text = user.FullName;              // Gán tên nhân viên
            txbEmail.Text = user.Email;            // Gán email
            txbPhone.Text = user.PhoneNumber;            // Gán số điện thoại

            // Gán giới tính vào ComboBox
            cboGender.SelectedItem = user.Gender switch
            {
                true => "Nữ",
                false => "Nam",
                _ => null
            };

            // Hiển thị ảnh nhân viên nếu có đường dẫn ảnh
            if (!string.IsNullOrEmpty(user.ImgLink))
            {
                string imagePath = Path.Combine("Resource", "UserImages", user.ImgLink);
                if (File.Exists(imagePath))
                {
                    picEmployeeImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picEmployeeImage.Image = null; // Không có ảnh
                }
            }
            else
            {
                picEmployeeImage.Image = null; // Không có ảnh
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

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbName.Text) ||
                string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new AppDBContext())
                {
                    // Lấy đối tượng User từ database dựa trên UserID
                    var existingUser = context.Users.Find(user.UserID);

                    if (existingUser != null)
                    {
                        // Cập nhật thông tin từ form vào đối tượng database
                        existingUser.FullName = txbName.Text;
                        existingUser.Email = txbEmail.Text;
                        existingUser.PhoneNumber = txbPhone.Text;
                        existingUser.Gender = cboGender.SelectedItem switch
                        {
                            "Nữ" => true,
                            "Nam" => false
                        };
                        existingUser.ImgLink = txbImgLink.Text;

                        // Cập nhật employee hiện tại
                        user = existingUser;

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAnyChanged = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadEmployeeDetail();
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            using (var context = new AppDBContext())
            {
                // Lấy đối tượng User từ database dựa trên UserID
                var existingUser = context.Users.Find(user.UserID);

                if (existingUser != null)
                {
                    // đặt lại mk 123 cho nhân viên
                    existingUser.Password = HashPassword._HashPassword("123");

                    // Cập nhật employee hiện tại
                    user = existingUser;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isAnyChanged) { this.DialogResult = DialogResult.None; }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new AppDBContext()) 
            {
                var existingUser = context.Users.Find(user.UserID);
                if (existingUser != null) 
                {
                    existingUser.isWorking = false;
                }

                user = existingUser;
                context.SaveChanges();

                MessageBox.Show("Xóa nhân viên thành công");
            }
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }
    }
}
