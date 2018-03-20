<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TravelCategoryEdit.aspx.cs" Inherits="WebUI.Admin.TravelCategoryEdit" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/ueditor/ueditor.config.js"></script>
    <script src="/ueditor/ueditor.all.js"></script>
    <script src="/ueditor/lang/zh-cn/zh-cn.js"></script>
    <style>
        .btn-submit {
            width: 300px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">更新旅游项目</h3>

        </div>
        <div class="panel-body">

            <div class="form-group">

                <asp:TextBox ID="txt_Title" runat="server" CssClass="form-control input-lg" placeholder="项目标题"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:TextBox ID="txt_Editor" runat="server" Height="500px" Rows="10" TextMode="MultiLine" Width="100%"></asp:TextBox>

            </div>
            <div class="form-group text-center">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary btn-lg btn-submit" OnClick="btnSubmit_OnClick" Text="提交" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script>
        var ue = UE.getEditor('body_txt_Editor');

    </script>
</asp:Content>
