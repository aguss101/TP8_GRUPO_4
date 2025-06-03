<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="Vistas.EliminarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 54px;
        }
        .auto-style9 {            height: 72px;
        }
        .auto-style10 {
            width: 2%;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
        }
        .auto-style14 {
            width: 20%;
            height: 23px;
        }
        .auto-style15 {
            width: 3%;
            height: 23px;
        }
        .auto-style16 {
            width: 2%;
        }
        .auto-style19 {
            width: 20%;
        }
        .auto-style20 {
            width: 3%;
        }
        .auto-style21 {
            height: 23px;
        }
        .auto-style22 {
            width: 15%;
            height: 23px;
        }
        .auto-style23 {
            width: 185px;
        }
        .auto-style24 {
            width: 15%;
        }
        .auto-style25 {
            width: 2%;
            height: 54px;
        }
        .auto-style26 {
            width: 15%;
            height: 54px;
        }
        .auto-style27 {
            width: 20%;
            height: 54px;
        }
        .auto-style28 {
            width: 3%;
            height: 54px;
        }
        .emergente{
            position: fixed;
            top: 0; left: 0;
            width: 100%; height: 100%;
            background-color: rgba(0,0,0,0.4);
            display: flex;
            align-items: center;
            justify-content: center;
            z-index: 9999;
        }
        .emergente .content{
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.3);
            text-align: center;
            min-width: 300px;
        }
        .emergente-boton button{
            display: block;
            width: 100%;
            margin-top: 10px;
        }
        .auto-style30 {
            width: 2%;
            height: 72px;
        }
        .auto-style31 {
            width: 14%;
            height: 72px;
        }
        .auto-style32 {
            width: 3%;
            height: 72px;
        }
        .auto-style33 {
            width: 14%;
        }
        .auto-style34 {
            width: 14%;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11" colspan="3">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/aspx/AgregarSucursal.aspx" ForeColor="Blue">Agregar Sucursal</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:HyperLink ID="hlListarSucursal" runat="server" NavigateUrl="~/aspx/ListadoDeSucursales.aspx" ForeColor="Blue">Listado de Sucursales</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/aspx/EliminarSucursales.aspx" ForeColor="Blue">Eliminar Sucursal</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style25">
                    </td>
                    <td class="auto-style4" colspan="2">
                        <asp:Label ID="lblEliminarSucursal" runat="server" Font-Bold="True" Text="Eliminar Sucursal" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style26"></td>
                    <td class="auto-style27"></td>
                    <td class="auto-style28"></td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        </td>
                    <td class="auto-style31">
                        <asp:Label ID="Label1" runat="server" Text="Ingresar ID sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style9" colspan="4">
                        <asp:TextBox ID="txbEliminarSucursal" runat="server" Width="306px" ValidationGroup="Group2" OnTextChanged="txbEliminarSucursal_TextChanged" AutoPostBack="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnEliminarSucursal" runat="server" Text="Eliminar" OnClick="btnEliminarSucursal_Click" ValidationGroup="Group2" />
                    &nbsp;&nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Ingrese un numero de sucursal valido" Visible="False"></asp:Label>
                        &nbsp;&nbsp;&nbsp;<asp:Label ID="lblErrorFormato" runat="server" ForeColor="Red" Text="Ingrese un numero de sucursal valido" Visible="False"></asp:Label>
                        &nbsp;&nbsp;&nbsp;<asp:Label ID="lblComprobarSucursal" runat="server" ForeColor="Green" Text="Esta ID pertenece a una sucursal" Visible="False"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style32"></td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11" colspan="2">
                        <asp:Label ID="lblEliminado" runat="server" ForeColor="Green" Text="La sucursal se ha eliminado correctamente" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style22"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style23">
                        <asp:GridView ID="gvRegistroAEliminar" runat="server" AutoGenerateColumns="False" BorderStyle="None">
                            <Columns>
                                <asp:BoundField AccessibleHeaderText="ID" DataField="IdSucursal" HeaderText="ID" />
                                <asp:BoundField AccessibleHeaderText="Nombre" DataField="NombreSucursal" HeaderText="Nombre" />
                                <asp:BoundField AccessibleHeaderText="Descripción" DataField="DescripcionSucursal" HeaderText="Descripción" />
                                <asp:BoundField AccessibleHeaderText="Provincia" DataField="ProvinciaSucursal" HeaderText="Provincia" />
                                <asp:BoundField AccessibleHeaderText="Dirección" DataField="DireccionSucursal" HeaderText="Dirección" />
                                <asp:BoundField AccessibleHeaderText="Horario" DataField="DescripcionHorario" HeaderText="Horario" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style34"></td>
                    <td class="auto-style21"></td>
                    <td class="auto-style22"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                </table>
        </div>
                <asp:Panel ID="pnlConfirmacion" runat="server" Visible="false" CssClass="emergente">
                    <div class="content">
                        <asp:Label ID="lblConfirmacion" runat="server" />
                        <br /><br />
                        <div>
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" CommandArgument="null"/>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                        </div>
                    </div>
                </asp:Panel>
    </form>
</body>
</html>
