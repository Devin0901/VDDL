<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="KpopZtation.View.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <style>
        .form-container input[type="text"]
        {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <asp:Image ID="Image" runat="server" ImageUrl="~/Assets/Insert-Product.png" AlternateText="Logo" style="width:100%; height: 100%; "/>  
            </div>
            <div class="col-md-6">
                <div class="form-container" style="padding-top: 20px;">
                    <div>
                        <asp:Label ID="lbName" runat="server" Text="Name: " style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbDescription" runat="server" Text="Description: "  style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbDescription" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbPrice" runat="server" Text="Price: " style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="lbStock" runat="server" Text="Stock: " style="color: black;"></asp:Label>
                        <asp:TextBox ID="tbStock" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <br />
                    <div>
                        <asp:Label ID="lbImage" runat="server" Text="Upload Image: " style="color: black;"></asp:Label>
                        <asp:FileUpload ID="fuImage" runat="server" />
                    </div>
                   
                </div>
                 <asp:Label ID="lbError" runat="server" Text="" style="color: red;"></asp:Label>
                    <asp:Button ID="btnAdd" runat="server" Text="Add Album" OnClick="btnAdd_Click" />
           </div>
        </div>
    </div>
   
</asp:Content>
