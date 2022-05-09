<%@ Page Title="TrangChu" Language="C#" MasterPageFile="~/GiaoDien.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="ShopQuanAo.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dtlSanPham" runat="server" RepeatColumns = "3">
        <ItemTemplate>
         <div class="products">
                <a class="thumb" href="<%#Eval("MaSP", "ChiTietSanPham.aspx?action=chitiet&id={0}&url=chitiet") %>"><img src="<%# Eval("HinhAnh") %>" alt="" /></a>
                <p style="font-weight:bold;"><%# Eval("TenSP") %></p>
                <p>Mã số : <%# Eval("MaSP") %></p>
                <p>Giá bán : <%# Eval("GiaBan") %> VNĐ</p>
                <a style="margin:10px;text-decoration:none; color:red;" href="<%#Eval("MaSP", "ChiTietSanPham.aspx?action=chitiet&id={0}&url=chitiet") %>">Chi tiết...</a>
        </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat ="server">
     <div id="slider_holder" class="theme-default">
        	<div id="slider" class="nivoSlider">
           	 <img src="images/slide_01.jpg" data-thumb="images/slide_01.jpg" alt="" />
                <a href="http://dev7studios.com"><img src="images/slide_02.jpg" data-thumb="images/slide_02.jpg" alt="" title="Không còn vẻ cứng nhắc khi đến công sở, những chiếc áo sơ mi thiết kế kiểu cách giúp bạn tự tin , giấu bớt nhược điểm" /></a>
                <img src="images/slide_03.jpg" data-thumb="images/slide_03.jpg" alt="" data-transition="slideInLeft" />
                <img src="images/slide_04.jpg" data-thumb="imagesslide_04.jpg" alt="" title="#htmlcaption" />
                <img src="images/slide_05.jpg" data-thumb="images/slide_05.jpg" alt="" title="#htmlcaption" />
                <img src="images/slide_06.jpg" data-thumb="images/slide_06.jpg" alt="" title="#htmlcaption" />
            </div>
            <div id="htmlcaption" class="nivo-html-caption">
                <strong>Phong cách</strong> ấn tượng <em> và </em> cá tính với <a href="SanPham.aspx?url=hot">sản phẩm nổi bật</a>. 
            </div>
        </div>
 </asp:Content>
