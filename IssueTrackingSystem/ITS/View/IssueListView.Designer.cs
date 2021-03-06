﻿namespace IssueTrackingSystem.ITS.View
{
    partial class IssueListView
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewStatisticReportButton = new System.Windows.Forms.Button();
            this.issuesDataGridView = new System.Windows.Forms.DataGridView();
            this.createIssueButton = new System.Windows.Forms.Button();
            this.selectSearchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.issueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 6;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayoutPanel.Controls.Add(this.viewStatisticReportButton, 5, 0);
            this.mainTableLayoutPanel.Controls.Add(this.issuesDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.createIssueButton, 4, 0);
            this.mainTableLayoutPanel.Controls.Add(this.selectSearchTypeComboBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.keywordTextBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.searchButton, 2, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 514);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // viewStatisticReportButton
            // 
            this.viewStatisticReportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewStatisticReportButton.Location = new System.Drawing.Point(660, 13);
            this.viewStatisticReportButton.Name = "viewStatisticReportButton";
            this.viewStatisticReportButton.Size = new System.Drawing.Size(111, 43);
            this.viewStatisticReportButton.TabIndex = 2;
            this.viewStatisticReportButton.Text = "查看報表";
            this.viewStatisticReportButton.UseVisualStyleBackColor = true;
            this.viewStatisticReportButton.Click += new System.EventHandler(this.viewStatisticReportButtonClicked);
            // 
            // issuesDataGridView
            // 
            this.issuesDataGridView.AllowUserToAddRows = false;
            this.issuesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueId,
            this.issueName,
            this.priority,
            this.severity,
            this.reporter,
            this.personInCharge,
            this.reportDate,
            this.project,
            this.issueState});
            this.mainTableLayoutPanel.SetColumnSpan(this.issuesDataGridView, 6);
            this.issuesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuesDataGridView.Location = new System.Drawing.Point(13, 62);
            this.issuesDataGridView.Name = "issuesDataGridView";
            this.issuesDataGridView.RowHeadersVisible = false;
            this.issuesDataGridView.RowTemplate.Height = 24;
            this.issuesDataGridView.Size = new System.Drawing.Size(758, 439);
            this.issuesDataGridView.TabIndex = 0;
            this.issuesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issuesDataGridViewCellClicked);
            this.issuesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issuesDataGridViewCellDoubleClicked);
            // 
            // createIssueButton
            // 
            this.createIssueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createIssueButton.Location = new System.Drawing.Point(546, 13);
            this.createIssueButton.Name = "createIssueButton";
            this.createIssueButton.Size = new System.Drawing.Size(108, 43);
            this.createIssueButton.TabIndex = 1;
            this.createIssueButton.Text = "新增議題";
            this.createIssueButton.UseVisualStyleBackColor = true;
            this.createIssueButton.Click += new System.EventHandler(this.createIssueButtonClicked);
            // 
            // selectSearchTypeComboBox
            // 
            this.selectSearchTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectSearchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSearchTypeComboBox.FormattingEnabled = true;
            this.selectSearchTypeComboBox.Items.AddRange(new object[] {
            "以議題名稱",
            "以專案名稱",
            "以提出人名稱",
            "以負責人名稱",
            "以議題狀態"});
            this.selectSearchTypeComboBox.Location = new System.Drawing.Point(127, 13);
            this.selectSearchTypeComboBox.Name = "selectSearchTypeComboBox";
            this.selectSearchTypeComboBox.Size = new System.Drawing.Size(108, 20);
            this.selectSearchTypeComboBox.TabIndex = 3;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(13, 13);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(100, 22);
            this.keywordTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(241, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 43);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "開始搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButtonClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // issueId
            // 
            this.issueId.FillWeight = 55.85743F;
            this.issueId.HeaderText = "ID";
            this.issueId.Name = "issueId";
            this.issueId.ReadOnly = true;
            // 
            // issueName
            // 
            this.issueName.FillWeight = 235.6657F;
            this.issueName.HeaderText = "議題名稱";
            this.issueName.Name = "issueName";
            this.issueName.ReadOnly = true;
            // 
            // priority
            // 
            this.priority.FillWeight = 57.48254F;
            this.priority.HeaderText = "優先度";
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            // 
            // severity
            // 
            this.severity.FillWeight = 82.56918F;
            this.severity.HeaderText = "嚴重度";
            this.severity.Name = "severity";
            this.severity.ReadOnly = true;
            // 
            // reporter
            // 
            this.reporter.FillWeight = 95.59816F;
            this.reporter.HeaderText = "提出人";
            this.reporter.Name = "reporter";
            this.reporter.ReadOnly = true;
            // 
            // personInCharge
            // 
            this.personInCharge.FillWeight = 95.19702F;
            this.personInCharge.HeaderText = "負責人";
            this.personInCharge.Name = "personInCharge";
            this.personInCharge.ReadOnly = true;
            // 
            // reportDate
            // 
            this.reportDate.FillWeight = 93.77536F;
            this.reportDate.HeaderText = "提出時間";
            this.reportDate.Name = "reportDate";
            this.reportDate.ReadOnly = true;
            // 
            // project
            // 
            this.project.FillWeight = 92.484F;
            this.project.HeaderText = "所屬專案";
            this.project.Name = "project";
            this.project.ReadOnly = true;
            // 
            // issueState
            // 
            this.issueState.FillWeight = 91.37055F;
            this.issueState.HeaderText = "狀態";
            this.issueState.Name = "issueState";
            this.issueState.ReadOnly = true;
            // 
            // IssueListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Name = "IssueListView";
            this.Text = "議題列表 - Issue Tracking System";
            this.Load += new System.EventHandler(this.IssueListViewLoad);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView issuesDataGridView;
        private System.Windows.Forms.Button createIssueButton;
        private System.Windows.Forms.Button viewStatisticReportButton;
        private System.Windows.Forms.ComboBox selectSearchTypeComboBox;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personInCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueState;

    }
}
