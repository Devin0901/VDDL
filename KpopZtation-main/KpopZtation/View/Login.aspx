<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KpopZtation.View.Login" %>
<!DOCTYPE html>


<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</head>
<style>
    h1{
        font-size: 45px;
        font-weight:bold;
    }
     .container {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
  }
    .form-group input[type="text"],
    .form-group input[type="password"] {
    width: 100%;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 3px;
    font-size: 14px;
  }
      .form-group .login-button {
    width: 100%;
    padding: 12px;
    background-color: #E89B2A;
    color: #fff;
    border: none;
    border-radius: 3px;
    font-size: 16px;
    cursor: pointer;
    transition: background-color 0.3s ease;
  }

</style>
<body>
     <form id="form1" runat="server"> 
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                  <asp:Image ID="Image" runat="server" ImageUrl="~/Assets/Login.png" AlternateText="Logo" style="width:100%; height: 100%; "/>   
                </div>
                <div class="col-md-6" style="margin-top: 100px">
                    <h1>Hello, Welcome!</h1>
                    <div class="form-group">
                        <asp:Label ID="lbEmail" runat="server" Text="Email: "></asp:Label>
                        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbPassword" runat="server" Text="Password: "></asp:Label>
                        <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:CheckBox ID="cbRemember" runat="server" Text="Remember Me" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Button CssClass="login-button" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </div>
                    <div class="register-wrapper">
                        <h1 style="font-size: 14px; color: grey; display: inline-block; margin-right: 5px;">Dont have account?</h1>
                        <a href="Register.aspx" class="login-link" style="text-decoration: none">Register</a>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
