using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStore.OtherProcess;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;


namespace GroceryStore.Views
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private void LoadRevenueData()
        {
            var startDate = new DateTime(2024, 1, 1); // Bắt đầu từ tháng 1/2024
            var endDate = new DateTime(2025, 1, 31); // Kết thúc vào tháng 1/2025

            // Tạo mô hình biểu đồ
            var plotModel = new PlotModel { Title = "Doanh Thu Theo Tháng" };

            // Tạo danh sách các tháng từ 1/2024 đến 1/2025
            var months = Enumerable.Range(0, ((endDate.Year - startDate.Year) * 12) + endDate.Month - startDate.Month + 1)
                                   .Select(offset => startDate.AddMonths(offset))
                                   .ToList();

            // Tạo LineSeries cho biểu đồ
            var lineSeriesRevenue = new LineSeries
            {
                Title = "Doanh Thu",
                MarkerType = MarkerType.Circle,
                Color = OxyColors.White,
            };

            var lineSeriesImport = new LineSeries
            {
                Title = "Nhập hàng",
                MarkerType = MarkerType.Circle,
                Color = OxyColors.Red
            };

            using (var context = new AppDBContext())
            {

                lblBillCount.Text = context.Bills.Count().ToString();
                lblCustomerCount.Text = context.Customers.Count().ToString();
                lblEmployeeCount.Text = context.Users.Where(u => u.Role != true).Count().ToString();
                lblSupplierCount.Text = context.Suppliers.Count().ToString();
                lblProductCount.Text = context.Products.Count().ToString();

                var weeklyRevenue = context.Bills
                                           .Where(b => b.BillDate >= DateTime.Now.AddDays(-7) && b.BillDate <= DateTime.Now)
                                           .Sum(b => b.TotalCost ?? 0);

                decimal weeklyIncome = weeklyRevenue * 0.2m;

                var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
                var monthlyRevenue = context.Bills
                                            .Where(b => b.BillDate >= DateTime.Now.AddDays(-30) && b.BillDate <= DateTime.Now)
                                            .Sum(b => b.TotalCost ?? 0);

                decimal monthlyIncome = monthlyRevenue * 0.2m;

                lblMonthlyProfit.Text = monthlyIncome.ToString("N0") + "  VND";
                lblWeeklyProfit.Text = weeklyIncome.ToString("N0") + "  VND";

                var top5Customers = context.Bills
                    .Where(b => b.CustomerID != null && b.CustomerID != 0) // Loại trừ CustomerID = 0 ngay từ Bills
                    .GroupBy(b => b.CustomerID)
                    .Select(g => new
                    {
                        CustomerID = g.Key,
                        TotalPurchase = g.Sum(b => b.TotalCost ?? 0)
                    })
                    .OrderByDescending(c => c.TotalPurchase) // Sắp xếp giảm dần theo giá trị mua hàng
                    .Where(c => c.CustomerID != 0) // Đảm bảo không có CustomerID = 0 trong nhóm
                    .Take(5) // Lấy 5 khách hàng đầu tiên
                    .Join(
                        context.Customers,
                        g => g.CustomerID,
                        c => c.CustomerID,
                        (g, c) => new
                        {
                            CustomerName = c.CustomerName, // Lấy tên khách hàng
                            TotalPurchase = g.TotalPurchase // Tổng giá trị mua hàng
                        })
                    .ToList();

                // Gán dữ liệu vào DataGridView
                tableTop5Customer.DataSource = top5Customers;
                tableTop5Customer.Columns["CustomerName"].HeaderText = "Tên khách";
                tableTop5Customer.Columns["TotalPurchase"].HeaderText = "Giá trị mua";

                // Lấy dữ liệu doanh thu theo tháng từ cơ sở dữ liệu
                var revenueData = context.Bills
                    .Where(b => b.BillDate >= startDate && b.BillDate <= endDate)
                    .GroupBy(b => new { b.BillDate.Year, b.BillDate.Month })
                    .Select(g => new
                    {
                        YearMonth = new DateTime(g.Key.Year, g.Key.Month, 1),
                        TotalRevenue = g.Sum(b => b.TotalCost)
                    })
                    .ToDictionary(r => r.YearMonth, r => r.TotalRevenue ?? 0);

                var importData = context.Imports
                    .Where(i => i.ImportDate >= startDate && i.ImportDate <= endDate)
                    .GroupBy(i => new { i.ImportDate.Year, i.ImportDate.Month })
                    .Select(g => new
                    {
                        YearMonth = new DateTime(g.Key.Year, g.Key.Month, 1),
                        TotalImport = g.Sum(i => i.TotalCost)
                    })
                    .ToDictionary(r => r.YearMonth, r => r.TotalImport ?? 0);
                    // Kết hợp dữ liệu với danh sách các tháng cho biểu đồ
                foreach (var month in months)
                {
                    // Nếu tháng không có dữ liệu, doanh thu = 0
                    var totalRevenue = revenueData.ContainsKey(month) ? revenueData[month] : 0;
                    var totalImport = importData.ContainsKey(month) ? importData[month] : 0;
                    lineSeriesRevenue.Points.Add(new DataPoint(DateTimeAxis.ToDouble(month), (double)totalRevenue));
                    lineSeriesImport.Points.Add(new DataPoint(DateTimeAxis.ToDouble(month), (double)totalImport));
                }
            }

            // Cấu hình trục X (tháng) và trục Y (doanh thu)
            plotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = DateTimeAxis.ToDouble(startDate),
                Maximum = DateTimeAxis.ToDouble(endDate),
                IntervalType = DateTimeIntervalType.Months,
                StringFormat = "MM/yyyy",
                Title = "Tháng",
                IsPanEnabled = false,
                IsZoomEnabled = false
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 0,
                Title = "Số tiền (VND)",
                MajorStep = 50000, 
                IsPanEnabled = false,
                IsZoomEnabled = false
            });

            // Thêm series vào biểu đồ
            plotModel.Series.Add(lineSeriesRevenue);
            plotModel.Series.Add(lineSeriesImport);

            plotModel.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.BottomCenter, // Vị trí chú thích ở góc trên bên phải
                LegendPlacement = LegendPlacement.Outside, // Chú thích bên ngoài biểu đồ
                LegendOrientation = LegendOrientation.Vertical // Chú thích theo chiều dọc
            });
            // Gán mô hình vào plotView
            plotView1.Model = plotModel;
        }
    }
}
