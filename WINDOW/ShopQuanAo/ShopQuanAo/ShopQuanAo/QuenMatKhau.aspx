<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDien.Master" AutoEventWireup="true" CodeBehind="QuenMatKhau.aspx.cs" Inherits="ShopQuanAo.QuenMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 95%;
        }
        .style2
        {
            width: 188px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
  
<div style="padding:20px;">

    <table class="style1">
        <tr>
            <td class="style2">
               <h4>Tên đăng nhập</h4></td>
            <td>
                <asp:TextBox ID="txtTenDangNhap" runat="server" Width="216px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Nhập tên đăng nhập" ForeColor="Red" 
                    ControlToValidate="txtTenDangNhap"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <h4>Email</h4></td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="216px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Nhập email" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLayMK" runat="server" Text="Lấy mật khẩu" 
                    onclick="btnLayMK_Click" />
            </td>
        </tr>
         <tr>
            <td colspan="3">
                <h4><asp:Label ID="lblMatKhau" runat="server" Text="" ForeColor="Red"></asp:Label></h4>
            </td>
        </tr>
    </table>
    
</div>
  </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
