namespace IssueTrackingSystem.AMS.View
{
    partial class UserListView
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
            this.userListDataGridView = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.joinedProjectsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingIssuesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.userListDataGridView, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // userListDataGridView
            // 
            this.userListDataGridView.AllowUserToAddRows = false;
            this.userListDataGridView.AllowUserToOrderColumns = true;
            this.userListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.username,
            this.emailAddress,
            this.authority,
            this.joinedProjectsNumber,
            this.invitedProjectsNumber,
            this.trackingIssuesNumber,
            this.delete});
            this.userListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.userListDataGridView.Name = "userListDataGridView";
            this.userListDataGridView.RowHeadersVisible = false;
            this.userListDataGridView.RowTemplate.Height = 24;
            this.userListDataGridView.Size = new System.Drawing.Size(778, 506);
            this.userListDataGridView.TabIndex = 0;
            this.userListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userListDataGridViewCellContentClicked);
            this.userListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.userRoleValueChanged);
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
            this.username.ReadOnly = true;
            // 
            // emailAddress
            // 
            this.emailAddress.FillWeight = 150.6035F;
            this.emailAddress.HeaderText = "E-mail";
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.ReadOnly = true;
            // 
            // authority
            // 
            this.authority.FillWeight = 80F;
            this.authority.HeaderText = "權限";
            this.authority.Items.AddRange(new object[] {
            "一般使用者",
            "系統管理員"});
            this.authority.Name = "authority";
            this.authority.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // joinedProjectsNumber
            // 
            this.joinedProjectsNumber.FillWeight = 60F;
            this.joinedProjectsNumber.HeaderText = "已加入專案數";
            this.joinedProjectsNumber.Name = "joinedProjectsNumber";
            this.joinedProjectsNumber.ReadOnly = true;
            // 
            // invitedProjectsNumber
            // 
            this.invitedProjectsNumber.FillWeight = 60F;
            this.invitedProjectsNumber.HeaderText = "受邀專案數";
            this.invitedProjectsNumber.Name = "invitedProjectsNumber";
            this.invitedProjectsNumber.ReadOnly = true;
            // 
            // trackingIssuesNumber
            // 
            this.trackingIssuesNumber.FillWeight = 60F;
            this.trackingIssuesNumber.HeaderText = "追蹤中議題數";
            this.trackingIssuesNumber.Name = "trackingIssuesNumber";
            this.trackingIssuesNumber.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 40.60914F;
            this.delete.HeaderText = "刪除";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "刪除";
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "UserListView";
            this.Text = "使用者列表 - Issue Tracking System";
            this.Load += new System.EventHandler(this.AccountListViewLoad);
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView userListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddress;
        private System.Windows.Forms.DataGridViewComboBoxColumn authority;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingIssuesNumber;
        private System.Windows.Forms.DataGridViewButtonColumn delete;

    }
}
