using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ShopQuanAo
{
    public partial class ThongKe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDuyet_Click(object sender, EventArgs e)
        {
            LoadTopSP();
        }
        public void LoadTopSP()
        {
            int top = int.Parse(ddlTop.SelectedValue);
            BUS_SanPham bus = new BUS_SanPham();
            DataTable dt = new DataTable();
            dt = bus.TopSanPham(top);

            gvTop.DataSource = dt.DefaultView;
            gvTop.DataBind();
        }
        public void LoadTopKH()
        {
            int top = int.Parse(ddlTopKH.SelectedValue);
            BUS_KhachHang bus = new BUS_KhachHang();
            DataTable dt = new DataTable();
            dt = bus.LoadTopKhachHang(top);

            gvKH.DataSource = dt.DefaultView;
            gvKH.DataBind();


        }

        protected void btnDuyetKH_Click(object sender, EventArgs e)
        {
            LoadTopKH();
        }
        public void LoadDoanhThu()
        {
            BUS_HoaDon bus = new BUS_HoaDon();
            DataTable dt = new DataTable();
            dt = bus.TinhDoanhThu();

            foreach(DataRow row in dt.Rows)
            {
                lblTongMua.Text = row["TongMua"].ToString();
                lblTongBan.Text = row["TongBan"].ToString();
                lblDoanhThu.Text = row["DoanhThu"].ToString();
            }
           
        }
        protected void btnDoanhThu_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }
    }
}