using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace ShopQuanAo
{
    public class DAO_BinhLuan : QuanLyKetNoi
    {
        public void ThemBinhLuan(BinhLuan bl)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.Open();
            string qry = "insert into BinhLuan(TieuDe,NoiDung,NgayBL,MaKH,MaSP,TrangThai) values("+"'"+bl.TIEUDE+"','"+bl.NOIDUNG+"','"+bl.NGAYBL+"',"+bl.MAKH+","+bl.MASP+",'"+bl.TRANGTHAI+"')";
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dao.Close();
        }
        public DataTable LoadBinhLuan(int MaSP,int admin)
        {
            DataTable dt = new DataTable();
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.Open();
            String qry = "select TieuDe,NoiDung,NgayBL,HoTen,Email from BinhLuan b , KhachHang k where b.makh = k.makh and b.TrangThai = 'True' and b.masp = "+MaSP;
            if (admin == 1)
            {
                qry = "select MaBinhLuan,TieuDe,NoiDung,NgayBL,HoTen,TenSP,TrangThai from BinhLuan b , KhachHang k , SanPham s where b.makh = k.makh and b.masp = s.masp and b.TrangThai = 'True'";
            }
            if (admin == 2)
            {
                qry = "select MaBinhLuan,TieuDe,NoiDung,NgayBL,HoTen,TenSP,TrangThai from BinhLuan b , KhachHang k , SanPham s where b.makh = k.makh and b.masp = s.masp and b.TrangThai = 'False'";
            }
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dt.Load(reader);
            }
            cmd.Dispose();
            reader.Dispose();
            dao.Close();
            return dt;

        }
        public BinhLuan LayThongTinBinhLuan(int MaBL)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.Open();
            string qry = "select TieuDe,NoiDung,NgayBL,HoTen,TenSP,TrangThai,s.MaSP as MaSP,k.MaKH as MaKH from BinhLuan b , KhachHang k , SanPham s where b.makh = k.makh and b.masp = s.masp and MaBinhLuan ="+MaBL;
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            BinhLuan bl = new BinhLuan();

            bl.TIEUDE = reader.GetString(0);
            bl.NOIDUNG = reader.GetString(1);
            bl.NGAYBL = reader.GetDateTime(2);
            bl.TENKH = reader.GetString(3);
            bl.TENSP = reader.GetString(4);
            bl.TRANGTHAI = reader.GetBoolean(5);
            bl.MAKH = reader.GetInt32(6);
            bl.MASP = reader.GetInt32(7);

            cmd.Dispose();
            reader.Dispose();

            
            dao.Close();
            return bl;
        }
        public void XoaBL(int MaBL)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.Open();
            string qry = "delete from BinhLuan where MaBinhLuan ="+MaBL;
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dao.Close();

        }
        public void CapNhatBinhLuan(BinhLuan bl)
        {
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.Open();
            string qry = "update BinhLuan set TieuDe = '"+bl.TIEUDE+"', NoiDung ='"+bl.NOIDUNG+"',TrangThai ='"+bl.TRANGTHAI+"' where MaBinhLuan ="+bl.MABINHLUAN;
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dao.Close();


        }
      
    }
}