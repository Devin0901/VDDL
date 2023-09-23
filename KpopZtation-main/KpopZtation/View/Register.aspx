<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="KpopZtation.View.Register" %>

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
  .form-group input[type="password"],
  .form-group select {
    width: 100%;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 3px;
    font-size: 14px;
  }
               .form-group .register-button {
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
                 <asp:Image ID="Image" runat="server" ImageUrl="~/Assets/Register.png" AlternateText="Logo" style="width:100%; height: 100%; "/>   
            </div>
            <div class="col-md-6">
                <h1>Hello, New User!</h1>
                 <div class="form-group">
                        <asp:Label ID="lbName" runat="server" Text="Full name: "></asp:Label>
                        <asp:TextBox ID="tbName" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbEmail" runat="server" Text="Email: "></asp:Label>
                        <asp:TextBox ID="tbEmail" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbPassword" runat="server" Text="Password: "></asp:Label>
                        <asp:TextBox ID="tbPassword" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="genderLbl" runat="server" Text="Gender: "></asp:Label>
                        <asp:RadioButtonList ID="genderRbl" runat="server">
                            <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbAddress" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="tbAddress" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lbRole" runat="server" Text="Choose Role: "></asp:Label>
                        <asp:DropDownList ID="ddlRole" runat="server">
                            <asp:ListItem Value="admin">admin</asp:ListItem>
                            <asp:ListItem Value="cstmr">customer</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                <br />
                    <div class="form-group">
                        <asp:Button CssClass="register-button" ID="registerBtn" runat="server" Text="Register" onclick="registerBtn_Click" />
                    </div>
                <div class="login-wrapper">
                    <h1 style="font-size: 14px; color: grey; display: inline-block; margin-right: 5px;">Already have account?</h1>
                    <a href="Login.aspx" class="login-link" style="text-decoration: none">Login</a>
                </div>
            </div>
        </div>
    </div>
        </form>
</body>
  
