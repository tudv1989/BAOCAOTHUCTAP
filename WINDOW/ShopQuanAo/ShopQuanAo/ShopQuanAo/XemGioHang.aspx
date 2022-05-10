<%@ Page Title="" Language="C#" MasterPageFile="~/GiaoDien.Master" AutoEventWireup="true" CodeBehind="XemGioHang.aspx.cs" Inherits="ShopQuanAo.XemGioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

       <div style="padding:15px 5px 5px 5px">
        <asp:GridView ID="gvGioHang" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="MaSP" GridLines="None" 
            onrowcancelingedit="gvGioHang_RowCancelingEdit" 
            onrowediting="gvGioHang_RowEditing" onrowupdating="gvGioHang_RowUpdating" 
            onrowdeleting="gvGioHang_RowDeleting" Width="667px" 
               EditRowStyle-Height="100px" RowStyle-Height="50px" ForeColor="#333333">

            <AlternatingRowStyle BackColor="White" />

            <Columns>
                <asp:BoundField HeaderText = "Mã SP" DataField="MaSP" ReadOnly="true" 
                    ItemStyle-HorizontalAlign="Center">

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:BoundField>

                <asp:TemplateField  HeaderText = "Tên SP" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                       <p style="color:#332221;font-weight:bold;"><%# Eval("TenSP") %></p>
                    </ItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText = "Kích cỡ" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("Size") %></p>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText = "Số lượng" ItemStyle-HorizontalAlign="Center"> 
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("SoLuong") %></p>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSL" runat="server" Text='<%# Eval("SoLuong") %>' Width="50px"/>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText = "Giá bán" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <p style="color:#332221;font-weight:bold;"> <%# Eval("GiaBan") %></p>
                    </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText = "Cập nhật" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnCapNhat" runat="server" CommandName="Edit">Cập nhật</asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="lbtnOK" runat="server" CommandName="Update">Xác nhận</asp:LinkButton>
                        <asp:LinkButton ID="lbtnHuy" runat="server" CommandName = "Cancel">Hủy</asp:LinkButton>
                    </EditItemTemplate>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText = "Xóa ?" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <span onclick="return confirm('Bạn có chắc chắn muốn xóa không ?')">
                              <asp:LinkButton ID="lbtnXoa" runat="server" CommandName="Delete">Xóa</asp:LinkButton>
                        </span>
                    </ItemTemplate>

                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>
            </Columns>

            <EditRowStyle Height="100px" BackColor="#39C9C4"></EditRowStyle>

            <FooterStyle BackColor="#507CD1" ForeColor="White" HorizontalAlign="Center" 
                Font-Bold="True"/>
            <HeaderStyle BackColor="#311F1F" Font-Bold="True" ForeColor="White" 
                HorizontalAlign="Center"  Height="50px"/>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="Aqua" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
        <div id="thanhtoan">
            <div style="float:right;">
                <div id="tongsp">
                    <p><font style="color:blue;font-weight: bold;">Tổng sản phẩm : </font> <font style="color:red;font-weight: bold;"><%= Session["TongSL"].ToString() %></font></p>
                </div>
                <div class="tongtien1" >
                        <p><font style="color:blue;font-weight: bold;">Tổng tiền : </font><font style="color:red;font-weight: bold;"><%= Session["TongTien"].ToString()%> VNĐ</font></p>
                </div>
                <div class="tongtien1">
                    <a href="TrangChu.aspx" style="padding-right: 15px;text-decoration: none;">Mua tiếp</a>
                    <a href="ThanhToan.aspx?url=thanhtoan" style="padding-right: 15px;text-decoration: none;">Thanh toán</a>
                </div>
           </div>
        </div>


</asp:Content>
