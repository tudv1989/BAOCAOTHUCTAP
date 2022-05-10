using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopQuanAo
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("TrangChu.aspx");
            }
        }

        protected void btnXacnhan_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                BUS_KhachHang bus = new BUS_KhachHang();
                int flagEmail = bus.LaTrungEmail(txtEmail.Text.Trim()) ;
                int flagUsername = bus.LaTrungTenDangNhap(txtTendangnhap.Text.Trim());

                if (flagUsername == 1 && flagEmail == 1)
                {
                    lblUsername.Text = "Tên đăng nhập này đã có người sử dụng!";
                    lblEmail.Text = "Địa chỉ Email này đã có người sử dụng!";
                    lblThongBao.Text = "Đăng kí không thành công !";


                }
                else
                    if (flagEmail == 1)
                    {
                        lblEmail.Text = "Địa chỉ Email này đã có người sử dụng!";
                        lblThongBao.Text = "Đăng kí không thành công !";
                        
                    }
                    else
                        if (flagUsername == 1)
                        {
                            lblUsername.Text = "Tên đăng nhập này đã có người sử dụng!";
                            lblThongBao.Text = "Đăng kí không thành công !";
                        }
                        else
                        {

                            KhachHang kh = new KhachHang();
                            kh.TENDANGNHAP = txtTendangnhap.Text;
                            kh.MATKHAU = txtMatkhau.Text;
                            kh.HOTEN = txtHoten.Text;
                            if (rblGioitinh.SelectedItem.Text.Equals("Nam"))
                            {
                                kh.GIOITINH = 1;
                            }
                            else
                            {
                                kh.GIOITINH = 0;
                            }
                            kh.DIACHI = txtDiachi.Text;
                            kh.EMAIL = txtEmail.Text;
                            kh.SODIENTHOAI = txtDienthoai.Text;
                            bus.GhiThongTinKhachHang(kh);
                            lblThongBao.Text = kh.TENDANGNHAP + " ! Đăng kí thành công .";
                            XoaThongTin();

                        }

             
            }
        }
        public void XoaThongTin()
        {
            txtTendangnhap.Text = "";
            txtMatkhau.Text = "";
            txtNLMatkhau.Text = "";
            txtHoten.Text = "";
            txtEmail.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            rblGioitinh.SelectedValue = null;
            lblUsername.Text = "";
            lblEmail.Text = "";


        }

       
       
    }
}