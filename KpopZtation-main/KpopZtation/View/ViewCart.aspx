<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="KpopZtation.View.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <style>
        .style-gridview{
            background-color: #F0A500;
            font-size: 14px;
            width: 100%;
        }
        .style-gridview th {
            background-color: #F0A500;
            color: #ffffff;
            padding: 5px;
        }
        .style-gridview tr:nth-child(even) {
            background-color: #ffffff;
        }
        .style-gridview td {
            padding: 5px;
            padding-top: 20px;
        }

        .style-btnCheckout {
            background-color: #F4F4F4;
            color: black;
            padding: 10px 20px;
            border: none;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            cursor: pointer;
            border-radius: 4px;
            float:right;
        }
    </style>
    <br />
    <br />
    <asp:GridView ID="gvItems" runat="server" CssClass="style-gridview" OnRowDeleting="gvItems_RowDeleting" >
        <Columns>
            <asp:CommandField ButtonType="Button" DeleteText="Remove" HeaderText="Action" ShowDeleteButton="True" ShowHeader="True"/>
        </Columns>
        <HeaderStyle BackColor="#337ab7" ForeColor="White" />
        <RowStyle BackColor="#ffffff" />
        <AlternatingRowStyle BackColor="#f2f2f2" />
    </asp:GridView>
    <br />

    <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" CssClass="style-btnCheckout"/>
    <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
</asp:Content>
