<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZtation.View.Home" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
    h1{
        font-size:64px;
        font-weight: bold;
        color: black;
    }
    h4{
        color:#ACA5A5;
        font-size: 20px;
    }
    .insert-button{
        width: 20%;
        padding: 12px;
        background-color: #E89B2A;
        color: white;
        border: none;
        border-radius: 3px;
        font-size: 16px;
        cursor: pointer;
        float: right;
    }
    .card {
        text-align: center;
        align-items: center;
        width: 100%;
        height: 80%;
    }

    .card .card-title {
        margin-top: 0;
        margin-bottom: 5px;
    }

    .card .btn-view-details {
        margin-top: 5px;
    }
</style>
    <br />
    <br />
    <br />
    <div>
        <asp:Button ID="btnInsert" runat="server" Text="Insert Product" OnClick="btnInsert_Click" CssClass="insert-button" />
    </div>
    <br />
    <br />
    <br />
   <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h1>Every Purchase Will</h1>
                <h1>Be Made With</h1>
                <h1>Pleasure</h1>
                <h4>Buying and selling of goods or services</h4>
                <h4>using the internet</h4>
                <div class="box1" style="width: 25%; height: 8%; background-color:#E89B2A; display: flex; align-items: center; justify-content: center; border-radius: 20px;">
                    <a href="#products" style="font-size: 17px; color: white; margin: 0; text-decoration: none">Start Shopping</a>
                </div>
            </div>
            <div class="col-md-6">
                <asp:Image ID="imgLogo" runat="server" ImageUrl="~/Assets/Home.png" AlternateText="Logo" style="margin-left: 100px"/>
            </div>
        </div>
    </div>
    <br />
    <br />
    <h1 style="font-size:48px; text-align:center">Millions of People use VVDL</h1>
    <br />
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <div style="width:auto; height: auto;">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Assets/Home2.png" AlternateText="Logo" style="margin-left: 100px"/>
                 </div>
            </div>
            <div class="col-md-4">
               <div style="width:auto; height: auto;">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Assets/Home3.png" AlternateText="Logo" style="margin-left: 100px"/>
                 </div>
            </div>
            <div class="col-md-4">
                <div style="width:auto; height: auto;">
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/Assets/Home4.png" AlternateText="Logo" style="margin-left: 100px"/>
                 </div>
            </div>
        </div>
    </div>

    <br />
    <br />
    <div id ="products" class="container">
        <div class="row">
            <% foreach (var product in products) { %>
                <div class="col-md-4">
                    <div class="card" style="text-align:center; align-items:center;">
                        <img src="/Assets/<%= product.ProductImage %>" class="card-img-top" alt="Artist Image" style="width: 60%; height: 60%; color: black;">
                        <div class="card-body">
                            <h5 class="card-title"><%= product.ProductName %></h5>
                        </div>
                        <a href="ProductDetails.aspx?id=<%= product.ProductID %>" class="btn btn-primary" style="margin-top: -20px; background-color: white; color: black; border-color: black;">View Details</a>
                        <br />
                    </div>
                </div>
            <% } %>
        </div>
    </div>
    <br />

</asp:Content>
