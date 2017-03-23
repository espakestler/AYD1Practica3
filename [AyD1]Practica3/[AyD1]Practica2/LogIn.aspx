<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="_AyD1_Practica2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center">
            <tr>
                <td><p align=right>Nombre de Usuario:</p></td><td>
                <asp:TextBox ID="Text_usuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><p align=right>Clave de acceso:</p></td><td>
                <asp:TextBox ID="Text_password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Registrarse" 
                        onclick="Button2_Click" />
                </td><td>
                    <asp:Button ID="Button1" runat="server" Text="Iniciar Sesión." 
                        onclick="Button1_Click" />           
                </td>
            </tr>
        </table>
    
</asp:Content>
