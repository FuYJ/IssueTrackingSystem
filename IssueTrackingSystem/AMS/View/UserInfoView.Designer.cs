namespace IssueTrackingSystem.AMS.View
{
    partial class UserInfoView
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
            this.userInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewInvitedProjectsButton = new System.Windows.Forms.Button();
            this.viewJoinedProjectsButton = new System.Windows.Forms.Button();
            this.trackingIssueNumberLabel = new System.Windows.Forms.Label();
            this.invitedProjectNumberLabel = new System.Windows.Forms.Label();
            this.joinedProjectNumberLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.trackingIssueNumberTitleLabel = new System.Windows.Forms.Label();
            this.invitedProjectNumberTitleLabel = new System.Windows.Forms.Label();
            this.joinedProjectNumberTitleLabel = new System.Windows.Forms.Label();
            this.emailAddressTitleLabel = new System.Windows.Forms.Label();
            this.usernameTitleLabel = new System.Windows.Forms.Label();
            this.viewIssuesButton = new System.Windows.Forms.Button();
            this.editInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.finishEditButton = new System.Windows.Forms.Button();
            this.editUserInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.editUserInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.editEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.editPasswordTextBox = new System.Windows.Forms.TextBox();
            this.editConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.editPassworLabel = new System.Windows.Forms.Label();
            this.editEmailAddressLabel = new System.Windows.Forms.Label();
            this.editUsernameLabel = new System.Windows.Forms.Label();
            this.editUsernameTextBox = new System.Windows.Forms.TextBox();
            this.viewInfoTableLayoutPanel.SuspendLayout();
            this.userInfoTableLayoutPanel.SuspendLayout();
            this.editInfoTableLayoutPanel.SuspendLayout();
            this.editUserInfoGroupBox.SuspendLayout();
            this.editUserInfoTableLayoutPanel.SuspendLayout();
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
            this.viewInfoTableLayoutPanel.Controls.Add(this.userInfoTableLayoutPanel, 1, 1);
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
            this.viewInfoTableLayoutPanel.TabIndex = 2;
            // 
            // editButton
            // 
            this.viewInfoTableLayoutPanel.SetColumnSpan(this.editButton, 2);
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(662, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 43);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "編輯使用者資料";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButtonClicked);
            // 
            // userInfoTableLayoutPanel
            // 
            this.userInfoTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.userInfoTableLayoutPanel.ColumnCount = 3;
            this.viewInfoTableLayoutPanel.SetColumnSpan(this.userInfoTableLayoutPanel, 2);
            this.userInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.userInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.Controls.Add(this.viewInvitedProjectsButton, 2, 3);
            this.userInfoTableLayoutPanel.Controls.Add(this.viewJoinedProjectsButton, 2, 2);
            this.userInfoTableLayoutPanel.Controls.Add(this.trackingIssueNumberLabel, 1, 4);
            this.userInfoTableLayoutPanel.Controls.Add(this.invitedProjectNumberLabel, 1, 3);
            this.userInfoTableLayoutPanel.Controls.Add(this.joinedProjectNumberLabel, 1, 2);
            this.userInfoTableLayoutPanel.Controls.Add(this.emailAddressLabel, 1, 1);
            this.userInfoTableLayoutPanel.Controls.Add(this.usernameLabel, 1, 0);
            this.userInfoTableLayoutPanel.Controls.Add(this.trackingIssueNumberTitleLabel, 0, 4);
            this.userInfoTableLayoutPanel.Controls.Add(this.invitedProjectNumberTitleLabel, 0, 3);
            this.userInfoTableLayoutPanel.Controls.Add(this.joinedProjectNumberTitleLabel, 0, 2);
            this.userInfoTableLayoutPanel.Controls.Add(this.emailAddressTitleLabel, 0, 1);
            this.userInfoTableLayoutPanel.Controls.Add(this.usernameTitleLabel, 0, 0);
            this.userInfoTableLayoutPanel.Controls.Add(this.viewIssuesButton, 2, 4);
            this.userInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoTableLayoutPanel.Location = new System.Drawing.Point(70, 62);
            this.userInfoTableLayoutPanel.Name = "userInfoTableLayoutPanel";
            this.userInfoTableLayoutPanel.RowCount = 5;
            this.userInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.userInfoTableLayoutPanel.Size = new System.Drawing.Size(643, 387);
            this.userInfoTableLayoutPanel.TabIndex = 1;
            // 
            // viewInvitedProjectsButton
            // 
            this.viewInvitedProjectsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewInvitedProjectsButton.Location = new System.Drawing.Point(516, 234);
            this.viewInvitedProjectsButton.Name = "viewInvitedProjectsButton";
            this.viewInvitedProjectsButton.Size = new System.Drawing.Size(121, 67);
            this.viewInvitedProjectsButton.TabIndex = 12;
            this.viewInvitedProjectsButton.Text = "查看被邀請的專案";
            this.viewInvitedProjectsButton.UseVisualStyleBackColor = true;
            this.viewInvitedProjectsButton.Click += new System.EventHandler(this.viewInvitedProjectsButtonClicked);
            // 
            // viewJoinedProjectsButton
            // 
            this.viewJoinedProjectsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewJoinedProjectsButton.Location = new System.Drawing.Point(516, 158);
            this.viewJoinedProjectsButton.Name = "viewJoinedProjectsButton";
            this.viewJoinedProjectsButton.Size = new System.Drawing.Size(121, 67);
            this.viewJoinedProjectsButton.TabIndex = 11;
            this.viewJoinedProjectsButton.Text = "查看已加入的專案";
            this.viewJoinedProjectsButton.UseVisualStyleBackColor = true;
            this.viewJoinedProjectsButton.Click += new System.EventHandler(this.viewJoinedProjectsButtonClicked);
            // 
            // trackingIssueNumberLabel
            // 
            this.trackingIssueNumberLabel.AutoSize = true;
            this.trackingIssueNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackingIssueNumberLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trackingIssueNumberLabel.Location = new System.Drawing.Point(135, 307);
            this.trackingIssueNumberLabel.Name = "trackingIssueNumberLabel";
            this.trackingIssueNumberLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.trackingIssueNumberLabel.Size = new System.Drawing.Size(372, 77);
            this.trackingIssueNumberLabel.TabIndex = 9;
            this.trackingIssueNumberLabel.Text = "12";
            this.trackingIssueNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // invitedProjectNumberLabel
            // 
            this.invitedProjectNumberLabel.AutoSize = true;
            this.invitedProjectNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invitedProjectNumberLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.invitedProjectNumberLabel.Location = new System.Drawing.Point(135, 231);
            this.invitedProjectNumberLabel.Name = "invitedProjectNumberLabel";
            this.invitedProjectNumberLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.invitedProjectNumberLabel.Size = new System.Drawing.Size(372, 73);
            this.invitedProjectNumberLabel.TabIndex = 8;
            this.invitedProjectNumberLabel.Text = "5";
            this.invitedProjectNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // joinedProjectNumberLabel
            // 
            this.joinedProjectNumberLabel.AutoSize = true;
            this.joinedProjectNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinedProjectNumberLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.joinedProjectNumberLabel.Location = new System.Drawing.Point(135, 155);
            this.joinedProjectNumberLabel.Name = "joinedProjectNumberLabel";
            this.joinedProjectNumberLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.joinedProjectNumberLabel.Size = new System.Drawing.Size(372, 73);
            this.joinedProjectNumberLabel.TabIndex = 7;
            this.joinedProjectNumberLabel.Text = "2";
            this.joinedProjectNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // trackingIssueNumberTitleLabel
            // 
            this.trackingIssueNumberTitleLabel.AutoSize = true;
            this.trackingIssueNumberTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackingIssueNumberTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trackingIssueNumberTitleLabel.Location = new System.Drawing.Point(6, 307);
            this.trackingIssueNumberTitleLabel.Name = "trackingIssueNumberTitleLabel";
            this.trackingIssueNumberTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.trackingIssueNumberTitleLabel.Size = new System.Drawing.Size(120, 77);
            this.trackingIssueNumberTitleLabel.TabIndex = 4;
            this.trackingIssueNumberTitleLabel.Text = "追蹤中的議題數";
            this.trackingIssueNumberTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // invitedProjectNumberTitleLabel
            // 
            this.invitedProjectNumberTitleLabel.AutoSize = true;
            this.invitedProjectNumberTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invitedProjectNumberTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.invitedProjectNumberTitleLabel.Location = new System.Drawing.Point(6, 231);
            this.invitedProjectNumberTitleLabel.Name = "invitedProjectNumberTitleLabel";
            this.invitedProjectNumberTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.invitedProjectNumberTitleLabel.Size = new System.Drawing.Size(120, 73);
            this.invitedProjectNumberTitleLabel.TabIndex = 3;
            this.invitedProjectNumberTitleLabel.Text = "被邀請的專案數";
            this.invitedProjectNumberTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // joinedProjectNumberTitleLabel
            // 
            this.joinedProjectNumberTitleLabel.AutoSize = true;
            this.joinedProjectNumberTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinedProjectNumberTitleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.joinedProjectNumberTitleLabel.Location = new System.Drawing.Point(6, 155);
            this.joinedProjectNumberTitleLabel.Name = "joinedProjectNumberTitleLabel";
            this.joinedProjectNumberTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.joinedProjectNumberTitleLabel.Size = new System.Drawing.Size(120, 73);
            this.joinedProjectNumberTitleLabel.TabIndex = 2;
            this.joinedProjectNumberTitleLabel.Text = "已加入的專案數";
            this.joinedProjectNumberTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.usernameTitleLabel.Text = "使用者名稱";
            this.usernameTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viewIssuesButton
            // 
            this.viewIssuesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewIssuesButton.Location = new System.Drawing.Point(516, 310);
            this.viewIssuesButton.Name = "viewIssuesButton";
            this.viewIssuesButton.Size = new System.Drawing.Size(121, 71);
            this.viewIssuesButton.TabIndex = 10;
            this.viewIssuesButton.Text = "查看議題列表";
            this.viewIssuesButton.UseVisualStyleBackColor = true;
            this.viewIssuesButton.Click += new System.EventHandler(this.viewIssuesButtonClicked);
            // 
            // editInfoTableLayoutPanel
            // 
            this.editInfoTableLayoutPanel.ColumnCount = 4;
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.editInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.editInfoTableLayoutPanel.Controls.Add(this.finishEditButton, 2, 0);
            this.editInfoTableLayoutPanel.Controls.Add(this.editUserInfoGroupBox, 1, 1);
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
            this.editInfoTableLayoutPanel.TabIndex = 3;
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
            // editUserInfoGroupBox
            // 
            this.editInfoTableLayoutPanel.SetColumnSpan(this.editUserInfoGroupBox, 2);
            this.editUserInfoGroupBox.Controls.Add(this.editUserInfoTableLayoutPanel);
            this.editUserInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUserInfoGroupBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editUserInfoGroupBox.Location = new System.Drawing.Point(70, 62);
            this.editUserInfoGroupBox.Name = "editUserInfoGroupBox";
            this.editUserInfoGroupBox.Size = new System.Drawing.Size(643, 387);
            this.editUserInfoGroupBox.TabIndex = 2;
            this.editUserInfoGroupBox.TabStop = false;
            this.editUserInfoGroupBox.Text = "編輯使用者資料";
            // 
            // editUserInfoTableLayoutPanel
            // 
            this.editUserInfoTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.editUserInfoTableLayoutPanel.ColumnCount = 2;
            this.editUserInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.editUserInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.editUserInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editConfirmPasswordTextBox, 1, 2);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editEmailAddressTextBox, 1, 3);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editPasswordTextBox, 1, 1);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editConfirmPasswordLabel, 0, 2);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editPassworLabel, 0, 1);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editEmailAddressLabel, 0, 3);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editUsernameLabel, 0, 0);
            this.editUserInfoTableLayoutPanel.Controls.Add(this.editUsernameTextBox, 1, 0);
            this.editUserInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUserInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.editUserInfoTableLayoutPanel.Name = "editUserInfoTableLayoutPanel";
            this.editUserInfoTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.editUserInfoTableLayoutPanel.RowCount = 4;
            this.editUserInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editUserInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editUserInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editUserInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editUserInfoTableLayoutPanel.Size = new System.Drawing.Size(637, 361);
            this.editUserInfoTableLayoutPanel.TabIndex = 1;
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
            this.editUsernameLabel.Text = "使用者名稱";
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
            // UserInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.viewInfoTableLayoutPanel);
            this.Controls.Add(this.editInfoTableLayoutPanel);
            this.Name = "UserInfoView";
            this.Text = "使用者資料 - Issue Tracking System";
            this.Load += new System.EventHandler(this.UserInfoViewLoad);
            this.Controls.SetChildIndex(this.editInfoTableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.viewInfoTableLayoutPanel, 0);
            this.viewInfoTableLayoutPanel.ResumeLayout(false);
            this.userInfoTableLayoutPanel.ResumeLayout(false);
            this.userInfoTableLayoutPanel.PerformLayout();
            this.editInfoTableLayoutPanel.ResumeLayout(false);
            this.editUserInfoGroupBox.ResumeLayout(false);
            this.editUserInfoTableLayoutPanel.ResumeLayout(false);
            this.editUserInfoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel viewInfoTableLayoutPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TableLayoutPanel userInfoTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel editInfoTableLayoutPanel;
        private System.Windows.Forms.Button finishEditButton;
        private System.Windows.Forms.TableLayoutPanel editUserInfoTableLayoutPanel;
        private System.Windows.Forms.Label editUsernameLabel;
        private System.Windows.Forms.Label editEmailAddressLabel;
        private System.Windows.Forms.Label editConfirmPasswordLabel;
        private System.Windows.Forms.Label editPassworLabel;
        private System.Windows.Forms.TextBox editConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox editEmailAddressTextBox;
        private System.Windows.Forms.TextBox editPasswordTextBox;
        private System.Windows.Forms.TextBox editUsernameTextBox;
        private System.Windows.Forms.GroupBox editUserInfoGroupBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label trackingIssueNumberTitleLabel;
        private System.Windows.Forms.Label invitedProjectNumberTitleLabel;
        private System.Windows.Forms.Label joinedProjectNumberTitleLabel;
        private System.Windows.Forms.Label emailAddressTitleLabel;
        private System.Windows.Forms.Label usernameTitleLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label trackingIssueNumberLabel;
        private System.Windows.Forms.Label invitedProjectNumberLabel;
        private System.Windows.Forms.Label joinedProjectNumberLabel;
        private System.Windows.Forms.Button viewInvitedProjectsButton;
        private System.Windows.Forms.Button viewJoinedProjectsButton;
        private System.Windows.Forms.Button viewIssuesButton;
    }
}
