
namespace Insights
{
    partial class insights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.miniPic = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowCash = new System.Windows.Forms.Button();
            this.btnShowBank = new System.Windows.Forms.Button();
            this.btnShowCredit = new System.Windows.Forms.Button();
            this.btnShowDebit = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insightsDataDataSet = new Insights.insightsDataDataSet();
            this.categoryTableAdapter = new Insights.insightsDataDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightsDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 0;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(305, 116);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SlateBlue;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Cash";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.YValuesPerPoint = 2;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LightSkyBlue;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Credit";
            series2.ShadowColor = System.Drawing.Color.Transparent;
            series2.YValuesPerPoint = 2;
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DarkViolet;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBorderColor = System.Drawing.Color.White;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Debit";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            series3.YValuesPerPoint = 2;
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.SteelBlue;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBorderColor = System.Drawing.Color.White;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Transaction";
            series4.ShadowColor = System.Drawing.Color.Transparent;
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(521, 554);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // miniPic
            // 
            this.miniPic.Location = new System.Drawing.Point(1097, 41);
            this.miniPic.Name = "miniPic";
            this.miniPic.Size = new System.Drawing.Size(41, 35);
            this.miniPic.TabIndex = 16;
            this.miniPic.TabStop = false;
            this.miniPic.Click += new System.EventHandler(this.miniPic_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(1053, 41);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(28, 35);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowCash
            // 
            this.btnShowCash.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCash.FlatAppearance.BorderSize = 0;
            this.btnShowCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCash.ForeColor = System.Drawing.Color.White;
            this.btnShowCash.Location = new System.Drawing.Point(881, 415);
            this.btnShowCash.Name = "btnShowCash";
            this.btnShowCash.Size = new System.Drawing.Size(200, 20);
            this.btnShowCash.TabIndex = 18;
            this.btnShowCash.UseVisualStyleBackColor = false;
            this.btnShowCash.Click += new System.EventHandler(this.btnShowCash_Click);
            // 
            // btnShowBank
            // 
            this.btnShowBank.BackColor = System.Drawing.Color.Transparent;
            this.btnShowBank.FlatAppearance.BorderSize = 0;
            this.btnShowBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBank.ForeColor = System.Drawing.Color.White;
            this.btnShowBank.Location = new System.Drawing.Point(881, 478);
            this.btnShowBank.Name = "btnShowBank";
            this.btnShowBank.Size = new System.Drawing.Size(200, 20);
            this.btnShowBank.TabIndex = 19;
            this.btnShowBank.UseVisualStyleBackColor = false;
            this.btnShowBank.Click += new System.EventHandler(this.btnShowBank_Click);
            // 
            // btnShowCredit
            // 
            this.btnShowCredit.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCredit.FlatAppearance.BorderSize = 0;
            this.btnShowCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCredit.ForeColor = System.Drawing.Color.White;
            this.btnShowCredit.Location = new System.Drawing.Point(881, 540);
            this.btnShowCredit.Name = "btnShowCredit";
            this.btnShowCredit.Size = new System.Drawing.Size(200, 20);
            this.btnShowCredit.TabIndex = 20;
            this.btnShowCredit.UseVisualStyleBackColor = false;
            this.btnShowCredit.Click += new System.EventHandler(this.btnShowCredit_Click);
            // 
            // btnShowDebit
            // 
            this.btnShowDebit.BackColor = System.Drawing.Color.Transparent;
            this.btnShowDebit.FlatAppearance.BorderSize = 0;
            this.btnShowDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDebit.ForeColor = System.Drawing.Color.White;
            this.btnShowDebit.Location = new System.Drawing.Point(881, 604);
            this.btnShowDebit.Name = "btnShowDebit";
            this.btnShowDebit.Size = new System.Drawing.Size(200, 20);
            this.btnShowDebit.TabIndex = 21;
            this.btnShowDebit.UseVisualStyleBackColor = false;
            this.btnShowDebit.Click += new System.EventHandler(this.btnShowDebit_Click);
            // 
            // chart2
            // 
            this.chart2.AllowDrop = true;
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderlineWidth = 0;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.categoryBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(848, 356);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Color = System.Drawing.Color.Lavender;
            series5.Label = "Food";
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Food";
            series5.ShadowColor = System.Drawing.Color.Transparent;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Color = System.Drawing.Color.SteelBlue;
            series6.Legend = "Legend1";
            series6.Name = "Transport";
            series6.ShadowColor = System.Drawing.Color.Transparent;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Color = System.Drawing.Color.Thistle;
            series7.Legend = "Legend1";
            series7.Name = "Health";
            series7.ShadowColor = System.Drawing.Color.Transparent;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Color = System.Drawing.Color.Orchid;
            series8.Legend = "Legend1";
            series8.Name = "Shopping";
            series8.ShadowColor = System.Drawing.Color.Transparent;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Color = System.Drawing.Color.Plum;
            series9.Legend = "Legend1";
            series9.Name = "Bills";
            series9.ShadowColor = System.Drawing.Color.Transparent;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Tour";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Others";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Series.Add(series9);
            this.chart2.Series.Add(series10);
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(290, 314);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.insightsDataDataSet;
            // 
            // insightsDataDataSet
            // 
            this.insightsDataDataSet.DataSetName = "insightsDataDataSet";
            this.insightsDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // insights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Insights.Properties.Resources.Insights;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 722);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnShowDebit);
            this.Controls.Add(this.btnShowCredit);
            this.Controls.Add(this.btnShowBank);
            this.Controls.Add(this.btnShowCash);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.miniPic);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.insights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insightsDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox miniPic;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShowCash;
        private System.Windows.Forms.Button btnShowBank;
        private System.Windows.Forms.Button btnShowCredit;
        private System.Windows.Forms.Button btnShowDebit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private insightsDataDataSet insightsDataDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private insightsDataDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}

