using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopQuanAo
{
    public class SanPham
    {

        private int maSP;

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        private string tenSP;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        private int giaMua;

        public int GiaMua
        {
            get { return giaMua; }
            set { giaMua = value; }
        }
        private int giaBan;

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        private int loaiSP;

        public int LoaiSP
        {
            get { return loaiSP; }
            set { loaiSP = value; }
        }
        private int chuDe;

        public int ChuDe
        {
            get { return chuDe; }
            set { chuDe = value; }
        }
        private string thongTin;

        public string ThongTin
        {
            get { return thongTin; }
            set { thongTin = value; }
        }
        private int gioiTinh;

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string hinhAnh;

        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
    }
}