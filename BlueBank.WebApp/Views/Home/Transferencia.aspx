<%@ Page Language="C#" MasterPageFile="~/Views/Home/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">

<h2><%= Html.Encode(ViewData["Transferencia"]) %></h2>

    <% using (Html.BeginForm("Transferencia", "Home")) %>
     
    <% { %>


    <table style="width: 100%">
        <tr>
            <td style="width: 326px">
                    Dados de Debito
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                    &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                    Agência: <%= Html.TextBox("AgenciaDebito") %>
            </td>
            <td> 
                Conta: <%= Html.TextBox("NumeroDebito") %>
            </td>
        </tr>
 
        <tr>
            <td style="width: 326px">
                    &nbsp;</td>
            <td> 
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                Dados  de Credito
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                Agência: <%= Html.TextBox("AgenciaCredito") %>
            </td>
            <td>Conta: <%= Html.TextBox("NumeroCredito") %></td>
        </tr>
        <tr>
            <td style="width: 326px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                Valor
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 326px">
                R$ : <%= Html.TextBox("ValorTransferencia") %>  
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr><td style="width: 326px">&nbsp;&nbsp; &nbsp;</td></tr>

        <tr>
            <td style="width: 326px">
                    <input type="submit" value="Confirmar" />
            </td>
        </tr>
    </table>
    
    
<% } %>



</asp:Content>
