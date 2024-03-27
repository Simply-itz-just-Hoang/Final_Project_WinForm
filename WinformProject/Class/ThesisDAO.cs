using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject.Class
{
    internal class ThesisDAO
    {
        DBconnection dbConn = new DBconnection();
        public void them(Thesis thesis)
        {
            dbConn.Execuate("INSERT INTO LuanVan(ThesisID, ThesisName, Describe) VALUES ("+thesis.ThesisID+","+thesis.ThesisName+", "+ thesis.Describe + ")");
        }
        public void xoa(Thesis thesis)
        {
            dbConn.Execuate("DELETE FROM LuanVan Where ThesisID = "+ thesis.ThesisID );
        }
        public void sua(Thesis thesis)
        {
            dbConn.Execuate("UPDATE LuanVan SET Desribe = "+ thesis.Describe + " WHERE ThesisName= "+ thesis.ThesisName + "");
        }

    }
}
