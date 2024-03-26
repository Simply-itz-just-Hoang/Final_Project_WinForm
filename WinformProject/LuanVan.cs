using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    internal class LuanVan
    {
        private char maLuanVan;
        private char ten;
        private char tinhtrang;
        public LuanVan(char maLuanVan, char ten, char tinhtrang)
        {
            this.maLuanVan = maLuanVan;
            this.ten = ten;
            this.tinhtrang = tinhtrang;
        }
        public char MaLuanVan
        {
            get { return this.maLuanVan; }
        }
        public char Ten
        {
            get { return this.ten; }
        }

        public char TinhTrang
        {
            get { return this.tinhtrang; }
        }
    }
}
