<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="_AyD1_Practica2.Transferencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center">
            <tr>
                <td><p align="right">Destino:</p></td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><p align="right">Monto:</p></td><td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="Hecho." align="center" />
                </td>
            </tr>
        </table>
</asp:Content>
