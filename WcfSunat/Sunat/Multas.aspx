<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multas.aspx.cs" Inherits="Sunat.Multas" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                &nbsp; Ingrese RUC:
            </td>
            <td class="style1">
                &nbsp;
                <asp:TextBox ID="txtruc" runat="server" Width="204px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnver" runat="server" Text="Ver Multas" OnClick="Btnver_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td class="style1">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp; &nbsp; &nbsp;
                <asp:DataList ID="dlmultas" runat="server">
                    <ItemTemplate>
                        QUE SE PAGA:  <%# Eval("TipoPago")%><br />
                        NUMERO RUC: <%# Eval("RUC") %><br>
                        PERIODO TRIBUTARIO: <%# Eval("Periodo")%><br/>
                        RESOLUCION: <%# Eval("Resolucion")%><br/>
                        CODIGO TRIBUTO: <%# Eval("CodigoTributo")%><br/>
                        IMPORTE A PAGAR: <%# Eval("Importe")%><br/>
                        <hr />
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
    <div>
    </div>
    </form>
</body>
</html>

