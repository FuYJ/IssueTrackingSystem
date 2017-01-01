namespace IssueTrackingSystem.AMS.View
{
    partial class LoginView
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.loginGroupBox, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.statusStrip1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(584, 361);
            this.mainTableLayoutPanel.TabIndex = 2;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.loginGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginGroupBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginGroupBox.Location = new System.Drawing.Point(119, 75);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(344, 210);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "登入";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.registerButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // registerButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.registerButton, 2);
            this.registerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.registerButton.Location = new System.Drawing.Point(3, 141);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(332, 40);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "註冊新帳號";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButtonClicked);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameTextBox.Location = new System.Drawing.Point(104, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(231, 27);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordTextBox.Location = new System.Drawing.Point(104, 49);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '‧';
            this.passwordTextBox.Size = new System.Drawing.Size(231, 27);
            this.passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.loginButton, 2);
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginButton.Location = new System.Drawing.Point(3, 95);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(332, 40);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "登入";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButtonClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(95, 46);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "使用者名稱";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordLabel.Location = new System.Drawing.Point(3, 46);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.passwordLabel.Size = new System.Drawing.Size(95, 46);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "密碼";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}