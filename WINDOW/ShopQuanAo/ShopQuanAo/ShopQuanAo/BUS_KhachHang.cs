using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}