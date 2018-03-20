<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>


<!DOCTYPE html>
<html class="fullscreen-bg">
<head>
    <title>登陆</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">

    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/vendor/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="assets/vendor/linearicons/style.css">

    <link rel="stylesheet" href="assets/css/main.css">

    <link rel="stylesheet" href="assets/css/demo.css">

    <!-- ICONS -->
    <link rel="apple-touch-icon" sizes="76x76" href="assets/img/apple-icon.png">
    <link rel="icon" type="image/png" sizes="96x96" href="assets/img/favicon.png">

    <style>
        #MsgTxt {
            color: #ff0000;
        }
        .auth-box .content {
            width: 98%;
        }
        
        .fill-form-info {
            background-image: none !important;
            height: auto !important;
            float: left !important;
            padding-right: 30px;
            padding-left: 30px;
            border-right: 1px solid #eee;
        }
        .left {
            float: right !important;
        }
        .auth-box {
            height: 650px;
        }
 
    </style>
</head>
<body>

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
                            <form class="form-auth-small" runat="server">
                                <div class="form-group">
                                    <label for="signin-email" class="control-label sr-only">工号:</label>
                                    <asp:TextBox ID="txt_EmpCode" class="form-control" runat="server" placeholder="工号"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="signin-password" class="control-label sr-only">密码:</label>
                                    <asp:TextBox ID="txt_UserPwd" class="form-control" runat="server" TextMode="Password" placeholder="密码"></asp:TextBox>
                                </div>
                                <div class="form-group" style="position: relative">
                                    <label for="signin-password" class="control-label sr-only">验证码:</label>
                                    <asp:TextBox ID="txt_CheckCode" class="form-control" runat="server" placeholder="验证码" Width="80%"></asp:TextBox>
                                    <a onclick="refresh()" style="position: absolute; top: 5px; right: 4px;">
                                        <img src="ValidateImg.ashx" id="ValidateCodeImage" style="cursor: pointer" /></a>
                                </div>
                                <div>

                                </div>

                                <asp:Button ID="btn_Login" class="btn btn-primary btn-lg btn-block" runat="server" Text="登录" OnClick="btn_Login_Click" />

                                <div class="bottom">
                                    <asp:Label ID="MsgTxt" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="bottom">
                                    <span class="helper-text">工号没有收录?<a href="Register.aspx">注册</a></span>
                                </div>
                            </form>
                        </div>
                    </div>
                    <div class="right fill-form-info">

                        <div runat="server" id="div_FillForm">
                        </div>
                    </div>
            
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
    </div>
    <script src="js/coderefresh.js"></script>

</body>
</html>
