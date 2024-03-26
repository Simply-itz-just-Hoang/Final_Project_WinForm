using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class LuanVanDAO
    {
        DBconnection dbcon = new DBconnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM LuanVan");

            return dbcon.Load(sqlStr);
        }
        public void Add(LuanVan luanvan)
        {

        string sqlStr = string.Format("INSERT INTO LuanVan(MaLuanVan, Ten, TinhTrang) VALUES ('{0}', '{1}', '{2}')", luanvan.MaLuanVan, luanvan.Ten, luanvan.TinhTrang);
            dbcon.Execuate(sqlStr);
        }
        public void Delete(LuanVan luanvan)
        {
            string sqlStr = string.Format("DELETE FROM LuanVan WHERE MaHocSinh ='{0}'", luanvan.MaLuanVan);
            dbcon.Execuate(sqlStr);
        }
        public void Change(LuanVan luanvan)
        {
            string sqlStr = string.Format("UPDATE LuanVan SET Ten='{0}', TìnhTrang ='{1}' WHERE MaHocSinh = '{2}'", luanvan.Ten, luanvan.TinhTrang, luanvan.MaLuanVan);
            dbcon.Execuate(sqlStr);
        }
    }
}
