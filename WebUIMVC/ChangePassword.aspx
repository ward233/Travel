<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebUI.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btnSubmit {
            margin-left: -60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">添加家属信息</h3>

        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <div class="form-horizontal">

                        <div class="form-group">

                            <label for="txt_NewPassword" class="col-md-3 control-label">新密码:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_NewPassword" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="新密码"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <label for="txt_ConfirmPassword" class="col-md-3 control-label">确认密码:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_ConfirmPassword" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="确认密码"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group text-center">
                            <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="btn btn-primary btnSubmit btn-lg" OnClick="btnSubmit_OnClick" />
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
