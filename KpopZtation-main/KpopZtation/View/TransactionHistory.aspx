<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtation.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
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

    </style>
    <asp:GridView ID="gvTransactions" CssClass="style-gridview" runat="server">

    </asp:GridView>

    <br />
    <br />
    <br />

</asp:Content>
