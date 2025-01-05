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

namespace GroceryStore.Views.AdminView
{
    public partial class Import_Product : UserControl
    {
        public Import_Product()
        {
            InitializeComponent();
        }

        private void LoadImportHistory()
        {
            using (var context = new AppDBContext())
            {
                var importData = context.Imports
                    .Select(import => new
                    {
                        ImportID = import.ImportID,
                        ImportDate = import.ImportDate,
                        TotalCost = import.TotalCost
                    })
                    .OrderByDescending(import => import.ImportDate)
                    .ToList();

                tableImportHistory.DataSource = importData;
            }

            // Tùy chỉnh tiêu đề cột nếu cần
            tableImportHistory.Columns["ImportID"].HeaderText = "Mã Nhập";
            tableImportHistory.Columns["ImportDate"].HeaderText = "Ngày Nhập";
            tableImportHistory.Columns["TotalCost"].HeaderText = "Tổng Chi Phí";
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

        private void LoadImportDetails(int importId)
        {
            using (var context = new AppDBContext())
            {
                var importDetails = context.ImportDetails
                    .Where(d => d.ImportID == importId)
                    .Select(d => new
                    {
                        d.ProductID,
                        d.Quantity,
                        d.UnitPrice,
                        TotalCost = d.Quantity * d.UnitPrice
                    })
                    .ToList();

                tableImportDetail.DataSource = importDetails;
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
