using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;

namespace ShopQuanAo
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LayThongTinSanPham();
            LoadBinhLuan();
            ThemSP_GioHang();

        }
        public void LayThongTinSanPham()
        {
            if (Request.QueryString["action"] == "chitiet")
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                Session["MaSP"] = id;
                BUS_SanPham bus = new BUS_SanPham();
                SanPham sp = new SanPham();

                sp = bus.LayThongTinSanPham(id);

                lblTenSP.Text = sp.TenSP;
                lblGiaBan.Text = "Giá : " + sp.GiaBan.ToString() +" VNĐ";
                imgSanPham.ImageUrl = sp.HinhAnh;
                pGiaBan.InnerText = sp.ThongTin;
                //do thong tin size len combobox 
                if (bus.LayKichThuocSanPham(id).Rows.Count == 0)
                {
                    ibtnMua.Visible = false;
                    ddlSize.DataSource = null;
                    lblTinhTrang.Text = "Tình trạng : hết hàng.";
                    ddlSize.DataBind();
                }
                else
                {
                    ddlSize.DataSource = bus.LayKichThuocSanPham(id);
                    ddlSize.DataBind();
                    lblTinhTrang.Text = "Tình trạng : Còn hàng.";
                }
               
                ibtnMua.PostBackUrl = "ChiTietSanPham.aspx?action=add&id="+id+"&url=chitiet";
            }
            

        }
        public void ThemSP_GioHang()
        {
            if (Request.QueryString["action"] == "add" && Session["Username"] == null)
            {
                Response.Write("<Script>alert(\"Vui lòng đăng nhập , để sử dụng chức năng này .\")</Script>");
                return;
            }
            if (Request.QueryString["action"] == "add")
            {
                int id = int.Parse(Request.QueryString["id"]);
                int size = int.Parse(ddlSize.SelectedValue.ToString());
                if (Session["GioHang"] == null)
                {
                    ArrayList giohang = new ArrayList();

                    // tạo mới món hàng
                    BUS_SanPham bus = new BUS_SanPham();
                    SanPham sp = bus.LayThongTinSanPham(id); // thêm vào slg 1
                    sp.SoLuong = 1;
                    sp.MASIZE = size;
                    // thêm vào giỏ hàng
                    giohang.Add(sp);
                    // lưu trong session
                    Session["GioHang"] = giohang;

                }
                else
                {

                    ArrayList giohang = (ArrayList)Session["GioHang"];
                    bool flag = false;
                    foreach (SanPham sp in giohang)
                    {
                        if (sp.MaSP == id && sp.MASIZE == size)
                        {
                            sp.SoLuong += 1;
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        // tạo mới món hàng
                        BUS_SanPham bus = new BUS_SanPham();
                        SanPham sp = bus.LayThongTinSanPham(id); // thêm vào slg 1
                        sp.MASIZE = size;
                        sp.SoLuong = 1;
                        // thêm vào giỏ hàng
                        giohang.Add(sp);
                    }
                }
                Response.Redirect("ChiTietSanPham.aspx?action=chitiet&id=" + id + "&url=chitiet");
             

            }
        }
        public void LoadBinhLuan()
        {
            int id = (int)Session["MaSP"];
            BUS_BinhLuan bus = new BUS_BinhLuan();
            DataTable dt = bus.LoadBinhLuan(id,0);
            dlBinhLuan.DataSource = dt;
            dlBinhLuan.DataBind();
        }

       
    }
}