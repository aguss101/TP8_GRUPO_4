<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

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
            height: 33px;
        }
        .auto-style5 {
        }
        .auto-style8 {
            height: 56px;
        }
        .auto-style12 {
            height: 24px;
            width: 13%;
        }
        .auto-style14 {
            height: 24px;
            width: 6%;
        }
        .auto-style15 {
            height: 56px;
            width: 6%;
        }
        .auto-style17 {
            height: 24px;
            width: 119px;
        }
        .auto-style18 {
            width: 6%;
        }
        .auto-style19 {
        }
        .auto-style21 {
            width: 8%;
        }
        .auto-style22 {
            height: 24px;
            width: 8%;
        }
        .auto-style23 {
            height: 56px;
            width: 8%;
        }
        .auto-style42 {
            width: 119px;
        }
        .auto-style45 {
            height: 56px;
            width: 13%;
        }
        .auto-style46 {
            width: 9%;
        }
        .auto-style47 {
            height: 24px;
            width: 9%;
        }
        .auto-style48 {
            height: 56px;
            width: 9%;
        }
        .auto-style49 {
            width: 10%;
        }
        .auto-style50 {
            height: 24px;
            width: 10%;
        }
        .auto-style51 {
            height: 56px;
            width: 10%;
        }
        .auto-style52 {
            width: 137px;
        }
        .auto-style53 {
            width: 6%;
            height: 26px;
        }
        .auto-style54 {
            height: 26px;
        }
        .auto-style55 {
            width: 119px;
            height: 26px;
        }
        .auto-style57 {
            width: 10%;
            height: 26px;
        }
        .auto-style58 {
            width: 8%;
            height: 26px;
        }
        .auto-style59 {
            width: 6%;
            height: 50px;
        }
        .auto-style60 {
            width: 13%;
            height: 50px;
        }
        .auto-style61 {
            width: 119px;
            height: 50px;
        }
        .auto-style62 {
            width: 9%;
            height: 50px;
        }
        .auto-style63 {
            width: 10%;
            height: 50px;
        }
        .auto-style64 {
            width: 8%;
            height: 50px;
        }
        .auto-style65 {
            width: 6%;
            height: 44px;
        }
        .auto-style66 {
            height: 44px;
        }
        .auto-style67 {
            width: 119px;
            height: 44px;
        }
        .auto-style69 {
            width: 10%;
            height: 44px;
        }
        .auto-style70 {
            width: 8%;
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style42">
                    <asp:HyperLink ID="HpAdd" runat="server" Font-Italic="False" Font-Overline="False" Font-Size="Medium" Font-Underline="True" ForeColor="Blue" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style52">
                    <asp:HyperLink ID="HpLista1" runat="server" Font-Italic="False" Font-Overline="False" Font-Size="Medium" Font-Underline="True" ForeColor="Blue" NavigateUrl="~/ListadoDeSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
                <td class="auto-style19">
                    <asp:HyperLink ID="HpDelete2" runat="server" Font-Italic="False" Font-Overline="False" Font-Size="Medium" Font-Underline="True" ForeColor="Blue" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style12"></td>
                <td class="auto-style17" colspan="2"></td>
                <td class="auto-style12"></td>
                <td class="auto-style47"></td>
                <td class="auto-style50"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style8" colspan="3">
                    <asp:Label ID="lblgroup" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="GRUPO N°4"></asp:Label>
                </td>
                <td class="auto-style45"></td>
                <td class="auto-style48"></td>
                <td class="auto-style51"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
                <td class="auto-style23"></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style5" colspan="3">
                    <asp:Label ID="lblAddSuc" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Agregar Sucursal"></asp:Label>
                </td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="10"></td>
            </tr>
            <tr>
                <td class="auto-style65"></td>
                <td class="auto-style66">
                    <asp:Label ID="lblNameSuc" runat="server" Font-Size="Large" Text="Nombre Sucursal:"></asp:Label>
                </td>
                <td class="auto-style67" colspan="2">
                    <asp:TextBox ID="txtNameSuc" runat="server" Width="272px" ValidationGroup="Group1"></asp:TextBox>
                </td>
                <td class="auto-style66" colspan="2">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNameSuc" ErrorMessage="Ingrese el nombre de la sucursal" ForeColor="Red" ValidationGroup="Group1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style69"></td>
                <td class="auto-style70"></td>
                <td class="auto-style70"></td>
                <td class="auto-style70"></td>
            </tr>
            <tr>
                <td class="auto-style59"></td>
                <td class="auto-style60">
                    <asp:Label ID="lblDesc" runat="server" Font-Bold="False" Font-Size="Large" Text="Descripcion:"></asp:Label>
                </td>
                <td class="auto-style61" colspan="2">
                    <asp:TextBox ID="txtDesc" runat="server" Height="40px" Width="272px" ValidationGroup="Group1"></asp:TextBox>
                </td>
                <td class="auto-style60">
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDesc" ErrorMessage="Ingrese una descripción" ForeColor="Red" ValidationGroup="Group1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style62"></td>
                <td class="auto-style63"></td>
                <td class="auto-style64"></td>
                <td class="auto-style64"></td>
                <td class="auto-style64"></td>
            </tr>
            <tr>
                <td class="auto-style53"></td>
                <td class="auto-style54">
                    <asp:Label ID="lblProv" runat="server" Font-Bold="False" Font-Size="Large" Text="Provincia:"></asp:Label>
                </td>
                <td class="auto-style55" colspan="2">
                    <asp:DropDownList ID="ddlProvincias" runat="server" Height="26px" Width="278px" AutoPostBack="True" ValidationGroup="Group1">
                    </asp:DropDownList>
                </td>
                <td class="auto-style54" colspan="2">
                    <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincias" ErrorMessage="Ingrese la provincia" ForeColor="Red" ValidationGroup="Group1" InitialValue="0"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style57"></td>
                <td class="auto-style58"></td>
                <td class="auto-style58"></td>
                <td class="auto-style58"></td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style19">
                    <asp:Label ID="lblProv0" runat="server" Font-Bold="False" Font-Size="Large" Text="Direccion:"></asp:Label>
                </td>
                <td class="auto-style42" colspan="2">
                    <asp:TextBox ID="txtDir" runat="server" Width="271px" ValidationGroup="Group1"></asp:TextBox>
                </td>
                <td class="auto-style19" colspan="2">
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDir" ErrorMessage="Ingrese la dirección de la sucursal" ForeColor="Red" ValidationGroup="Group1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style42" colspan="2">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style42" colspan="2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="Group1" />
                </td>
                <td class="auto-style19" colspan="2">
                    <asp:Label ID="lblCorrect" runat="server" Font-Bold="True" ForeColor="Green"></asp:Label>
                </td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
