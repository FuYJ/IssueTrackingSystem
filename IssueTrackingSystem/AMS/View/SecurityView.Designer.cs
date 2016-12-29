namespace IssueTrackingSystem.AMS.View
{
    partial class SecurityView
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
            this.viewInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editButton = new System.Windows.Forms.Button();
            this.securityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewUsersButton = new System.Windows.Forms.Button();
            this.viewIssuesButton = new System.Windows.Forms.Button();
            this.viewProjectsButton = new System.Windows.Forms.Button();
            this.usersNumberLabel = new System.Windows.Forms.Label();
            this.issuesNumberLabel = new System.Windows.Forms.Label();
            this.projectsNumberLabel = new System.Windows.Forms.Label();
            this.usersNumberTitleLabel = new System.Windows.Forms.Label();
            this.issuesNumberTitleLabel = new System.Windows.Forms.Label();
            this.projectsNumberTitleLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailAddressTitleLabel = new System.Windows.Forms.Label();
            this.usernameTitleLabel = new System.Windows.Forms.Label();
            this.editInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.finishEditButton = new System.Windows.Forms.Button();
            this.editSecurityInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.editSecurityInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.editEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.editPasswordTextBox = new System.Windows.Forms.TextBox();
            this.editConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.editPassworLabel = new System.Windows.Forms.Label();
            this.editEmailAddressLabel = new System.Windows.Forms.Label();
            this.editUsernameLabel = new System.Windows.Forms.Label();
            this.editUsernameTextBox = new System.Windows.Forms.TextBox();
            this.viewInfoTableLayoutPanel.SuspendLayout();
            this.securityTableLayoutPanel.SuspendLayout();
            this.editInfoTableLayoutPanel.SuspendLayout();
            this.editSecurityInfoGroupBox.SuspendLayout();
            this.editSecurityInfoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewInfoTableLayoutPanel
            // 
            this.viewInfoTableLayoutPanel.ColumnCount = 4;
            this.viewInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.viewInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
            this.viewInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.viewInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.viewInfoTableLayoutPanel.Controls.Add(this.editButton, 2, 0);
            this.viewInfoTableLayoutPanel.Controls.Add(this.securityTableLayoutPanel, 1, 1);
            this.viewInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewInfoTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.viewInfoTableLayoutPanel.Name = "viewInfoTableLayoutPanel";
            this.viewInfoTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.viewInfoTableLayoutPanel.RowCount = 3;
            this.viewInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.viewInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.viewInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewInfoTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.viewInfoTableLayoutPanel.TabIndex = 3;
            // 
            // editButton
            // 
            this.viewInfoTableLayoutPanel.SetColumnSpan(this.editButton, 2);
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(662, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 43);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "編輯資料";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButtonClicked);
            // 
            // securityTableLayoutPanel
            // 
            this.securityTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.securityTableLayoutPanel.ColumnCount = 3;
            this.viewInfoTableLayoutPanel.SetColumnSpan(this.securityTableLayoutPanel, 2);
            this.securityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.securityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.Controls.Add(this.viewUsersButton, 2, 4);
            this.securityTableLayoutPanel.Controls.Add(this.viewIssuesButton, 2, 3);
            this.securityTableLayoutPanel.Controls.Add(this.viewProjectsButton, 2, 2);
            this.securityTableLayoutPanel.Controls.Add(this.usersNumberLabel, 1, 4);
            this.securityTableLayoutPanel.Controls.Add(this.issuesNumberLabel, 1, 3);
            this.securityTableLayoutPanel.Controls.Add(this.projectsNumberLabel, 1, 2);
            this.securityTableLayoutPanel.Controls.Add(this.usersNumberTitleLabel, 0, 4);
            this.securityTableLayoutPanel.Controls.Add(this.issuesNumberTitleLabel, 0, 3);
            this.securityTableLayoutPanel.Controls.Add(this.projectsNumberTitleLabel, 0, 2);
            this.securityTableLayoutPanel.Controls.Add(this.emailAddressLabel, 1, 1);
            this.securityTableLayoutPanel.Controls.Add(this.usernameLabel, 1, 0);
            this.securityTableLayoutPanel.Controls.Add(this.emailAddressTitleLabel, 0, 1);
            this.securityTableLayoutPanel.Controls.Add(this.usernameTitleLabel, 0, 0);
            this.securityTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securityTableLayoutPanel.Location = new System.Drawing.Point(70, 62);
            this.securityTableLayoutPanel.Name = "securityTableLayoutPanel";
            this.securityTableLayoutPanel.RowCount = 5;
            this.securityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.securityTableLayoutPanel.Size = new System.Drawing.Size(643, 387);
            this.securityTableLayoutPanel.TabIndex = 1;
            // 
            // viewUsersButton
            // 
            this.viewUsersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUsersButton.Location = new System.Drawing.Point(516, 310);
            this.viewUsersButton.Name = "viewUsersButton";
            this.viewUsersButton.Size = new System.Drawing.Size(121, 71);
            this.viewUsersButton.TabIndex = 15;
            this.viewUsersButton.Text = "查看使用者列表";
            this.viewUsersButton.UseVisualStyleBackColor = true;
            this.viewUsersButton.Click += new System.EventHandler(this.viewUsersButtonClicked);
            // 
            // viewIssuesButton
            // 
            this.viewIssuesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewIssuesButton.Location = new System.Drawing.Point(516, 234);
            this.viewIssuesButton.Name = "viewIssuesButton";
            this.viewIssuesButton.Size = new System.Drawing.Size(121, 67);
            this.viewIssuesButton.TabIndex = 14;
            this.viewIssuesButton.Text = "查看議題列表";
            this.viewIssuesButton.UseVisualStyleBackColor = true;
            this.viewIssuesButton.Click += new System.EventHandler(this.viewIssuesButtonClicked);
            // 
            // viewProjectsButton
            // 
            this.viewProjectsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProjectsButton.Location = new System.Drawing.Point(516, 158);
            this.viewProjectsButton.Name = "viewProjectsButton";
            this.viewProjectsButton.Size = new System.Drawing.Size(121, 67);
            this.viewProjectsButton.TabIndex = 13;
            this.viewProjectsButton.Text = "查看專案列表";
            this.viewProjectsButton.UseVisualStyleBackColor = true;
            this.viewProjectsButton.Click += new System.EventHandler(this.viewProjectsButtonClicked);
            // 
            // usersNumberLabel
            // 
            this.usersNumberLabel.AutoSize = true;
            this.usersNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersNumberLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usersNumberLabel.Location = new System.Drawing.Point(135, 307);
            this.usersNumberLabel.Name = "usersNumberLabel";
            this.usersNumberLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.usersNumberLabel.Size = new System.Drawing.Size(372, 77);
            this.usersNumberLabel.TabIndex = 12;
            this.usersNumberLabel.Text = "1";
            this.usersNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // issuesNumberLabel
            // 
            this.issuesNumberLabel.AutoSize = true;
            this.issuesNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuesNumberLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issuesNumberLabel.Location = new System.Drawing.Point(135, 231);
            this.issuesNumberLabel.Name = "issuesNumberLabel";
            this.issuesNumberLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issuesNumberLabel.Size = new System.Drawing.Size(372, 73);
            this.issuesNumberLabel.TabIndex = 11;
            this.issuesNumberLabel.Text = "1";
            this.issuesNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // projectsNumberLabel
            // 
            this.projectsNumberLabel.AutoSize = true;
            this.projectsNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsNumberLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectsNumberLabel.Location = new System.Drawing.Point(135, 155);
            this.projectsNumberLabel.Name = "projectsNumberLabel";
            this.projectsNumberLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.projectsNumberLabel.Size = new System.Drawing.Size(372, 73);
            this.projectsNumberLabel.TabIndex = 10;
            this.projectsNumberLabel.Text = "1";
            this.projectsNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usersNumberTitleLabel
            // 
            this.usersNumberTitleLabel.AutoSize = true;
            this.usersNumberTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersNumberTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usersNumberTitleLabel.Location = new System.Drawing.Point(6, 307);
            this.usersNumberTitleLabel.Name = "usersNumberTitleLabel";
            this.usersNumberTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.usersNumberTitleLabel.Size = new System.Drawing.Size(120, 77);
            this.usersNumberTitleLabel.TabIndex = 9;
            this.usersNumberTitleLabel.Text = "系統使用者總數";
            this.usersNumberTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // issuesNumberTitleLabel
            // 
            this.issuesNumberTitleLabel.AutoSize = true;
            this.issuesNumberTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuesNumberTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.issuesNumberTitleLabel.Location = new System.Drawing.Point(6, 231);
            this.issuesNumberTitleLabel.Name = "issuesNumberTitleLabel";
            this.issuesNumberTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.issuesNumberTitleLabel.Size = new System.Drawing.Size(120, 73);
            this.issuesNumberTitleLabel.TabIndex = 8;
            this.issuesNumberTitleLabel.Text = "系統議題總數";
            this.issuesNumberTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // projectsNumberTitleLabel
            // 
            this.projectsNumberTitleLabel.AutoSize = true;
            this.projectsNumberTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsNumberTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.projectsNumberTitleLabel.Location = new System.Drawing.Point(6, 155);
            this.projectsNumberTitleLabel.Name = "projectsNumberTitleLabel";
            this.projectsNumberTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.projectsNumberTitleLabel.Size = new System.Drawing.Size(120, 73);
            this.projectsNumberTitleLabel.TabIndex = 7;
            this.projectsNumberTitleLabel.Text = "系統專案總數";
            this.projectsNumberTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailAddressLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.emailAddressLabel.Location = new System.Drawing.Point(135, 79);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.emailAddressLabel.Size = new System.Drawing.Size(372, 73);
            this.emailAddressLabel.TabIndex = 6;
            this.emailAddressLabel.Text = "asdfg@123.email.com";
            this.emailAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameLabel.Location = new System.Drawing.Point(135, 3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(372, 73);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Mary";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailAddressTitleLabel
            // 
            this.emailAddressTitleLabel.AutoSize = true;
            this.emailAddressTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailAddressTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.emailAddressTitleLabel.Location = new System.Drawing.Point(6, 79);
            this.emailAddressTitleLabel.Name = "emailAddressTitleLabel";
            this.emailAddressTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.emailAddressTitleLabel.Size = new System.Drawing.Size(120, 73);
            this.emailAddressTitleLabel.TabIndex = 1;
            this.emailAddressTitleLabel.Text = "Email";
            this.emailAddressTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameTitleLabel
            // 
            this.usernameTitleLabel.AutoSize = true;
            this.usernameTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usernameTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.usernameTitleLabel.Name = "usernameTitleLabel";
            this.usernameTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.usernameTitleLabel.Size = new System.Drawing.Size(120, 73);
            this.usernameTitleLabel.TabIndex = 0;
            this.usernameTitleLabel.Text = "管理者名稱";
            this.usernameTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editInfoTableLayoutPanel
            // 
            this.editInfoTableLayoutPanel.ColumnCount = 4;
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.editInfoTableLayoutPanel.Controls.Add(this.finishEditButton, 2, 0);
            this.editInfoTableLayoutPanel.Controls.Add(this.editSecurityInfoGroupBox, 1, 1);
            this.editInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editInfoTableLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.editInfoTableLayoutPanel.Name = "editInfoTableLayoutPanel";
            this.editInfoTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.editInfoTableLayoutPanel.RowCount = 3;
            this.editInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.editInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.editInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editInfoTableLayoutPanel.Size = new System.Drawing.Size(784, 512);
            this.editInfoTableLayoutPanel.TabIndex = 4;
            this.editInfoTableLayoutPanel.Visible = false;
            // 
            // finishEditButton
            // 
            this.editInfoTableLayoutPanel.SetColumnSpan(this.finishEditButton, 2);
            this.finishEditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishEditButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.finishEditButton.Location = new System.Drawing.Point(662, 13);
            this.finishEditButton.Name = "finishEditButton";
            this.finishEditButton.Size = new System.Drawing.Size(109, 43);
            this.finishEditButton.TabIndex = 0;
            this.finishEditButton.Text = "編輯完成";
            this.finishEditButton.UseVisualStyleBackColor = true;
            this.finishEditButton.Click += new System.EventHandler(this.finishEditButtonClicked);
            // 
            // editSecurityInfoGroupBox
            // 
            this.editInfoTableLayoutPanel.SetColumnSpan(this.editSecurityInfoGroupBox, 2);
            this.editSecurityInfoGroupBox.Controls.Add(this.editSecurityInfoTableLayoutPanel);
            this.editSecurityInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSecurityInfoGroupBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editSecurityInfoGroupBox.Location = new System.Drawing.Point(70, 62);
            this.editSecurityInfoGroupBox.Name = "editSecurityInfoGroupBox";
            this.editSecurityInfoGroupBox.Size = new System.Drawing.Size(643, 387);
            this.editSecurityInfoGroupBox.TabIndex = 2;
            this.editSecurityInfoGroupBox.TabStop = false;
            this.editSecurityInfoGroupBox.Text = "編輯管理者資料";
            // 
            // editSecurityInfoTableLayoutPanel
            // 
            this.editSecurityInfoTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.editSecurityInfoTableLayoutPanel.ColumnCount = 2;
            this.editSecurityInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.editSecurityInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.editSecurityInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editConfirmPasswordTextBox, 1, 2);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editEmailAddressTextBox, 1, 3);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editPasswordTextBox, 1, 1);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editConfirmPasswordLabel, 0, 2);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editPassworLabel, 0, 1);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editEmailAddressLabel, 0, 3);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editUsernameLabel, 0, 0);
            this.editSecurityInfoTableLayoutPanel.Controls.Add(this.editUsernameTextBox, 1, 0);
            this.editSecurityInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSecurityInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.editSecurityInfoTableLayoutPanel.Name = "editSecurityInfoTableLayoutPanel";
            this.editSecurityInfoTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.editSecurityInfoTableLayoutPanel.RowCount = 4;
            this.editSecurityInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editSecurityInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editSecurityInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editSecurityInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editSecurityInfoTableLayoutPanel.Size = new System.Drawing.Size(637, 361);
            this.editSecurityInfoTableLayoutPanel.TabIndex = 1;
            // 
            // editConfirmPasswordTextBox
            // 
            this.editConfirmPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editConfirmPasswordTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editConfirmPasswordTextBox.Location = new System.Drawing.Point(159, 184);
            this.editConfirmPasswordTextBox.Name = "editConfirmPasswordTextBox";
            this.editConfirmPasswordTextBox.PasswordChar = '‧';
            this.editConfirmPasswordTextBox.Size = new System.Drawing.Size(452, 27);
            this.editConfirmPasswordTextBox.TabIndex = 7;
            this.editConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.editConfirmPasswordTextBoxTextChanged);
            // 
            // editEmailAddressTextBox
            // 
            this.editEmailAddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editEmailAddressTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editEmailAddressTextBox.Location = new System.Drawing.Point(159, 273);
            this.editEmailAddressTextBox.Name = "editEmailAddressTextBox";
            this.editEmailAddressTextBox.Size = new System.Drawing.Size(452, 27);
            this.editEmailAddressTextBox.TabIndex = 6;
            // 
            // editPasswordTextBox
            // 
            this.editPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPasswordTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editPasswordTextBox.Location = new System.Drawing.Point(159, 95);
            this.editPasswordTextBox.Name = "editPasswordTextBox";
            this.editPasswordTextBox.PasswordChar = '‧';
            this.editPasswordTextBox.Size = new System.Drawing.Size(452, 27);
            this.editPasswordTextBox.TabIndex = 5;
            // 
            // editConfirmPasswordLabel
            // 
            this.editConfirmPasswordLabel.AutoSize = true;
            this.editConfirmPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editConfirmPasswordLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editConfirmPasswordLabel.Location = new System.Drawing.Point(26, 181);
            this.editConfirmPasswordLabel.Name = "editConfirmPasswordLabel";
            this.editConfirmPasswordLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.editConfirmPasswordLabel.Size = new System.Drawing.Size(124, 86);
            this.editConfirmPasswordLabel.TabIndex = 3;
            this.editConfirmPasswordLabel.Text = "密碼再確認";
            this.editConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editPassworLabel
            // 
            this.editPassworLabel.AutoSize = true;
            this.editPassworLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPassworLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editPassworLabel.Location = new System.Drawing.Point(26, 92);
            this.editPassworLabel.Name = "editPassworLabel";
            this.editPassworLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.editPassworLabel.Size = new System.Drawing.Size(124, 86);
            this.editPassworLabel.TabIndex = 2;
            this.editPassworLabel.Text = "密碼";
            this.editPassworLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editEmailAddressLabel
            // 
            this.editEmailAddressLabel.AutoSize = true;
            this.editEmailAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editEmailAddressLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editEmailAddressLabel.Location = new System.Drawing.Point(26, 270);
            this.editEmailAddressLabel.Name = "editEmailAddressLabel";
            this.editEmailAddressLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.editEmailAddressLabel.Size = new System.Drawing.Size(124, 88);
            this.editEmailAddressLabel.TabIndex = 1;
            this.editEmailAddressLabel.Text = "E-mail";
            this.editEmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editUsernameLabel
            // 
            this.editUsernameLabel.AutoSize = true;
            this.editUsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUsernameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editUsernameLabel.Location = new System.Drawing.Point(26, 3);
            this.editUsernameLabel.Name = "editUsernameLabel";
            this.editUsernameLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.editUsernameLabel.Size = new System.Drawing.Size(124, 86);
            this.editUsernameLabel.TabIndex = 0;
            this.editUsernameLabel.Text = "管理者名稱";
            this.editUsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editUsernameTextBox
            // 
            this.editUsernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUsernameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editUsernameTextBox.Location = new System.Drawing.Point(159, 6);
            this.editUsernameTextBox.Name = "editUsernameTextBox";
            this.editUsernameTextBox.Size = new System.Drawing.Size(452, 27);
            this.editUsernameTextBox.TabIndex = 4;
            // 
            // SecurityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.viewInfoTableLayoutPanel);
            this.Controls.Add(this.editInfoTableLayoutPanel);
            this.Name = "SecurityView";
            this.Text = "管理者資料 - Issue Tracking System";
            this.Controls.SetChildIndex(this.editInfoTableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.viewInfoTableLayoutPanel, 0);
            this.viewInfoTableLayoutPanel.ResumeLayout(false);
            this.securityTableLayoutPanel.ResumeLayout(false);
            this.securityTableLayoutPanel.PerformLayout();
            this.editInfoTableLayoutPanel.ResumeLayout(false);
            this.editSecurityInfoGroupBox.ResumeLayout(false);
            this.editSecurityInfoTableLayoutPanel.ResumeLayout(false);
            this.editSecurityInfoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel viewInfoTableLayoutPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TableLayoutPanel securityTableLayoutPanel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailAddressTitleLabel;
        private System.Windows.Forms.Label usernameTitleLabel;
        private System.Windows.Forms.TableLayoutPanel editInfoTableLayoutPanel;
        private System.Windows.Forms.Button finishEditButton;
        private System.Windows.Forms.GroupBox editSecurityInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel editSecurityInfoTableLayoutPanel;
        private System.Windows.Forms.TextBox editConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox editEmailAddressTextBox;
        private System.Windows.Forms.TextBox editPasswordTextBox;
        private System.Windows.Forms.Label editConfirmPasswordLabel;
        private System.Windows.Forms.Label editPassworLabel;
        private System.Windows.Forms.Label editEmailAddressLabel;
        private System.Windows.Forms.Label editUsernameLabel;
        private System.Windows.Forms.TextBox editUsernameTextBox;
        private System.Windows.Forms.Label projectsNumberTitleLabel;
        private System.Windows.Forms.Label usersNumberLabel;
        private System.Windows.Forms.Label issuesNumberLabel;
        private System.Windows.Forms.Label projectsNumberLabel;
        private System.Windows.Forms.Label usersNumberTitleLabel;
        private System.Windows.Forms.Label issuesNumberTitleLabel;
        private System.Windows.Forms.Button viewUsersButton;
        private System.Windows.Forms.Button viewIssuesButton;
        private System.Windows.Forms.Button viewProjectsButton;
    }
}
