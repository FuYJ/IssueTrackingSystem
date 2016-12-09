namespace IssueTrackingSystem.ULS.View
{
    partial class SecurityView
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
            this.securityDataGridView = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.joinedProjectsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingIssuesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.securityDataGridView, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 512F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // securityDataGridView
            // 
            this.securityDataGridView.AllowUserToAddRows = false;
            this.securityDataGridView.AllowUserToOrderColumns = true;
            this.securityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.securityDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.securityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.securityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.username,
            this.emailAddress,
            this.authority,
            this.joinedProjectsNumber,
            this.invitedProjectsNumber,
            this.trackingIssuesNumber,
            this.delete});
            this.securityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securityDataGridView.Location = new System.Drawing.Point(3, 3);
            this.securityDataGridView.Name = "securityDataGridView";
            this.securityDataGridView.RowHeadersVisible = false;
            this.securityDataGridView.RowTemplate.Height = 24;
            this.securityDataGridView.Size = new System.Drawing.Size(778, 506);
            this.securityDataGridView.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.FillWeight = 40.27835F;
            this.userId.HeaderText = "ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // username
            // 
            this.username.FillWeight = 99.69226F;
            this.username.HeaderText = "使用者名稱";
            this.username.Name = "username";
            // 
            // emailAddress
            // 
            this.emailAddress.FillWeight = 230.6035F;
            this.emailAddress.HeaderText = "E-mail";
            this.emailAddress.Name = "emailAddress";
            // 
            // authority
            // 
            this.authority.FillWeight = 66.01459F;
            this.authority.HeaderText = "權限";
            this.authority.Name = "authority";
            this.authority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // joinedProjectsNumber
            // 
            this.joinedProjectsNumber.FillWeight = 107.6007F;
            this.joinedProjectsNumber.HeaderText = "已加入專案數";
            this.joinedProjectsNumber.Name = "joinedProjectsNumber";
            // 
            // invitedProjectsNumber
            // 
            this.invitedProjectsNumber.FillWeight = 107.6007F;
            this.invitedProjectsNumber.HeaderText = "受邀專案數";
            this.invitedProjectsNumber.Name = "invitedProjectsNumber";
            // 
            // trackingIssuesNumber
            // 
            this.trackingIssuesNumber.FillWeight = 107.6007F;
            this.trackingIssuesNumber.HeaderText = "追蹤中議題數";
            this.trackingIssuesNumber.Name = "trackingIssuesNumber";
            // 
            // delete
            // 
            this.delete.FillWeight = 40.60914F;
            this.delete.HeaderText = "刪除";
            this.delete.Name = "delete";
            // 
            // SecurityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "SecurityView";
            this.Text = "使用者列表 - Issue Tracking System";
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.securityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView securityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddress;
        private System.Windows.Forms.DataGridViewComboBoxColumn authority;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingIssuesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;

    }
}
