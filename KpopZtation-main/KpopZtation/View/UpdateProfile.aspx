<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZtation.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<br />
<br />

<style>

    .form-container input[type="text"],
    .form-container input[type="password"] {
        width: 100%;
        padding: 8px;
        border: 1px solid #ccc;
        border-radius: 4px;
    }

    .update-button{
        width: 100%;
        padding: 12px;
        background-color: #E89B2A;
        color: white;
        border: none;
        border-radius: 3px;
        font-size: 16px;
        cursor: pointer;
    }
</style>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                 <asp:Image ID="Image" runat="server" ImageUrl="~/Assets/Register.png" AlternateText="Logo" style="width:100%; height: 100%; "/>  
            </div>
            <div class="col-md-6">
                <div class="form-container" style="padding-top: 20px;">
                    <div>
                        <asp:Label ID="lbName" runat="server" Text="Full name: " style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbName" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbEmail" runat="server" Text="Email: " style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbEmail" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbPassword" runat="server" Text="Password: " style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbPassword" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="genderLbl" runat="server" Text="Gender: " style="color: black;"></asp:Label>
                        <asp:RadioButtonList ID="genderRbl" runat="server">
                            <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div>
                        <asp:Label ID="lbAddress" runat="server" Text="Address" style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbAddress" runat="server" placeholder=""></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <br />
                    <br />
                    <div>
                        <asp:Button ID="registerBtn" runat="server" Text="Update" onclick="registerBtn_Click" CssClass="update-button"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
