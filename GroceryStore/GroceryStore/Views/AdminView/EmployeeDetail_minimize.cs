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

        private void btnInformation_Click(object sender, EventArgs e)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail(user);
            if (employeeDetail.ShowDialog() == DialogResult.None)
            {
                OnUserUpdate?.Invoke();
            }
            else if(employeeDetail.ShowDialog() == DialogResult.Ignore)
            {
                OnUserDelete?.Invoke(user);
            }
        }
    }
}
