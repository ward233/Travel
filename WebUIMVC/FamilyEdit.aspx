<%@ Page Title="" Language="C#" MasterPageFile="~/Front.Master" AutoEventWireup="true" CodeBehind="FamilyEdit.aspx.cs" Inherits="WebUI.FamilyEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .sex-radio {
            margin-top: 7px;
            display: inline-block;
            margin-right: 10px;
        }

        .fancy-checkbox {
            margin-top: 7px;
        }

        .btnSubmit {
            margin-left: -60px;
        }
    </style>
    <link href="assets/css/bootstrap-datetimepicker.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-headline">
        <div class="panel-heading">
            <h3 class="panel-title">修改家属信息</h3>

        </div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <div class="form-horizontal">

                        <div class="form-group">

                            <label for="txt_RealName" class="col-md-3 control-label">真实姓名:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_RealName" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="真实姓名"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-md-3 control-label">性别:</label>
                            <div class="col-md-6">


                                <label class="fancy-radio sex-radio">
                                    <input value="男" type="radio" runat="server" id="rad_Man" checked />
                                    <span><i></i>男</span>
                                </label>

                                <label class="fancy-radio sex-radio">
                                    <input value="女" type="radio" runat="server" id="rad_Woman" />
                                    <span><i></i>女</span>
                                </label>

                            </div>

                        </div>

                        <div class="form-group">

                            <label for="txt_IdCard" class="col-md-3 control-label">身份证号:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_IdCard" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="身份证号"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <label for="txt_BirthDay" class="col-md-3 control-label">生日:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_BirthDay" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="生日"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <label class="col-md-3 control-label">是否占床位:</label>
                            <div class="col-md-6">

                                <label class="fancy-checkbox">
                                    <input name="HasBed" value="hasBed" type="checkbox" runat="server" id="ckb_HasBed" />
                                    <span><i></i>占床位</span>
                                </label>
                            </div>
                        </div>
                        <div class="form-group">

                            <label for="txt_Height" class="col-md-3 control-label">身高:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_Height" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="身高"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <label for="txt_LongTellNum" class="col-md-3 control-label">长号:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_LongTellNum" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="长号"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <label for="txt_ShortTellNum" class="col-md-3 control-label">短号:</label>
                            <div class="col-md-6">
                                <asp:TextBox ID="txt_ShortTellNum" ClientIDMode="Static" CssClass="form-control" runat="server" placeholder="短号"></asp:TextBox>
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

    <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="assets/js/bootstrap-datetimepicker.min.js"></script>
    <script src="assets/js/bootstrap-datetimepicker.zh-CN.js"></script>
    <script>

        $('#txt_BirthDay').datetimepicker({
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

        $("input[type='radio']").change(function () {
            $("input[type='radio']").not($(this)).attr("checked", "");
        })
    </script>
</asp:Content>
