using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ShopQuanAo
{
    public class BUS_HoaDon
    {
        public void ThemHD(HoaDon hd)
        {
            DAO_HoaDon daoHD = new DAO_HoaDon();
            daoHD.ThemHD(hd);
        }
        public DataTable LoadDSHD(bool TrangThai)
        {
            DAO_HoaDon daoHD = new DAO_HoaDon();
            return daoHD.LoadDSHD(TrangThai);
        }
        public HoaDon LayThongTinHD(int MaHD)
        {
            DAO_HoaDon dao = new DAO_HoaDon();
            return dao.LayThongTinHD(MaHD);
        }
        public void CapNhatHD(HoaDon hd)
        {
            DAO_HoaDon dao = new DAO_HoaDon();
            dao.Open();
            dao.CapNhatHD(hd);
            dao.Close();
        }
        public void CapNhatSoLuong(int MaSP)
        {
            DAO_HoaDon dao = new DAO_HoaDon();
            dao.Open();
            dao.CapNhatSoLuong(MaSP);
            dao.Close();
        }
        public DataTable TinhDoanhThu()
        {
            DAO_HoaDon dao = new DAO_HoaDon();
            return dao.TinhDoanhThu();
        }
    }
}