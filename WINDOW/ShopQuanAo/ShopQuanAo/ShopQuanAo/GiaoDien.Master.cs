using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Text;

namespace ShopQuanAo
{
    public partial class GiaoDien : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
            XoaSanPham();
            LoadTieuDe();
            HienThiGioHang();
            LoadThongTinDangNhap();
        }
        public void HienThiGioHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP");
            dt.Columns.Add("Ten");
            dt.Columns.Add("SL");

            int SoLuong = 0,TongTien = 0;

            if (Session["GioHang"] != null)
            {
                ArrayList giohang = (ArrayList)Session["GioHang"];
                BUS_SanPham bus_sp = new BUS_SanPham();
                foreach(SanPham sp in giohang)
                {
                   
                    
                    DataRow dr = dt.NewRow();
                    dr["MaSP"] = sp.MaSP;
                    dr["Ten"] = sp.TenSP;
                    dr["SL"] = sp.SoLuong;
                    SoLuong += sp.SoLuong;
                    TongTien += (sp.SoLuong * sp.GiaBan);
                    dt.Rows.Add(dr);

                }
                Session["TongSL"] = SoLuong;
                Session["TongTien"] = TongTien;
                lblTongSL.Text = "Số lượng : " +SoLuong.ToString() + " sản phẩm";
                lblTongTien.Text = "Tổng tiền : " + TongTien.ToString() + " VNĐ";
                dtlGioHang.DataSource = dt;
                dtlGioHang.DataBind();
            }
        }
        public void XoaSanPham()
        {
            
            if (Request.QueryString["action"] == "xoa" && Session["GioHang"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Session["url"] = Request.UrlReferrer.ToString();
                ArrayList giohang = (ArrayList)Session["GioHang"];
                foreach (SanPham sp in giohang)
                {
                    if (sp.MaSP.Equals(id))
                    {
                        giohang.Remove(sp);
                        break;
                    }
                }
                Session["GioHang"] = giohang;
                Response.Redirect(Session["url"].ToString());

                

            }
        }

        protected void ibtnSearch_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SanPham.aspx?url=tk&value="+txtSearch.Text.Trim());
        }
        public void LoadTieuDe()
        {
            if (Request.QueryString["url"] != null)
            {
                string ulr = Request.QueryString["url"];
                switch (ulr)
                {
                    case "nam0":
                        lblTieuDe.Text = "Áo thun nam";
                        break;
                    case "nam1":
                        lblTieuDe.Text = "Áo sơ mi nam";
                        break;
                    case "nam2":
                        lblTieuDe.Text = "Áo khoác nam";
                        break;
                    case "nam3":
                        lblTieuDe.Text = "Quần Jean nam";
                        break;
                    case "nam4":
                        lblTieuDe.Text = "Quần Kaki nam";
                        break;
                    case "nu0":
                        lblTieuDe.Text = "Áo thun nữ";
                        break;
                    case "nu1":
                        lblTieuDe.Text = "Áo sơ mi nữ";
                        break;
                    case "nu2":
                        lblTieuDe.Text = "Áo khoác nữ";
                        break;
                    case "nu3":
                        lblTieuDe.Text = "Quần Jean nữ";
                        break;
                    case "nu5":
                        lblTieuDe.Text = "Váy";
                        break;
                    case "pknam":
                        lblTieuDe.Text = "Phụ kiện nam";
                        break;
                    case "pknu":
                        lblTieuDe.Text = "Phụ kiện nữ";
                        break;
                    case "saleoff":
                        lblTieuDe.Text = "Sản phẩm khuyến mãi";
                        break;
                    case "new":
                        lblTieuDe.Text = "Sản phẩm mới";
                        break;
                    case "hot":
                        lblTieuDe.Text = "Sản phẩm nổi bật";
                        break;
                    case "tk":
                        lblTieuDe.Text = "Kết quả tìm kiếm";
                        break;
                    case "dk":
                        lblTieuDe.Text = "Đăng kí thành viên";
                        break;
                    case "dn":
                         lblTieuDe.Text = "Đăng nhập";
                        break;
                    case "xemgio":
                        lblTieuDe.Text = "Chi tiết giỏ hàng của bạn";
                        break;
                    case "thanhtoan":
                        lblTieuDe.Text = "Thanh toán";
                        break;
                    case "chitiet":
                        lblTieuDe.Text = "Chi tiết sản phẩm";
                        break;
                    default:
                        break;

                }
            }
            
        }
        public void LoadThongTinDangNhap()
        {
            
            if (Session["Username"] == null)
            {
                hplLogin.Text = "Khách";
                hplLogin.NavigateUrl = "DangNhap.aspx?url=dn";
            }
            else
            {
                hplLogin.Text = Session["Username"].ToString();
                hplLogin.NavigateUrl = "ThongTinNguoiDung.aspx";
                lThoat.Visible = true;
            }
        }
      
       
    }
}