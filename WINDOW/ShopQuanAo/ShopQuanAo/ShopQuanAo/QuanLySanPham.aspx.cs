using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ShopQuanAo
{
    public partial class QuanLySanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSP(0, 1);
                DienDuLieu();
            }

        }
        public void LoadSP(int loaisp,int gioitinh)
        {
            BUS_SanPham busSP = new BUS_SanPham();
            DataTable dt = new DataTable();
            dt = busSP.LoadSPTheoLoaiAdmin(loaisp,gioitinh);

            gvDSSP.DataSource = dt.DefaultView;
            gvDSSP.DataBind();

        }

        protected void btnDuyet_Click(object sender, EventArgs e)
        {
            int loaisp = int.Parse(ddlLoaiSP.SelectedValue);
            int gioitinh = 0;
            if(rblGioitinh.SelectedValue.Equals("Nam"))
            {
                gioitinh = 1;
            }
            LoadSP(loaisp, gioitinh);

        }

        protected void gvDSSP_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int masp = int.Parse(gvDSSP.DataKeys[e.RowIndex].Value.ToString());
            BUS_SanPham busSP = new BUS_SanPham();
            busSP.XoaSP(masp);
            int loaisp = int.Parse(ddlLoaiSP.SelectedValue);
            int gioitinh = 0;
            if (rblGioitinh.SelectedValue.Equals("Nam"))
            {
                gioitinh = 1;
            }
            LoadSP(loaisp, gioitinh);
        }

        protected void gvDSSP_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("capnhatSP"))
            {
                txtSoLuongS.Enabled = false;
                txtSoLuongM.Enabled = false;
                txtSoLuongL.Enabled = false;
                txtSoLuongXL.Enabled = false;
                txtSoLuongXXL.Enabled = false;

                rfvSoLuongS.Visible = false;
                rfvSoLuongM.Visible = false;
                rfvSoLuongL.Visible = false;
                rfvSoLuongXL.Visible = false;
                rfvSoLuongXXL.Visible = false;


                int id = int.Parse(e.CommandArgument.ToString());
                int masp = int.Parse(gvDSSP.DataKeys[id].Value.ToString());

                SanPham sp = new SanPham();

                BUS_SanPham bus = new BUS_SanPham();

                sp = bus.LayThongTinSanPham(masp);

                Label2.Text = "Cập nhật sản phẩm";
                btnThemSP.Text = "Cập nhật";
                txtMaSP.Enabled = false;
                txtMaSP.Text = sp.MaSP.ToString() ;
                txtTenSP.Text = sp.TenSP;
                txtGiaMua.Text = sp.GiaMua.ToString();
                txtGiaBan.Text = sp.GiaBan.ToString();
                switch (sp.MASIZE)
                {
                    case 0:
                        txtSoLuongS.Text = sp.SoLuong.ToString();
                        txtSoLuongS.Enabled = true;
                        Session["MaSize"] = 0;
                        rfvSoLuongS.Visible = true;
                        break;
                    case 1:
                        txtSoLuongM.Text = sp.SoLuong.ToString();
                        txtSoLuongM.Enabled = true;
                        Session["MaSize"] = 1;
                        rfvSoLuongM.Visible = true;
                        break;
                    case 2:
                        txtSoLuongL.Text = sp.SoLuong.ToString();
                        txtSoLuongL.Enabled = true;
                        Session["MaSize"] = 2;
                        rfvSoLuongL.Visible = true;
                        break;
                    case 3:
                        txtSoLuongXL.Text = sp.SoLuong.ToString();
                        txtSoLuongXL.Enabled = true;
                        Session["MaSize"] = 3;
                        rfvSoLuongXL.Visible = true;
                        break;
                    case 4:
                        txtSoLuongXXL.Text = sp.SoLuong.ToString();
                        txtSoLuongXXL.Enabled = true;
                        Session["MaSize"] = 4;
                        rfvSoLuongXXL.Visible = true;
                        break;
                }
                ddlLoai.SelectedIndex = sp.LoaiSP;
                ddlChuDe.SelectedIndex = sp.ChuDe;
                txtThongTin.Text = sp.ThongTin;
                rbtngt.SelectedValue= sp.GioiTinh.ToString();
                txtNgayNhap.Text = sp.NgayNhap.ToShortDateString();
                txtHinhAnh.Text = sp.HinhAnh;

            

               
                
            }
        }

     
        protected void btnThemSP_Click(object sender, EventArgs e)
        {
            if (btnThemSP.Text.Equals("Cập nhật"))
            {
                SanPham sp = new SanPham();

                BUS_SanPham bus = new BUS_SanPham();

                sp.MaSP = int.Parse(txtMaSP.Text);
                sp.TenSP = txtTenSP.Text;
                sp.GiaMua = int.Parse(txtGiaMua.Text);
                sp.GiaBan = int.Parse(txtGiaBan.Text);
                sp.MASIZE = int.Parse(Session["MaSize"].ToString());
                switch (sp.MASIZE)
                {
                    case 0:
                        sp.SoLuong = int.Parse(txtSoLuongS.Text.Trim());
                        break;
                    case 1:
                        sp.SoLuong = int.Parse(txtSoLuongM.Text.Trim());
                        break;
                    case 2:
                        sp.SoLuong = int.Parse(txtSoLuongL.Text.Trim());
                        break;
                    case 3:
                        sp.SoLuong = int.Parse(txtSoLuongXL.Text.Trim());
                        break;
                    case 4:
                        sp.SoLuong = int.Parse(txtSoLuongXXL.Text.Trim());
                        break;
                }
                sp.LoaiSP = int.Parse(ddlLoai.SelectedValue);
                sp.ChuDe = int.Parse(ddlChuDe.SelectedValue);
                sp.ThongTin = txtThongTin.Text;
                sp.GioiTinh = int.Parse(rbtngt.SelectedValue);
                sp.NgayNhap = DateTime.Parse(txtNgayNhap.Text);
                sp.HinhAnh = txtHinhAnh.Text;

                bus.CapNhatSP(sp);
                DienDuLieu();
                lblThongBao.Text = "Cập nhật sản phẩm thành công !";
          
            }
            if (btnThemSP.Text.Equals("Thêm"))
            {

                SanPham sp = new SanPham();

                BUS_SanPham busSP = new BUS_SanPham();
                sp.MaSP = int.Parse(txtMaSP.Text);

                if (busSP.LaTrungMaSP(sp.MaSP) == 1)
                {
                    lblMaSP1.Text = "Trùng mã sản phẩm !";
                    return;
                }
                sp.TenSP = txtTenSP.Text;
                sp.GiaMua = int.Parse(txtGiaMua.Text);
                sp.GiaBan = int.Parse(txtGiaBan.Text);
                sp.LoaiSP = int.Parse(ddlLoai.SelectedValue);
                sp.ChuDe = int.Parse(ddlChuDe.SelectedValue);
                sp.ThongTin = txtThongTin.Text;
                sp.GioiTinh = int.Parse(rbtngt.SelectedValue);
                sp.NgayNhap = DateTime.Parse(txtNgayNhap.Text);
                sp.HinhAnh = txtHinhAnh.Text;
                busSP.ThemSP(sp);
                //them size s
                sp.MASIZE = 0;
                sp.SoLuong = int.Parse(txtSoLuongS.Text.Trim());
                busSP.ThemSoLuongSanPham(sp);
                //them size m
                sp.MASIZE = 1;
                sp.SoLuong = int.Parse(txtSoLuongM.Text.Trim());
                busSP.ThemSoLuongSanPham(sp);
                //them size l
                sp.MASIZE = 2;
                sp.SoLuong = int.Parse(txtSoLuongL.Text.Trim());
                busSP.ThemSoLuongSanPham(sp);
                //them size xl
                sp.MASIZE = 3;
                sp.SoLuong = int.Parse(txtSoLuongXL.Text.Trim());
                busSP.ThemSoLuongSanPham(sp);
                //them size xxl
                sp.MASIZE = 4;
                sp.SoLuong = int.Parse(txtSoLuongXXL.Text.Trim());
                busSP.ThemSoLuongSanPham(sp);

                lblThongBao.Text = "Thêm sản phẩm thành công !";
                DienDuLieu();
 
            }
        }

        protected void btnThemMoi_Click(object sender, EventArgs e)
        {

            txtSoLuongS.Enabled = true;
            txtSoLuongM.Enabled = true;
            txtSoLuongL.Enabled = true;
            txtSoLuongXL.Enabled = true;
            txtSoLuongXXL.Enabled = true;

            rfvSoLuongS.Visible = true;
            rfvSoLuongM.Visible = true;
            rfvSoLuongL.Visible = true;
            rfvSoLuongXL.Visible = true;
            rfvSoLuongXXL.Visible = true;

            Label2.Text = "Thêm sản phẩm";
            btnThemSP.Text = "Thêm";
            txtMaSP.Enabled = true;
            lblThongBao.Text = "";
            DienDuLieu();

           
        }
        public void DienDuLieu()
        {
            
            txtTenSP.Text = "";
            txtGiaMua.Text = "";
            txtGiaBan.Text = "";
            
            ddlLoai.SelectedIndex = 0;
            ddlChuDe.SelectedIndex = 0;
            txtThongTin.Text = "";
            rbtngt.SelectedValue = "0";
            txtNgayNhap.Text = "";
            txtHinhAnh.Text = "";
        }
    }
}