using GroceryStore.Model;
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
    public partial class EmployeeDetail_minimize : Form
    {
        public User user = new User();
        public EmployeeDetail_minimize()
        {
            InitializeComponent();
        }

        internal EmployeeDetail_minimize(User u)
        {
            InitializeComponent();
            user = u;
            string imgName = string.IsNullOrEmpty(user.ImgLink) ? "default.png" : user.ImgLink;
            picEmployee.ImageLocation = Path.Combine("Resource", "UserImages", imgName);
            lblEmployeeName.Text = user.FullName;
            lblEmployeePhone.Text = user.PhoneNumber;
        }

        internal event Action<User> OnUserDelete;
        internal event Action OnUserUpdate;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                // Gọi sự kiện OnUserDelete để thông báo nhân viên cần được xóa
                OnUserDelete?.Invoke(user);

                // Đóng form sau khi báo xóa
                this.Close();
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail(user);
            if (employeeDetail.ShowDialog() == DialogResult.Ignore)
            {
                OnUserDelete?.Invoke(user);
            }
            else if (employeeDetail.ShowDialog() == DialogResult.None)
            {
                OnUserUpdate?.Invoke();
            }
        }
    }
}
