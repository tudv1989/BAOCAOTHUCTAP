using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopQuanAo
{
    public partial class ThoatDangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Logout();

        }
        public void Logout()
        {
            
            Session["Username"] = null;
            Session["GioHang"] = null;
            Response.Redirect("TrangChu.aspx");
          
        }
    }
}