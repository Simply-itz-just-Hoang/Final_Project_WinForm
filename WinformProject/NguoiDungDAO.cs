using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class NguoiDungDAO
    {
        DBconnection dbcon = new DBconnection();
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM NguoiDung");

            return dbcon.Load(sqlStr);
        }
        public void Add(NguoiDung nguoidung)
        {
        string sqlStr = string.Format("INSERT INTO NguoiDung(TaiKhoan, MatKhau, VaiTro) VALUES ('{0}', '{1}', '{2}')",nguoidung.TaiKhoan , nguoidung.MatKhau, nguoidung.VaiTro);
            dbcon.Execuate(sqlStr);
        }
    public void Delete(NguoiDung nguoidung)
    {
        string sqlStr = string.Format("DELETE FROM NguoiDung WHERE TaiKhoan ='{0}'", nguoidung.TaiKhoan);
        dbcon.Execuate(sqlStr);
    }
    }
}
