using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject.Class
{
    class Thesis
    {
        Random random = new Random();
        public string ThesisID { get; set; }
        public string ThesisName { get; set; }
        public string Describe {  get; set; }

        public Thesis(string ThesisID, string ThesisName, string Describe)
        {
            this.ThesisID = ThesisID;
            this.ThesisName = ThesisName;
            this.Describe = Describe;
            ThesisID = random.Next(1, 1000).ToString("D3");
        }
    }
}
