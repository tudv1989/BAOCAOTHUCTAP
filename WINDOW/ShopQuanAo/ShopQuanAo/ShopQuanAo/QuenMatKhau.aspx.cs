using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopQuanAo
{
    public partial class QuenMatKhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    Response.Redirect("TrangChu.aspx");
                }
            }
        }

        protected void btnLayMK_Click(object sender, EventArgs e)
        {
            BUS_KhachHang bus = new BUS_KhachHang();
            string uname = txtTenDangNhap.Text.Trim();
            KhachHang kh = new KhachHang();
            kh = bus.LayThongTinKhachHang(uname);
            if (kh.MAKH == 0 || kh.EMAIL.Equals(txtEmail.Text.Trim()) == false)
            {
                lblMatKhau.Text = "Bạn nhập sai thông tin ";
                return;
                
            }
            kh.MATKHAU = "123456";
            bus.CapNhatKhachHang(kh);
            lblMatKhau.Text = "Mật khẩu của bạn là : 123456 ! Vui lòng đổi lại để đảm bảo thông tin của bạn";
        }
    }
}