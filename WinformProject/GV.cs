using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class GV
    {
        private string maGiaoVien;
        private string ten;
        private string email;
        private string khoa;
        private string nganh;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        public GV(string maHocSinh, string ten, string email, string khoa, string nganh, string ngaysinh, string gioitinh, string sdt)
        {
            this.maGiaoVien = maGiaoVien;
            this.ten = ten;
            this.email = email;
            this.khoa = khoa;
            this.nganh = nganh;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
        }
        public string MaGiaoVien
        {
            get { return this.maGiaoVien; }
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
        public string NgaySinh
        {
            get { return this.ngaysinh; }
        }
        public string GioiTinh
        {
            get { return this.gioitinh; }
        }
        public string SDT
        {
            get { return this.sdt; }
        }
    }
}
