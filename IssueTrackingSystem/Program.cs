using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem.AMS.View;
using IssueTrackingSystem.Model;

namespace IssueTrackingSystem
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                    new System.Net.Security.RemoteCertificateValidationCallback(delegate(object MySender,
                                System.Security.Cryptography.X509Certificates.X509Certificate MyCertificate,
                                System.Security.Cryptography.X509Certificates.X509Chain MyChain,
                                System.Net.Security.SslPolicyErrors MyErrors)
                    {
                        if (MySender is System.Net.WebRequest)
                        {
                            //忽略憑証檢查，一律回傳true
                            return true;
                        }
                        return false;
                    });

            UserModel userModel = new UserModel();
            IssueModel issueModel = new IssueModel();
            ProjectModel projectModel = new ProjectModel();
            ProjectMemberModel projectMemberModel = new ProjectMemberModel();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView(userModel, issueModel, projectModel, projectMemberModel));
        }
    }
}
