<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="_AyD1_Practica2.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center">
            <tr>
                <td><p align="right">Nombre Completo:</p></td><td>
                <asp:TextBox ID="TextBox_nombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><p align="right">Usuario:</p></td><td>
                <asp:TextBox ID="TextBox_usuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><p align="right">Correo Electronico:</p></td><td>
                <asp:TextBox ID="TextBox_email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><p align="right">Clave de acceso:</p></td><td>
                <asp:TextBox ID="TextBox_password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td align="center">
                    <asp:Button ID="Button_registrar" runat="server" Text="Registrar" 
                        align="center" onclick="Button_registrar_Click" />
                </td>
            </tr>
        </table>
    
</asp:Content>
