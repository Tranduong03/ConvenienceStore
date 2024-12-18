﻿using GroceryStore.Model;
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
    public partial class EmployeeDetailInfo : Form
    {
        User employee = new User();
        public EmployeeDetailInfo()
        {
            InitializeComponent();
        }

        internal EmployeeDetailInfo(User user)
        {
            InitializeComponent();
            employee = user;
            LoadEmployeeDetail(employee);
        }

        private void LoadEmployeeDetail(User user)
        {
            // Gán giá trị các thuộc tính của User vào các điều khiển trên form
            txbName.Text = user.UserName;              // Gán tên nhân viên
            txbEmail.Text = user.Email;            // Gán email
            txbPhone.Text = user.PhoneNumber;            // Gán số điện thoại
            txbAddress.Text = user.Address;        // Gán địa chỉ

            // Gán giới tính vào ComboBox
            cboGender.SelectedItem = user.Gender switch
            {
                0 => "Nam",
                1 => "Nữ",
                2 => "Phi nhị giới",
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

            // Tạo đối tượng User từ thông tin nhập liệu
            User user = new User
            {
                UserName = txbName.Text,
                Email = txbEmail.Text,
                PhoneNumber = txbPhone.Text,
                Address = txbAddress.Text,
                Gender = cboGender.SelectedItem switch
                {
                    "Nam" => 0,
                    "Nữ" => 1,
                    "Phi nhị giới" => 2,
                    _ => 0
                },
                ImgLink = txbImgLink.Text // Lấy tên file ảnh từ TextBox
            };

            try
            {
                // Lưu thông tin vào cơ sở dữ liệu
                using (var context = new AppDBContext())
                {
                    // Giả sử bạn đang thêm mới một nhân viên
                    context.Users.Add(user);
                    context.SaveChanges();
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPassword.Text) ||
                string.IsNullOrWhiteSpace(txbNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txbRePassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbNewPassword.Text != txbRePassword.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải chứa ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Giả định UserID hoặc thông tin User đã có
                int userId = employee.UserID; // CurrentUser là đối tượng chứa thông tin người dùng đang được chỉnh sửa

                using (var context = new AppDBContext())
                {
                    // Tìm user trong database
                    var user = context.Users.SingleOrDefault(u => u.UserID == userId);

                    if (user == null)
                    {
                        MessageBox.Show("Người dùng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra mật khẩu cũ
                    if (!HashPassword.VerifyPassword(txbPassword.Text, user.Password))
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Hash mật khẩu mới và cập nhật
                    user.Password = HashPassword._HashPassword(txbNewPassword.Text);

                    context.SaveChanges(); // Lưu thay đổi vào database

                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu nhập trên form
                    txbPassword.Clear();
                    txbNewPassword.Clear();
                    txbRePassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}