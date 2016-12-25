namespace IssueTrackingSystem.AMS.View
{
    partial class ProjectListView
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
            this.projectTabControl = new System.Windows.Forms.TabControl();
            this.joinedProjectsTabPage = new System.Windows.Forms.TabPage();
            this.invitedProjectsTabPage = new System.Windows.Forms.TabPage();
            this.joinedProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.invitedProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.invitedProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptInvitedProjectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.joinedProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedProjectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewJoinedProjectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mainTableLayoutPanel.SuspendLayout();
            this.projectTabControl.SuspendLayout();
            this.joinedProjectsTabPage.SuspendLayout();
            this.invitedProjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joinedProjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitedProjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.projectTabControl, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // projectTabControl
            // 
            this.projectTabControl.Controls.Add(this.joinedProjectsTabPage);
            this.projectTabControl.Controls.Add(this.invitedProjectsTabPage);
            this.projectTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTabControl.Location = new System.Drawing.Point(13, 13);
            this.projectTabControl.Name = "projectTabControl";
            this.projectTabControl.SelectedIndex = 0;
            this.projectTabControl.Size = new System.Drawing.Size(758, 486);
            this.projectTabControl.TabIndex = 0;
            // 
            // joinedProjectsTabPage
            // 
            this.joinedProjectsTabPage.Controls.Add(this.joinedProjectsDataGridView);
            this.joinedProjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.joinedProjectsTabPage.Name = "joinedProjectsTabPage";
            this.joinedProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.joinedProjectsTabPage.Size = new System.Drawing.Size(750, 460);
            this.joinedProjectsTabPage.TabIndex = 0;
            this.joinedProjectsTabPage.Text = "已加入的專案";
            this.joinedProjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // invitedProjectsTabPage
            // 
            this.invitedProjectsTabPage.Controls.Add(this.invitedProjectsDataGridView);
            this.invitedProjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.invitedProjectsTabPage.Name = "invitedProjectsTabPage";
            this.invitedProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.invitedProjectsTabPage.Size = new System.Drawing.Size(750, 460);
            this.invitedProjectsTabPage.TabIndex = 1;
            this.invitedProjectsTabPage.Text = "受邀請的專案";
            this.invitedProjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // joinedProjectsDataGridView
            // 
            this.joinedProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.joinedProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.joinedProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinedProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.joinedProjectId,
            this.joinedProjectName,
            this.joinedProjectDescription,
            this.joinedProjectManager,
            this.viewJoinedProjectButton});
            this.joinedProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinedProjectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.joinedProjectsDataGridView.Name = "joinedProjectsDataGridView";
            this.joinedProjectsDataGridView.RowHeadersVisible = false;
            this.joinedProjectsDataGridView.RowTemplate.Height = 24;
            this.joinedProjectsDataGridView.Size = new System.Drawing.Size(744, 454);
            this.joinedProjectsDataGridView.TabIndex = 0;
            // 
            // invitedProjectsDataGridView
            // 
            this.invitedProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invitedProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.invitedProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invitedProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invitedProjectId,
            this.invitedProjectName,
            this.invitedProjectDescription,
            this.invitedProjectManager,
            this.acceptInvitedProjectButton});
            this.invitedProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invitedProjectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.invitedProjectsDataGridView.Name = "invitedProjectsDataGridView";
            this.invitedProjectsDataGridView.RowHeadersVisible = false;
            this.invitedProjectsDataGridView.RowTemplate.Height = 24;
            this.invitedProjectsDataGridView.Size = new System.Drawing.Size(744, 454);
            this.invitedProjectsDataGridView.TabIndex = 1;
            // 
            // invitedProjectId
            // 
            this.invitedProjectId.FillWeight = 24.83928F;
            this.invitedProjectId.HeaderText = "ID";
            this.invitedProjectId.Name = "invitedProjectId";
            this.invitedProjectId.ReadOnly = true;
            // 
            // invitedProjectName
            // 
            this.invitedProjectName.FillWeight = 116.1236F;
            this.invitedProjectName.HeaderText = "專案名稱";
            this.invitedProjectName.Name = "invitedProjectName";
            // 
            // invitedProjectDescription
            // 
            this.invitedProjectDescription.FillWeight = 239.4765F;
            this.invitedProjectDescription.HeaderText = "簡介";
            this.invitedProjectDescription.Name = "invitedProjectDescription";
            // 
            // invitedProjectManager
            // 
            this.invitedProjectManager.FillWeight = 63.45178F;
            this.invitedProjectManager.HeaderText = "專案管理員";
            this.invitedProjectManager.Name = "invitedProjectManager";
            // 
            // acceptInvitedProjectButton
            // 
            this.acceptInvitedProjectButton.FillWeight = 56.10882F;
            this.acceptInvitedProjectButton.HeaderText = "接受邀請";
            this.acceptInvitedProjectButton.Name = "acceptInvitedProjectButton";
            this.acceptInvitedProjectButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acceptInvitedProjectButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // joinedProjectId
            // 
            this.joinedProjectId.FillWeight = 24.83928F;
            this.joinedProjectId.HeaderText = "ID";
            this.joinedProjectId.Name = "joinedProjectId";
            // 
            // joinedProjectName
            // 
            this.joinedProjectName.FillWeight = 116.1236F;
            this.joinedProjectName.HeaderText = "專案名稱";
            this.joinedProjectName.Name = "joinedProjectName";
            // 
            // joinedProjectDescription
            // 
            this.joinedProjectDescription.FillWeight = 239.4765F;
            this.joinedProjectDescription.HeaderText = "簡介";
            this.joinedProjectDescription.Name = "joinedProjectDescription";
            // 
            // joinedProjectManager
            // 
            this.joinedProjectManager.FillWeight = 63.45178F;
            this.joinedProjectManager.HeaderText = "專案管理員";
            this.joinedProjectManager.Name = "joinedProjectManager";
            // 
            // viewJoinedProjectButton
            // 
            this.viewJoinedProjectButton.DataPropertyName = "檢視專案";
            this.viewJoinedProjectButton.FillWeight = 56.10882F;
            this.viewJoinedProjectButton.HeaderText = "檢視專案";
            this.viewJoinedProjectButton.Name = "viewJoinedProjectButton";
            this.viewJoinedProjectButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewJoinedProjectButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ProjectListView";
            this.Text = "專案列表  - Issue Tracking System";
            this.Controls.SetChildIndex(this.mainTableLayoutPanel, 0);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.projectTabControl.ResumeLayout(false);
            this.joinedProjectsTabPage.ResumeLayout(false);
            this.invitedProjectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.joinedProjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitedProjectsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TabControl projectTabControl;
        private System.Windows.Forms.TabPage joinedProjectsTabPage;
        private System.Windows.Forms.TabPage invitedProjectsTabPage;
        private System.Windows.Forms.DataGridView joinedProjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectManager;
        private System.Windows.Forms.DataGridViewButtonColumn viewJoinedProjectButton;
        private System.Windows.Forms.DataGridView invitedProjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectManager;
        private System.Windows.Forms.DataGridViewButtonColumn acceptInvitedProjectButton;
    }
}
