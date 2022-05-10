using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopQuanAo
{
    public partial class GiaoDienAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        public void LoadThongTin()
        {
            if (Session["Username"] != null)
            {
                string username = Session["Username"].ToString();
                BUS_KhachHang bus = new BUS_KhachHang();
                KhachHang kh = new KhachHang();
                kh = bus.LayThongTinKhachHang(username);
                if (kh.LAADMIN.Equals(true))
                {
                    lblTenDangNhap.Text = username;
                }
                else
                {
                    Response.Redirect("TrangChu.aspx");
                }
               
            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }
        }
    }
}