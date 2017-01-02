namespace IssueTrackingSystem.ITS.View
{
    partial class CreateIssueView
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
            this.IssueTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.issueSeverityComboBox = new System.Windows.Forms.ComboBox();
            this.projectTitleLabel = new System.Windows.Forms.Label();
            this.issueSeverityTitleLabel = new System.Windows.Forms.Label();
            this.issuePriorityTitleLabel = new System.Windows.Forms.Label();
            this.issueStateLabel = new System.Windows.Forms.Label();
            this.issueNameLabel = new System.Windows.Forms.Label();
            this.issueStateTitleLabel = new System.Windows.Forms.Label();
            this.issueDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.issueDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.issuePriorityComboBox = new System.Windows.Forms.ComboBox();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.issueNameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.IssueTableLayoutPanel.SuspendLayout();
            this.issueDescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IssueTableLayoutPanel
            // 
            this.IssueTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.IssueTableLayoutPanel.ColumnCount = 4;
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IssueTableLayoutPanel.Controls.Add(this.issueSeverityComboBox, 3, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.projectTitleLabel, 0, 2);
            this.IssueTableLayoutPanel.Controls.Add(this.issueSeverityTitleLabel, 2, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.issuePriorityTitleLabel, 0, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.issueStateLabel, 3, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.issueNameLabel, 0, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.issueStateTitleLabel, 2, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.issueDescriptionGroupBox, 0, 3);
            this.IssueTableLayoutPanel.Controls.Add(this.issuePriorityComboBox, 1, 1);
            this.IssueTableLayoutPanel.Controls.Add(this.projectComboBox, 1, 2);
            this.IssueTableLayoutPanel.Controls.Add(this.issueNameTextBox, 1, 0);
            this.IssueTableLayoutPanel.Controls.Add(this.submitButton, 3, 7);
            this.IssueTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IssueTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IssueTableLayoutPanel.Name = "IssueTableLayoutPanel";
            this.IssueTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.IssueTableLayoutPanel.RowCount = 8;
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.IssueTableLayoutPanel.Size = new System.Drawing.Size(784, 561);
            this.IssueTableLayoutPanel.TabIndex = 2;
            // 
            // issueSeverityComboBox
            // 
            this.issueSeverityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueSeverityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issueSeverityComboBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueSeverityComboBox.FormattingEnabled = true;
            this.issueSeverityComboBox.Items.AddRange(new object[] {
            "Optional",
            "Important",
            "Emergent"});
            this.issueSeverityComboBox.Location = new System.Drawing.Point(581, 90);
            this.issueSeverityComboBox.Name = "issueSeverityComboBox";
            this.issueSeverityComboBox.Size = new System.Drawing.Size(177, 24);
            this.issueSeverityComboBox.TabIndex = 21;
            // 
            // projectTitleLabel
            // 
            this.projectTitleLabel.AutoSize = true;
            this.projectTitleLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectTitleLabel.Location = new System.Drawing.Point(26, 151);
            this.projectTitleLabel.Name = "projectTitleLabel";
            this.projectTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.projectTitleLabel.Size = new System.Drawing.Size(72, 24);
            this.projectTitleLabel.TabIndex = 19;
            this.projectTitleLabel.Text = "所屬專案";
            // 
            // issueSeverityTitleLabel
            // 
            this.issueSeverityTitleLabel.AutoSize = true;
            this.issueSeverityTitleLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueSeverityTitleLabel.Location = new System.Drawing.Point(396, 87);
            this.issueSeverityTitleLabel.Name = "issueSeverityTitleLabel";
            this.issueSeverityTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issueSeverityTitleLabel.Size = new System.Drawing.Size(56, 24);
            this.issueSeverityTitleLabel.TabIndex = 4;
            this.issueSeverityTitleLabel.Text = "嚴重度";
            // 
            // issuePriorityTitleLabel
            // 
            this.issuePriorityTitleLabel.AutoSize = true;
            this.issuePriorityTitleLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issuePriorityTitleLabel.Location = new System.Drawing.Point(26, 87);
            this.issuePriorityTitleLabel.Name = "issuePriorityTitleLabel";
            this.issuePriorityTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issuePriorityTitleLabel.Size = new System.Drawing.Size(56, 24);
            this.issuePriorityTitleLabel.TabIndex = 3;
            this.issuePriorityTitleLabel.Text = "優先度";
            // 
            // issueStateLabel
            // 
            this.issueStateLabel.AutoSize = true;
            this.issueStateLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueStateLabel.Location = new System.Drawing.Point(581, 23);
            this.issueStateLabel.Name = "issueStateLabel";
            this.issueStateLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issueStateLabel.Size = new System.Drawing.Size(56, 24);
            this.issueStateLabel.TabIndex = 2;
            this.issueStateLabel.Text = "待審核";
            // 
            // issueNameLabel
            // 
            this.issueNameLabel.AutoSize = true;
            this.issueNameLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueNameLabel.Location = new System.Drawing.Point(26, 23);
            this.issueNameLabel.Name = "issueNameLabel";
            this.issueNameLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issueNameLabel.Size = new System.Drawing.Size(72, 24);
            this.issueNameLabel.TabIndex = 0;
            this.issueNameLabel.Text = "議題名稱";
            // 
            // issueStateTitleLabel
            // 
            this.issueStateTitleLabel.AutoSize = true;
            this.issueStateTitleLabel.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueStateTitleLabel.Location = new System.Drawing.Point(396, 23);
            this.issueStateTitleLabel.Name = "issueStateTitleLabel";
            this.issueStateTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issueStateTitleLabel.Size = new System.Drawing.Size(40, 24);
            this.issueStateTitleLabel.TabIndex = 1;
            this.issueStateTitleLabel.Text = "狀態";
            // 
            // issueDescriptionGroupBox
            // 
            this.IssueTableLayoutPanel.SetColumnSpan(this.issueDescriptionGroupBox, 4);
            this.issueDescriptionGroupBox.Controls.Add(this.issueDescriptionRichTextBox);
            this.issueDescriptionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueDescriptionGroupBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueDescriptionGroupBox.Location = new System.Drawing.Point(26, 218);
            this.issueDescriptionGroupBox.Name = "issueDescriptionGroupBox";
            this.IssueTableLayoutPanel.SetRowSpan(this.issueDescriptionGroupBox, 4);
            this.issueDescriptionGroupBox.Size = new System.Drawing.Size(732, 247);
            this.issueDescriptionGroupBox.TabIndex = 15;
            this.issueDescriptionGroupBox.TabStop = false;
            this.issueDescriptionGroupBox.Text = "敘述";
            // 
            // issueDescriptionRichTextBox
            // 
            this.issueDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueDescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueDescriptionRichTextBox.Location = new System.Drawing.Point(3, 23);
            this.issueDescriptionRichTextBox.Name = "issueDescriptionRichTextBox";
            this.issueDescriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.issueDescriptionRichTextBox.Size = new System.Drawing.Size(726, 221);
            this.issueDescriptionRichTextBox.TabIndex = 0;
            this.issueDescriptionRichTextBox.Text = "[敘述]";
            // 
            // issuePriorityComboBox
            // 
            this.issuePriorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuePriorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuePriorityComboBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issuePriorityComboBox.FormattingEnabled = true;
            this.issuePriorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.issuePriorityComboBox.Location = new System.Drawing.Point(211, 90);
            this.issuePriorityComboBox.Name = "issuePriorityComboBox";
            this.issuePriorityComboBox.Size = new System.Drawing.Size(176, 24);
            this.issuePriorityComboBox.TabIndex = 18;
            // 
            // projectComboBox
            // 
            this.projectComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projectComboBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(211, 154);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(176, 24);
            this.projectComboBox.TabIndex = 20;
            // 
            // issueNameTextBox
            // 
            this.issueNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueNameTextBox.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issueNameTextBox.Location = new System.Drawing.Point(211, 26);
            this.issueNameTextBox.Name = "issueNameTextBox";
            this.issueNameTextBox.Size = new System.Drawing.Size(176, 27);
            this.issueNameTextBox.TabIndex = 22;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.submitButton.Location = new System.Drawing.Point(581, 474);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(177, 61);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "確認發布";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButtonClicked);
            // 
            // CreateIssueView
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.IssueTableLayoutPanel);
            this.Name = "CreateIssueView";
            this.Text = "新增議題 - Issue Tracking System";
            this.IssueTableLayoutPanel.ResumeLayout(false);
            this.IssueTableLayoutPanel.PerformLayout();
            this.issueDescriptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel IssueTableLayoutPanel;
        private System.Windows.Forms.Label issueSeverityTitleLabel;
        private System.Windows.Forms.Label issuePriorityTitleLabel;
        private System.Windows.Forms.Label issueNameLabel;
        private System.Windows.Forms.Label issueStateTitleLabel;
        private System.Windows.Forms.GroupBox issueDescriptionGroupBox;
        private System.Windows.Forms.RichTextBox issueDescriptionRichTextBox;
        private System.Windows.Forms.Label projectTitleLabel;
        private System.Windows.Forms.Label issueStateLabel;
        private System.Windows.Forms.ComboBox issuePriorityComboBox;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.ComboBox issueSeverityComboBox;
        private System.Windows.Forms.TextBox issueNameTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}
