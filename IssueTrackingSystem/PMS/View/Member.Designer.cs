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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._mainProject = new System.Windows.Forms.Button();
            this._memberList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._joiningMemberTable = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._permission = new System.Windows.Forms.TextBox();
            this._permissionList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._name = new System.Windows.Forms.TextBox();
            this._nameInput = new System.Windows.Forms.TextBox();
            this._inviteMember = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._nextPage = new System.Windows.Forms.Button();
            this._previousPage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this._memberList.SuspendLayout();
            this._joiningMemberTable.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._mainProject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._memberList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(81, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(621, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "123";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _mainProject
            // 
            this._mainProject.Dock = System.Windows.Forms.DockStyle.Right;
            this._mainProject.Location = new System.Drawing.Point(627, 79);
            this._mainProject.Name = "_mainProject";
            this._mainProject.Size = new System.Drawing.Size(75, 45);
            this._mainProject.TabIndex = 1;
            this._mainProject.Text = "Main";
            this._mainProject.UseVisualStyleBackColor = true;
            // 
            // _memberList
            // 
            this._memberList.Controls.Add(this.tabPage1);
            this._memberList.Controls.Add(this._joiningMemberTable);
            this._memberList.Controls.Add(this.tabPage3);
            this._memberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._memberList.Location = new System.Drawing.Point(81, 130);
            this._memberList.Name = "_memberList";
            this._memberList.SelectedIndex = 0;
            this._memberList.Size = new System.Drawing.Size(621, 326);
            this._memberList.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Existing Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _joiningMemberTable
            // 
            this._joiningMemberTable.Controls.Add(this.tableLayoutPanel3);
            this._joiningMemberTable.Location = new System.Drawing.Point(4, 22);
            this._joiningMemberTable.Name = "_joiningMemberTable";
            this._joiningMemberTable.Padding = new System.Windows.Forms.Padding(3);
            this._joiningMemberTable.Size = new System.Drawing.Size(613, 300);
            this._joiningMemberTable.TabIndex = 1;
            this._joiningMemberTable.Text = "Joining Member";
            this._joiningMemberTable.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(607, 294);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(613, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this._permissionList.FormattingEnabled = true;
            this._permissionList.Items.AddRange(new object[] {
            "general_user",
            "developer",
            "tester",
            "manager"});
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
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._nextPage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._previousPage, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(502, 462);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 47);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // _nextPage
            // 
            this._nextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nextPage.Location = new System.Drawing.Point(103, 3);
            this._nextPage.Name = "_nextPage";
            this._nextPage.Size = new System.Drawing.Size(94, 41);
            this._nextPage.TabIndex = 0;
            this._nextPage.Text = "Next";
            this._nextPage.UseVisualStyleBackColor = true;
            // 
            // _previousPage
            // 
            this._previousPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previousPage.Location = new System.Drawing.Point(3, 3);
            this._previousPage.Name = "_previousPage";
            this._previousPage.Size = new System.Drawing.Size(94, 41);
            this._previousPage.TabIndex = 1;
            this._previousPage.Text = "Previous";
            this._previousPage.UseVisualStyleBackColor = true;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Member";
            this.Text = "Member";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._memberList.ResumeLayout(false);
            this._joiningMemberTable.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _mainProject;
        private System.Windows.Forms.TabControl _memberList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage _joiningMemberTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox _permission;
        private System.Windows.Forms.ComboBox _permissionList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _nameInput;
        private System.Windows.Forms.Button _inviteMember;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _nextPage;
        private System.Windows.Forms.Button _previousPage;
    }
}