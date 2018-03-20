<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="TravelCategoryShow.aspx.cs" Inherits="WebUI.TravelCategoryShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .txt-title, .txt-content {
            margin-bottom: 30px;
        } 
        .label {
            font-size: 13px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">查看旅游项目详情</h3>

        </div>
        <div class="panel-body text-center">
            <h1 runat="server" id="txt_Title" class="txt-title"></h1>

            <div runat="server" id="txt_Content" class="txt-content center-block">
            </div>



        </div>

    </div>
    <div class="panel">
        <div class="panel-heading">
            <h3 class="panel-title">批次选择</h3>
        </div>
        <div class="panel-body">
            <div class="row">
                <asp:Repeater runat="server" ID="RepStageChoice" ItemType="Model.TravelStage">
                    <ItemTemplate>
                        <div class="col-lg-6" style="margin-bottom: 20px;">
                            <label class="fancy-radio">
                                <input value="<%#Item.Id %>" type="radio" name="stage" />
                                <span><i></i><span class="label label-primary">第<%#Container.ItemIndex + 1  %>批</span> 出发日期: <span class="label label-info"><%#Item.StartDate %> 日</span>  天数: <span class="label label-info"><%#Item.Days %> 天</span>  价格: <span class="label label-info"><%#Item.Price %>元</span>    剩余人数: <span class="label label-danger"><%#Item.Count %>人</span> </span>



                            </label>

                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>



            <div class="form-group text-center" style="margin-top: 30px;">
                <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="btn btn-primary btn-lg btn-submit" OnClick="btnSubmit_OnClick" />
            </div>

        </div>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
