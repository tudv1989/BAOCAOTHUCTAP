using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ShopQuanAo
{
    public class DAO_KhachHang:QuanLyKetNoi
    {
        public void GhiThongTinKhachHang(KhachHang kh)
        {
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "insert into khachhang(TenDangNhap,MatKhau,HoTen,GioiTinh,DiaChi,Email,SoDienThoai,LaAdmin) values('" + kh.TENDANGNHAP + "','" + kh.MATKHAU + "','" + kh.HOTEN + "'," + kh.GIOITINH + ",'" + kh.DIACHI + "','" + kh.EMAIL + "','" + kh.SODIENTHOAI + "','False')";
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
            int flag = -1;
            DAO_KhachHang dao = new DAO_KhachHang();
            dao.Open();
            string qry = "SELECT * FROM KHACHHANG WHERE TENDANGNHAP = '" + Username + "' AND MATKHAU ='" + Password + "'";
            SqlCommand cmd = new SqlCommand(qry,dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bool isAdmin = reader.GetBoolean(8);
                if (isAdmin == true)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
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
        public KhachHang LayThongTinKhachHang(string uname)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.Open();
            string qry = "select * from KhachHang where TenDangNhap = '"+uname+"'";
            SqlCommand cmd = new SqlCommand(qry, daoKH.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            KhachHang kh = new KhachHang();
            if (reader.HasRows)
            {
                reader.Read();
                kh.MAKH = reader.GetInt32(0);
                kh.TENDANGNHAP = uname;
                kh.HOTEN = reader.GetValue(3).ToString();
                kh.GIOITINH = reader.GetInt32(4);
                kh.DIACHI = reader.GetValue(5).ToString();
                kh.EMAIL = reader.GetValue(6).ToString();
                kh.SODIENTHOAI = reader.GetValue(7).ToString();
                kh.LAADMIN = (bool)reader.GetValue(8);
            }
            

            reader.Dispose();
            cmd.Dispose();
            daoKH.Close();

            return kh;
        }
        public DataTable DanhSachKhachHang()
        {
            DataTable ds = new DataTable();
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.Open();
            string qry = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(qry, daoKH.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            ds.Load(reader);
            daoKH.Close();
            return ds;
        }
        public void CapNhatKhachHang(KhachHang kh)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.Open();
            string qry = "Update KhachHang set MatKhau = '"+kh.MATKHAU+"', HoTen = '"+kh.HOTEN+"', GioiTinh = "+kh.GIOITINH+
             ", DiaChi = '"+kh.DIACHI +"', Email = '"+kh.EMAIL +"',SoDienThoai ='"+kh.SODIENTHOAI+"', LaAdmin = '"+kh.LAADMIN+"'" +
             "where MaKH = "+kh.MAKH;
            SqlCommand cmd = new SqlCommand(qry,daoKH.cnn);
            cmd.ExecuteNonQuery();
            daoKH.Close();

        }
        public void XoaKhachHang(int MaKH)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.Open();
            string qry = "XOAKH";
            SqlCommand cmd = new SqlCommand(qry, daoKH.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = MaKH;
            cmd.ExecuteNonQuery();

            cmd.Dispose();

            daoKH.Close();
        }
        public DataTable LoadTopKhachHang(int num)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.Open();
            string qry = "select top " + num + " with ties B.HoTen,B.SoDienThoai , SUM(SoLuong*DonGia) as DoanhThu from HoaDon A,KhachHang B,ChiTiet_HoaDon C where A.MaHD = C.MaHD and B.MaKH = A.MaKH group by B.MaKH,B.HoTen,B.SoDienThoai order by SUM(SoLuong*DonGia) desc";
            SqlCommand cmd = new SqlCommand(qry, daoKH.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Dispose();
            cmd.Dispose();
            daoKH.Close();

            return dt;
        }
        public void CapNhatThongTinKH(KhachHang kh)
        {
            DAO_KhachHang daoKH = new DAO_KhachHang();
            daoKH.Open();
            string qry = "Update KhachHang set HoTen = '" + kh.HOTEN + "', GioiTinh = " + kh.GIOITINH +
             ", DiaChi = '" + kh.DIACHI + "', Email = '" + kh.EMAIL + "',SoDienThoai ='" + kh.SODIENTHOAI + "'" +
             "where MaKH = " + kh.MAKH;
            SqlCommand cmd = new SqlCommand(qry, daoKH.cnn);
            cmd.ExecuteNonQuery();
            daoKH.Close();
        }
    }
}