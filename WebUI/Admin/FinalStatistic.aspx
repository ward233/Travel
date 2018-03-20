<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="FinalStatistic.aspx.cs" Inherits="WebUI.Admin.FinalStatistic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">最终统计</h3>
        </div>
        <div class="panel-body">
            <table class="table table-bordered table-striped text-center">
                <thead>
                    <tr>
                        <th>疗养项目</th>
                        <th>出发时间</th>
                        <th>真实姓名</th>
                        <th>工号</th>
                        <th>性别</th>
                        <th>身份证号</th>
                        <th>生日</th>
                        <th>身高</th>
                        <th>部门</th>
                        <th>是否占床</th>
                        <th>是否老师</th>
                        <th>长号</th>
                        <th>短号</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="repTableBody" runat="server" ItemType="Model.ViewFinalStatistic">
                        <ItemTemplate>
                            <tr>
                                <td><%#Item.Title %></td>
                                <td>
                                    <%#Item.StartDate %>
                                </td>
                                <td><%#Item.RealName %></td>
                                <td><%#Item.EmpCode %></td>
                                <td><%#Item.Sex %></td>
                                <td><%#Item.IdCard %></td>
                                <td><%#Item.BirthDay %></td>
                                <td><%#Item.Height %></td>
                                <td><%#Item.DepName %></td>
                                <td><%#Item.HasBed ? "是" : "否" %></td>
                                <td><%#Item.IsTeacher ? "是" : "否" %></td>
                                <td><%#Item.LongTellNum %></td>
                                <td><%#Item.ShortTellNum %></td>
                            
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
