<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TravelCategoryDetail.aspx.cs" Inherits="WebUI.Admin.TravelCategoryDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .txt-title,.txt-content {
            margin-bottom: 30px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">查看旅游项目详情</h3>

        </div>
        <div class="panel-body text-center">
            <h1 runat="server" ID="txt_Title" class="txt-title">

            </h1>
            
            <div runat="server" ID="txt_Content" class="txt-content">

            </div>
            
            <a href="#" runat="server" id="GoBack" class="btn btn-primary btn-lg">返回</a>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
