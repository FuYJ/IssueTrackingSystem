namespace IssueTrackingSystem.PMS.View
{
    partial class CreateUpdateProject
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
            this._projectNameText = new System.Windows.Forms.TextBox();
            this._projectNameInput = new System.Windows.Forms.TextBox();
            this._destriptionText = new System.Windows.Forms.TextBox();
            this._descriptionInput = new System.Windows.Forms.TextBox();
            this._createUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _projectNameText
            // 
            this._projectNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectNameText.Location = new System.Drawing.Point(91, 81);
            this._projectNameText.Name = "_projectNameText";
            this._projectNameText.ReadOnly = true;
            this._projectNameText.Size = new System.Drawing.Size(100, 15);
            this._projectNameText.TabIndex = 2;
            this._projectNameText.Text = "ProjectName:";
            this._projectNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _projectNameInput
            // 
            this._projectNameInput.Location = new System.Drawing.Point(197, 78);
            this._projectNameInput.Name = "_projectNameInput";
            this._projectNameInput.Size = new System.Drawing.Size(439, 22);
            this._projectNameInput.TabIndex = 3;
            // 
            // _destriptionText
            // 
            this._destriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._destriptionText.Location = new System.Drawing.Point(81, 126);
            this._destriptionText.Name = "_destriptionText";
            this._destriptionText.ReadOnly = true;
            this._destriptionText.Size = new System.Drawing.Size(100, 15);
            this._destriptionText.TabIndex = 4;
            this._destriptionText.Text = "Destription:";
            this._destriptionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _descriptionInput
            // 
            this._descriptionInput.Location = new System.Drawing.Point(127, 147);
            this._descriptionInput.Multiline = true;
            this._descriptionInput.Name = "_descriptionInput";
            this._descriptionInput.Size = new System.Drawing.Size(509, 349);
            this._descriptionInput.TabIndex = 5;
            // 
            // _createUpdate
            // 
            this._createUpdate.Location = new System.Drawing.Point(639, 517);
            this._createUpdate.Name = "_createUpdate";
            this._createUpdate.Size = new System.Drawing.Size(119, 32);
            this._createUpdate.TabIndex = 6;
            this._createUpdate.UseVisualStyleBackColor = true;
            // 
            // CreateUpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._createUpdate);
            this.Controls.Add(this._descriptionInput);
            this.Controls.Add(this._destriptionText);
            this.Controls.Add(this._projectNameInput);
            this.Controls.Add(this._projectNameText);
            this.Name = "CreateUpdateProject";
            this.Text = "CreateUpdateProject";
            this.Controls.SetChildIndex(this._projectNameText, 0);
            this.Controls.SetChildIndex(this._projectNameInput, 0);
            this.Controls.SetChildIndex(this._destriptionText, 0);
            this.Controls.SetChildIndex(this._descriptionInput, 0);
            this.Controls.SetChildIndex(this._createUpdate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _projectNameText;
        private System.Windows.Forms.TextBox _projectNameInput;
        private System.Windows.Forms.TextBox _destriptionText;
        private System.Windows.Forms.TextBox _descriptionInput;
        private System.Windows.Forms.Button _createUpdate;
    }
}