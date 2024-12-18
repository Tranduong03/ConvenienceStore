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

namespace GroceryStore.Views
{

    public partial class MainForm : Form
    {
        User currentUser = new User();
        public MainForm()
        {
            InitializeComponent();
        }

        internal MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblCustomerName.Text = currentUser.UserName;
            if (currentUser.ImgLink != string.Empty)
            {
                string imagePath = Path.Combine("Resource", "UserImages", user.ImgLink);
                picImgLink.Image = Image.FromFile(imagePath);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            EmployeeProductView employeeProductView = new EmployeeProductView(currentUser);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(employeeProductView);
        }

        private void btnDetailInfo_Click(object sender, EventArgs e)
        {
            EmployeeDetailInfo employeeDetailInfo = new EmployeeDetailInfo(currentUser);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(employeeDetailInfo);
        }
    }
}
