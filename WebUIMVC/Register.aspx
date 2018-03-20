<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebUI.Register" %>

<!doctype html>
<html lang="zh-cn" class="fullscreen-bg">

<head>
    <title>注册</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
    <!-- VENDOR CSS -->
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/vendor/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="assets/vendor/chartist/css/chartist-custom.css">
    <link rel="stylesheet" href="assets/vendor/linearicons/style.css">
    <!-- MAIN CSS -->
    <link rel="stylesheet" href="assets/css/main.css">
    <!-- FOR DEMO PURPOSES ONLY. You should remove this in your project -->
    <link rel="stylesheet" href="assets/css/demo.css">
    <!-- GOOGLE FONTS -->


    <link rel="stylesheet" href="assets/vendor/toastr/toastr.min.css">

    <!-- ICONS -->
    <link rel="apple-touch-icon" sizes="76x76" href="assets/img/apple-icon.png">
    <link rel="icon" type="image/png" sizes="96x96" href="assets/img/favicon.png">
    <script src="assets/js/jquery-3.2.1.min.js"></script>

    <script src="assets/vendor/toastr/toastr.min.js"></script>

    <style>
        .auth-box .content {
            width: 98%;
        }

        .auth-box {
            height: 650px;
        }

        .left {
            margin-left: 28%;
        }

        .sex-radio {
            margin-top: 7px;
            display: inline-block;
            margin-right: 10px;
        }

        .validateStyle {
            color: red;
            height: 10px;
            position: absolute;
            left: 0;
        }

        .form-group {
            margin-bottom: 23px;
            position: relative;
        }

        .requiredFlag:before {
            color: red;
            content: "*";
        }
    </style>
</head>

<body>

    <!-- WRAPPER -->
    <div id="wrapper">
        <div class="vertical-align-wrap">
            <div class="vertical-align-middle">
                <div class="auth-box ">
                    <div class="left">
                        <div class="content">
                            <div class="header">
                                <div class="logo text-center">
                                    <img src="assets/img/logo-dark.png" alt="Klorofil Logo">
                                </div>
                            </div>
                            <form class="form-auth-small" runat="server" ID="form1">
                                <div class="form-group">
                                    <asp:TextBox runat="server" ID="txt_RealName" placeholder="真实姓名" CssClass="form-control" /><asp:RequiredFieldValidator ID="req_RealName" runat="server" ControlToValidate="txt_RealName" CssClass="validateStyle" ErrorMessage="请填写真实姓名"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox runat="server" ID="txt_EmpCode" placeholder="工号" CssClass="form-control" /><asp:RequiredFieldValidator ID="req_EmpCode" runat="server" ControlToValidate="txt_EmpCode" CssClass="validateStyle" ErrorMessage="请填写工号"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group text-left">

                                    <label class="fancy-radio sex-radio">
                                        <input value="男" type="radio" name="sex" checked="checked" />
                                        <span><i></i>男</span>
                                    </label>

                                    <label class="fancy-radio sex-radio">
                                        <input value="女" type="radio" name="sex"/>
                                        <span><i></i>女</span>
                                    </label>


                                </div>
                                <div class="form-group">
                                    <asp:TextBox runat="server" ID="txt_IdCard" placeholder="身份证号" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ID="req_IdCard" runat="server" ControlToValidate="txt_IdCard" CssClass="validateStyle" ErrorMessage="请填写身份证号"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="reg_IdCard" ControlToValidate="txt_IdCard" ValidationExpression="\d{17}[\d|X]|\d{15}" runat="server" ErrorMessage="请输入正确的身份证号" CssClass="validateStyle"></asp:RegularExpressionValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox runat="server" ID="txt_PassW" placeholder="密码" CssClass="form-control" TextMode="Password" />
                                    <asp:RequiredFieldValidator ID="req_PassW" runat="server" ControlToValidate="txt_PassW" ErrorMessage="密码不能为空" CssClass="validateStyle"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox runat="server" ID="txt_confirmPassW" placeholder="确认密码" CssClass="form-control" TextMode="Password" />
                                    <asp:CompareValidator ID="cmp_PassW" runat="server" ControlToCompare="txt_PassW" ControlToValidate="txt_confirmPassW" Operator="Equal" ErrorMessage="两次密码不一致" CssClass="validateStyle"></asp:CompareValidator>
                                </div>

                                <div class="form-group">
                                    <asp:DropDownList ID="ddl_Department" CssClass="form-control" runat="server"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="req_Departmen" runat="server" ControlToValidate="ddl_Department" InitialValue="-1" ErrorMessage="请选择部门" CssClass="validateStyle"></asp:RequiredFieldValidator>
                                </div>
                                
                                <div class="form-group">

                                
                                <asp:Button ID="btn_Submit" runat="server" CssClass="btn btn-primary btn-lg btn-block" Text="注册" OnClick="btn_Submit_OnClick" />
                                </div>
                                <div class="form-group">
                                    <a href="Login.aspx" >回到登录页</a>
                                </div>
                                
                                

                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>
                            </form>
                        </div>
                    </div>

                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- END WRAPPER -->


</body>


<script src="assets/vendor/bootstrap/js/bootstrap.min.js"></script>

<script src="assets/vendor/jquery-slimscroll/jquery.slimscroll.min.js"></script>

<script src="assets/scripts/klorofil-common.js"></script>

</html>
