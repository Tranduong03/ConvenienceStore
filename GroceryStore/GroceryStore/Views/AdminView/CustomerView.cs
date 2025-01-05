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

namespace GroceryStore.Views.AdminView
{
    public partial class CustomerView : UserControl
    {
        private User currentAdm = new User();

        private bool isAnyChange = false;
        private List<Customer> listChange = new List<Customer>();
        private int pageNumber;
        private int pageSize = 21;
        private int currentPage = 1;
        public CustomerView()
        {
            InitializeComponent();
            lblError.Text = "";
            groupBox1.Visible = false;
        }

        internal CustomerView(User user)
        {
            InitializeComponent();
            currentAdm = user;
            lblError.Text = "";
            groupBox1.Visible = false;
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            tableCustomerList.Columns["colCustomerID"].ReadOnly = true;
            LoadCustomerList();
        }

        private void LoadCustomerList()
        {
            lblCurrentPage.Text = currentPage.ToString();
            tableCustomerList.Rows.Clear();
            using (var context = new AppDBContext())
            {
                pageNumber = (context.Customers.Count() - 1) / 21 + 1;
                lblMaxPage.Text = pageNumber.ToString();
                // Lấy danh sách khách hàng từ database, chỉ lấy các trường cần thiết
                var customers = context.Customers.Where(c => c.CustomerID != 0)
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        PhoneNumber = c.PhoneNumber ?? "Không có số điện thoại"
                    }).ToList();

                var pageData = customers.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

                foreach (var customer in pageData)
                {
                    // Kiểm tra và thay thế giá trị NULL nếu cần
                    string phoneNumber = customer.PhoneNumber ?? "Không có số điện thoại";

                    // Thêm dòng vào DataGridView
                    tableCustomerList.Rows.Add(customer.CustomerID, customer.CustomerName, phoneNumber);
                }
            }

        }

        private void tableCustomerList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Kiểm tra nếu cột được chỉnh sửa là cột số điện thoại
            if (tableCustomerList.Columns[e.ColumnIndex].Name == "colPhone")
            {
                string newPhoneNumber = e.FormattedValue.ToString();

                // Kiểm tra số điện thoại có độ dài từ 8 đến 15 ký tự và chỉ chứa số
                if (!System.Text.RegularExpressions.Regex.IsMatch(newPhoneNumber, @"^\d{8,15}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập từ 8 đến 15 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // Hủy chỉnh sửa
                }
            }
            else if (tableCustomerList.Columns[e.ColumnIndex].Name == "colCustomerName")
            {
                string newName = e.FormattedValue.ToString();

                if (string.IsNullOrEmpty(newName))
                {
                    e.Cancel = true;
                }
            }
        }
        private void tableCustomerList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= tableCustomerList.Rows.Count) return;
            // Lấy thông tin từ dòng đang chỉnh sửa
            var row = tableCustomerList.Rows[e.RowIndex];
            int customerId = Convert.ToInt32(row.Cells["colCustomerID"].Value);
            string customerName = row.Cells["colCustomerName"].Value.ToString();
            string phoneNumber = row.Cells["colPhone"].Value.ToString();

            // Kiểm tra nếu khách hàng đã có trong danh sách thay đổi
            var existingCustomer = listChange.FirstOrDefault(c => c.CustomerID == customerId);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerName = customerName;
                existingCustomer.PhoneNumber = phoneNumber;
            }
            else
            {
                // Thêm khách hàng mới vào danh sách thay đổi
                listChange.Add(new Customer
                {
                    CustomerID = customerId,
                    CustomerName = customerName,
                    PhoneNumber = phoneNumber
                });
            }

            isAnyChange = true;
        }

        private bool PromptSaveChanges()
        {
            if (isAnyChange)
            {
                var result = MessageBox.Show("Bạn có muốn lưu các thay đổi không?",
                                             "Xác nhận lưu thay đổi",
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveChanges(); // Hàm lưu dữ liệu
                    LoadCustomerList();
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    isAnyChange = false; // Bỏ qua thay đổi
                    LoadCustomerList();
                    return true;
                }
                else
                {
                    return false;  // 
                }
            }
            return true;
        }


        private void SaveChanges()
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    foreach (var customer in listChange)
                    {
                        var dbCustomer = context.Customers.Find(customer.CustomerID);
                        if (dbCustomer != null)
                        {
                            dbCustomer.CustomerName = customer.CustomerName;
                            dbCustomer.PhoneNumber = customer.PhoneNumber;
                        }
                    }
                    context.SaveChanges();
                    MessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listChange.Clear(); // Xóa danh sách thay đổi sau khi lưu
                    isAnyChange = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu thay đổi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            PromptSaveChanges();
            if (currentPage > 1)
            {
                currentPage--;
                LoadCustomerList();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PromptSaveChanges();
            if (currentPage < pageNumber)
            {
                currentPage++;
                LoadCustomerList();
            }

        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            SaveChanges();
            LoadCustomerList();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }      

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!PromptSaveChanges())
                return;

            string customerName = txbName.Text.Trim();
            int gender = cboGender.SelectedIndex;
            string phone = txbPhone.Text.Trim();

            lblError.Text = "";

            if (string.IsNullOrEmpty(customerName))
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
                        CustomerName = customerName,
                        PhoneNumber = phone,
                        Gender = gender == 0 ? false : true,
                        FCoin = 0
                    };

                    // Thêm vào DB
                    context.Customers.Add(newCustomer);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }


}
