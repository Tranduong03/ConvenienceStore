using GroceryStore.Model;
using GroceryStore.Views.AdminView;
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
    public partial class AdminForm : Form
    {
        private User currentAdm;
        public AdminForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        internal AdminForm(User user)
        {
            InitializeComponent();
            currentAdm = user;
            this.MaximizeBox = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView(currentAdm);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(productView);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeManage employeeView = new EmployeeManage(currentAdm);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(employeeView);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView(currentAdm);
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(customerView);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(dashboard);
        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            BillHistoryAdmin billHistoryAdmin = new BillHistoryAdmin();
            pnlWork.Controls.Clear();
            pnlWork.Controls.Add(billHistoryAdmin);
        }
    }
}
