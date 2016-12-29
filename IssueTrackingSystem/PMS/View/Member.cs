using IssueTrackingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrackingSystem.PMS.View
{
    public partial class Member : Form
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;

        public Member(UserModel userModel, IssueModel issueModel, ProjectModel projectModel)
//            : base(userModel, issueModel, projectModel)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.issueModel = issueModel;
            this.projectModel = projectModel;
        }
    }
}
