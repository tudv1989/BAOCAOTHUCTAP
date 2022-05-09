using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ShopQuanAo
{
    public class DAO_KhachHang:QuanLyKetNoi
    {
        public void GhiThongTinKhachHang(KhachHang kh)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "insert into khachhang(TenDangNhap,MatKhau,NLMatkhau,HoTen,GioiTinh,DiaChi,Email,SoDienThoai) values('" + kh.TENDANGNHAP + "','" + kh.MATKHAU + "','" + kh.MATKHAU + "','" + kh.HOTEN + "'," + kh.GIOITINH + ",'" + kh.DIACHI + "','" + kh.EMAIL + "','" + kh.SODIENTHOAI + "')";
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            dao.Close();

        }
        public int LaTrungTenDangNhap(string TenDangNhap)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "SELECT * FROM KHACHHANG WHERE TENDANGNHAP = '" + TenDangNhap+"'";
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return 1;
            }
            return 0;
        }
        public int LaTrungEmail(string Email)
        {
            int flag = 0;
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "SELECT * FROM KHACHHANG WHERE Email = '" + Email + "'";
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                
                flag =  1;
            }
            cmd.Dispose();
            reader.Dispose();
            dao.Close();
            return flag;
        }
        public int LaDangNhapThanhCong(string Username,string Password)
        {
            int flag = 0;
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "SELECT * FROM KHACHHANG WHERE TENDANGNHAP = '" + Username + "' AND MATKHAU ='" + Password + "'";
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                flag = 1;
            }
            cmd.Dispose();
            reader.Dispose();
            dao.Close();
            return flag;
        }
        public int LayMaKH(string username)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "SELECT MaKH FROM KHACHHANG WHERE TENDANGNHAP = '" + username + "'";
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int makh = int.Parse(reader.GetValue(0).ToString());
                cmd.Dispose();
                reader.Dispose();
                dao.Close();
                return makh;
            }
            else
            {
                cmd.Dispose();
                reader.Dispose();
                dao.Close();
                return -1;
            }
           
        }
    }
}