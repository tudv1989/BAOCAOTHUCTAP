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
    }
}