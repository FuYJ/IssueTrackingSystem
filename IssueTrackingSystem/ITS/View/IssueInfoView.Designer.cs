namespace IssueTrackingSystem.ITS.View
{
    partial class IssueInfoView
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
            this.issueInfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.IssueTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.issueNameTitleLabel = new System.Windows.Forms.Label();
            this.issueAssigneeComboBox = new System.Windows.Forms.ComboBox();
            this.issueStateComboBox = new System.Windows.Forms.ComboBox();
            this.issueSeverityComboBox = new System.Windows.Forms.ComboBox();
            this.issueAssigneeTitleLabel = new System.Windows.Forms.Label();
            this.issueReportDateLabel = new System.Windows.Forms.Label();
            this.issueReportDateTitleLabel = new System.Windows.Forms.Label();
            this.issueReporterLabel = new System.Windows.Forms.Label();
            this.issueReporterTitleLabel = new System.Windows.Forms.Label();
            this.issueSeverityTitleLabel = new System.Windows.Forms.Label();
            this.issuePriorityTitleLabel = new System.Windows.Forms.Label();
            this.issueStateTitleLabel = new System.Windows.Forms.Label();
            this.issueDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.issueDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.issuePriorityComboBox = new System.Windows.Forms.ComboBox();
            this.issueNameLabel = new System.Windows.Forms.Label();
            this.issueHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.issueHistoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.issueInfoSplitContainer)).BeginInit();
            this.issueInfoSplitContainer.Panel1.SuspendLayout();
            this.issueInfoSplitContainer.Panel2.SuspendLayout();
            this.issueInfoSplitContainer.SuspendLayout();
            this.IssueTableLayoutPanel.SuspendLayout();
            this.issueDescriptionGroupBox.SuspendLayout();
            this.issueHistoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueInfoSplitContainer
            // 
            this.issueInfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueInfoSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.issueInfoSplitContainer.Name = "issueInfoSplitContainer";
            this.issueInfoSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // issueInfoSplitContainer.Panel1
            // 
            this.issueInfoSplitContainer.Panel1.Controls.Add(this.IssueTableLayoutPanel);
            // 
            // issueInfoSplitContainer.Panel2
            // 
            this.issueInfoSplitContainer.Panel2.AutoScroll = true;
            this.issueInfoSplitContainer.Panel2.Controls.Add(this.issueHistoryGroupBox);
            this.issueInfoSplitContainer.Size = new System.Drawing.Size(784, 512);
            this.issueInfoSplitContainer.SplitterDistance = 193;
            this.issueInfoSplitContainer.TabIndex = 2;
            // 
            // IssueTableLayoutPanel
            // 
            this.IssueTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.IssueTableLayoutPanel.ColumnCount = 4;
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.Controls.Add(this.issueNameTitleLabel, 0, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.issueAssigneeComboBox, 1, 3);
            this.IssueTableLayoutPanel.Controls.Add(this.issueStateComboBox, 3, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.issueSeverityComboBox, 3, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.issueAssigneeTitleLabel, 0, 3);
            this.IssueTableLayoutPanel.Controls.Add(this.issueReportDateLabel, 3, 2);
            this.IssueTableLayoutPanel.Controls.Add(this.issueReportDateTitleLabel, 2, 2);
            this.IssueTableLayoutPanel.Controls.Add(this.issueReporterLabel, 1, 2);
            this.IssueTableLayoutPanel.Controls.Add(this.issueReporterTitleLabel, 0, 2);
            this.IssueTableLayoutPanel.Controls.Add(this.issueSeverityTitleLabel, 2, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.issuePriorityTitleLabel, 0, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.issueStateTitleLabel, 2, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.issueDescriptionGroupBox, 0, 4);
            this.IssueTableLayoutPanel.Controls.Add(this.submitButton, 3, 7);
            this.IssueTableLayoutPanel.Controls.Add(this.issuePriorityComboBox, 1, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.issueNameLabel, 1, 0);
            this.IssueTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IssueTableLayoutPanel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IssueTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IssueTableLayoutPanel.Name = "IssueTableLayoutPanel";
            this.IssueTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.IssueTableLayoutPanel.RowCount = 8;
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.Size = new System.Drawing.Size(784, 193);
            this.IssueTableLayoutPanel.TabIndex = 0;
            // 
            // issueNameTitleLabel
            // 
            this.issueNameTitleLabel.AutoSize = true;
            this.issueNameTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueNameTitleLabel.Location = new System.Drawing.Point(11, 8);
            this.issueNameTitleLabel.Name = "issueNameTitleLabel";
            this.issueNameTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueNameTitleLabel.Size = new System.Drawing.Size(53, 16);
            this.issueNameTitleLabel.TabIndex = 21;
            this.issueNameTitleLabel.Text = "議題名稱";
            // 
            // issueAssigneeComboBox
            // 
            this.issueAssigneeComboBox.Enabled = false;
            this.issueAssigneeComboBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueAssigneeComboBox.FormattingEnabled = true;
            this.issueAssigneeComboBox.Location = new System.Drawing.Point(200, 74);
            this.issueAssigneeComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.issueAssigneeComboBox.Name = "issueAssigneeComboBox";
            this.issueAssigneeComboBox.Size = new System.Drawing.Size(121, 20);
            this.issueAssigneeComboBox.TabIndex = 20;
            // 
            // issueStateComboBox
            // 
            this.issueStateComboBox.Enabled = false;
            this.issueStateComboBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueStateComboBox.FormattingEnabled = true;
            this.issueStateComboBox.Items.AddRange(new object[] {
            "處理中",
            "測試中",
            "等待中",
            "已完成"});
            this.issueStateComboBox.Location = new System.Drawing.Point(584, 8);
            this.issueStateComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.issueStateComboBox.Name = "issueStateComboBox";
            this.issueStateComboBox.Size = new System.Drawing.Size(121, 20);
            this.issueStateComboBox.TabIndex = 19;
            // 
            // issueSeverityComboBox
            // 
            this.issueSeverityComboBox.Enabled = false;
            this.issueSeverityComboBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueSeverityComboBox.FormattingEnabled = true;
            this.issueSeverityComboBox.Items.AddRange(new object[] {
            "Optional",
            "Important",
            "Emergent"});
            this.issueSeverityComboBox.Location = new System.Drawing.Point(584, 30);
            this.issueSeverityComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.issueSeverityComboBox.Name = "issueSeverityComboBox";
            this.issueSeverityComboBox.Size = new System.Drawing.Size(121, 20);
            this.issueSeverityComboBox.TabIndex = 18;
            // 
            // issueAssigneeTitleLabel
            // 
            this.issueAssigneeTitleLabel.AutoSize = true;
            this.issueAssigneeTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueAssigneeTitleLabel.Location = new System.Drawing.Point(11, 74);
            this.issueAssigneeTitleLabel.Name = "issueAssigneeTitleLabel";
            this.issueAssigneeTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueAssigneeTitleLabel.Size = new System.Drawing.Size(41, 16);
            this.issueAssigneeTitleLabel.TabIndex = 11;
            this.issueAssigneeTitleLabel.Text = "負責人";
            // 
            // issueReportDateLabel
            // 
            this.issueReportDateLabel.AutoSize = true;
            this.issueReportDateLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueReportDateLabel.Location = new System.Drawing.Point(587, 52);
            this.issueReportDateLabel.Name = "issueReportDateLabel";
            this.issueReportDateLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueReportDateLabel.Size = new System.Drawing.Size(61, 16);
            this.issueReportDateLabel.TabIndex = 10;
            this.issueReportDateLabel.Text = "[提出日期]";
            // 
            // issueReportDateTitleLabel
            // 
            this.issueReportDateTitleLabel.AutoSize = true;
            this.issueReportDateTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueReportDateTitleLabel.Location = new System.Drawing.Point(395, 52);
            this.issueReportDateTitleLabel.Name = "issueReportDateTitleLabel";
            this.issueReportDateTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueReportDateTitleLabel.Size = new System.Drawing.Size(53, 16);
            this.issueReportDateTitleLabel.TabIndex = 9;
            this.issueReportDateTitleLabel.Text = "提出日期";
            // 
            // issueReporterLabel
            // 
            this.issueReporterLabel.AutoSize = true;
            this.issueReporterLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueReporterLabel.Location = new System.Drawing.Point(203, 52);
            this.issueReporterLabel.Name = "issueReporterLabel";
            this.issueReporterLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueReporterLabel.Size = new System.Drawing.Size(49, 16);
            this.issueReporterLabel.TabIndex = 8;
            this.issueReporterLabel.Text = "[提出者]";
            // 
            // issueReporterTitleLabel
            // 
            this.issueReporterTitleLabel.AutoSize = true;
            this.issueReporterTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueReporterTitleLabel.Location = new System.Drawing.Point(11, 52);
            this.issueReporterTitleLabel.Name = "issueReporterTitleLabel";
            this.issueReporterTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueReporterTitleLabel.Size = new System.Drawing.Size(41, 16);
            this.issueReporterTitleLabel.TabIndex = 7;
            this.issueReporterTitleLabel.Text = "提出者";
            // 
            // issueSeverityTitleLabel
            // 
            this.issueSeverityTitleLabel.AutoSize = true;
            this.issueSeverityTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueSeverityTitleLabel.Location = new System.Drawing.Point(395, 30);
            this.issueSeverityTitleLabel.Name = "issueSeverityTitleLabel";
            this.issueSeverityTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueSeverityTitleLabel.Size = new System.Drawing.Size(41, 16);
            this.issueSeverityTitleLabel.TabIndex = 4;
            this.issueSeverityTitleLabel.Text = "嚴重度";
            // 
            // issuePriorityTitleLabel
            // 
            this.issuePriorityTitleLabel.AutoSize = true;
            this.issuePriorityTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issuePriorityTitleLabel.Location = new System.Drawing.Point(11, 30);
            this.issuePriorityTitleLabel.Name = "issuePriorityTitleLabel";
            this.issuePriorityTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issuePriorityTitleLabel.Size = new System.Drawing.Size(41, 16);
            this.issuePriorityTitleLabel.TabIndex = 3;
            this.issuePriorityTitleLabel.Text = "優先度";
            // 
            // issueStateTitleLabel
            // 
            this.issueStateTitleLabel.AutoSize = true;
            this.issueStateTitleLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueStateTitleLabel.Location = new System.Drawing.Point(395, 8);
            this.issueStateTitleLabel.Name = "issueStateTitleLabel";
            this.issueStateTitleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueStateTitleLabel.Size = new System.Drawing.Size(29, 16);
            this.issueStateTitleLabel.TabIndex = 1;
            this.issueStateTitleLabel.Text = "狀態";
            // 
            // issueDescriptionGroupBox
            // 
            this.IssueTableLayoutPanel.SetColumnSpan(this.issueDescriptionGroupBox, 4);
            this.issueDescriptionGroupBox.Controls.Add(this.issueDescriptionRichTextBox);
            this.issueDescriptionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueDescriptionGroupBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueDescriptionGroupBox.Location = new System.Drawing.Point(11, 99);
            this.issueDescriptionGroupBox.Name = "issueDescriptionGroupBox";
            this.IssueTableLayoutPanel.SetRowSpan(this.issueDescriptionGroupBox, 3);
            this.issueDescriptionGroupBox.Size = new System.Drawing.Size(762, 57);
            this.issueDescriptionGroupBox.TabIndex = 15;
            this.issueDescriptionGroupBox.TabStop = false;
            this.issueDescriptionGroupBox.Text = "敘述";
            // 
            // issueDescriptionRichTextBox
            // 
            this.issueDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueDescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueDescriptionRichTextBox.Location = new System.Drawing.Point(3, 18);
            this.issueDescriptionRichTextBox.Name = "issueDescriptionRichTextBox";
            this.issueDescriptionRichTextBox.ReadOnly = true;
            this.issueDescriptionRichTextBox.Size = new System.Drawing.Size(756, 36);
            this.issueDescriptionRichTextBox.TabIndex = 0;
            this.issueDescriptionRichTextBox.Text = "[敘述]";
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.submitButton.Location = new System.Drawing.Point(664, 162);
            this.submitButton.Margin = new System.Windows.Forms.Padding(80, 0, 3, 0);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 23);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "提交議題";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButtonClicked);
            // 
            // issuePriorityComboBox
            // 
            this.issuePriorityComboBox.Enabled = false;
            this.issuePriorityComboBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issuePriorityComboBox.FormattingEnabled = true;
            this.issuePriorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.issuePriorityComboBox.Location = new System.Drawing.Point(200, 30);
            this.issuePriorityComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.issuePriorityComboBox.Name = "issuePriorityComboBox";
            this.issuePriorityComboBox.Size = new System.Drawing.Size(121, 20);
            this.issuePriorityComboBox.TabIndex = 17;
            // 
            // issueNameLabel
            // 
            this.issueNameLabel.AutoSize = true;
            this.issueNameLabel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueNameLabel.Location = new System.Drawing.Point(203, 8);
            this.issueNameLabel.Name = "issueNameLabel";
            this.issueNameLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.issueNameLabel.Size = new System.Drawing.Size(61, 16);
            this.issueNameLabel.TabIndex = 0;
            this.issueNameLabel.Text = "[議題名稱]";
            // 
            // issueHistoryGroupBox
            // 
            this.issueHistoryGroupBox.Controls.Add(this.issueHistoryFlowLayoutPanel);
            this.issueHistoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueHistoryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.issueHistoryGroupBox.Name = "issueHistoryGroupBox";
            this.issueHistoryGroupBox.Size = new System.Drawing.Size(784, 315);
            this.issueHistoryGroupBox.TabIndex = 0;
            this.issueHistoryGroupBox.TabStop = false;
            this.issueHistoryGroupBox.Text = "歷史紀錄";
            // 
            // issueHistoryFlowLayoutPanel
            // 
            this.issueHistoryFlowLayoutPanel.AutoScroll = true;
            this.issueHistoryFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueHistoryFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.issueHistoryFlowLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.issueHistoryFlowLayoutPanel.Name = "issueHistoryFlowLayoutPanel";
            this.issueHistoryFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.issueHistoryFlowLayoutPanel.Size = new System.Drawing.Size(778, 294);
            this.issueHistoryFlowLayoutPanel.TabIndex = 0;
            this.issueHistoryFlowLayoutPanel.WrapContents = false;
            // 
            // IssueInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.issueInfoSplitContainer);
            this.Name = "IssueInfoView";
            this.Text = "[議題名稱] - IssueTrackingSystem";
            this.Load += new System.EventHandler(this.IssueInfoViewLoad);
            this.Controls.SetChildIndex(this.issueInfoSplitContainer, 0);
            this.issueInfoSplitContainer.Panel1.ResumeLayout(false);
            this.issueInfoSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issueInfoSplitContainer)).EndInit();
            this.issueInfoSplitContainer.ResumeLayout(false);
            this.IssueTableLayoutPanel.ResumeLayout(false);
            this.IssueTableLayoutPanel.PerformLayout();
            this.issueDescriptionGroupBox.ResumeLayout(false);
            this.issueHistoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer issueInfoSplitContainer;
        private System.Windows.Forms.TableLayoutPanel IssueTableLayoutPanel;
        private System.Windows.Forms.Label issueNameLabel;
        private System.Windows.Forms.Label issuePriorityTitleLabel;
        private System.Windows.Forms.Label issueStateTitleLabel;
        private System.Windows.Forms.Label issueReporterTitleLabel;
        private System.Windows.Forms.Label issueSeverityTitleLabel;
        private System.Windows.Forms.Label issueAssigneeTitleLabel;
        private System.Windows.Forms.Label issueReportDateLabel;
        private System.Windows.Forms.Label issueReportDateTitleLabel;
        private System.Windows.Forms.Label issueReporterLabel;
        private System.Windows.Forms.GroupBox issueDescriptionGroupBox;
        private System.Windows.Forms.RichTextBox issueDescriptionRichTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox issueStateComboBox;
        private System.Windows.Forms.ComboBox issueSeverityComboBox;
        private System.Windows.Forms.ComboBox issuePriorityComboBox;
        private System.Windows.Forms.ComboBox issueAssigneeComboBox;
        private System.Windows.Forms.FlowLayoutPanel issueHistoryFlowLayoutPanel;
        private System.Windows.Forms.Label issueNameTitleLabel;
        private System.Windows.Forms.GroupBox issueHistoryGroupBox;
    }
}
