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
        private int totalPages;
        private int currentPage = 1;
        private int pageSize = 12;
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
            string keyword = txbSearch.Text;
            using (var context = new AppDBContext())
            {
                var users = context.Users.Where(u => !u.Role && u.FullName.Contains(keyword) && u.isWorking).ToList();
                int countEmployee = users.Count();

                totalPages = (int)Math.Ceiling((double)countEmployee / pageSize);
                currentPage = currentPage > totalPages ? totalPages : currentPage;

                lblCurrentPage.Text = currentPage.ToString();
                lblMaxPage.Text = totalPages.ToString();

                var filterEmployee = users.Skip((currentPage - 1) * pageSize)
                                            .Take(pageSize)
                                            .ToList();
                foreach (var user in filterEmployee)
                {
                    EmployeeDetail_minimize employeeShow = new EmployeeDetail_minimize(user);
                    employeeShow.OnUserUpdate += HandleUpdate;
                    employeeShow.OnUserDelete += HandleDelete;
                    Panel pnlEmployee = employeeShow.pnlEmployee;
                    flpEmployeeView.Controls.Add(pnlEmployee); // Thêm panel vào FlowLayoutPanel
                }

            }
        }

        private void HandleDelete(User user)
        {
            LoadEmployeePanels();
            throw new NotImplementedException();
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
            LoadEmployeePanels();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadEmployeePanels();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadEmployeePanels();
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            if(addEmployee.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeePanels();
            }
        }
    }
}
