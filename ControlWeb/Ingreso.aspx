<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Ingreso.aspx.cs" Inherits="Ingreso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 242px;
        }
        .auto-style2 {
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
        <br />
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Codigo del producto</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="(*)Requerido" ControlToValidate="txtCod"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Tipo del producto</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlTipo" runat="server">
                        <asp:ListItem Value="0">Seleccione...</asp:ListItem>
                        <asp:ListItem Value="1">pc</asp:ListItem>
                        <asp:ListItem Value="2">wii</asp:ListItem>
                        <asp:ListItem Value="3">playstation3</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="(*)Requerido" ControlToValidate="ddlTipo"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="(*)Fuera de rango" MaximumValue="3" MinimumValue="1" ControlToValidate="ddlTipo"  ></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nombre del producto</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="(*)Requerido" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Precio del producto</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="(*)Requerido" ControlToValidate="txtPrecio"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnIngreso" runat="server" Text="Registro" OnClick="btnIngreso_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnListar" runat="server" Text="Listar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
    </p>
</asp:Content>

