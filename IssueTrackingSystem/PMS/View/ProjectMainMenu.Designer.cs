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
            this._projectName = new System.Windows.Forms.TextBox();
            this._memberList = new System.Windows.Forms.Button();
            this._descriptionButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._issueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _projectName
            // 
            this._projectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectName.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._projectName.Location = new System.Drawing.Point(211, 79);
            this._projectName.Name = "_projectName";
            this._projectName.ReadOnly = true;
            this._projectName.Size = new System.Drawing.Size(369, 32);
            this._projectName.TabIndex = 2;
            this._projectName.TabStop = false;
            this._projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _memberList
            // 
            this._memberList.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._memberList.Location = new System.Drawing.Point(146, 166);
            this._memberList.Name = "_memberList";
            this._memberList.Size = new System.Drawing.Size(203, 102);
            this._memberList.TabIndex = 3;
            this._memberList.Text = "Member";
            this._memberList.UseVisualStyleBackColor = true;
            this._memberList.Click += new System.EventHandler(this.MemberListClicked);
            // 
            // _descriptionButton
            // 
            this._descriptionButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._descriptionButton.Location = new System.Drawing.Point(440, 166);
            this._descriptionButton.Name = "_descriptionButton";
            this._descriptionButton.Size = new System.Drawing.Size(203, 102);
            this._descriptionButton.TabIndex = 4;
            this._descriptionButton.Text = "Description";
            this._descriptionButton.UseVisualStyleBackColor = true;
            this._descriptionButton.Click += new System.EventHandler(this.DescriptionButtonClicked);
            // 
            // _deleteButton
            // 
            this._deleteButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._deleteButton.Location = new System.Drawing.Point(440, 312);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(203, 102);
            this._deleteButton.TabIndex = 5;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButtonClicked);
            // 
            // _issueButton
            // 
            this._issueButton.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._issueButton.Location = new System.Drawing.Point(146, 312);
            this._issueButton.Name = "_issueButton";
            this._issueButton.Size = new System.Drawing.Size(203, 102);
            this._issueButton.TabIndex = 6;
            this._issueButton.Text = "Issue";
            this._issueButton.UseVisualStyleBackColor = true;
            // 
            // ProjectMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._issueButton);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._descriptionButton);
            this.Controls.Add(this._memberList);
            this.Controls.Add(this._projectName);
            this.Name = "ProjectMainMenu";
            this.Text = "ProjectMainMenu";
            this.Controls.SetChildIndex(this._projectName, 0);
            this.Controls.SetChildIndex(this._memberList, 0);
            this.Controls.SetChildIndex(this._descriptionButton, 0);
            this.Controls.SetChildIndex(this._deleteButton, 0);
            this.Controls.SetChildIndex(this._issueButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _projectName;
        private System.Windows.Forms.Button _memberList;
        private System.Windows.Forms.Button _descriptionButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _issueButton;
    }
}