using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ShopQuanAo
{
    public class DAO_HoaDon : QuanLyKetNoi
    {
        public void ThemHD(HoaDon hd)
        {
            DAO_HoaDon daoHD = new DAO_HoaDon();
            daoHD.Open();
            string qry = "insert into HoaDon values('"+hd.MAHD+"','"+hd.NGAYLAPHD+"','"+hd.NGAYGIAOHANG+"',"+hd.MAKH+",'"+hd.DIACHIGIAOHANG+"','False')";
            SqlCommand cmd = new SqlCommand(qry, daoHD.cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose(); 
            daoHD.Close();
        }
        public DataTable LoadDSHD(bool TrangThai)
        {
            DAO_HoaDon dao = new DAO_HoaDon();
            dao.Open();
            string qry = "select MaHD,NgayLapHD,NgayGiaoHang,HoTen,DiaChiGiaoHang,TrangThai from HoaDon h,KhachHang k where h.MaKH = k.MaKH and h.TrangThai = '"+TrangThai+"'";
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cmd.Dispose();
            reader.Dispose();
            dao.Close();
            return dt;
        }
        public HoaDon LayThongTinHD(int MaHD)
        {
            DAO_HoaDon dao = new DAO_HoaDon();
            dao.Open();
            string qry = "select MaHD,HoTen,NgayLapHD,NgayGiaoHang,DiaChiGiaoHang,TrangThai from HoaDon h,KhachHang k where h.MaKH = k.MaKH and h.MaHD ="+MaHD;
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            HoaDon hd = new HoaDon();
            hd.MAHD = reader.GetInt32(0);
            hd.HOTEN = reader.GetString(1);
            hd.NGAYLAPHD = reader.GetDateTime(2).ToShortDateString();
            hd.NGAYGIAOHANG = reader.GetDateTime(3).ToShortDateString();
            hd.DIACHIGIAOHANG = reader.GetString(4);
            hd.TRANGTHAI = reader.GetBoolean(5);

            cmd.Dispose();
            reader.Dispose();
            dao.Close();

            return hd;
        }
        public void CapNhatHD(HoaDon hd)
        {
            string qry = "update HoaDon set DiaChiGiaoHang = '"+hd.DIACHIGIAOHANG+"', TrangThai = '"+hd.TRANGTHAI+"' where MaHD = "+hd.MAHD;
            SqlCommand cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public void CapNhatSoLuong(int MaSP)
        {
            string qry = "update SanPham_Size set SoLuong = SoLuongTam where MaSP = "+MaSP;
            SqlCommand cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public DataTable TinhDoanhThu()
        {
            DataTable dt = new DataTable();
            DAO_HoaDon dao = new DAO_HoaDon();
            dao.Open();
            string qry = "select sum(A.GiaMua*B.SoLuong) as TongMua ,sum(B.DonGia*B.SoLuong) as TongBan , SUM((B.DonGia*B.SoLuong) - (A.GiaMua*B.SoLuong)) as DoanhThu from SanPham A,ChiTiet_HoaDon B where A.MaSP = B.MaSP";
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            dao.Close();

            return dt;
        }
    }
}