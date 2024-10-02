using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Insights
{
    public partial class insights : Form
    {
        string dataAccessFileName = "insightsData.mdf";
        private DataAccess dataAccess;

        public insights()
        {
            InitializeComponent();
            dataAccess = new DataAccess(dataAccessFileName);
        }


        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Cash";
            chart1.Series[0].YValueMembers = "Cash";
            chart1.Series[1].XValueMember = "Credit";
            chart1.Series[1].YValueMembers = "Credit";
            chart1.Series[2].XValueMember = "Debit";
            chart1.Series[2].YValueMembers = "Debit";
            chart1.Series[3].XValueMember = "Transaction";
            chart1.Series[3].YValueMembers = "Transaction";

        }

        private void insights_Load(object sender, EventArgs e)
        {
            string query = "Select * from Insights";
            var cmd = dataAccess.GetCommand(query);

            chart2_Click(sender, e);

            DataTable userData = dataAccess.ExecuteCommand(cmd);

            if (userData.Rows.Count > 0)
            {
                double cash = Convert.ToDouble(userData.Rows[0]["Cash"]);
                double credit = Convert.ToDouble(userData.Rows[0]["Credit"]);
                double debit = Convert.ToDouble(userData.Rows[0]["Debit"]);
                double transaction = Convert.ToDouble(userData.Rows[0]["Transaction"]);

                chart1.Series["Cash"].Points.AddXY(1, cash);
                chart1.Series["Credit"].Points.AddXY(1, credit);
                chart1.Series["Debit"].Points.AddXY(1, debit);
                chart1.Series["Transaction"].Points.AddXY(1, transaction);
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;


            }
            else
            {
                MessageBox.Show("No data found for the user.");
            }

        }

        private void miniPic_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowCash_Click(object sender, EventArgs e)
        {

        }

        private void btnShowBank_Click(object sender, EventArgs e)
        {

        }

        private void btnShowCredit_Click(object sender, EventArgs e)
        {

        }

        private void btnShowDebit_Click(object sender, EventArgs e)
        {

        }
        private void chart2_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM Category";
            var cmd = dataAccess.GetCommand(query);
            DataTable categoryData = dataAccess.ExecuteCommand(cmd);

            if (categoryData.Rows.Count > 0)
            {
                chart2.Series.Clear();
                Series series = chart2.Series.Add("Categories");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;

                foreach (DataRow row in categoryData.Rows)
                {
                    double food = Convert.ToDouble(row["Food"]);
                    double transport = Convert.ToDouble(row["Transport"]);
                    double shopping = Convert.ToDouble(row["Shopping"]);
                    double health = Convert.ToDouble(row["Health"]);
                    double bills = Convert.ToDouble(row["Bills"]);
                    var tour = Convert.ToDouble(row["Tour"]);
                    double others = Convert.ToDouble(row["Others"]);

                    if (food > 0) series.Points.AddXY("Food", food);
                    if (transport > 0) series.Points.AddXY("Transport", transport);
                    if (shopping > 0) series.Points.AddXY("Shopping", shopping);
                    if (health > 0) series.Points.AddXY("Health", health);
                    if (bills > 0) series.Points.AddXY("Bills", bills);
                    if (tour > 0) series.Points.AddXY("Tour", tour);
                    if (others > 0) series.Points.AddXY("Others", others);
                }

                foreach (var point in series.Points)
                {
                    point.Font = new Font("Arial", 5, FontStyle.Bold);
                    point.LabelForeColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("No data found in the Category table.");
            }

        }
    }
}