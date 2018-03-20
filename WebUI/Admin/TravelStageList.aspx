<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TravelStageList.aspx.cs" Inherits="WebUI.Admin.TravelStageList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">查看旅游行程</h3>
        </div>
        <div class="panel-body">
            <table class="table table-bordered table-striped text-center">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>旅游项目</th>
                        <th>出发时间</th>
                        <th>人数</th>
                        <th>天数</th>
                        <th>价格</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="repTableBody" runat="server" ItemType="Model.TravelStage">
                        <ItemTemplate>
                            <tr>
                                <td><%#Item.Id %></td>
                                <td>
                                    <a href="TravelCategoryDetail.aspx?id=<%#Item.TravelCategoryId %>" class="btn btn-info btn-sm"><%#Item.TravelCategory.Title %></a>
                                </td>
                                <td><%#Item.StartDate %></td>
                                <td><%#Item.Count %></td>
                                <td><%#Item.Days %></td>
                                <td><%#Item.Price %></td>
                                <td>
                                    <asp:Button ID="btn_Update" runat="server" Text="更新" CssClass="btn btn-success btn-sm" ToolTip="<%#Item.Id %>" OnClick="btn_Update_OnClick" />
                                    <asp:Button ID="btn_Delete" runat="server" Text="删除" CssClass="btn btn-danger btn-sm" ToolTip="<%#Item.Id %>" OnClick="btn_Delete_OnClick"  />
                                    
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div class="text-center">
                <webdiyer:AspNetPager ID="AspNetPager" runat="server" CssClass="pagination" LayoutType="Ul" PagingButtonLayoutType="UnorderedList" PagingButtonSpacing="0" CurrentPageButtonClass="active" PageSize="10" OnPageChanged="AspNetPager_OnPageChanged" UrlPaging="True">
                </webdiyer:AspNetPager>
            </div>


        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
