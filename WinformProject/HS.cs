using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class HS
    {

        private string maHocSinh;
        private string ten;
        private string email;
        private string khoa;
        private string nganh;
        private string id_GiaoVien;
        private string id_LuanVan;
        public HS(string maHocSinh, string ten, string email, string khoa, string nganh, string id_GiaoVien, string id_LuanVan)
        {
            this.maHocSinh = maHocSinh;
            this.ten = ten;
            this.email = email;
            this.khoa = khoa;
            this.nganh = nganh;
            this.id_GiaoVien = id_GiaoVien;
            this.id_LuanVan = id_LuanVan;
        }
        public string MaHocSinh
        {
            get { return this.maHocSinh; }
        }
        public string Ten
        {
            get { return this.ten; }
        }
        public string Email
        {
            get { return this.email; }
        }
        public string Khoa
        {
            get { return this.khoa; }
        }
        public string Nganh
        {
            get { return this.nganh; }
        }
        public string ID_GiaoVien
        {
            get { return this.id_GiaoVien; }
        }
        public string ID_LuanVan
        {
            get { return this.id_LuanVan; }
        }

    }
}
