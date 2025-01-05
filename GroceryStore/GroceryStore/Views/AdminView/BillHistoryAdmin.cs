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
    public partial class BillHistoryAdmin : UserControl
    {
        public BillHistoryAdmin()
        {
            InitializeComponent();
        }

        private void BillHistoryAdmin_Load(object sender, EventArgs e)
        {
            LoadBillHistory();
            dtpStart.Value = new DateTime(2000, 1, 1);
        }

        private void LoadBillHistory()
        {
            using (var context = new AppDBContext())
            {


                // Lấy dữ liệu từ các điều khiển
                string customerSearch = txbCustomerSearch.Text.Trim();
                string userSearch = txbEmployeeSearch.Text.Trim();
                DateTime startDate = dtpStart.Value.Date;             // dtpStart là DateTimePicker bắt đầu
                DateTime endDate = dtpEnd.Value.Date.AddDays(1).AddTicks(-1); // dtpEnd là DateTimePicker kết thúc

                // Truy vấn lấy danh sách hóa đơn
                var bills = context.Bills
                    .Where(b => b.BillDate >= startDate
                                && b.BillDate <= endDate
                                && (string.IsNullOrEmpty(customerSearch) ||
                                    (b.Customer != null && b.Customer.CustomerName.Contains(customerSearch)))
                                && (string.IsNullOrEmpty(userSearch) ||
                                    (b.User != null && b.User.UserName.Contains(userSearch))))
                    .Select(b => new
                    {
                        BillID = b.BillID,
                        CustomerName = b.Customer != null ? b.Customer.CustomerName : "Không xác định",
                        EmployeeName = b.User != null ? b.User.FullName : "Không xác định",
                        BillDate = b.BillDate,
                        TotalCost = b.TotalCost
                    })
                    .ToList();


                // Gán dữ liệu cho DataGridView
                tableBillHistory.DataSource = bills;
                tableBillHistory.Columns["BillID"].HeaderText = "Mã hóa đơn";
                tableBillHistory.Columns["CustomerName"].HeaderText = "Tên khách hàng";
                tableBillHistory.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
                tableBillHistory.Columns["BillDate"].HeaderText = "Ngày hóa đơn";
                tableBillHistory.Columns["TotalCost"].HeaderText = "Tổng chi phí";
            }
        }
        private void btnFillWithDay_Click(object sender, EventArgs e)
        {
            LoadBillHistory();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            if (start > end)
            {
                start = end;
                dtpStart.Value = start;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            if (start > end)
            {
                end = start;
                dtpEnd.Value = end;
            }

            if (end > DateTime.Now)
            {
                end = DateTime.Now;
                dtpEnd.Value = end;
            }
        }

        private void tableBillHistory_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn
            if (tableBillHistory.SelectedRows.Count > 0)
            {
                // Lấy BillID từ dòng đã chọn (dòng đầu tiên trong collection SelectedRows)
                int billID = Convert.ToInt32(tableBillHistory.SelectedRows[0].Cells["BillID"].Value);

                LoadBillDetails(billID); // Gọi hàm để tải thông tin chi tiết
            }
        }
        private void LoadBillDetails(int billID)
        {
            using (var context = new AppDBContext())
            {
                // Truy vấn chi tiết hóa đơn theo BillID
                var billDetails = context.BillDetails
                    .Where(bd => bd.BillID == billID)
                    .Select(bd => new
                    {
                        ProductName = bd.Product.ProductName,
                        UnitPrice = bd.UnitPrice,
                        Quantity = bd.Quantity,
                        TotalPrice = bd.TotalPrice // TotalPrice tính tự động từ Quantity * UnitPrice
                    })
                    .ToList();

                // Gán dữ liệu cho DataGridView tableBillDetail
                tableBillDetail.DataSource = billDetails;
                var totalCost = context.Bills
                    .Where(b => b.BillID == billID)
                    .Select(b => b.TotalCost)
                    .FirstOrDefault();

                // Hiển thị tổng chi phí trên Label
                lblTotalCost.Text = totalCost.ToString();

                // Cập nhật tiêu đề cột cho tableBillDetail
                tableBillDetail.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                tableBillDetail.Columns["UnitPrice"].HeaderText = "Giá bán";
                tableBillDetail.Columns["Quantity"].HeaderText = "Số lượng";
                tableBillDetail.Columns["TotalPrice"].HeaderText = "Thành tiền";

                tableBillDetail.ClearSelection();
            }

        }
    }
}
