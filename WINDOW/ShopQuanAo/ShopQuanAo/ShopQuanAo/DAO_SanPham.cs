using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace ShopQuanAo
{
    public class DAO_SanPham : QuanLyKetNoi
    {

        public DataTable LoadSPChuDe(int ChuDe)
        {
            DAO_SanPham dao_sp = new DAO_SanPham();
            dao_sp.Open();
            string qry = "select * from SanPham where chude = "+ChuDe;
            SqlCommand cmd = new SqlCommand(qry, dao_sp.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);

            cmd.Dispose();
            reader.Dispose();

            dao_sp.Close();

            return dt;

        }
        public DataTable LoadSPTheoLoai(int LoaiSP,int Gioitinh)
        {
            DAO_SanPham dao_sp = new DAO_SanPham();
            dao_sp.Open();
            string qry = "select * from SanPham where LoaiSP = " + LoaiSP +"and GioiTinh =" + Gioitinh;
            SqlCommand cmd = new SqlCommand(qry, dao_sp.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);

            cmd.Dispose();
            reader.Dispose();

            dao_sp.Close();

            return dt;

        }
        public SanPham LayThongTinSanPham(int ID)
        {
            DAO_SanPham dao_sp = new DAO_SanPham();
            dao_sp.Open();
            string qry = "SELECT * FROM SANPHAM WHERE MASP = " + ID ;
            SqlCommand cmd = new SqlCommand(qry, dao_sp.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            SanPham sp = new SanPham();
            sp.MaSP = ID;
            sp.TenSP = reader["TenSP"].ToString() ;
            sp.GiaBan = int.Parse(reader["GiaBan"].ToString());
            sp.GiaMua = int.Parse(reader["GiaMua"].ToString());
            sp.LoaiSP = int.Parse(reader["LoaiSP"].ToString());
            sp.ChuDe = int.Parse(reader["ChuDe"].ToString());
            sp.ThongTin = reader["ThongTin"].ToString();
            sp.GioiTinh = int.Parse(reader["GioiTinh"].ToString());
            sp.NgayNhap = DateTime.Parse(reader["NgayNhapHang"].ToString());
            sp.HinhAnh = reader["HinhAnh"].ToString();
            return sp;
        }
        public DataTable TimKiemSanPham(string TenSP)
        {
            DataTable dt = new DataTable();

            DAO_SanPham dao = new DAO_SanPham();
            dao.Open();
            string qry = "SELECT * FROM SANPHAM WHERE TENSP LIKE '%" + TenSP + "%'";
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            cmd.Dispose();
            reader.Dispose();

            dao.Close();

            return dt;
        }
        public DataTable LayKichThuocSanPham(int ID)
        {
            DAO_SanPham dao = new DAO_SanPham();
            dao.Open();
            String qry = "SELECT A.SIZE,A.MASIZE FROM  SIZE A, SANPHAM_SIZE B WHERE  A.MASIZE = B.MASIZE AND B.SOLUONG > 0  AND B.MASP = "+ID;
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            cmd.Dispose();
            reader.Dispose();

            dao.Close();

            return dt;

        }
       
    }
    
}