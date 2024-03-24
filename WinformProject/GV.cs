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
        public GV(string maHocSinh, string ten, string email, string khoa, string nganh)
        {
            this.maGiaoVien = maGiaoVien;
            this.ten = ten;
            this.email = email;
            this.khoa = khoa;
            this.nganh = nganh;

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
    }
}
