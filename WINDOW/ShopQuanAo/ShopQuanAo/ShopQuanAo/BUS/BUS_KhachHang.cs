using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ShopQuanAo
{
    public class BUS_KhachHang
    {
        public void GhiThongTinKhachHang(KhachHang kh)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.GhiThongTinKhachHang(kh);
        }
        public int LaTrungTenDangNhap(string TenDangNhap)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            return dao.LaTrungTenDangNhap(TenDangNhap);
        }
        public int LaTrungEmail(string Email)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            return dao.LaTrungEmail(Email);
        }
        public int LaDangNhapThanhCong(string Username,string Password)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            return dao.LaDangNhapThanhCong(Username,Password);
        }
        public int LayMaKH(string username)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            return dao.LayMaKH(username);
        }
        public KhachHang LayThongTinKhachHang(string uname)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            return daoKH.LayThongTinKhachHang(uname);
        }
        public DataTable DanhSachKhachHang()
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            return daoKH.DanhSachKhachHang();
        }
        public void CapNhatKhachHang(KhachHang kh)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.CapNhatKhachHang(kh);
        }
        public void XoaKhachHang(int MaKH)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.XoaKhachHang(MaKH);
        }
        public DataTable LoadTopKhachHang(int num)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            return dao.LoadTopKhachHang(num);
        }
        public void CapNhatThongTinKH(KhachHang kh)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.CapNhatThongTinKH(kh);
        }
    }
}