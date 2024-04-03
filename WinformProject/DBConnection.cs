using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WinformProject
{
    public class DBConnection
    {
        public void ChuyenSangDrive()
        {
            var prs = new ProcessStartInfo("\"C:\\Program Files (x86)\\CocCoc\\Browser\\Application\\browser.exe\"");
            prs.Arguments = "https://drive.google.com/drive/home";
            Process.Start(prs);
        }
        
    }
}
