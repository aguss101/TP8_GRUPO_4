<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="Vistas.ListadoDeSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 215px;
        }
        .auto-style7 {
            width: 198px;
            height: 23px;
        }
        .auto-style8 {
            width: 215px;
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            height: 163px;
        }
        .auto-style12 {
            height: 163px;
        }
        .auto-style14 {
            height: 46px;
        }
        .auto-style16 {
            width: 125px;
            height: 55px;
        }
        .auto-style17 {
            height: 55px;
        }
        .auto-style19 {
            height: 163px;
        }
        .auto-style23 {
            height: 23px;
        }
        .auto-style24 {
            height: 55px;
            width: 200px;
        }
        .auto-style25 {
            height: 55px;
            width: 208px;
        }
        .auto-style26 {
            width: 198px;
            height: 11px;
        }
        .auto-style27 {
            width: 215px;
            height: 11px;
        }
        .auto-style28 {
            height: 11px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/aspx/AgregarSucursal.aspx" ForeColor="Blue">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style25"><asp:HyperLink ID="hlListarSucursales" runat="server" NavigateUrl="~/aspx/ListadoDeSucursales.aspx" ForeColor="Blue">Listado de Sucursales</asp:HyperLink>
                </td>
                <td class="auto-style16">
&nbsp;&nbsp;<asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/aspx/EliminarSucursales.aspx" ForeColor="Blue">Eliminar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style17"></td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="5">
                    <asp:Label ID="lblListadoSucursales" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Listado de sucursales"></asp:Label>
                </td>
                <td class="auto-style14" colspan="2"></td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style26" colspan="3">
                </td>
                <td class="auto-style27" colspan="2">
                </td>
                <td class="auto-style28" colspan="2">
                </td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style23" colspan="3">
                    <asp:Label ID="lblSearch" runat="server" Text="Busqueda ingrese Id sucursal:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txbIdSucursal" runat="server" Width="232px" ValidationGroup="GroupSucList1"></asp:TextBox>
                </td>
                <td class="auto-style8" colspan="2">&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" ValidationGroup="GroupSucList1" />
&nbsp;&nbsp; <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" OnClick="btnMostrarTodos_Click" />
&nbsp;&nbsp; <asp:Button ID="btnOrdenar" runat="server" Text="Ordenar" OnClick="btnOrdenarSucursales" />
                </td>
                <td class="auto-style9" colspan="2">
                    &nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="3"></td>
                <td class="auto-style8" colspan="2">
                    <asp:Label ID="lblInvalidInputSuc" runat="server" ForeColor="Red" Text="Valor inválido, ingrese un número!" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9" colspan="2">&nbsp;</td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="4">
                    <asp:GridView ID="gvSucursales" runat="server" Width="966px" style="margin-left: 0px">
                    </asp:GridView>
                </td>
                <td class="auto-style10" colspan="2">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="3"></td>
                <td class="auto-style8" colspan="2"></td>
                <td class="auto-style9" colspan="2"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="3"></td>
                <td class="auto-style8" colspan="2"></td>
                <td class="auto-style9" colspan="2">&nbsp;</td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">&nbsp;</td>
                <td class="auto-style3" colspan="2">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>
    </form>
</body>
</html>
