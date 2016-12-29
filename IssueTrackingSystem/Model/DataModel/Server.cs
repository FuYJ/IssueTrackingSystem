using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem.Model.DataModel
{
    public class Server
    {
        //private static String apiUrl = "http://cic01.mmslab.ntut.edu.tw:8080/ITS_ws/api";
        private static String apiUrl = "https://140.124.73.12/ITS_ws/api";

        public static String ApiUrl
        {
            get { return apiUrl; }
        }
    }
}
