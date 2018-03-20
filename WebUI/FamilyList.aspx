<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="FamilyList.aspx.cs" Inherits="WebUI.FamilyList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">查看家属信息</h3>
        </div>
        <div class="panel-body">
            <table class="table table-bordered table-striped text-center">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>真实姓名</th>
                        <th>性别</th>
                        <th>身份证号</th>
                        <th>生日</th>
                        <th>是否占床</th>
                        <th>身高</th>
                        <th>长号</th>
                        <th>短号</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="repTableBody" runat="server" ItemType="Model.FamilyInfo">
                        <ItemTemplate>
                            <tr>
                                <td><%#Item.Id %></td>
                                <td><%#Item.RealName %></td>
                                <td><%#Item.Sex %></td>
                                <td><%#Item.IdCard %></td>
                                <td><%#Item.BirthDay %></td>
                                <td><%#Item.HasBed ? "是" : "否" %></td>
                                <td><%#Item.Height %></td>
                                <td><%#Item.LongTellNum %></td>
                                <td><%#Item.ShortTellNum %></td>
                                <td>
                                    <asp:Button ID="btn_Update" runat="server" Text="更新" CssClass="btn btn-success btn-sm"  ToolTip="<%#Item.Id %>" OnClick="btn_Update_OnClick" />
                                    <asp:Button ID="btn_Delete" runat="server" Text="删除" CssClass="btn btn-danger btn-sm"  ToolTip="<%#Item.Id %>" OnClick="btn_Delete_OnClick" OnClientClick="return confirm('确定要删除吗?');" />

                                </td>
                            </tr>
                        </ItemTemplate>

                        <FooterTemplate>
                            <tr>
                                <td colspan="10" runat="server" visible='<%#bool.Parse((repTableBody.Items.Count==0).ToString())%>' >
                                    <asp:Label ID="lblEmpty"
                                               Text="当前没有家属信息" runat="server"
                                               Visible='<%#bool.Parse((repTableBody.Items.Count==0).ToString())%>' >      
     
                                    </asp:Label></td>
                            </tr>
                   
                        </FooterTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div class="text-center">
                <webdiyer:AspNetPager ID="AspNetPager" runat="server" CssClass="pagination" LayoutType="Ul" PagingButtonLayoutType="UnorderedList" PagingButtonSpacing="0" CurrentPageButtonClass="active" PageSize="10" OnPageChanged="AspNetPager_OnPageChanged" UrlPaging="True">
                </webdiyer:AspNetPager>
            </div>


        </div>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
