using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace ShopQuanAo
{
    public partial class SanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            LoadSanPham();
     

        }
        public void LoadSanPham()
        {
            if (Request.QueryString["url"] != null)
            {
                string ulr = Request.QueryString["url"];
                Session["url"] = Request.UrlReferrer.ToString();
                BUS_SanPham bus = new BUS_SanPham();
                switch (ulr)
                {
                    case "nam0":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(0, 1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nam0";
                        break;
                    case "nam1":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(1, 1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nam1";
                        break;
                    case "nam2":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(2, 1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nam2";
                        break;
                    case "nam3":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(3, 1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nam3";
                        break;
                    case "nam4":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(4, 1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nam4";
                        break;
                    case "nu0":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(0, 0);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nu0";
                        break;
                    case "nu1":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(1, 0);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nu1";
                        break;
                    case "nu2":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(2, 0);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nu2";
                        break;
                    case "nu3":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(3, 0);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nu3";
                        break;
                    case "nu5":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(5, 0);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "nu4";
                        break;
                    case "pknam":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(6, 1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "pknam";
                        break;
                    case "pknu":
                        dtlSanPham.DataSource = bus.LoadSanPhamTheoLoai(6, 0);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "pknu";
                        break;
                    case "saleoff":
                        dtlSanPham.DataSource = bus.LoadSanPhamChuDe(3);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "saleoff";
                        break;
                    case "new":
                        dtlSanPham.DataSource = bus.LoadSanPhamChuDe(2);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "new";
                        break;
                    case "hot":
                        dtlSanPham.DataSource = bus.LoadSanPhamChuDe(1);
                        dtlSanPham.DataBind();
                        Session["LoaiSP"] = "hot";
                        break;
                    case "tk":
                        string TenSP = Request.QueryString["value"];
                        dtlSanPham.DataSource = bus.TimKiemSanPham(TenSP);
                        dtlSanPham.DataBind();
                        break;
                    default:
                        break;

                }

            }


        }
        
    }
}