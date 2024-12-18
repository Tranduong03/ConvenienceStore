using GroceryStore.Model;
using GroceryStore.OtherProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.Views
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = txbName.Text.Trim();
            string address = txbAddress.Text.Trim() != string.Empty ? txbAddress.Text.Trim() : "none";
            string email = txbEmail.Text.Trim() != string.Empty ? txbEmail.Text.Trim() : "none";
            int gender = cboGender.SelectedIndex;
            string phone = txbPhone.Text.Trim();
            DateTime dateJoin = DateTime.Now;

            lblError.Text = "";

            if (string.IsNullOrEmpty(name))
            {
                lblError.Text = "Tên không được để trống";
                return;
            }

            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, @"^\+?[0-9]{8,12}$"))
            {
                lblError.Text = "Vui lòng nhập đúng định dạng số điện thoại";
                return;
            }

            if (gender < 0)
            {
                lblError.Text = "Vui lòng chọn giới tính";
                return;
            }

            try
            {
                using (var context = new AppDBContext())
                {
                    // Kiểm tra trùng lặp Phone
                    bool phoneExists = context.Customers.Any(c => c.PhoneNumber == phone);

                    if (phoneExists)
                    {
                        lblError.Text = "Số điện thoại đã được đăng kí";
                        return;
                    }

                    // Tạo khách hàng mới
                    Customer newCustomer = new Customer
                    {
                        Name = name,
                        Email = email.Contains('@') ? email : email + "@gmail.com",
                        PhoneNumber = phone,
                        Address = address,
                        Gender = gender,
                        dateJoin = dateJoin // Lưu thời gian hiện tại
                    };

                    // Thêm vào DB
                    context.Customers.Add(newCustomer);
                    context.SaveChanges();

                    int newCustomerId = newCustomer.CustomerId;
                    this.Tag = newCustomerId; // Lưu ID vào Tag của form
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Đóng form sau khi thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
