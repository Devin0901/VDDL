<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="KpopZtation.View.AlbumDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <br />
    <br />
    <br />

    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="card" style="text-align:center; align-items:center">
                    <img src="/Assets/<%= product.ProductImage %>" class="card-img-top" alt="Artist Image" style="width: 70%; height: 70%; color: black;">
                </div>
            </div>
            <div class="col-md-6">
                <h1 style="color: black; font-size: 40px"><%= product.ProductName %></h1>
                <h2 style="color: #ACA5A5;font-size: 30px">Rp <%= product.ProductPrice %></h2>
                <br />
                <p style="color: black; font-size: 20px"><%= product.ProductDescription %></p>
                <br />
                <p style="color: black; font-size: 22px;">Stock: <%= product.ProductStock %></p>


                <asp:Label ID="lbQty" runat="server" Text="Quantity: " style="font-size: 16px; font-weight: bold; color: black"></asp:Label>
                <asp:TextBox ID="tbQty" runat="server" style="width: 30%; padding: 8px; border: 1px solid #ccc; border-radius: 4px; margin-left: 10px;"></asp:TextBox>
                <asp:Button ID="btnCart" runat="server" Text="Add to cart" OnClick="btnCart_Click" style="background-color: #f0a500; color: #fff; padding: 10px 20px; border: none; border-radius: 4px; cursor: pointer; font-weight: bold; margin-left: 10px;"></asp:Button>
                <asp:Label ID="lbError" runat="server" Text="" style="color: red; font-size: 14px; margin-left: 10px;"></asp:Label>

            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
