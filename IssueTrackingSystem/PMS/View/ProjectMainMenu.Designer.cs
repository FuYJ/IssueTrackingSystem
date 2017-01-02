namespace IssueTrackingSystem.PMS.View
{
    partial class ProjectMainMenu
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
            this._errorMessage = new System.Windows.Forms.TextBox();
            this._issueButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._descriptionButton = new System.Windows.Forms.Button();
            this._memberList = new System.Windows.Forms.Button();
            this._projectName = new System.Windows.Forms.TextBox();
            this._leaveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 8;
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
            // _errorMessage
            // 
            this._errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._errorMessage.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._errorMessage.Location = new System.Drawing.Point(302, 517);
            this._errorMessage.Name = "_errorMessage";
            this._errorMessage.ReadOnly = true;
            this._errorMessage.Size = new System.Drawing.Size(171, 32);
            this._errorMessage.TabIndex = 7;
            this._errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _issueButton
            // 
            this._issueButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._issueButton.Location = new System.Drawing.Point(146, 258);
            this._issueButton.Name = "_issueButton";
            this._issueButton.Size = new System.Drawing.Size(203, 102);
            this._issueButton.TabIndex = 6;
            this._issueButton.Text = "Issue";
            this._issueButton.UseVisualStyleBackColor = true;
            this._issueButton.Click += new System.EventHandler(this.IssueButtonClicked);
            // 
            // _deleteButton
            // 
            this._deleteButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._deleteButton.Location = new System.Drawing.Point(440, 258);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(203, 102);
            this._deleteButton.TabIndex = 5;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButtonClicked);
            // 
            // _descriptionButton
            // 
            this._descriptionButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._descriptionButton.Location = new System.Drawing.Point(440, 112);
            this._descriptionButton.Name = "_descriptionButton";
            this._descriptionButton.Size = new System.Drawing.Size(203, 102);
            this._descriptionButton.TabIndex = 4;
            this._descriptionButton.Text = "Description";
            this._descriptionButton.UseVisualStyleBackColor = true;
            this._descriptionButton.Click += new System.EventHandler(this.DescriptionButtonClicked);
            // 
            // _memberList
            // 
            this._memberList.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._memberList.Location = new System.Drawing.Point(146, 112);
            this._memberList.Name = "_memberList";
            this._memberList.Size = new System.Drawing.Size(203, 102);
            this._memberList.TabIndex = 3;
            this._memberList.Text = "Member";
            this._memberList.UseVisualStyleBackColor = true;
            this._memberList.Click += new System.EventHandler(this.MemberListClicked);
            // 
            // _projectName
            // 
            this._projectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectName.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._projectName.Location = new System.Drawing.Point(211, 57);
            this._projectName.Name = "_projectName";
            this._projectName.ReadOnly = true;
            this._projectName.Size = new System.Drawing.Size(369, 32);
            this._projectName.TabIndex = 2;
            this._projectName.TabStop = false;
            this._projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _leaveButton
            // 
            this._leaveButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._leaveButton.Location = new System.Drawing.Point(286, 379);
            this._leaveButton.Name = "_leaveButton";
            this._leaveButton.Size = new System.Drawing.Size(203, 102);
            this._leaveButton.TabIndex = 9;
            this._leaveButton.Text = "Leave";
            this._leaveButton.UseVisualStyleBackColor = true;
            this._leaveButton.Click += new System.EventHandler(this.LeaveButtonClicked);
            // 
            // ProjectMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._leaveButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._errorMessage);
            this.Controls.Add(this._issueButton);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._descriptionButton);
            this.Controls.Add(this._memberList);
            this.Controls.Add(this._projectName);
            this.Name = "ProjectMainMenu";
            this.Text = "ProjectMainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issueTackingSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
        private System.Windows.Forms.TextBox _errorMessage;
        private System.Windows.Forms.Button _issueButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _descriptionButton;
        private System.Windows.Forms.Button _memberList;
        private System.Windows.Forms.TextBox _projectName;
        private System.Windows.Forms.Button _leaveButton;
    }
}