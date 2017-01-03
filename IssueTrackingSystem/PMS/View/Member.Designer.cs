namespace IssueTrackingSystem.PMS.View
{
    partial class Member
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._projectName = new System.Windows.Forms.TextBox();
            this._memberList = new System.Windows.Forms.TabControl();
            this._existingMemberTable = new System.Windows.Forms.TabPage();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._userRole = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._joiningMemberTable = new System.Windows.Forms.TabPage();
            this._dataGridViewJoining = new System.Windows.Forms.DataGridView();
            this._inviteMemberTable = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._permission = new System.Windows.Forms.TextBox();
            this._permissionList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._name = new System.Windows.Forms.TextBox();
            this._nameInput = new System.Windows.Forms.TextBox();
            this._inviteMember = new System.Windows.Forms.Button();
            this._errorMessage = new System.Windows.Forms.TextBox();
            this._leaveButton = new System.Windows.Forms.Button();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._userRole2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this._memberList.SuspendLayout();
            this._existingMemberTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this._joiningMemberTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewJoining)).BeginInit();
            this._inviteMemberTable.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this._projectName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._memberList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._errorMessage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._leaveButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 512);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _projectName
            // 
            this._projectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._projectName.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._projectName.Location = new System.Drawing.Point(81, 41);
            this._projectName.Name = "_projectName";
            this._projectName.ReadOnly = true;
            this._projectName.Size = new System.Drawing.Size(621, 32);
            this._projectName.TabIndex = 0;
            this._projectName.Text = "123";
            this._projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _memberList
            // 
            this._memberList.Controls.Add(this._existingMemberTable);
            this._memberList.Controls.Add(this._joiningMemberTable);
            this._memberList.Controls.Add(this._inviteMemberTable);
            this._memberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._memberList.Location = new System.Drawing.Point(81, 130);
            this._memberList.Name = "_memberList";
            this._memberList.SelectedIndex = 0;
            this._memberList.Size = new System.Drawing.Size(621, 326);
            this._memberList.TabIndex = 2;
            this._memberList.SelectedIndexChanged += new System.EventHandler(this.MemberListSelectedIndexChanged);
            // 
            // _existingMemberTable
            // 
            this._existingMemberTable.Controls.Add(this._dataGridView);
            this._existingMemberTable.Location = new System.Drawing.Point(4, 22);
            this._existingMemberTable.Name = "_existingMemberTable";
            this._existingMemberTable.Padding = new System.Windows.Forms.Padding(3);
            this._existingMemberTable.Size = new System.Drawing.Size(613, 300);
            this._existingMemberTable.TabIndex = 0;
            this._existingMemberTable.Text = "Existing Members";
            this._existingMemberTable.UseVisualStyleBackColor = true;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._userID,
            this._userName,
            this._userEmail,
            this._userRole,
            this._deleteButton});
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(3, 3);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.RowTemplate.Height = 24;
            this._dataGridView.Size = new System.Drawing.Size(607, 294);
            this._dataGridView.TabIndex = 0;
            this._dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
            // 
            // _userID
            // 
            this._userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._userID.HeaderText = "ID";
            this._userID.Name = "_userID";
            this._userID.ReadOnly = true;
            this._userID.Width = 42;
            // 
            // _userName
            // 
            this._userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._userName.HeaderText = "Name";
            this._userName.Name = "_userName";
            this._userName.ReadOnly = true;
            this._userName.Width = 57;
            // 
            // _userEmail
            // 
            this._userEmail.HeaderText = "Email";
            this._userEmail.Name = "_userEmail";
            this._userEmail.ReadOnly = true;
            // 
            // _userRole
            // 
            this._userRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this._userRole.HeaderText = "Role";
            this._userRole.Items.AddRange(new object[] {
            "GeneralUser",
            "ProjectDeveloper",
            "ProjectTester",
            "ProjectManager"});
            this._userRole.Name = "_userRole";
            this._userRole.Width = 5;
            // 
            // _deleteButton
            // 
            this._deleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this._deleteButton.HeaderText = "Delete";
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Text = "Delete";
            this._deleteButton.Width = 40;
            // 
            // _joiningMemberTable
            // 
            this._joiningMemberTable.Controls.Add(this._dataGridViewJoining);
            this._joiningMemberTable.Location = new System.Drawing.Point(4, 22);
            this._joiningMemberTable.Name = "_joiningMemberTable";
            this._joiningMemberTable.Padding = new System.Windows.Forms.Padding(3);
            this._joiningMemberTable.Size = new System.Drawing.Size(613, 300);
            this._joiningMemberTable.TabIndex = 1;
            this._joiningMemberTable.Text = "Joining Member";
            this._joiningMemberTable.UseVisualStyleBackColor = true;
            // 
            // _dataGridViewJoining
            // 
            this._dataGridViewJoining.AllowUserToAddRows = false;
            this._dataGridViewJoining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridViewJoining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewJoining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this._userRole2,
            this.dataGridViewButtonColumn2});
            this._dataGridViewJoining.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewJoining.Location = new System.Drawing.Point(3, 3);
            this._dataGridViewJoining.Name = "_dataGridViewJoining";
            this._dataGridViewJoining.RowHeadersVisible = false;
            this._dataGridViewJoining.RowTemplate.Height = 24;
            this._dataGridViewJoining.Size = new System.Drawing.Size(607, 294);
            this._dataGridViewJoining.TabIndex = 1;
            this._dataGridViewJoining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewJoiningCellContentClick);
            // 
            // _inviteMemberTable
            // 
            this._inviteMemberTable.Controls.Add(this.tableLayoutPanel4);
            this._inviteMemberTable.Location = new System.Drawing.Point(4, 22);
            this._inviteMemberTable.Name = "_inviteMemberTable";
            this._inviteMemberTable.Padding = new System.Windows.Forms.Padding(3);
            this._inviteMemberTable.Size = new System.Drawing.Size(613, 300);
            this._inviteMemberTable.TabIndex = 2;
            this._inviteMemberTable.Text = "Invite_Member";
            this._inviteMemberTable.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this._inviteMember, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.91437F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.17126F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.91437F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(607, 294);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Controls.Add(this._permission, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this._permissionList, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(601, 170);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // _permission
            // 
            this._permission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._permission.Dock = System.Windows.Forms.DockStyle.Top;
            this._permission.Location = new System.Drawing.Point(3, 3);
            this._permission.Name = "_permission";
            this._permission.ReadOnly = true;
            this._permission.Size = new System.Drawing.Size(114, 15);
            this._permission.TabIndex = 0;
            this._permission.Text = "Permission:";
            this._permission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _permissionList
            // 
            this._permissionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._permissionList.FormattingEnabled = true;
            this._permissionList.Items.AddRange(new object[] {
            "GeneralUser",
            "ProjectDeveloper",
            "ProjectTester"});
            this._permissionList.Location = new System.Drawing.Point(123, 3);
            this._permissionList.Name = "_permissionList";
            this._permissionList.Size = new System.Drawing.Size(121, 20);
            this._permissionList.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Controls.Add(this._name, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this._nameInput, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(601, 52);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // _name
            // 
            this._name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._name.Location = new System.Drawing.Point(3, 34);
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.Size = new System.Drawing.Size(114, 15);
            this._name.TabIndex = 0;
            this._name.Text = "Name:";
            this._name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _nameInput
            // 
            this._nameInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._nameInput.Location = new System.Drawing.Point(123, 27);
            this._nameInput.Name = "_nameInput";
            this._nameInput.Size = new System.Drawing.Size(475, 22);
            this._nameInput.TabIndex = 1;
            // 
            // _inviteMember
            // 
            this._inviteMember.Dock = System.Windows.Forms.DockStyle.Right;
            this._inviteMember.Location = new System.Drawing.Point(479, 237);
            this._inviteMember.Name = "_inviteMember";
            this._inviteMember.Size = new System.Drawing.Size(125, 54);
            this._inviteMember.TabIndex = 2;
            this._inviteMember.Text = "Invite Member";
            this._inviteMember.UseVisualStyleBackColor = true;
            this._inviteMember.Click += new System.EventHandler(this.InviteMemberClicked);
            // 
            // _errorMessage
            // 
            this._errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._errorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._errorMessage.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._errorMessage.Location = new System.Drawing.Point(81, 462);
            this._errorMessage.Name = "_errorMessage";
            this._errorMessage.ReadOnly = true;
            this._errorMessage.Size = new System.Drawing.Size(621, 33);
            this._errorMessage.TabIndex = 3;
            // 
            // _leaveButton
            // 
            this._leaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._leaveButton.Location = new System.Drawing.Point(627, 79);
            this._leaveButton.Name = "_leaveButton";
            this._leaveButton.Size = new System.Drawing.Size(75, 45);
            this._leaveButton.TabIndex = 4;
            this._leaveButton.Text = "Leave";
            this._leaveButton.UseVisualStyleBackColor = true;
            this._leaveButton.Click += new System.EventHandler(this.LeaveButtonClicked);
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewButtonColumn3.HeaderText = "Update";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            this.dataGridViewButtonColumn3.Text = "Update";
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewButtonColumn4.HeaderText = "Delete";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Text = "Delete";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // _userRole2
            // 
            this._userRole2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this._userRole2.HeaderText = "Role";
            this._userRole2.Items.AddRange(new object[] {
            "GeneralUser",
            "ProjectDeveloper",
            "ProjectTester",
            "ProjectManager"});
            this._userRole2.Name = "_userRole2";
            this._userRole2.Width = 5;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.Width = 40;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Member";
            this.Text = "Member";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._memberList.ResumeLayout(false);
            this._existingMemberTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this._joiningMemberTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewJoining)).EndInit();
            this._inviteMemberTable.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _projectName;
        private System.Windows.Forms.TabControl _memberList;
        private System.Windows.Forms.TabPage _existingMemberTable;
        private System.Windows.Forms.TabPage _joiningMemberTable;
        private System.Windows.Forms.TabPage _inviteMemberTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox _permission;
        private System.Windows.Forms.ComboBox _permissionList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _nameInput;
        private System.Windows.Forms.Button _inviteMember;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridView _dataGridViewJoining;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.TextBox _errorMessage;
        private System.Windows.Forms.Button _leaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _userEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn _userRole;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn _userRole2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}