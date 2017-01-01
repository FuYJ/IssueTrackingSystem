namespace IssueTrackingSystem.View
{
    partial class BaseView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issueTackingSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userInfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.issueListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.projectListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createProjectButton = new System.Windows.Forms.ToolStripButton();
            this.createIssueToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.viewReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.logoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueTackingSystemToolStripMenuItem,
            this.視窗ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issueTackingSystemToolStripMenuItem
            // 
            this.issueTackingSystemToolStripMenuItem.Name = "issueTackingSystemToolStripMenuItem";
            this.issueTackingSystemToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.issueTackingSystemToolStripMenuItem.Text = "Issue Tacking System";
            // 
            // 視窗ToolStripMenuItem
            // 
            this.視窗ToolStripMenuItem.Name = "視窗ToolStripMenuItem";
            this.視窗ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.視窗ToolStripMenuItem.Text = "視窗";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripButton,
            this.issueListToolStripButton,
            this.projectListToolStripButton,
            this.toolStripSeparator1,
            this.createProjectButton,
            this.createIssueToolStripButton,
            this.viewReportToolStripButton,
            this.toolStripSeparator2,
            this.userListToolStripButton,
            this.logoutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // userInfoToolStripButton
            // 
            this.userInfoToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.user;
            this.userInfoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userInfoToolStripButton.Name = "userInfoToolStripButton";
            this.userInfoToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.userInfoToolStripButton.Text = "使用者資訊";
            this.userInfoToolStripButton.Click += new System.EventHandler(this.userInfoToolStripButtonClicked);
            // 
            // issueListToolStripButton
            // 
            this.issueListToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.issue;
            this.issueListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.issueListToolStripButton.Name = "issueListToolStripButton";
            this.issueListToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.issueListToolStripButton.Text = "議題列表";
            this.issueListToolStripButton.Click += new System.EventHandler(this.issueListToolStripButtonClicked);
            // 
            // projectListToolStripButton
            // 
            this.projectListToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.project;
            this.projectListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectListToolStripButton.Name = "projectListToolStripButton";
            this.projectListToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.projectListToolStripButton.Text = "專案列表";
            this.projectListToolStripButton.Click += new System.EventHandler(this.projectListToolStripButtonClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // createProjectButton
            // 
            this.createProjectButton.Image = global::IssueTrackingSystem.Properties.Resources.addProject;
            this.createProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(75, 22);
            this.createProjectButton.Text = "新增專案";
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButtonClicked);
            // 
            // createIssueToolStripButton
            // 
            this.createIssueToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.createIssue;
            this.createIssueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createIssueToolStripButton.Name = "createIssueToolStripButton";
            this.createIssueToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.createIssueToolStripButton.Text = "新增議題";
            this.createIssueToolStripButton.Click += new System.EventHandler(this.addIssueToolStripButtonClicked);
            // 
            // viewReportToolStripButton
            // 
            this.viewReportToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.pieChart;
            this.viewReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewReportToolStripButton.Name = "viewReportToolStripButton";
            this.viewReportToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.viewReportToolStripButton.Text = "查看報表";
            this.viewReportToolStripButton.Click += new System.EventHandler(this.viewReportToolStripButtonClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userListToolStripButton
            // 
            this.userListToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.users;
            this.userListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userListToolStripButton.Name = "userListToolStripButton";
            this.userListToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.userListToolStripButton.Text = "使用者列表";
            this.userListToolStripButton.Click += new System.EventHandler(this.userListToolStripButtonClicked);
            // 
            // logoutToolStripButton
            // 
            this.logoutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripButton.Enabled = false;
            this.logoutToolStripButton.Image = global::IssueTrackingSystem.Properties.Resources.sign_out;
            this.logoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutToolStripButton.Name = "logoutToolStripButton";
            this.logoutToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.logoutToolStripButton.Text = "登出";
            this.logoutToolStripButton.Visible = false;
            this.logoutToolStripButton.Click += new System.EventHandler(this.logoutToolStripButtonClicked);
            // 
            // BaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseView";
            this.Text = "null";
            this.Load += new System.EventHandler(this.BaseViewLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issueTackingSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton userInfoToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton issueListToolStripButton;
        private System.Windows.Forms.ToolStripButton projectListToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton userListToolStripButton;
        private System.Windows.Forms.ToolStripButton createProjectButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton createIssueToolStripButton;
        private System.Windows.Forms.ToolStripButton viewReportToolStripButton;
        protected System.Windows.Forms.ToolStripButton logoutToolStripButton;
    }
}