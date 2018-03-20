<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="FillFormNotice.aspx.cs" Inherits="WebUI.Admin.FillFormNotice" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>

    <script src="/ueditor/ueditor.config.js"></script>
    <script src="/ueditor/ueditor.all.js"></script>
    <script src="/ueditor/lang/zh-cn/zh-cn.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">添加填表须知</h3>

        </div>
        <div class="panel-body">

            <div class="form-group">
                <asp:TextBox ID="txt_Editor" runat="server" TextMode="MultiLine" Height="500px" Rows="10" Width="100%"></asp:TextBox>

            </div>
            <div class="form-group text-center">
                <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="btn btn-primary btn-lg btn-submit" OnClick="btnSubmit_OnClick" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script>
        var ue = UE.getEditor('body_txt_Editor');

    </script>
</asp:Content>
