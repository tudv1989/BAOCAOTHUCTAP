using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections; 

namespace ShopQuanAo
{
    public partial class XemGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["GioHang"] == null)
                {
                    Response.Redirect("TrangChu.aspx");
                    return;
                }
                LoadGioHang();
                Session["LoaiSP"] = "xemgio";
             
            }
        }
        public void LoadGioHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP");
            dt.Columns.Add("TenSP");
            dt.Columns.Add("Size");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("GiaBan");
       
            if (Session["GioHang"] != null)
            {
                ArrayList giohang = (ArrayList)Session["GioHang"];
                BUS_SanPham bus_sp = new BUS_SanPham();
                foreach (SanPham sp in giohang)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaSP"] = sp.MaSP;
                    dr["TenSP"] = sp.TenSP;
                    switch (sp.MASIZE)
                    {
                        case 0:
                            dr["Size"] = "S";
                            break;
                        case 1:
                            dr["Size"] = "M";
                            break;
                        case 2:
                            dr["Size"] = "L";
                            break;
                        case 3:
                            dr["Size"] = "XL";
                            break;
                        case 4:
                            dr["Size"] = "XXL";
                            break;
                            
                    }
                    dr["SoLuong"] = sp.SoLuong;
                    dr["GiaBan"] = sp.GiaBan;
                    dt.Rows.Add(dr);

                }
                gvGioHang.DataSource = dt.DefaultView;
                gvGioHang.DataBind();

            }
        }
        
        protected void gvGioHang_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvGioHang.EditIndex = e.NewEditIndex;
            LoadGioHang();

        }

        protected void gvGioHang_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvGioHang.EditIndex = -1;
            LoadGioHang();
        }

        protected void gvGioHang_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int masp = int.Parse(gvGioHang.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = gvGioHang.Rows[e.RowIndex];
            TextBox tsl = row.FindControl("txtSL") as TextBox;
            string t = tsl.Text;
            ArrayList giohang = (ArrayList)Session["GioHang"];
            foreach (SanPham sp in giohang)
            {
                if (sp.MaSP == masp)
                {
                    sp.SoLuong = int.Parse(t);
                    break;

                }
            }
            Session["GioHang"] = giohang;
            gvGioHang.EditIndex = -1;
            LoadGioHang();
            Response.Redirect("XemGioHang.aspx?url=xemgio");
        }

        protected void gvGioHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int masp = int.Parse(gvGioHang.DataKeys[e.RowIndex].Value.ToString());
            ArrayList giohang = (ArrayList)Session["GioHang"];
            foreach (SanPham sp in giohang)
            {
                if (sp.MaSP == masp)
                {
                    giohang.Remove(sp);
                    break;

                }
            }
            Session["GioHang"] = giohang;
            LoadGioHang();
            Response.Redirect("XemGioHang.aspx?url=xemgio");
        }

       

        

       
    }
}