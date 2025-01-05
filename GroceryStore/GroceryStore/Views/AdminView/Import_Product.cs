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
            if (tableImportHistory.Rows.Count > 0)
            {
                var firstRow = tableImportHistory.Rows[0];
                var importDateValue = firstRow.Cells["ImportDate"].Value;
                var totalCost = firstRow.Cells["TotalCost"].Value;
                lblImportDate.Text = importDateValue != null ? importDateValue.ToString() : "Không có dữ liệu";
                lblTotalCost.Text = totalCost.ToString();
            }
            else
            {
                lblImportDate.Text = "Chưa có dữ liệu nhập hàng.";
                lblTotalCost.Text = "";
            }
        }

        private void tableImportHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (tableImportHistory.SelectedRows.Count == 0) return;

            var selectedRow = tableImportHistory.SelectedRows[0];

            // Lấy giá trị ImportDate
            var importDateValue = selectedRow.Cells["ImportDate"].Value;
            lblImportDate.Text = importDateValue != null ? importDateValue.ToString() : "Không có dữ liệu";

            var totalCost = selectedRow.Cells["TotalCost"].Value;
            lblTotalCost.Text = totalCost.ToString();
            // Lấy ImportID và tải chi tiết nhập
            if (selectedRow.Cells["ImportID"].Value != null &&
                int.TryParse(selectedRow.Cells["ImportID"].Value.ToString(), out int importId))
            {
                LoadImportDetails(importId);
            }
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
            tableImportDetail.Columns["ProductID"].HeaderText = "ID sản phẩm";
            tableImportDetail.Columns["Quantity"].HeaderText = "Số lượng nhập";
            tableImportDetail.Columns["UnitPrice"].HeaderText = "Giá mua vào";
            tableImportDetail.Columns["TotalCost"].HeaderText = "Tổng giá nhập";
        }
        private void btnNewImport_Click(object sender, EventArgs e)
        {
            var importForm = new AddImportProduct(); // Form để nhập hàng
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
