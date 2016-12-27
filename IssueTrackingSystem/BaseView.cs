using IssueTrackingSystem.AMS.View;
using IssueTrackingSystem.Model;
using IssueTrackingSystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrackingSystem.View
{
    public partial class BaseView : Form
    {
        public BaseView()
        {
            InitializeComponent();
        }

        private void userListToolStripButtonClicked(object sender, EventArgs e)
        {
            UserListView accountListView = new UserListView();
            accountListView.Show();
        }
    }
}
