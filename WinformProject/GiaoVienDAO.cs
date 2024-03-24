using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class GiaoVienDAO
    {

        DBconnection dbcon = new DBconnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");

            return dbcon.Load(sqlStr);
        }

        public void Add(GV gv)
        {

            string sqlStr = string.Format("INSERT INTO HocSinh(MaGiaoVien, Ten, Email, Khoa, Nganh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", gv.MaGiaoVien, gv.Ten, gv.Email, gv.Khoa, gv.Nganh);
            dbcon.Execuate(sqlStr);
        }
        public void Delete(GV gv)
        {
            string sqlStr = string.Format("DELETE FROM GiaoVien WHERE MaGiaoVien ='{0}'", gv.MaGiaoVien);
            dbcon.Execuate(sqlStr);
        }
        public void Change(GV gv)
        {
            string sqlStr = string.Format("UPDATE GiaoVien SET Ten='{0}', Email ='{1}', Khoa = '{2}', Nganh = '{3}' WHERE MaGiaoVien = '{4}'", gv.Ten, gv.Email, gv.Khoa, gv.Nganh,gv.MaGiaoVien);
            dbcon.Execuate(sqlStr);
        }

    }
}
