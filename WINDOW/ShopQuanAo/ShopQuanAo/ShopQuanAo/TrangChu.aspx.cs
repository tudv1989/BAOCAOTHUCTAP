using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace ShopQuanAo
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["url"] = "TrangChu.aspx";
            HienThiSanPham();
        }
        public void HienThiSanPham()
        {
            BUS_SanPham bus = new BUS_SanPham();
            dtlSanPham.DataSource = bus.LoadSanPhamChuDe(1);
            dtlSanPham.DataBind();
        }
        
    }
}