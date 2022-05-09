using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ShopQuanAo
{
    public partial class QuanLyBinhLuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBL();
                Session["PageIndex"] = 0;
            }
        }
        public void LoadBL()
        {
            BUS_BinhLuan busBL = new BUS_BinhLuan();
            DataTable dt = new DataTable();
            dt = busBL.LoadBinhLuan(0, 2);

            gvBinhLuan.DataSource = dt.DefaultView;
            gvBinhLuan.DataBind();
        }

        protected void gvBinhLuan_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            BUS_BinhLuan busBL = new BUS_BinhLuan();
            DataTable dt = new DataTable();
            int flag = int.Parse(ddlBinhLuan.SelectedValue);
            dt = busBL.LoadBinhLuan(0, flag);
            Session["PageIndex"] = e.NewPageIndex;
            gvBinhLuan.DataSource = dt.DefaultView;
            gvBinhLuan.PageIndex = e.NewPageIndex;
            gvBinhLuan.DataBind();
        }

        protected void btnDuyet_Click(object sender, EventArgs e)
        {
            BUS_BinhLuan busBL = new BUS_BinhLuan();
            DataTable dt = new DataTable();
            int flag = int.Parse(ddlBinhLuan.SelectedValue);
            dt = busBL.LoadBinhLuan(0, flag);

            gvBinhLuan.DataSource = dt.DefaultView;
            gvBinhLuan.DataBind();
        }

        protected void gvBinhLuan_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            int id = int.Parse(gvBinhLuan.DataKeys[e.NewSelectedIndex].Value.ToString());
            Session["MaBL"] = id;
            BinhLuan bl = new BinhLuan();
            BUS_BinhLuan bus = new BUS_BinhLuan();
            bl = bus.LayThongTinBinhLuan(id);

            txtHoten.Text = bl.TENKH;
            txtTieuDe.Text = bl.TIEUDE;
            txtNoiDung.Text = bl.NOIDUNG;
            txtTenSP.Text = bl.TENSP;
            lblNgayGui.Text = bl.NGAYBL.ToShortDateString();
            ddlTrangThai.SelectedValue = bl.TRANGTHAI.ToString();

            lblThongBao.Text = "";
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (Session["MaBL"] != null)
            {
                int id = int.Parse(Session["MaBL"].ToString());
                BUS_BinhLuan bus = new BUS_BinhLuan();
                bus.XoaBL(id);
                Session["MaBL"] = null;
                DataTable dt = new DataTable();
                int flag = int.Parse(ddlBinhLuan.SelectedValue);
                dt = bus.LoadBinhLuan(0, flag);
                gvBinhLuan.DataSource = dt.DefaultView;
                gvBinhLuan.SelectedIndex = -1;
                gvBinhLuan.PageIndex = int.Parse(Session["PageIndex"].ToString());
                gvBinhLuan.DataBind();
                lblThongBao.Text = "";

                txtHoten.Text = "";
                txtTieuDe.Text = "";
                txtNoiDung.Text = "";
                txtTenSP.Text = "";
            }
            else
            {

                lblThongBao.Text = "Chưa chọn bình luận cần xóa !";
            }

        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Session["MaBL"] != null)
            {
                int id = int.Parse(Session["MaBL"].ToString());
                BUS_BinhLuan bus = new BUS_BinhLuan();

                BinhLuan bl = new BinhLuan();
                bl.MABINHLUAN = id;
                bl.TIEUDE = txtTieuDe.Text;
                bl.NOIDUNG = txtNoiDung.Text;
                bl.TRANGTHAI = bool.Parse(ddlTrangThai.SelectedValue);
                bus.CapNhatBinhLuan(bl);
                Session["MaBL"] = null;
                DataTable dt = new DataTable();
                int flag = int.Parse(ddlBinhLuan.SelectedValue);
                dt = bus.LoadBinhLuan(0, flag);
                gvBinhLuan.DataSource = dt.DefaultView;
                gvBinhLuan.SelectedIndex = -1;
                gvBinhLuan.PageIndex = int.Parse(Session["PageIndex"].ToString());
                gvBinhLuan.DataBind();
                lblThongBao.Text = "";
            }
            else
            {

                lblThongBao.Text = "Chưa chọn bình luận cần cập nhật !";
            }

        }

      
    }
}