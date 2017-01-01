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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTypeTitleLabel = new System.Windows.Forms.Label();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchKeyComboBox = new System.Windows.Forms.ComboBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.projectInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.projectInfoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.projectNameTitleLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectDescriptionTitleLabel = new System.Windows.Forms.Label();
            this.projectDescriptionLabel = new System.Windows.Forms.Label();
            this.projectManagerTitleLabel = new System.Windows.Forms.Label();
            this.projectManagerLabel = new System.Windows.Forms.Label();
            this.projectCreatedDateTitleLabel = new System.Windows.Forms.Label();
            this.projectCreatedDateLabel = new System.Windows.Forms.Label();
            this.chartTabControl = new System.Windows.Forms.TabControl();
            this.pieChartTabPage = new System.Windows.Forms.TabPage();
            this.lineChartTabPage = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.projectInfoGroupBox.SuspendLayout();
            this.projectInfoFlowLayoutPanel.SuspendLayout();
            this.chartTabControl.SuspendLayout();
            this.pieChartTabPage.SuspendLayout();
            this.lineChartTabPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(3, 3);
            this.pieChart.Name = "pieChart";
            this.pieChart.Padding = new System.Windows.Forms.Padding(10);
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "issueStates";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(462, 474);
            this.pieChart.TabIndex = 2;
            this.pieChart.Text = "chart1";
            // 
            // lineChart
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(3, 3);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "已完成";
            series2.Name = "resolvedIssues";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "未完成";
            series3.Name = "unresolvedIssues";
            this.lineChart.Series.Add(series2);
            this.lineChart.Series.Add(series3);
            this.lineChart.Size = new System.Drawing.Size(462, 474);
            this.lineChart.TabIndex = 3;
            this.lineChart.Text = "chart2";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.chartTabControl, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.mainTableLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.projectInfoGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(485, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.65613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.34387F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.searchTypeTitleLabel);
            this.flowLayoutPanel.Controls.Add(this.searchTypeComboBox);
            this.flowLayoutPanel.Controls.Add(this.searchKeyComboBox);
            this.flowLayoutPanel.Controls.Add(this.generateReportButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(290, 139);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // searchTypeTitleLabel
            // 
            this.searchTypeTitleLabel.AutoSize = true;
            this.searchTypeTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchTypeTitleLabel.Location = new System.Drawing.Point(5, 5);
            this.searchTypeTitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.searchTypeTitleLabel.Name = "searchTypeTitleLabel";
            this.searchTypeTitleLabel.Size = new System.Drawing.Size(72, 16);
            this.searchTypeTitleLabel.TabIndex = 3;
            this.searchTypeTitleLabel.Text = "搜索條件";
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Items.AddRange(new object[] {
            "依據專案",
            "依據使用者"});
            this.searchTypeComboBox.Location = new System.Drawing.Point(5, 31);
            this.searchTypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.searchTypeComboBox.TabIndex = 1;
            this.searchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.searchTypeComboBoxSelectedIndexChanged);
            // 
            // searchKeyComboBox
            // 
            this.searchKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchKeyComboBox.FormattingEnabled = true;
            this.searchKeyComboBox.Location = new System.Drawing.Point(5, 61);
            this.searchKeyComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchKeyComboBox.Name = "searchKeyComboBox";
            this.searchKeyComboBox.Size = new System.Drawing.Size(121, 20);
            this.searchKeyComboBox.TabIndex = 4;
            // 
            // generateReportButton
            // 
            this.generateReportButton.AutoSize = true;
            this.generateReportButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.generateReportButton.Location = new System.Drawing.Point(5, 91);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(5);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(82, 30);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "產生報表";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButtonClicked);
            // 
            // projectInfoGroupBox
            // 
            this.projectInfoGroupBox.Controls.Add(this.projectInfoFlowLayoutPanel);
            this.projectInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectInfoGroupBox.Location = new System.Drawing.Point(3, 148);
            this.projectInfoGroupBox.Name = "projectInfoGroupBox";
            this.projectInfoGroupBox.Size = new System.Drawing.Size(290, 355);
            this.projectInfoGroupBox.TabIndex = 1;
            this.projectInfoGroupBox.TabStop = false;
            this.projectInfoGroupBox.Text = "專案資訊";
            // 
            // projectInfoFlowLayoutPanel
            // 
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectNameTitleLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectNameLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectDescriptionTitleLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectDescriptionLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectManagerTitleLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectManagerLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectCreatedDateTitleLabel);
            this.projectInfoFlowLayoutPanel.Controls.Add(this.projectCreatedDateLabel);
            this.projectInfoFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectInfoFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.projectInfoFlowLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.projectInfoFlowLayoutPanel.Name = "projectInfoFlowLayoutPanel";
            this.projectInfoFlowLayoutPanel.Size = new System.Drawing.Size(284, 334);
            this.projectInfoFlowLayoutPanel.TabIndex = 0;
            // 
            // projectNameTitleLabel
            // 
            this.projectNameTitleLabel.AutoSize = true;
            this.projectNameTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectNameTitleLabel.Location = new System.Drawing.Point(5, 5);
            this.projectNameTitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectNameTitleLabel.Name = "projectNameTitleLabel";
            this.projectNameTitleLabel.Size = new System.Drawing.Size(76, 16);
            this.projectNameTitleLabel.TabIndex = 0;
            this.projectNameTitleLabel.Text = "專案名稱:";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectNameLabel.Location = new System.Drawing.Point(5, 31);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(50, 16);
            this.projectNameLabel.TabIndex = 5;
            this.projectNameLabel.Text = "[名稱]";
            // 
            // projectDescriptionTitleLabel
            // 
            this.projectDescriptionTitleLabel.AutoSize = true;
            this.projectDescriptionTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectDescriptionTitleLabel.Location = new System.Drawing.Point(5, 57);
            this.projectDescriptionTitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectDescriptionTitleLabel.Name = "projectDescriptionTitleLabel";
            this.projectDescriptionTitleLabel.Size = new System.Drawing.Size(76, 16);
            this.projectDescriptionTitleLabel.TabIndex = 1;
            this.projectDescriptionTitleLabel.Text = "專案簡介:";
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.AutoSize = true;
            this.projectDescriptionLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectDescriptionLabel.Location = new System.Drawing.Point(5, 83);
            this.projectDescriptionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(50, 16);
            this.projectDescriptionLabel.TabIndex = 4;
            this.projectDescriptionLabel.Text = "[簡介]";
            // 
            // projectManagerTitleLabel
            // 
            this.projectManagerTitleLabel.AutoSize = true;
            this.projectManagerTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectManagerTitleLabel.Location = new System.Drawing.Point(5, 109);
            this.projectManagerTitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectManagerTitleLabel.Name = "projectManagerTitleLabel";
            this.projectManagerTitleLabel.Size = new System.Drawing.Size(92, 16);
            this.projectManagerTitleLabel.TabIndex = 2;
            this.projectManagerTitleLabel.Text = "專案管理者:";
            // 
            // projectManagerLabel
            // 
            this.projectManagerLabel.AutoSize = true;
            this.projectManagerLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectManagerLabel.Location = new System.Drawing.Point(5, 135);
            this.projectManagerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectManagerLabel.Name = "projectManagerLabel";
            this.projectManagerLabel.Size = new System.Drawing.Size(66, 16);
            this.projectManagerLabel.TabIndex = 6;
            this.projectManagerLabel.Text = "[管理者]";
            // 
            // projectCreatedDateTitleLabel
            // 
            this.projectCreatedDateTitleLabel.AutoSize = true;
            this.projectCreatedDateTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectCreatedDateTitleLabel.Location = new System.Drawing.Point(5, 161);
            this.projectCreatedDateTitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectCreatedDateTitleLabel.Name = "projectCreatedDateTitleLabel";
            this.projectCreatedDateTitleLabel.Size = new System.Drawing.Size(108, 16);
            this.projectCreatedDateTitleLabel.TabIndex = 3;
            this.projectCreatedDateTitleLabel.Text = "專案創建日期:";
            // 
            // projectCreatedDateLabel
            // 
            this.projectCreatedDateLabel.AutoSize = true;
            this.projectCreatedDateLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectCreatedDateLabel.Location = new System.Drawing.Point(5, 187);
            this.projectCreatedDateLabel.Margin = new System.Windows.Forms.Padding(5);
            this.projectCreatedDateLabel.Name = "projectCreatedDateLabel";
            this.projectCreatedDateLabel.Size = new System.Drawing.Size(82, 16);
            this.projectCreatedDateLabel.TabIndex = 7;
            this.projectCreatedDateLabel.Text = "[創建日期]";
            // 
            // chartTabControl
            // 
            this.chartTabControl.Controls.Add(this.pieChartTabPage);
            this.chartTabControl.Controls.Add(this.lineChartTabPage);
            this.chartTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTabControl.Location = new System.Drawing.Point(3, 3);
            this.chartTabControl.Name = "chartTabControl";
            this.chartTabControl.SelectedIndex = 0;
            this.chartTabControl.Size = new System.Drawing.Size(476, 506);
            this.chartTabControl.TabIndex = 3;
            // 
            // pieChartTabPage
            // 
            this.pieChartTabPage.Controls.Add(this.pieChart);
            this.pieChartTabPage.Location = new System.Drawing.Point(4, 22);
            this.pieChartTabPage.Name = "pieChartTabPage";
            this.pieChartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pieChartTabPage.Size = new System.Drawing.Size(468, 480);
            this.pieChartTabPage.TabIndex = 0;
            this.pieChartTabPage.Text = "議題狀態統計";
            this.pieChartTabPage.UseVisualStyleBackColor = true;
            // 
            // lineChartTabPage
            // 
            this.lineChartTabPage.Controls.Add(this.lineChart);
            this.lineChartTabPage.Location = new System.Drawing.Point(4, 22);
            this.lineChartTabPage.Name = "lineChartTabPage";
            this.lineChartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lineChartTabPage.Size = new System.Drawing.Size(468, 480);
            this.lineChartTabPage.TabIndex = 1;
            this.lineChartTabPage.Text = "議題完成狀況紀錄";
            this.lineChartTabPage.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ReportView";
            this.Text = "統計報表 - Issue Tracking Ysytem";
            this.Load += new System.EventHandler(this.ReportViewLoad);
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.projectInfoGroupBox.ResumeLayout(false);
            this.projectInfoFlowLayoutPanel.ResumeLayout(false);
            this.projectInfoFlowLayoutPanel.PerformLayout();
            this.chartTabControl.ResumeLayout(false);
            this.pieChartTabPage.ResumeLayout(false);
            this.lineChartTabPage.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label searchTypeTitleLabel;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.ComboBox searchKeyComboBox;
        private System.Windows.Forms.GroupBox projectInfoGroupBox;
        private System.Windows.Forms.FlowLayoutPanel projectInfoFlowLayoutPanel;
        private System.Windows.Forms.Label projectNameTitleLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label projectDescriptionTitleLabel;
        private System.Windows.Forms.Label projectDescriptionLabel;
        private System.Windows.Forms.Label projectManagerTitleLabel;
        private System.Windows.Forms.Label projectManagerLabel;
        private System.Windows.Forms.Label projectCreatedDateTitleLabel;
        private System.Windows.Forms.Label projectCreatedDateLabel;
        private System.Windows.Forms.TabControl chartTabControl;
        private System.Windows.Forms.TabPage pieChartTabPage;
        private System.Windows.Forms.TabPage lineChartTabPage;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;


    }
}
