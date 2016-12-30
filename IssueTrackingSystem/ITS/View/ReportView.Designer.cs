namespace IssueTrackingSystem.ITS.View
{
    partial class ReportView
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pieChartGroupBox = new System.Windows.Forms.GroupBox();
            this.lineChartGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.pieChartGroupBox.SuspendLayout();
            this.lineChartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(3, 18);
            this.pieChart.Name = "pieChart";
            this.pieChart.Padding = new System.Windows.Forms.Padding(10);
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(380, 485);
            this.pieChart.TabIndex = 2;
            this.pieChart.Text = "chart1";
            // 
            // lineChart
            // 
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(3, 18);
            this.lineChart.Name = "lineChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "resolvedIssues";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "unresolvedIssues";
            this.lineChart.Series.Add(series2);
            this.lineChart.Series.Add(series3);
            this.lineChart.Size = new System.Drawing.Size(380, 485);
            this.lineChart.TabIndex = 3;
            this.lineChart.Text = "chart2";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.pieChartGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.lineChartGroupBox, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.mainTableLayoutPanel.TabIndex = 4;
            // 
            // pieChartGroupBox
            // 
            this.pieChartGroupBox.Controls.Add(this.pieChart);
            this.pieChartGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartGroupBox.Location = new System.Drawing.Point(3, 3);
            this.pieChartGroupBox.Name = "pieChartGroupBox";
            this.pieChartGroupBox.Size = new System.Drawing.Size(386, 506);
            this.pieChartGroupBox.TabIndex = 5;
            this.pieChartGroupBox.TabStop = false;
            this.pieChartGroupBox.Text = "議題狀態統計";
            // 
            // lineChartGroupBox
            // 
            this.lineChartGroupBox.Controls.Add(this.lineChart);
            this.lineChartGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineChartGroupBox.Location = new System.Drawing.Point(395, 3);
            this.lineChartGroupBox.Name = "lineChartGroupBox";
            this.lineChartGroupBox.Size = new System.Drawing.Size(386, 506);
            this.lineChartGroupBox.TabIndex = 6;
            this.lineChartGroupBox.TabStop = false;
            this.lineChartGroupBox.Text = "議題完成狀況統計";
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ReportView";
            this.Text = "統計報表 - Issue Tracking Ysytem";
            this.Load += new System.EventHandler(this.ReportViewLoad);
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.pieChartGroupBox.ResumeLayout(false);
            this.lineChartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox pieChartGroupBox;
        private System.Windows.Forms.GroupBox lineChartGroupBox;


    }
}
