<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDien.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="ShopQuanAo.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="wrapper_reg">
        <div id="content_reg">
           <div id="content_login">
               <asp:ScriptManager ID="ScriptManager1" runat="server">
               </asp:ScriptManager>
               <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
               
              <table width="330px">
                <tr>
                    <td colspan="2"><h1>Đăng Nhập</h1></td>
                </tr>
                <tr>
                    <td><p>Tên đăng nhập</p></td>
                    <td><asp:TextBox ID="txtTendangnhap" runat="server" Height="20px" Width="170px"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td><p>Mật khẩu</p></td>
                    <td><asp:TextBox ID="txtMatkhau" runat="server" Height="20px" Width="170px" 
                            TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:ImageButton ID="ibtnLogin" runat="server" 
                            ImageUrl="~/images/button_login.png"  CssClass="button_login" 
                            onclick="ibtnLogin_Click"/>
                    </td>
                    <td>
                        <asp:HyperLink ID="hplQuenmatkhau" runat="server" NavigateUrl="QuenMatKhau.aspx">Quên mật khẩu ?</asp:HyperLink><br />
                        <asp:HyperLink ID="hplDangki" runat="server" NavigateUrl="DangKy.aspx">Chưa có tài khoản ?</asp:HyperLink>

                    </td>
                    
                    
                </tr>
              </table>
              <div id="login_message">
                  <asp:Label ID="lblThongbao" runat="server" CssClass="login_message"></asp:Label><br />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ErrorMessage="Vui lòng nhập tên đăng nhập" 
                      ControlToValidate="txtTendangnhap" ForeColor="Red"></asp:RequiredFieldValidator><br />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ErrorMessage="Vui lòng nhập mật khẩu" ControlToValidate="txtMatkhau" 
                      ForeColor="Red"></asp:RequiredFieldValidator>
              </div>
               </ContentTemplate>
              </asp:UpdatePanel>
           </div>

        </div>
    </div>
</asp:Content>
