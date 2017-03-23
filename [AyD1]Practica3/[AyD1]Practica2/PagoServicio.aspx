<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagoServicio.aspx.cs" Inherits="_AyD1_Practica2.PagoServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center">
            <tr>
                <td><p align="right">Cuenta Servicio:</p></td>
                <td><asp:TextBox ID="TextBox_cuenta" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><p align="right">Tipo Servicio:</p></td><td>
                <asp:ListBox ID="ListBox1" runat="server">
                    <asp:ListItem>Telefonico</asp:ListItem>
                    <asp:ListItem>Energia electrica</asp:ListItem>
                    <asp:ListItem>Agua Potable</asp:ListItem>
                    <asp:ListItem>Matricula Estudiantil</asp:ListItem>
                </asp:ListBox>
                
                </td>
            </tr>
            <tr>
                <td><p align="right">Monto:</p></td><td>
                <asp:TextBox ID="TextBox_monto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td><td>
                    <asp:Button ID="Button1" runat="server" Text="Hecho." onclick="Button1_Click" />           
                </td>
            </tr>
        </table>
</asp:Content>
