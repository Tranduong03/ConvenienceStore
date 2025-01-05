using GroceryStore.Model;
using GroceryStore.Views.EmployeeView;
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
            this.MaximizeBox = false;
        }

        internal MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.MaximizeBox=false;
            lblCustomerName.Text = currentUser.UserName;
            if (currentUser.ImgLink != string.Empty)
            {
                string imagePath = Path.Combine("Resource", "UserImages", user.ImgLink);
                picImgLink.Image = Image.FromFile(imagePath);
            }
            EmployeeProductView employeeProductView = new EmployeeProductView(currentUser);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(employeeProductView);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            EmployeeProductView employeeProductView = new EmployeeProductView(currentUser);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(employeeProductView);
        }

        private void btnDetailInfo_Click(object sender, EventArgs e)
        {
            EmployeeDetailInfo employeeDetailInfo = new EmployeeDetailInfo(ref currentUser);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(employeeDetailInfo);
        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            BillHistory billHistory = new BillHistory(currentUser);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(billHistory);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
           
            
        }
    }
}
