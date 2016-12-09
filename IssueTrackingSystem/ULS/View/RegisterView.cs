using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTrackingSystem.ULS.View
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void registerButtonClicked(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void cancelButtonClicked(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
