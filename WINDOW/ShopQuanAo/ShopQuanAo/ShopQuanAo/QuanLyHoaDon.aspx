<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDienAdmin.Master" AutoEventWireup="true" CodeBehind="QuanLyHoaDon.aspx.cs" Inherits="ShopQuanAo.QuanLyHoaDon" %>
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
                    <asp:DropDownList ID="ddlHoaDon" runat="server">
                        <asp:ListItem Value="True">Đã duyệt</asp:ListItem>
                        <asp:ListItem Value="False"  Selected="True">Chưa duyệt</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnDuyet" runat="server" Text="Duyệt" 
                        onclick="btnDuyet_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvHoaDon" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Height="170px" 
            Width="834px" DataKeyNames="MaHD" 
            onselectedindexchanging="gvHoaDon_SelectedIndexChanging" 
            AllowPaging="True" onpageindexchanging="gvHoaDon_PageIndexChanging" 
            PageSize="3">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaHD" HeaderText="Mã hóa đơn">
                <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="HoTen" HeaderText="Tên khách hàng">
                <ItemStyle HorizontalAlign="Center" Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="NgayLapHD" HeaderText="Ngày Lập HD">
                <ItemStyle HorizontalAlign="Center" Width="120px" />
                </asp:BoundField>
                <asp:BoundField DataField="NgayGiaoHang" HeaderText="Ngày giao hàng">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="DiaChiGiaoHang" HeaderText="Địa chỉ giao hàng">
                <ItemStyle HorizontalAlign="Center" Width="250px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText = "Trạng Thái" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("TrangThai").Equals(false)? "Chưa duyệt":"Đã duyệt" %></p>
                    </ItemTemplate>

<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
                 </asp:TemplateField>
                <asp:CommandField SelectText="Chọn" ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
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
      <div style="padding:20px">
        <table>
             <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Mã hóa đơn"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaHD" runat="server" Width="265px" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tên khách hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTenKH" runat="server" Width="265px" Enabled="False"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Ngày lập HD"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNgayLapHD" runat="server" Width="265px" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Ngày giao hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNgayGiaoHang" runat="server" Width="265px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label5" runat="server" Text="Địa chỉ giao hàng"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDiaChi" runat="server" TextMode="MultiLine" Height="90px" 
                        Width="265px"></asp:TextBox>
                </td>
                <td>
                     <asp:Label ID="Label6" runat="server" Text="Trạng thái"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTrangThai" runat="server">
                        <asp:ListItem Value="True">Đã duyệt</asp:ListItem>
                        <asp:ListItem Value="False"  Selected="True">Chưa duyệt</asp:ListItem>
                    </asp:DropDownList>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" 
                        onclick="btnCapNhat_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                   <h2><asp:Label ID="lblThongBao" runat="server" Text="" ForeColor="Red"></asp:Label></h2> 
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <h2>Chi tiết hóa đơn</h2>
                </td>
                
            </tr>
            <tr>
                 <td colspan="4">
                    <asp:GridView ID="gvCTHD" runat="server" AllowPaging="True" 
                         AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MaHD" 
                         ForeColor="#333333" GridLines="None"  
                         onpageindexchanging="gvCTHD_PageIndexChanging" onrowediting="gvCTHD_RowEditing" 
                         onrowupdating="gvCTHD_RowUpdating" PageSize="5" Width="834px" 
                         onrowcancelingedit="gvCTHD_RowCancelingEdit" onrowdeleting="gvCTHD_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="MaHD" HeaderText="Mã HD" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Center" Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="MaSP" HeaderText="Mã SP" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Size" HeaderText="Kích thước" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText = "Số lượng" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px"> 
                                <ItemTemplate>
                                    <p style="color:#332221;font-weight:bold;"> <%# Eval("SoLuong") %></p>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtSoLuong" runat="server" Text='<%# Eval("SoLuong") %>' Width="100px"/>
                                </EditItemTemplate>
                            <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                            <asp:BoundField DataField="DonGia" HeaderText="Đơn giá" ReadOnly="True">
                            <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:BoundField>
                            <asp:CommandField CancelText="Hủy" EditText="Sửa" ShowEditButton="True" 
                                UpdateText="Xác nhận" HeaderText ="Cập nhật">
                            <ItemStyle HorizontalAlign="Center" Width="100px" />
                            </asp:CommandField>
                            <asp:TemplateField HeaderText = "Xóa ?" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <span onclick="return confirm('Bạn có chắc chắn muốn xóa không ?')">
                                          <asp:LinkButton ID="lbtnXoa" runat="server" CommandName="Delete">Xóa</asp:LinkButton>
                                    </span>
                                </ItemTemplate>

                                 <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
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
                </td>
            </tr>
        </table>
       
      </div>
      </ContentTemplate>
      </asp:UpdatePanel>
</asp:Content>
