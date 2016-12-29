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
            this.button1 = new System.Windows.Forms.Button();
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
            this._memberList.Location = new System.Drawing.Point(304, 158);
            this._memberList.Name = "_memberList";
            this._memberList.Size = new System.Drawing.Size(203, 102);
            this._memberList.TabIndex = 3;
            this._memberList.Text = "Member";
            this._memberList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(304, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 102);
            this.button1.TabIndex = 4;
            this.button1.Text = "Description";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProjectMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._memberList);
            this.Controls.Add(this._projectName);
            this.Name = "ProjectMainMenu";
            this.Text = "ProjectMainMenu";
            this.Controls.SetChildIndex(this._projectName, 0);
            this.Controls.SetChildIndex(this._memberList, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _projectName;
        private System.Windows.Forms.Button _memberList;
        private System.Windows.Forms.Button button1;
    }
}