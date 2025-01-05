using GroceryStore.Model;
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

namespace GroceryStore.Views.AdminView
{
    public partial class EmployeeManage : UserControl
    {
        private User currentAdm = new User();
        public EmployeeManage()
        {
            InitializeComponent();
        }

        internal EmployeeManage(User user)
        {
            InitializeComponent();
            currentAdm = user;
            LoadEmployeePanels();
        }

        private void LoadEmployeePanels()
        {
            flpEmployeeView.Controls.Clear();

            using (var context = new AppDBContext())
            {
                var users = context.Users.ToList();


                foreach (var user in users)
                {
                    EmployeeDetail_minimize employeeShow = new EmployeeDetail_minimize(user);
                    employeeShow.OnUserUpdate += HandleUpdate;
                    Panel pnlEmployee = employeeShow.pnlEmployee;
                    flpEmployeeView.Controls.Add(pnlEmployee); // Thêm panel vào FlowLayoutPanel
                }

            }
        }

        private void HandleUpdate()
        {
            LoadEmployeePanels();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            LoadEmployeePanels();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
