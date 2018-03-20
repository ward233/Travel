<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TravelStageAdd.aspx.cs" Inherits="WebUI.Admin.TravelStageAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>添加旅游行程</title>
    <style>
        .fancy-checkbox input[type="checkbox"] + span:before {
            height: 17px;
        }
        .formWarp {
            margin-top: 20px;
        }
        .btn-submit {
            width: 300px;
        }
      
    </style>
    <link href="assets/css/bootstrap-datetimepicker.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">添加旅游行程</h3>

        </div>
        <div class="panel-body">
            <div class="row">
                
                <asp:Repeater ID="RepCategory" runat="server" ItemType="Model.TravelCategory">
                    <ItemTemplate>
                    <div class="col-md-2 col-sm-4 col-xs-6">
                        <label class="fancy-checkbox">
                            <input type="checkbox" runat="server" id="CbxCategory" value="<%#Item.Id %>">
                            <span><%#Item.Title%></span>
                        </label>
                    </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
            
            <div class="form-horizontal formWarp">

                <div class="form-group">
                
           
                    <asp:TextBox ID="txt_StartDate" ClientIDMode="Static" runat="server" CssClass="form-control input-lg" placeholder="出发日期"></asp:TextBox>
                </div>

     
                <div class="form-group">
                    <div class="input-group ">
                        <asp:TextBox ID="txt_Days" runat="server" CssClass="form-control input-lg" placeholder="天数"></asp:TextBox><span class="input-group-addon">天</span>
                    </div>
                </div>
                <div class="form-group">
                    <div class="input-group ">
                        <asp:TextBox ID="txt_Count" runat="server" CssClass="form-control input-lg" placeholder="总人数"></asp:TextBox><span class="input-group-addon">人</span>
                    </div>
                </div>
                <div class="form-group">
                    <div class="input-group">
                        <asp:TextBox ID="txt_Price" runat="server" CssClass="form-control input-lg" placeholder="价格"></asp:TextBox><span class="input-group-addon">元</span>
                    </div>
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="btn btn-primary btn-lg btn-submit" OnClick="btnSubmit_OnClick" />
                </div>
            </div>

       
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="assets/js/bootstrap-datetimepicker.min.js"></script>
    <script src="assets/js/bootstrap-datetimepicker.zh-CN.js"></script>
    <script>

        $('#txt_StartDate').datetimepicker({
            language: 'zh-CN',
            format: 'yyyy-mm-dd',
            weekStart: 1,
            todayBtn: 1,
            autoclose: 1,
            todayHighlight: 1,
            startView: 2,
            minView: 2,
            forceParse: 0
        });

    </script>
</asp:Content>
