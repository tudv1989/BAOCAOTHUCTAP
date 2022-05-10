<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDienAdmin.Master" AutoEventWireup="true" CodeBehind="ThongKe.aspx.cs" Inherits="ShopQuanAo.ThongKe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
   
    <div style="padding:20px">
        <table>
            <tr>
                <td colspan="2" class="style1">
                    <h2>Danh sách sản phẩm bán chạy nhất</h2>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlTop" runat="server" Height="21px" Width="162px">
                        <asp:ListItem Value="3">Top 3</asp:ListItem>
                        <asp:ListItem Value="5">Top 5</asp:ListItem>
                        <asp:ListItem Value="10">Top 10</asp:ListItem>
                    </asp:DropDownList>
                     <asp:Button ID="btnDuyet" runat="server" Text="Duyệt" Width="89px" 
                        onclick="btnDuyet_Click" />
                </td>
                <td>
                   
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvTop" runat="server" Height="134px" Width="675px" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="GiaMua" HeaderText="Giá mua">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="GiaBan" HeaderText="Giá bán">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="SoLuongBan" HeaderText="Số lượng bán">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
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
    <div style="padding:20px">
        <table>
            <tr>
                <td colspan="2" class="style1">
                    <h2>Danh sách khách hàng mua nhiều nhất</h2>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlTopKH" runat="server" Height="21px" Width="162px">
                        <asp:ListItem Value="3">Top 3</asp:ListItem>
                        <asp:ListItem Value="5">Top 5</asp:ListItem>
                        <asp:ListItem Value="10">Top 10</asp:ListItem>
                    </asp:DropDownList>
                     <asp:Button ID="btnDuyetKH" runat="server" Text="Duyệt" Width="89px" 
                        onclick="btnDuyetKH_Click" />
                </td>
                <td>
                   
                </td>
          </tr>
          <tr>
            <td colspan="3">
                <asp:GridView ID="gvKH" runat="server" Height="134px" Width="675px" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="HoTen" HeaderText="Tên Khách Hàng">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="SoDienThoai" HeaderText="Điện thoại">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="DoanhThu" HeaderText="Doanh thu">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
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
     
     <div style="padding:20px">
        <table>
            <tr>
                <td colspan="4" class="style1">
                    <h2>Tổng doanh thu</h2>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                     <asp:Button ID="btnDoanhThu" runat="server" Text="Duyệt" Width="89px" 
                         onclick="btnDoanhThu_Click" />
                </td>
               
           </tr>
           <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Tong mua"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTongMua" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                </td>
                <td>
                     <asp:Label ID="Label2" runat="server" Text="Tong ban"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTongBan" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                </td>
           </tr>
           <tr>
            <td>
                 <asp:Label ID="Label3" runat="server" Text="Doanh thu"></asp:Label>
            </td>
            <td colspan="3">
                <asp:Label ID="lblDoanhThu" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
            </td>
           </tr>
       </table>
    </div>
     </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
