using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class HocSinhDAO
    {
        DBconnection dbcon = new DBconnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");

            return dbcon.Load(sqlStr);
        }

        public void Add(HS hs)
        {
            
        string sqlStr = string.Format("INSERT INTO HocSinh(MaHocSinh, Ten, Email, Khoa, Nganh, NgaySinh, GioiTinh, SDT, ID_GiaoVien, ID_LuanVan) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}','{8}','{9}')",hs.MaHocSinh, hs.Ten,hs.Email,hs.Khoa,hs.Nganh,hs.NgaySinh,hs.GioiTinh ,hs.SDT ,hs.ID_GiaoVien,hs.ID_LuanVan);
            dbcon.Execuate(sqlStr);
        }
        public void Delete(HS hs)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE MaHocSinh ='{0}'", hs.MaHocSinh);
            dbcon.Execuate(sqlStr);
        }
        public void Change(HS hs)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten='{0}', Email ='{1}', Khoa = '{2}', Nganh = '{3}',NgaySinh = '{4}', GioiTinh = '{5}', SDT = '{6}' , ID_GiaoVien = '{7}', ID_LuanVan = '{8}' WHERE MaHocSinh = '{9}'", hs.Ten, hs.Email, hs.Khoa, hs.Nganh, hs.NgaySinh, hs.GioiTinh, hs.SDT, hs.ID_GiaoVien, hs.ID_LuanVan, hs.MaHocSinh);
            dbcon.Execuate(sqlStr);
        }
    }
}
