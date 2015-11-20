<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="McGiltonCapitals._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="countryRepeater" runat="server">
        <ItemTemplate>
            Country ID: <%#Eval("CountryID") %><br />
            Country: <%#Eval("Country") %><br />
            Capital: <%#Eval("Capital") %><br /><br />
        </ItemTemplate>
    </asp:Repeater>

    Enter Country ID to delete:



    <asp:TextBox ID="TextBoxCountry" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Button" />



</asp:Content>
