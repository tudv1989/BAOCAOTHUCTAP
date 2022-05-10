using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopQuanAo
{
    public class BinhLuan
    {
        private int MaBinhLuan;

        public int MABINHLUAN
        {
            get { return MaBinhLuan; }
            set { MaBinhLuan = value; }
        }
        private string TieuDe;

        public string TIEUDE
        {
            get { return TieuDe; }
            set { TieuDe = value; }
        }
        private string NoiDung;

        public string NOIDUNG
        {
            get { return NoiDung; }
            set { NoiDung = value; }
        }
        private DateTime NgayBL;

        public DateTime NGAYBL
        {
            get { return NgayBL; }
            set { NgayBL = value; }
        }
        private int MaKH;

        public int MAKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        private int MaSP;

        public int MASP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }



    }
}