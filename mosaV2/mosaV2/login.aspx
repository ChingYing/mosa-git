<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>供應商查訊息統</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="width:80%;margin-top:50px;">
            <div class="row">
                <div class="col">
                    <div class="card">
                    <div class="card-header">供應商查訊息統登入</div>
                    <div class="card-body">
                        帳號<asp:TextBox ID="userid" runat="server" requriedplaceholder="必填" Class="form-control"></asp:TextBox>
                        <br />
                        密碼<asp:TextBox ID="password" runat="server" TextMode="Password" requriedplaceholder="必填" Class="form-control" ></asp:TextBox>
                        <br />
                        <p>
                            <asp:Button ID="BtnLogin" runat="server" Text="登入" Class="btn btn-primary" OnClick="BtnLogin_Click"/>
                        </p>
                    </div>
                    </div>
                </div>
            </div>
            <asp:Label ID="labelshow" runat="server" Text="" ForeColor="red"></asp:Label>
        </div>
    </form>
</body>
</html>