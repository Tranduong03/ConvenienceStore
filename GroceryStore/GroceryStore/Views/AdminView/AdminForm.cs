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
        }

        internal AdminForm(User user)
        {
            InitializeComponent();
            currentAdm = user;
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
    }
}
