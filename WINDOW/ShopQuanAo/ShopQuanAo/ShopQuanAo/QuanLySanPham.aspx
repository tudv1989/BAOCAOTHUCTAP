<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDienAdmin.Master" AutoEventWireup="true" CodeBehind="QuanLySanPham.aspx.cs" Inherits="ShopQuanAo.QuanLySanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 52%;
        }
        .style2
        {
            width: 142px;
        }
        .style3
        {
            width: 134px;
        }
        .style5
        {
            width: 205px;
        }
        .style6
        {
            width: 191px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
   <ContentTemplate>
    <div style = "padding:10px;">

    
        <h2>Bộ lọc</h2>
         <table class="style1">
             <tr>
                 <td class="style2">
         <asp:Label ID="Label1" runat="server" Text="Loại sản phẩm "></asp:Label>
                 </td>
                 <td class="style3">
        <asp:DropDownList
            ID="ddlLoaiSP" runat="server" Height="35px" Width="110px">
            <asp:ListItem Value="0" Selected = "True">Áo thun</asp:ListItem>
            <asp:ListItem Value="1">Áo sơ mi</asp:ListItem>
            <asp:ListItem Value="2">Áo khoác</asp:ListItem>
            <asp:ListItem Value="3">Quần Jean</asp:ListItem>
            <asp:ListItem Value="4">Quần Kaki</asp:ListItem>
            <asp:ListItem Value="5">Váy</asp:ListItem>
             
            <asp:ListItem Value="6">Phụ Kiện</asp:ListItem>
             
        </asp:DropDownList>
                 </td>
                 <td>
         <asp:RadioButtonList ID="rblGioitinh" runat="server">
            <asp:ListItem Selected="True">Nam</asp:ListItem>
            <asp:ListItem>Nữ</asp:ListItem>
        </asp:RadioButtonList>
                 </td>
             </tr>
             <tr>
                 <td class="style2">
                     <asp:Button ID="btnDuyet" runat="server" onclick="btnDuyet_Click" Text="Duyệt" 
                         Width="94px" />
                 </td>
                 <td class="style3">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
             </tr>
        </table>

    </div>
   
    <div style="padding:30px;">
        <asp:GridView ID="gvDSSP" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" 
            Width="872px" DataKeyNames="MaSP" onrowdeleting="gvDSSP_RowDeleting" 
            onrowcommand="gvDSSP_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="GiaBan" HeaderText="Giá bán">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="NgayNhapHang" HeaderText="Ngày Nhập SP">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Size" HeaderText="Kích thước">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="SoLuong" HeaderText="Số lượng">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:ButtonField CommandName="capnhatSP" Text="Cập nhật">
                <ItemStyle HorizontalAlign="Center" />
                </asp:ButtonField>
                <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
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
        <asp:Button ID="btnThemMoi" runat="server" Text="Thêm Sản Phẩm" 
            onclick="btnThemMoi_Click" />

    </div>
    <div style="padding:10px;">
        <table>
            <tr>
                <td colspan="4">
                    <h1><asp:Label ID="Label2" runat="server" Text="Thêm sản phẩm"></asp:Label></h1>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblMaSP" runat="server" Text="Mã sản phẩm"></asp:Label>
                </td>
               
                <td class="style6">
                    <asp:TextBox ID="txtMaSP" runat="server" Width="180px"></asp:TextBox>
                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                         ControlToValidate="txtMaSP" ErrorMessage="Chưa nhập mã sản phẩm" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator><br />
                     <asp:Label ID="lblMaSP1" runat="server"></asp:Label>
                 </td>
                 <td>
                    <asp:Label ID="lblTenSP" runat="server" Text="Tên sản phẩm"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtTenSP" runat="server" Width="180px"></asp:TextBox>
                  
                </td>
                <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                         ControlToValidate="txtTenSP" ErrorMessage="Chưa nhập tên sản phẩm" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
              
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblGiaMua" runat="server" Text="Giá mua"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtGiaMua" runat="server" Width="180px"></asp:TextBox>
                </td>

                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                         ControlToValidate="txtGiaMua" ErrorMessage="Chưa nhập giá mua" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                 <td>
                    <asp:Label ID="Label4" runat="server" Text="Giá bán"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtGiaBan" runat="server" Width="180px"></asp:TextBox>
                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                         ControlToValidate="txtGiaBan" ErrorMessage="Chưa nhập giá bán" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblSize" runat="server" Text="Kích thước"></asp:Label>
                </td>
                <td class="style6">
                     Size S</td>
                <td></td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Số lượng"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtSoLuongS" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSoLuongS" runat="server" 
                        ErrorMessage="Chưa nhập số lượng" ControlToValidate="txtSoLuongS" 
                        ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
              <tr>
                <td>
                    &nbsp;</td>
                <td class="style6">
                     Size M</td>
                <td></td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Số lượng"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtSoLuongM" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSoLuongM" runat="server" 
                        ErrorMessage="Chưa nhập số lượng" ControlToValidate="txtSoLuongM" 
                        ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
              <tr>
                <td>
                    &nbsp;</td>
                <td class="style6">
                     Size L</td>
                <td></td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Số lượng"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtSoLuongL" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSoLuongL" runat="server" 
                        ErrorMessage="Chưa nhập số lượng" ControlToValidate="txtSoLuongL" 
                        ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
              <tr>
                <td>
                    &nbsp;</td>
                <td class="style6">
                     Size XL</td>
                <td></td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Số lượng"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtSoLuongXL" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSoLuongXL" runat="server" 
                        ErrorMessage="Chưa nhập số lượng" ControlToValidate="txtSoLuongXL" 
                        ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
              <tr>
                <td>
                    &nbsp;</td>
                <td class="style6">
                     Size XXL</td>
                <td></td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Số lượng"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtSoLuongXXL" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvSoLuongXXL" runat="server" 
                        ErrorMessage="Chưa nhập số lượng" ControlToValidate="txtSoLuongXXL" 
                        ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLoaiSP" runat="server" Text="Loại sản phẩm"></asp:Label>
                </td>
                <td class="style6">
                    <asp:DropDownList
                        ID="ddlLoai" runat="server" Height="35px" Width="185px">
                        <asp:ListItem Value="0" Selected = "True">Áo thun</asp:ListItem>
                        <asp:ListItem Value="1">Áo sơ mi</asp:ListItem>
                        <asp:ListItem Value="2">Áo khoác</asp:ListItem>
                        <asp:ListItem Value="3">Quần Jean</asp:ListItem>
                        <asp:ListItem Value="4">Quần Kaki</asp:ListItem>
                        <asp:ListItem Value="5">Váy</asp:ListItem>
                        <asp:ListItem Value="6">Phụ Kiện</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td></td>
                 <td>
                    <asp:Label ID="lblChuDe" runat="server" Text="Chủ đề"></asp:Label>
                </td>
                <td class="style6">
                    <asp:DropDownList
                        ID="ddlChuDe" runat="server" Height="35px" Width="185px">
                        <asp:ListItem Value="0" Selected = "True">HOT</asp:ListItem>
                        <asp:ListItem Value="1">Khuyến mãi</asp:ListItem>
                        <asp:ListItem Value="2">Mới</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblThongTin" runat="server" Text="Thông tin"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtThongTin" runat="server" TextMode="MultiLine" Width="180px"></asp:TextBox>
                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                         ControlToValidate="txtThongTin" ErrorMessage="Chưa nhập thông tin" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                 <td>
                    <asp:Label ID="lblGioiTinh" runat="server" Text="Giới tính"></asp:Label>
                </td>
                <td class="style6">
                     <asp:RadioButtonList ID="rbtngt" runat="server">
                        <asp:ListItem Selected="True" Value="1">Nam</asp:ListItem>
                        <asp:ListItem Value="0">Nữ</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblNgayNhap" runat="server" Text="Ngày nhập hàng"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtNgayNhap" runat="server" Width="180px"></asp:TextBox>
                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                         ControlToValidate="txtNgayNhap" ErrorMessage="Chưa nhập ngày nhập hàng" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
                  <td>
                    <asp:Label ID="lblHinhAnh" runat="server" Text="Link hình ảnh"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtHinhAnh" runat="server" Width="180px"></asp:TextBox>
                </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                         ControlToValidate="txtHinhAnh" ErrorMessage="Chưa nhập link hình ảnh" 
                         ValidationGroup="CapNhat"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnThemSP" runat="server" Text="Thêm" 
                        onclick="btnThemSP_Click" ValidationGroup="CapNhat" Height="31px" 
                        Width="75px" />
                </td>
            </tr>
            <tr>
                <td colspan ="4">
                    <h2>
                        <asp:Label ID="lblThongBao" runat="server" Text="" ForeColor="Red"></asp:Label></h2>
                </td>
            </tr>
        </table>
     </div>
     </ContentTemplate>
     </asp:UpdatePanel>
</asp:Content>
