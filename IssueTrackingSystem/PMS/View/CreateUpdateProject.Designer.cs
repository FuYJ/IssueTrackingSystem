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
            this._errorMessage = new System.Windows.Forms.TextBox();
            this._leaveButton = new System.Windows.Forms.Button();
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
            this._projectNameText.TabStop = false;
            this._projectNameText.Text = "專案名稱:";
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
            this._destriptionText.TabStop = false;
            this._destriptionText.Text = "專案內容:";
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
            this._createUpdate.Location = new System.Drawing.Point(646, 517);
            this._createUpdate.Name = "_createUpdate";
            this._createUpdate.Size = new System.Drawing.Size(119, 32);
            this._createUpdate.TabIndex = 6;
            this._createUpdate.UseVisualStyleBackColor = true;
            this._createUpdate.Click += new System.EventHandler(this.ClickCreateUpdate);
            // 
            // _errorMessage
            // 
            this._errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._errorMessage.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._errorMessage.Location = new System.Drawing.Point(296, 512);
            this._errorMessage.Name = "_errorMessage";
            this._errorMessage.ReadOnly = true;
            this._errorMessage.Size = new System.Drawing.Size(175, 32);
            this._errorMessage.TabIndex = 7;
            this._errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _leaveButton
            // 
            this._leaveButton.Location = new System.Drawing.Point(511, 517);
            this._leaveButton.Name = "_leaveButton";
            this._leaveButton.Size = new System.Drawing.Size(119, 32);
            this._leaveButton.TabIndex = 8;
            this._leaveButton.Text = "Leave";
            this._leaveButton.UseVisualStyleBackColor = true;
            this._leaveButton.Click += new System.EventHandler(this.LeaveButtonClicked);
            // 
            // CreateUpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._leaveButton);
            this.Controls.Add(this._errorMessage);
            this.Controls.Add(this._createUpdate);
            this.Controls.Add(this._descriptionInput);
            this.Controls.Add(this._destriptionText);
            this.Controls.Add(this._projectNameInput);
            this.Controls.Add(this._projectNameText);
            this.Name = "CreateUpdateProject";
            this.Text = "CreateUpdateProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _projectNameText;
        private System.Windows.Forms.TextBox _projectNameInput;
        private System.Windows.Forms.TextBox _destriptionText;
        private System.Windows.Forms.TextBox _descriptionInput;
        private System.Windows.Forms.Button _createUpdate;
        private System.Windows.Forms.TextBox _errorMessage;
        private System.Windows.Forms.Button _leaveButton;
    }
}