<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TravelCategoryList.aspx.cs" Inherits="WebUI.Admin.TravelCategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">查看旅游项目</h3>
        </div>
        <div class="panel-body">
            <table class="table table-bordered table-striped text-center">
                <thead >
                <tr>
                    <th>#</th>
                    <th>标题</th>
                    <th>创建时间</th>
                    <th>操作</th>
                </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="repTableBody" runat="server" ItemType="Model.TravelCategory">
                       <ItemTemplate>
                           <tr>
                               <td><%#Item.Id %></td>
                               <td><%#Item.Title %></td>
                               <td><%#Item.CreateDate %></td>
                               <td>
                                   <asp:Button ID="btn_Show" runat="server" Text="查看" CssClass="btn btn-primary btn-sm" OnClick="Btn_Show_OnClick" ToolTip="<%#Item.Id %>" />
                                   <asp:Button ID="btn_Update" runat="server" Text="更新" CssClass="btn btn-success btn-sm" OnClick="Btn_Update_OnClick" ToolTip="<%#Item.Id %>" />           
                                   <asp:Button ID="btn_Delete" runat="server" Text="删除" CssClass="btn btn-danger btn-sm" OnClick="Btn_Delete_OnClick" ToolTip="<%#Item.Id %>" />
                             
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
