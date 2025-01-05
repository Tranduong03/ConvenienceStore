using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStore.OtherProcess;
using Microsoft.EntityFrameworkCore;
using GroceryStore.Model;

namespace GroceryStore.Views.AdminView
{
    public partial class Import_Product : UserControl
    {
        public Import_Product()
        {
            InitializeComponent();
            int? userID = CurrentUser.UserID;
        }

        private void LoadImportHistory()
        {
            using (var context = new AppDBContext())
            {
                var data = context.Imports
                    .Join(context.Users,
                          import => import.UserID,
                          user => user.UserID,
                          (import, user) => new
                          {
                              ImportID = import.ImportID,
                              ImportDate = import.ImportDate,
                              TotalCost = import.TotalCost,
                              Username = user.UserName
                          })
                    .OrderByDescending(import => import.ImportDate)
                    .ToList();

                // In ra console để kiểm tra dữ liệu
                foreach (var item in data)
                {
                    Console.WriteLine($"ImportID: {item.ImportID}, Username: {item.Username}");
                }

                tableImportHistory.DataSource = data;
            }
            // Tùy chỉnh tiêu đề cột nếu cần
            tableImportHistory.Columns["ImportID"].HeaderText = "Mã Nhập";
            tableImportHistory.Columns["ImportDate"].HeaderText = "Ngày Nhập";
            tableImportHistory.Columns["TotalCost"].HeaderText = "Tổng Chi Phí";
            tableImportHistory.Columns["Username"].HeaderText = "Username";
        }

        private void Import_Product_Load(object sender, EventArgs e)
        {
            LoadImportHistory();
        }

        private void tableImportHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (tableImportHistory.CurrentRow == null) return;

            int importId = Convert.ToInt32(tableImportHistory.CurrentRow.Cells["ImportID"].Value);
            LoadImportDetails(importId);
        }

        private void LoadImportDetails(int importID)
        {
            using (var context = new AppDBContext())
            {
                var data = context.ImportDetails
                    .Join(context.Products,
                          detail => detail.ProductID,
                          product => product.ProductID,
                          (detail, product) => new
                          {
                              ImportDetailID = detail.DetailID,
                              ProductName = product.ProductName, // Thêm ProductName
                              Quantity = detail.Quantity,
                              UnitPrice = detail.UnitPrice,
                              Total = detail.Quantity * detail.UnitPrice,
                              ImportID = detail.ImportID
                          })
                    .Where(detail => detail.ImportID == importID)
                    .ToList();

                tableImportDetail.DataSource = data;
            }
        }

        private void btnNewImport_Click(object sender, EventArgs e)
        {
            var importForm = new ImportProduct(); // Form để nhập hàng
            importForm.ShowDialog();
            LoadImportHistory(); // Reload lại lịch sử sau khi thêm mới
        }

        private void FilterImportHistory()
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            using (var context = new AppDBContext())
            {
                var filteredData = context.Imports
                    .Where(import =>
                        import.ImportDate.Date >= startDate &&
                        import.ImportDate.Date <= endDate)
                    .Select(import => new
                    {
                        ImportID = import.ImportID,
                        ImportDate = import.ImportDate,
                        TotalCost = import.TotalCost
                    })
                    .OrderByDescending(import => import.ImportDate)
                    .ToList();

                tableImportHistory.DataSource = filteredData;
            }
        }



        private void btnFillWithDay_Click(object sender, EventArgs e)
        {
            if (dtpEnd.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày kết thúc không được lớn hơn ngày hiện tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterImportHistory();
        }

    }
}
