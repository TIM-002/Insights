using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Insights
{
    public partial class insights : Form
    {
        private DataAccess dataAccess;

        public insights()
        {
            InitializeComponent();
            dataAccess = new DataAccess("insightsData.mdf"); // Assuming the database file is named insightsData.mdf
        }

        private void insights_Load(object sender, EventArgs e)
        {
            LoadSpendingCategories();
        }

        private void LoadSpendingCategories()
        {
            try
            {
                // Query to get spending by category
                string query = "SELECT Category, SUM(Spending) AS TotalSpending FROM Category GROUP BY Category";
                DataTable categoryData = dataAccess.ExecuteCommand(query);

                if (categoryData.Rows.Count > 0)
                {
                    chart2.Series.Clear(); // Clear existing series
                    Series series = chart2.Series.Add("Categories");
                    series.ChartType = SeriesChartType.Pie;
                    series.IsValueShownAsLabel = true;

                    // Add data points to the pie chart
                    foreach (DataRow row in categoryData.Rows)
                    {
                        string categoryName = row["Category"].ToString();
                        double totalSpending = Convert.ToDouble(row["TotalSpending"]);

                        if (totalSpending > 0)
                        {
                            series.Points.AddXY(categoryName, totalSpending); // Add category and spending to the chart
                        }
                    }

                    // Customize chart points
                    foreach (var point in series.Points)
                    {
                        point.Font = new Font("Arial", 9, FontStyle.Bold); // Adjust font size
                        point.LabelForeColor = Color.White; // Set label color
                    }

                    chart2.Titles.Clear();
                    Title chartTitle = chart2.Titles.Add("Spending Categories"); // Set chart title
                    chartTitle.ForeColor = Color.White; // Set title color to white
                    chartTitle.Font = new Font("Arial", 11, FontStyle.Bold);


                }
                else
                {
                    MessageBox.Show("No data found in the Category table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // Log out action
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            // Chart click event handler (if needed)
        }
    }
}
