<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDien.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="ShopQuanAo.SanPham1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <%--Không hiển thị slider tại trang SanPham.aspx--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
     <asp:DataList ID="dtlSanPham" runat="server" RepeatColumns = "3">
        <ItemTemplate>
             <div class="products">
                <a class="thumb" href="<%#Eval("MaSP", "ChiTietSanPham.aspx?action=chitiet&id={0}") %>"><img src="<%# Eval("HinhAnh") %>" alt="" /></a>
                <p style="font-weight:bold;"><%# Eval("TenSP") %></p>
                <p>Mã số : <%# Eval("MaSP") %></p>
                <p>Giá bán : <%# Eval("GiaBan") %> VNĐ</p>
                <a style="margin:10px;text-decoration:none; color:red;" href="<%#Eval("MaSP", "ChiTietSanPham.aspx?action=chitiet&id={0}") %>">Chi tiết...</a>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
