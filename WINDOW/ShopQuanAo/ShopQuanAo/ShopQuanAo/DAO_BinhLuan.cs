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
            string qry = "insert into BinhLuan(TieuDe,NoiDung,NgayBL,MaKH,MaSP) values("+"'"+bl.TIEUDE+"','"+bl.NOIDUNG+"','"+bl.NGAYBL+"',"+bl.MAKH+","+bl.MASP+")";
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dao.Close();
        }
        public DataTable LoadBinhLuan(int MaSP)
        {
            DataTable dt = new DataTable();
            DAO_BinhLuan dao = new DAO_BinhLuan();
            dao.Open();
            String qry = "select TieuDe,NoiDung,NgayBL,HoTen,Email from BinhLuan b , KhachHang k where b.makh = k.makh and b.masp = "+MaSP;
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
    }
}