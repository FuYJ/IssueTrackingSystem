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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issueTackingSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.userInfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.issueListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.projectListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.userListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.createProjectButton = new System.Windows.Forms.ToolStripButton();
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
            this.userListToolStripButton,
            this.createProjectButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // userInfoToolStripButton
            // 
            this.userInfoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("userInfoToolStripButton.Image")));
            this.userInfoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userInfoToolStripButton.Name = "userInfoToolStripButton";
            this.userInfoToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.userInfoToolStripButton.Text = "使用者資訊";
            // 
            // issueListToolStripButton
            // 
            this.issueListToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("issueListToolStripButton.Image")));
            this.issueListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.issueListToolStripButton.Name = "issueListToolStripButton";
            this.issueListToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.issueListToolStripButton.Text = "議題列表";
            // 
            // projectListToolStripButton
            // 
            this.projectListToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("projectListToolStripButton.Image")));
            this.projectListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectListToolStripButton.Name = "projectListToolStripButton";
            this.projectListToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.projectListToolStripButton.Text = "專案列表";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // userListToolStripButton
            // 
            this.userListToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("userListToolStripButton.Image")));
            this.userListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userListToolStripButton.Name = "userListToolStripButton";
            this.userListToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.userListToolStripButton.Text = "使用者列表";
            this.userListToolStripButton.Click += new System.EventHandler(this.userListToolStripButtonClicked);
            // 
            // createProjectButton
            // 
            this.createProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("createProjectButton.Image")));
            this.createProjectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(75, 22);
            this.createProjectButton.Text = "新增專案";
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButtonClicked);
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
    }
}