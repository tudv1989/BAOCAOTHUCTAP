using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopQuanAo
{
    public partial class PostComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThemComment();

        }
        public void ThemComment()
        {
            // nhận các tham số truyền theo method post
            string tieude = Request["td"];
            string noidung = Request["nd"];
            int masp = (int)Session["MaSP"];
            DateTime date = DateTime.Now;
            //lay ma khach hang thong qua username
            string username = (string)Session["Username"];
            int makh;
            BUS_KhachHang bus = new BUS_KhachHang();
            if (bus.LayMaKH(username) != -1)
            {
                makh = bus.LayMaKH(username);
            }
            else
            {
                return;
            }
            //neu nhap day du tieu de va noi dung
            if (tieude != null && noidung != null)
            {
                BUS_BinhLuan bus_bl = new BUS_BinhLuan();
                BinhLuan bl = new BinhLuan();
                bl.TIEUDE = tieude;
                bl.NOIDUNG = noidung;
                bl.NGAYBL = date;
                bl.MASP = masp;
                bl.MAKH = makh;
                bl.TRANGTHAI = false;
                bus_bl.ThemBinhLuan(bl);

                Response.Write("1");

            }
            //truong hop khong nhap tieu de hoac noi dung
            else
            {
                Response.Write("0");
            }

        }
    }
}