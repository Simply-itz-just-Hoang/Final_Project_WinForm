using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class NguoiDung
    {
        private char taikhoan;
        private char matkhau;
        private char vaitro;
        public NguoiDung(char taikhoan, char matkhau, char vaitro)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.vaitro = vaitro;
        }
        public char TaiKhoan
        {
            get { return this.taikhoan; }
        }
        public char MatKhau
        {
            get { return this.matkhau; }
        }
        public char VaiTro
        {
            get { return this.vaitro; }
        }

    }
}
