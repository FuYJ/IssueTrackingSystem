namespace IssueTrackingSystem.PMS.View
{
    partial class IssueList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._projectName = new System.Windows.Forms.TextBox();
            this.issuesDataGridView = new System.Windows.Forms.DataGridView();
            this.issueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.issuesDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._projectName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 396);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _projectName
            // 
            this._projectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._projectName.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._projectName.Location = new System.Drawing.Point(3, 4);
            this._projectName.Name = "_projectName";
            this._projectName.ReadOnly = true;
            this._projectName.Size = new System.Drawing.Size(776, 32);
            this._projectName.TabIndex = 0;
            this._projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.issuesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuesDataGridView.Location = new System.Drawing.Point(3, 42);
            this.issuesDataGridView.Name = "issuesDataGridView";
            this.issuesDataGridView.RowHeadersVisible = false;
            this.issuesDataGridView.RowTemplate.Height = 24;
            this.issuesDataGridView.Size = new System.Drawing.Size(776, 310);
            this.issuesDataGridView.TabIndex = 2;
            // 
            // issueId
            // 
            this.issueId.FillWeight = 55.85743F;
            this.issueId.HeaderText = "ID";
            this.issueId.Name = "issueId";
            // 
            // issueName
            // 
            this.issueName.FillWeight = 235.6657F;
            this.issueName.HeaderText = "議題名稱";
            this.issueName.Name = "issueName";
            // 
            // priority
            // 
            this.priority.FillWeight = 57.48254F;
            this.priority.HeaderText = "優先度";
            this.priority.Name = "priority";
            // 
            // severity
            // 
            this.severity.FillWeight = 82.56918F;
            this.severity.HeaderText = "嚴重度";
            this.severity.Name = "severity";
            // 
            // reporter
            // 
            this.reporter.FillWeight = 95.59816F;
            this.reporter.HeaderText = "提出人";
            this.reporter.Name = "reporter";
            // 
            // personInCharge
            // 
            this.personInCharge.FillWeight = 95.19702F;
            this.personInCharge.HeaderText = "負責人";
            this.personInCharge.Name = "personInCharge";
            // 
            // reportDate
            // 
            this.reportDate.FillWeight = 93.77536F;
            this.reportDate.HeaderText = "提出時間";
            this.reportDate.Name = "reportDate";
            // 
            // project
            // 
            this.project.FillWeight = 92.484F;
            this.project.HeaderText = "所屬專案";
            this.project.Name = "project";
            // 
            // issueState
            // 
            this.issueState.FillWeight = 91.37055F;
            this.issueState.HeaderText = "狀態";
            this.issueState.Name = "issueState";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this._deleteButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 358);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 35);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // _deleteButton
            // 
            this._deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteButton.Location = new System.Drawing.Point(261, 3);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(252, 29);
            this._deleteButton.TabIndex = 0;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButtonClicked);
            // 
            // IssueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IssueList";
            this.Text = "IssueList";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView issuesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personInCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueState;
        private System.Windows.Forms.TextBox _projectName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _deleteButton;
    }
}