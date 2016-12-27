using IssueTrackingSystem.AMS.Controller;
using IssueTrackingSystem.ITS.Controller;
using IssueTrackingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IssueTrackingSystem.ITS.View
{
    public partial class IssueInfoView : IssueTrackingSystem.View.BaseView
    {
        private UserModel userModel;
        private IssueModel issueModel;
        private ProjectModel projectModel;
        private UserController userController;
        private IssueController issueController;


        public IssueInfoView()
        {
            InitializeComponent();
            userModel = new UserModel();
            issueModel = new IssueModel();
            projectModel = new ProjectModel();
            userController = new UserController(userModel);
            issueController = new IssueController(userModel, issueModel, projectModel);
        }


    }
}
