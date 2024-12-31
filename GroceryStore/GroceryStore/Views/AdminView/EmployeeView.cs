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
    public partial class EmployeeView : UserControl
    {
        private User currentAdm = new User();
        public EmployeeView()
        {
            InitializeComponent();
        }

        internal EmployeeView(User user)
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
                    employeeShow.OnUserDelete += HandleUserDelete;
                    employeeShow.OnUserUpdate += HandleUpdate;
                    Panel pnlEmployee = employeeShow.pnlEmployee;
                    flpEmployeeView.Controls.Add(pnlEmployee); // Thêm panel vào FlowLayoutPanel
                }

            }
        }

        private void HandleUserDelete(User user)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    // Tìm và xóa nhân viên trong database
                    var userToDelete = context.Users.Find(user.UserID);
                    if (userToDelete != null)
                    {
                        context.Users.Remove(userToDelete);
                        context.SaveChanges();

                        MessageBox.Show($"Đã xóa nhân viên {user.FullName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tải lại danh sách sau khi xóa
                        LoadEmployeePanels();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
