<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDienAdmin.Master" AutoEventWireup="true" CodeBehind="QuanLyBinhLuan.aspx.cs" Inherits="ShopQuanAo.QuanLyBinhLuan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div style="padding:20px;">
        <h2>Bộ lọc</h2>
        <table>
            <tr>
                <td>
                    <p>Trạng thái</p>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBinhLuan" runat="server">
                        <asp:ListItem Value="1">Đã duyệt</asp:ListItem>
                        <asp:ListItem Value="2"  Selected="True">Chưa duyệt</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnDuyet" runat="server" Text="Duyệt" 
                        onclick="btnDuyet_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvBinhLuan" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Height="111px" 
            Width="874px" AllowPaging="True" DataKeyNames="MaBinhLuan" 
            onpageindexchanging="gvBinhLuan_PageIndexChanging" PageSize="5" 
            onselectedindexchanging="gvBinhLuan_SelectedIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="HoTen" HeaderText="Tên khách hàng">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="TieuDe" HeaderText="Tiêu đề bình luận">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="NoiDung" HeaderText="Nội dung bình luận">
                <ItemStyle HorizontalAlign="Center" Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="NgayBL" HeaderText="Ngày gửi bình luận">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                 <asp:TemplateField HeaderText = "Trạng Thái" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("TrangThai").Equals(false)? "Chưa duyệt":"Đã duyệt" %></p>
                    </ItemTemplate>

<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
                 </asp:TemplateField>
                <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    <div style="padding:20px;">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Tên khách hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHoten" runat="server" Width="265px" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tên sản phẩm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTenSP" runat="server" Width="265px" Enabled="False"></asp:TextBox>
                </td>

            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Tiêu đề"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTieuDe" runat="server" Width="265px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Nội dung"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNoiDung" runat="server" Width="265px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Ngày gửi"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblNgayGui" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Trạng thái"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTrangThai" runat="server">
                        <asp:ListItem Value="True">Đã duyệt</asp:ListItem>
                        <asp:ListItem Value="False">Chưa duyệt</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" Width="100px" 
                        onclick="btnCapNhat_Click" />
                </td>
                <td>
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="100px" 
                        onclick="btnXoa_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <h2><asp:Label ID="lblThongBao" runat="server" Text="" ForeColor="Red"></asp:Label></h2>
                </td>
            </tr>
        </table>
    </div>
     </ContentTemplate>
    </asp:UpdatePanel>
   
</asp:Content>
