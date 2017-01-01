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
            this.generalUserTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.projectTabControl = new System.Windows.Forms.TabControl();
            this.joinedProjectsTabPage = new System.Windows.Forms.TabPage();
            this.joinedProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.invitedProjectsTabPage = new System.Windows.Forms.TabPage();
            this.invitedProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.invitedProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invitedProjectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptInvitedProjectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.denyInvitedProjectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.allProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.projectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemManagerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.joinedProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedProjectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalUserTableLayoutPanel.SuspendLayout();
            this.projectTabControl.SuspendLayout();
            this.joinedProjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joinedProjectsDataGridView)).BeginInit();
            this.invitedProjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invitedProjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProjectsDataGridView)).BeginInit();
            this.systemManagerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalUserTableLayoutPanel
            // 
            this.generalUserTableLayoutPanel.ColumnCount = 1;
            this.generalUserTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalUserTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalUserTableLayoutPanel.Controls.Add(this.projectTabControl, 0, 0);
            this.generalUserTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalUserTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.generalUserTableLayoutPanel.Name = "generalUserTableLayoutPanel";
            this.generalUserTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.generalUserTableLayoutPanel.RowCount = 3;
            this.generalUserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalUserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalUserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalUserTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.generalUserTableLayoutPanel.TabIndex = 2;
            // 
            // projectTabControl
            // 
            this.projectTabControl.Controls.Add(this.joinedProjectsTabPage);
            this.projectTabControl.Controls.Add(this.invitedProjectsTabPage);
            this.projectTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTabControl.Location = new System.Drawing.Point(13, 13);
            this.projectTabControl.Name = "projectTabControl";
            this.projectTabControl.SelectedIndex = 0;
            this.projectTabControl.Size = new System.Drawing.Size(758, 446);
            this.projectTabControl.TabIndex = 0;
            // 
            // joinedProjectsTabPage
            // 
            this.joinedProjectsTabPage.Controls.Add(this.joinedProjectsDataGridView);
            this.joinedProjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.joinedProjectsTabPage.Name = "joinedProjectsTabPage";
            this.joinedProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.joinedProjectsTabPage.Size = new System.Drawing.Size(750, 420);
            this.joinedProjectsTabPage.TabIndex = 0;
            this.joinedProjectsTabPage.Text = "已加入的專案";
            this.joinedProjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // joinedProjectsDataGridView
            // 
            this.joinedProjectsDataGridView.AllowUserToAddRows = false;
            this.joinedProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.joinedProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.joinedProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinedProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.joinedProjectId,
            this.joinedProjectName,
            this.joinedProjectDescription,
            this.joinedProjectManager});
            this.joinedProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinedProjectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.joinedProjectsDataGridView.Name = "joinedProjectsDataGridView";
            this.joinedProjectsDataGridView.RowHeadersVisible = false;
            this.joinedProjectsDataGridView.RowTemplate.Height = 24;
            this.joinedProjectsDataGridView.Size = new System.Drawing.Size(744, 414);
            this.joinedProjectsDataGridView.TabIndex = 0;
            this.joinedProjectsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.joinedProjectsDataGridViewCellClicked);
            this.joinedProjectsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.joinedProjectsDataGridViewCellDoubleClicked);
            // 
            // invitedProjectsTabPage
            // 
            this.invitedProjectsTabPage.Controls.Add(this.invitedProjectsDataGridView);
            this.invitedProjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.invitedProjectsTabPage.Name = "invitedProjectsTabPage";
            this.invitedProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.invitedProjectsTabPage.Size = new System.Drawing.Size(750, 420);
            this.invitedProjectsTabPage.TabIndex = 1;
            this.invitedProjectsTabPage.Text = "受邀請的專案";
            this.invitedProjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // invitedProjectsDataGridView
            // 
            this.invitedProjectsDataGridView.AllowUserToAddRows = false;
            this.invitedProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invitedProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.invitedProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invitedProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invitedProjectId,
            this.invitedProjectName,
            this.invitedProjectDescription,
            this.invitedProjectManager,
            this.acceptInvitedProjectButton,
            this.denyInvitedProjectButton});
            this.invitedProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invitedProjectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.invitedProjectsDataGridView.Name = "invitedProjectsDataGridView";
            this.invitedProjectsDataGridView.RowHeadersVisible = false;
            this.invitedProjectsDataGridView.RowTemplate.Height = 24;
            this.invitedProjectsDataGridView.Size = new System.Drawing.Size(744, 414);
            this.invitedProjectsDataGridView.TabIndex = 1;
            this.invitedProjectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invitedProjectsDataGridViewCellContentClicked);
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
            this.acceptInvitedProjectButton.FillWeight = 50F;
            this.acceptInvitedProjectButton.HeaderText = "接受邀請";
            this.acceptInvitedProjectButton.Name = "acceptInvitedProjectButton";
            this.acceptInvitedProjectButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acceptInvitedProjectButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // denyInvitedProjectButton
            // 
            this.denyInvitedProjectButton.FillWeight = 50F;
            this.denyInvitedProjectButton.HeaderText = "拒絕邀請";
            this.denyInvitedProjectButton.Name = "denyInvitedProjectButton";
            this.denyInvitedProjectButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denyInvitedProjectButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // allProjectsDataGridView
            // 
            this.allProjectsDataGridView.AllowUserToAddRows = false;
            this.allProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.allProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectId,
            this.projectName,
            this.description,
            this.projectManager});
            this.allProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProjectsDataGridView.Location = new System.Drawing.Point(10, 10);
            this.allProjectsDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.allProjectsDataGridView.Name = "allProjectsDataGridView";
            this.allProjectsDataGridView.RowHeadersVisible = false;
            this.allProjectsDataGridView.RowTemplate.Height = 24;
            this.allProjectsDataGridView.Size = new System.Drawing.Size(764, 472);
            this.allProjectsDataGridView.TabIndex = 2;
            // 
            // projectId
            // 
            this.projectId.FillWeight = 21.31845F;
            this.projectId.HeaderText = "ID";
            this.projectId.Name = "projectId";
            // 
            // projectName
            // 
            this.projectName.FillWeight = 57.54066F;
            this.projectName.HeaderText = "專案名稱";
            this.projectName.Name = "projectName";
            // 
            // description
            // 
            this.description.FillWeight = 286.7903F;
            this.description.HeaderText = "簡介";
            this.description.Name = "description";
            // 
            // projectManager
            // 
            this.projectManager.FillWeight = 83.58919F;
            this.projectManager.HeaderText = "負責人";
            this.projectManager.Name = "projectManager";
            // 
            // systemManagerTableLayoutPanel
            // 
            this.systemManagerTableLayoutPanel.ColumnCount = 1;
            this.systemManagerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.systemManagerTableLayoutPanel.Controls.Add(this.allProjectsDataGridView, 0, 0);
            this.systemManagerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemManagerTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.systemManagerTableLayoutPanel.Name = "systemManagerTableLayoutPanel";
            this.systemManagerTableLayoutPanel.RowCount = 2;
            this.systemManagerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.systemManagerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.systemManagerTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.systemManagerTableLayoutPanel.TabIndex = 2;
            // 
            // joinedProjectId
            // 
            this.joinedProjectId.FillWeight = 24.83928F;
            this.joinedProjectId.HeaderText = "ID";
            this.joinedProjectId.Name = "joinedProjectId";
            this.joinedProjectId.ReadOnly = true;
            // 
            // joinedProjectName
            // 
            this.joinedProjectName.FillWeight = 116.1236F;
            this.joinedProjectName.HeaderText = "專案名稱";
            this.joinedProjectName.Name = "joinedProjectName";
            this.joinedProjectName.ReadOnly = true;
            // 
            // joinedProjectDescription
            // 
            this.joinedProjectDescription.FillWeight = 239.4765F;
            this.joinedProjectDescription.HeaderText = "簡介";
            this.joinedProjectDescription.Name = "joinedProjectDescription";
            this.joinedProjectDescription.ReadOnly = true;
            // 
            // joinedProjectManager
            // 
            this.joinedProjectManager.FillWeight = 63.45178F;
            this.joinedProjectManager.HeaderText = "專案管理員";
            this.joinedProjectManager.Name = "joinedProjectManager";
            this.joinedProjectManager.ReadOnly = true;
            // 
            // ProjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.generalUserTableLayoutPanel);
            this.Controls.Add(this.systemManagerTableLayoutPanel);
            this.Name = "ProjectListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "專案列表  - Issue Tracking System";
            this.Load += new System.EventHandler(this.projectListViewLoad);
            this.Controls.SetChildIndex(this.systemManagerTableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.generalUserTableLayoutPanel, 0);
            this.generalUserTableLayoutPanel.ResumeLayout(false);
            this.projectTabControl.ResumeLayout(false);
            this.joinedProjectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.joinedProjectsDataGridView)).EndInit();
            this.invitedProjectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invitedProjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProjectsDataGridView)).EndInit();
            this.systemManagerTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel generalUserTableLayoutPanel;
        private System.Windows.Forms.TabControl projectTabControl;
        private System.Windows.Forms.TabPage joinedProjectsTabPage;
        private System.Windows.Forms.DataGridView joinedProjectsDataGridView;
        private System.Windows.Forms.TabPage invitedProjectsTabPage;
        private System.Windows.Forms.DataGridView invitedProjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn invitedProjectManager;
        private System.Windows.Forms.DataGridViewButtonColumn acceptInvitedProjectButton;
        private System.Windows.Forms.DataGridViewButtonColumn denyInvitedProjectButton;
        private System.Windows.Forms.DataGridView allProjectsDataGridView;
        private System.Windows.Forms.TableLayoutPanel systemManagerTableLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinedProjectManager;
    }
}
