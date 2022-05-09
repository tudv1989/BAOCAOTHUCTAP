using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ShopQuanAo
{
    public class BUS_SanPham
    {
        public DataTable LoadSanPhamChuDe(int ChuDe)
        {
            DAO_SanPham dao = new DAO_SanPham();
            return dao.LoadSPChuDe(ChuDe);
        }
        public DataTable LoadSanPhamTheoLoai(int LoaiSP, int GioiTinh)
        {
            DAO_SanPham dao = new DAO_SanPham();
            return dao.LoadSPTheoLoai(LoaiSP,GioiTinh);
        }
        public SanPham LayThongTinSanPham(int ID)
        {
            DAO_SanPham dao_sp = new DAO_SanPham();

            return dao_sp.LayThongTinSanPham(ID);
            
        }
        public DataTable TimKiemSanPham(string TenSP)
        {
            DAO_SanPham dao = new DAO_SanPham();
            return dao.TimKiemSanPham(TenSP);
        }
        public DataTable LayKichThuocSanPham(int ID)
        {
            DAO_SanPham dao = new DAO_SanPham();

            return dao.LayKichThuocSanPham(ID);
        }
        public void XoaSP(int MaSP)
        {
            DAO_SanPham dao = new DAO_SanPham();
            dao.XoaSP(MaSP);
        }
        public void ThemSP(SanPham sp)
        {
            DAO_SanPham daoSP = new DAO_SanPham();
            daoSP.ThemSP(sp);
        }
        public void ThemSoLuongSanPham(SanPham sp)
        {
            DAO_SanPham daoSP = new DAO_SanPham();
            daoSP.ThemSoLuongSanPham(sp);
        }
        public int LayMaSP()
        {
            DAO_SanPham daoSP = new DAO_SanPham();
            return daoSP.LayMaSP();
        }
        public void CapNhatSP(SanPham sp)
        {
            DAO_SanPham dao = new DAO_SanPham();
            dao.CapNhatSP(sp);
        }
        public DataTable TopSanPham(int num)
        {
            DAO_SanPham dao = new DAO_SanPham();
            return dao.TopSanPham(num);
        }
        public int LaTrungMaSP(int MaSP)
        {
            DAO_SanPham dao = new DAO_SanPham();
            return dao.LaTrungMaSP(MaSP);
        }
        public DataTable LoadSPTheoLoaiAdmin(int LoaiSP, int Gioitinh)
        {
            DAO_SanPham dao = new DAO_SanPham();
            return dao.LoadSPTheoLoaiAdmin(LoaiSP, Gioitinh);
        }
    }
}