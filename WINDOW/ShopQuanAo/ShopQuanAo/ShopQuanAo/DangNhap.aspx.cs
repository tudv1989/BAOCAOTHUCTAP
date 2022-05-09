using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopQuanAo
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("TrangChu.aspx");
            }
        }

        protected void ibtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            string username = txtTendangnhap.Text.Trim();
            string password = txtMatkhau.Text.Trim();

            BUS_KhachHang bus = new BUS_KhachHang();

            int flag = bus.LaDangNhapThanhCong(username,password);

            if (flag == 0)
            {
                Session["Username"] = username;
                Response.Redirect("TrangChu.aspx");
            }
            else
                if (flag == 1)
                {
                    Session["Username"] = username;
                    Response.Redirect("QuanLy.aspx");

                }
                else
                {
                    lblThongbao.Text = "Thông tin đăng nhập không chính xác !<br />Vui lòng nhập lại.";
                }
        }
    }
}