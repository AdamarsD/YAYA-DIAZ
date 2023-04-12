<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="labotarioII.CatalogoProductos" %>

<!DOCTYPE html>

<body></body> xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
        <table style="width: 600px; border:1px;">
            <thead>
                <tr style="border:1px;">
                    <th colspan="2" style="font-size: x-large; font-weight: bold; text-align: center;
                        text-transform: uppercase; background-color: #999999; color: #FFFFFF;">
                        Tienda al mayoreo
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr style="border:1px;">
                    <td class="style2" style="font-size: larger; font-weight: bold; text-align: left;
                        text-transform: capitalize;">
                        Zapatos Deportivos
                    </td>
                    <td class="style3">
                        <asp:LinkButton ID="lbZapato" runat="server" onclick="lbZapato_Click">Agregar al Carrito</asp:LinkButton>
                    </td>
                </tr>
                <tr style="border:1px;">
                    <td class="style2" style="font-size: larger; font-weight: bold; text-align: left;
                        text-transform: capitalize;">
                        Camisas Deportivas
                    </td>
                    <td class="style3">
                        <asp:LinkButton ID="lbCamisas" runat="server" onclick="lbCamisas_Click">Agregar al Carrito</asp:LinkButton>
                    </td>
                </tr>
                <tr style="border:1px;">
                    <td class="style2" style="font-size: larger; font-weight: bold; text-align: left;
                        text-transform: capitalize;">
                        Pantalones Cortos
                    </td>
                    <td class="style3">
                        <asp:LinkButton ID="lbPantalones" runat="server" onclick="lbPantalones_Click">Agregar al Carrito</asp:LinkButton>
                    </td>
                </tr>
                <tr style="border:1px;">
                    <td class="style2″ style="font-size: larger; font-weight: bold; text-align: left;
                        text-transform: capitalize;">
                        Sandalias
                    </td>
                    <td class="style3">
                        <asp:LinkButton ID="lbSandalias" runat="server" onclick="lbSandalias_Click">Agregar al Carrito</asp:LinkButton>
                    </td>
                </tr>
                <tr style="border:1px;">
                    <td class="style2″ style="font-size: larger; font-weight: bold; text-align: left;
                        text-transform: capitalize;">
                        Boxer
                    </td>
                    <td class="style3">
                        <asp:LinkButton ID="lbBoxer" runat="server" onclick="lbBoxer_Click">Agregar al Carrito</asp:LinkButton>
                    </td>
                </tr>
                <tr style="border:1px;"">
                    <td class="style1″ colspan="2″>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    </form>
</body>