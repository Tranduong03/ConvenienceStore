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
    public partial class ChooseCustomer : Form
    {
        public ChooseCustomer()
        {
            InitializeComponent();
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {
            using (var context = new AppDBContext())
            {
                // Lấy danh sách khách hàng từ database, chỉ lấy các trường cần thiết
                var customers = context.Customers
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        PhoneNumber = c.PhoneNumber ?? "Không có số điện thoại"
                    }).ToList();

                foreach (var customer in customers)
                {
                    // Kiểm tra và thay thế giá trị NULL nếu cần
                    string phoneNumber = customer.PhoneNumber ?? "Không có số điện thoại";

                    // Thêm dòng vào DataGridView
                    tableCustomerList.Rows.Add(customer.CustomerID, customer.CustomerName, phoneNumber);
                }
            }
        } 


        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            if (tableCustomerList.SelectedRows.Count == 0) // Kiểm tra nếu không có hàng nào được chọn
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy ID từ cột colCustomerID của hàng được chọn
                int customerId = Convert.ToInt32(tableCustomerList.SelectedRows[0].Cells["colCustomerID"].Value);

                this.Tag = customerId; // Lưu ID vào Tag của form để sử dụng sau này
                this.DialogResult = DialogResult.OK; // Đóng form và trả về kết quả
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi chọn khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
