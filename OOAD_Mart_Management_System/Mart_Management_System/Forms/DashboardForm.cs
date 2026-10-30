using System.Drawing.Drawing2D;
using System.Globalization;
using Mart_Management_System.Models;
using Mart_Management_System.Repositories;

namespace Mart_Management_System.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly DashboardRepository _dashboardRepository;
        private List<ReportRow> _salesTrend = new();

        private Label lblRevenueTitle;
        private Label lblRevenueValue;
        private Label lblSalesTitle;
        private Label lblSalesValue;
        private Label lblProductsTitle;
        private Label lblProductsValue;
        private Label lblLowStockTitle;
        private Label lblLowStockValue;
        private Label lblExpiryTitle;
        private Label lblExpiryValue;
        private Label lblTopProductTitle;
        private Label lblTopProductValue;
        private Label lblTopProductQuantity;

        public DashboardForm()
        {
            InitializeComponent();
            InitializeCards();
            _dashboardRepository = new DashboardRepository();
            chartPanel.Resize += (_, _) => chartPanel.Invalidate();
        }

        private void InitializeCards()
        {
            ConfigureCard(cardRevenue, "Today's Revenue", out lblRevenueTitle, out lblRevenueValue, out _);
            ConfigureCard(cardSales, "Today's Sales", out lblSalesTitle, out lblSalesValue, out _);
            ConfigureCard(cardProducts, "Active Products", out lblProductsTitle, out lblProductsValue, out _);
            ConfigureCard(cardLowStock, "Low Stock", out lblLowStockTitle, out lblLowStockValue, out _);
            ConfigureCard(cardExpiry, "Expiring Soon", out lblExpiryTitle, out lblExpiryValue, out _);
            ConfigureCard(cardTopProduct, "Top Seller", out lblTopProductTitle, out lblTopProductValue, out TableLayoutPanel topProductLayout);

            // The final card carries no trailing gap so the row stays balanced.
            cardTopProduct.Margin = new Padding(0, 10, 0, 10);
            lblTopProductValue.AutoEllipsis = true;
            lblTopProductValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            lblTopProductQuantity = new Label();
            lblTopProductQuantity.AutoSize = false;
            lblTopProductQuantity.Dock = DockStyle.Fill;
            lblTopProductQuantity.Font = new Font("Segoe UI", 8.5F);
            lblTopProductQuantity.ForeColor = Color.Gray;
            lblTopProductQuantity.Name = "lblTopProductQuantity";
            lblTopProductQuantity.TabIndex = 2;
            lblTopProductQuantity.Text = "No completed sales yet";
            lblTopProductQuantity.TextAlign = ContentAlignment.MiddleLeft;
            topProductLayout.Controls.Add(lblTopProductQuantity, 0, 2);
        }

        private static void ConfigureCard(
            Panel card,
            string title,
            out Label titleLabel,
            out Label valueLabel,
            out TableLayoutPanel cardLayout
        )
        {
            card.BackColor = Color.White;
            card.Margin = new Padding(0, 10, 8, 10);
            card.Padding = new Padding(0);
            card.TabStop = false;

            titleLabel = new Label();
            titleLabel.AutoSize = false;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 9F);
            titleLabel.ForeColor = Color.Gray;
            titleLabel.Name = "lblTitle";
            titleLabel.Text = title;
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;

            valueLabel = new Label();
            valueLabel.AutoSize = false;
            valueLabel.Dock = DockStyle.Fill;
            valueLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            valueLabel.ForeColor = Color.FromArgb(91, 174, 99);
            valueLabel.Name = "lblValue";
            valueLabel.Text = "$0.00";
            valueLabel.TextAlign = ContentAlignment.MiddleLeft;

            cardLayout = new TableLayoutPanel();
            cardLayout.ColumnCount = 1;
            cardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            cardLayout.Dock = DockStyle.Fill;
            cardLayout.Margin = new Padding(0);
            cardLayout.Padding = new Padding(14, 12, 14, 12);
            cardLayout.RowCount = 3;
            cardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            cardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));

            cardLayout.Controls.Add(titleLabel, 0, 0);
            cardLayout.Controls.Add(valueLabel, 0, 1);

            card.SuspendLayout();
            card.Controls.Add(cardLayout);
            card.ResumeLayout(false);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void LoadSummary()
        {
            try
            {
                DashboardSummary summary = _dashboardRepository.GetSummary();
                lblRevenueValue.Text = summary.TodayRevenue.ToString("C2");
                lblSalesValue.Text = summary.TodaySalesCount.ToString();
                lblProductsValue.Text = summary.ActiveProducts.ToString();
                lblLowStockValue.Text = summary.LowStockCount.ToString();
                lblExpiryValue.Text = summary.ExpiringSoonCount.ToString();
                lblTopProductValue.Text = summary.TopSellingProduct;
                toolTip.SetToolTip(
                    lblTopProductValue,
                    summary.TopSellingProduct
                );
                lblTopProductQuantity.Text = summary.TopSellingQuantity > 0
                    ? $"{summary.TopSellingQuantity:0} units sold"
                    : "No completed sales yet";

                _salesTrend = _dashboardRepository.GetSalesTrend(
                    DateTime.Today.AddDays(-6),
                    DateTime.Today
                );
                lblLastUpdated.Text = $"Updated {DateTime.Now:yyyy-MM-dd HH:mm}";
                lblMessage.Text = string.Empty;
                chartPanel.Invalidate();
            }
            catch (Exception)
            {
                _salesTrend = new List<ReportRow>();
                lblMessage.Text = "Unable to load dashboard data.";
                chartPanel.Invalidate();
            }
        }

        private void ChartPanel_Paint(object? sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);

            const int leftMargin = 62;
            const int rightMargin = 20;
            const int topMargin = 20;
            const int bottomMargin = 48;
            int chartWidth = Math.Max(120, chartPanel.Width - leftMargin - rightMargin);
            int chartHeight = Math.Max(120, chartPanel.Height - topMargin - bottomMargin);
            int chartBottom = topMargin + chartHeight;

            decimal maximum = _salesTrend.Count == 0
                ? 0
                : _salesTrend.Max(row => row.Value);
            decimal scaleMaximum = maximum <= 0 ? 1 : maximum;

            using Font axisFont = new("Segoe UI", 8F);
            using Font valueFont = new("Segoe UI", 8F, FontStyle.Bold);
            using Brush axisBrush = new SolidBrush(Color.FromArgb(110, 110, 110));
            using Brush valueBrush = new SolidBrush(Color.FromArgb(70, 70, 70));
            using Brush barBrush = new SolidBrush(Color.FromArgb(91, 174, 99));
            using Brush emptyBarBrush = new SolidBrush(Color.FromArgb(232, 232, 232));
            using Pen gridPen = new(Color.FromArgb(228, 231, 235));

            for (int gridIndex = 0; gridIndex <= 4; gridIndex++)
            {
                int y = chartBottom - (chartHeight * gridIndex / 4);
                graphics.DrawLine(gridPen, leftMargin, y, leftMargin + chartWidth, y);

                decimal value = scaleMaximum * gridIndex / 4m;
                graphics.DrawString(
                    value.ToString("C0", CultureInfo.CurrentCulture),
                    axisFont,
                    axisBrush,
                    6,
                    y - 8
                );
            }

            DateTime today = DateTime.Today;
            int slotWidth = chartWidth / 7;
            int barWidth = Math.Max(18, slotWidth - 26);

            for (int index = 0; index < 7; index++)
            {
                DateTime date = today.AddDays(index - 6);
                string dateKey = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                decimal value = _salesTrend
                    .FirstOrDefault(row => row.Label == dateKey)
                    ?.Value ?? 0;
                int barHeight = value <= 0
                    ? 0
                    : Math.Max(4, (int)(chartHeight * (double)value / (double)scaleMaximum));
                int x = leftMargin + (index * slotWidth) + ((slotWidth - barWidth) / 2);
                int y = chartBottom - barHeight;

                graphics.FillRectangle(
                    value > 0 ? barBrush : emptyBarBrush,
                    x,
                    y,
                    barWidth,
                    value > 0 ? barHeight : 3
                );

                graphics.DrawString(
                    date.ToString("ddd", CultureInfo.CurrentCulture),
                    axisFont,
                    axisBrush,
                    x - 5,
                    chartBottom + 12
                );

                if (value > 0)
                {
                    graphics.DrawString(
                        value.ToString("C0", CultureInfo.CurrentCulture),
                        valueFont,
                        valueBrush,
                        x - 8,
                        Math.Max(2, y - 20)
                    );
                }
            }

            if (_salesTrend.Count == 0)
            {
                graphics.DrawString(
                    "No sales data available",
                    valueFont,
                    axisBrush,
                    leftMargin + (chartWidth / 2) - 65,
                    topMargin + (chartHeight / 2) - 10
                );
            }
        }
    }
}
