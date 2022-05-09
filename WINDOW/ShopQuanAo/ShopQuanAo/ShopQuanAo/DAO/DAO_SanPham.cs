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
        public DataTable LoadSPTheoLoai(int LoaiSP, int Gioitinh)
        {
            DAO_SanPham dao_sp = new DAO_SanPham();
            dao_sp.Open();
            string qry = "select *  from SanPham  where LoaiSP = " + LoaiSP + "and GioiTinh =" + Gioitinh;
            SqlCommand cmd = new SqlCommand(qry, dao_sp.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);

            cmd.Dispose();
            reader.Dispose();

            dao_sp.Close();

            return dt;

        }
        public DataTable LoadSPTheoLoaiAdmin(int LoaiSP,int Gioitinh)
        {
            DAO_SanPham dao_sp = new DAO_SanPham();
            dao_sp.Open();
            string qry = "select s.MaSP as MaSP,TenSP , GiaBan , NgayNhapHang,Size,SoLuong,HinhAnh  from SanPham s, sanpham_size si , Size size where s.MaSP = si.MaSP and size.MaSize = si.MaSize  and LoaiSP = " + LoaiSP + "and GioiTinh =" + Gioitinh;
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
            string qry = "select s.MaSP as MaSP,TenSP , GiaBan ,GiaMua, NgayNhapHang,GioiTinh,HinhAnh,si.MaSize as MaSize,SoLuong,LoaiSP,ChuDe,ThongTin  from SanPham s, sanpham_size si , Size size where s.MaSP = si.MaSP and size.MaSize = si.MaSize and s.MaSP = "+ID;
            SqlCommand cmd = new SqlCommand(qry, dao_sp.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            SanPham sp = new SanPham();
            sp.MaSP = ID;
            sp.TenSP = reader.GetString(1);
            sp.GiaBan = int.Parse(reader["GiaBan"].ToString());
            sp.GiaMua = int.Parse(reader["GiaMua"].ToString());
            sp.LoaiSP = int.Parse(reader["LoaiSP"].ToString());
            sp.ChuDe = int.Parse(reader["ChuDe"].ToString());
            sp.ThongTin = reader["ThongTin"].ToString();
            sp.GioiTinh = int.Parse(reader["GioiTinh"].ToString());
            sp.NgayNhap = DateTime.Parse(reader["NgayNhapHang"].ToString());
            sp.HinhAnh = reader["HinhAnh"].ToString();
            sp.MASIZE = int.Parse(reader["MaSize"].ToString());
            sp.SoLuong = int.Parse(reader["SoLuong"].ToString());

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
        public void XoaSP(int MaSP)
        {
            DAO_SanPham daoSP = new DAO_SanPham();
            daoSP.Open();
            string qry = "XOASP";
            SqlCommand cmd = new SqlCommand(qry, daoSP.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = MaSP;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            daoSP.Close();
        }
        public void ThemSP(SanPham sp)
        {
            DAO_SanPham dao = new DAO_SanPham();
            dao.Open();
            string qry = "insert into SanPham(MaSP,TenSP,GiaMua,GiaBan,LoaiSP,ChuDe,ThongTin,GioiTinh,NgayNhapHang,HinhAnh) values("+sp.MaSP +",'" + sp.TenSP + "'," + sp.GiaMua + "," + sp.GiaBan + "," + sp.LoaiSP + "," + sp.ChuDe + ",'" + sp.ThongTin + "'," + sp.GioiTinh + ",'" + sp.NgayNhap + "','" + sp.HinhAnh + "')";

            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            cmd.ExecuteNonQuery();

            cmd.Dispose();

            dao.Close();
         
        }
        public void ThemSoLuongSanPham(SanPham sp)
        {
            DAO_SanPham dao = new DAO_SanPham();
            dao.Open();
            string qry = "insert into SanPham_Size(MaSP,MaSize,SoLuong) values("+ sp.MaSP +","+sp.MASIZE+","+sp.SoLuong+")" ;
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            cmd.ExecuteNonQuery();
            dao.Close();
        }
        public void CapNhatSP(SanPham sp)
        {
            DAO_SanPham daoSP = new DAO_SanPham();
            daoSP.Open();
            string qry = "SUASP";
            SqlCommand cmd = new SqlCommand(qry, daoSP.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = sp.MaSP;
            cmd.Parameters.Add("@TenSP", SqlDbType.Text).Value = sp.TenSP;
            cmd.Parameters.Add("@GiaMua", SqlDbType.Int).Value = sp.GiaMua;
            cmd.Parameters.Add("@GiaBan", SqlDbType.Int).Value = sp.GiaBan;
            cmd.Parameters.Add("@LoaiSP", SqlDbType.Int).Value = sp.LoaiSP;
            cmd.Parameters.Add("@ChuDe", SqlDbType.Int).Value = sp.ChuDe;
            cmd.Parameters.Add("@ThongTin", SqlDbType.Text).Value = sp.ThongTin;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Int).Value = sp.GioiTinh;
            cmd.Parameters.Add("@NgayNhapHang", SqlDbType.Date).Value = sp.NgayNhap;
            cmd.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = sp.HinhAnh;
            cmd.Parameters.Add("@MaSize", SqlDbType.Int).Value = sp.MASIZE;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = sp.SoLuong;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            daoSP.Close();


        }
        public int LayMaSP()
        {
            DAO_SanPham daoSP = new DAO_SanPham();
            daoSP.Open();
            string qry = "select top 1 MaSP from SanPham order by MaSP desc";
            SqlCommand cmd = new SqlCommand(qry,daoSP.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int Masp = reader.GetInt32(0);
            reader.Dispose();
            daoSP.Close();

            return Masp+1;
        }
        public DataTable TopSanPham(int num)
        {
            DAO_SanPham dao = new DAO_SanPham();
            dao.Open();
            string qry = "select top " + num + " with ties B.TenSP , B.GiaMua,B.GiaBan,SUM(SoLuong)as SoLuongBan from ChiTiet_HoaDon as A , SanPham B where A.MaSP = B.MaSP group by A.MaSP ,B.TenSP, B.GiaMua,B.GiaBan order by SUM(SoLuong) desc";
            SqlCommand cmd = new SqlCommand(qry, dao.cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Dispose();
            cmd.Dispose();

            dao.Close();
            return dt;
        }
        public int LaTrungMaSP(int MaSP)
        {
            int flag = 0;
            DAO_SanPham dao = new DAO_SanPham();
            dao.Open();
            string qry = "select * from SanPham where MaSP = " + MaSP;
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
      
        
       
    }
    
}