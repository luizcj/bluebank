<%@ Page Language="C#" MasterPageFile="~/Views/Home/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">

<h2><%= Html.Encode(ViewData["Transferencia"]) %></h2>

    <% using (Html.BeginForm("Transferencia", "Home")) %>
     
    <% { %>


    <table style="width: 100%">
        <tr>
            <td style="width: 186px">
                    Dados de Origem
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">
                    Agência: <%= Html.TextBox("AgenciaOrigem") %>
            </td>
            <td> 
                Conta: <%= Html.TextBox("NumeroOrigem") %>
            </td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 186px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />

    

    

 
    
  

    <br />

    Dados  de Destino
    <br />
    Agência: <%= Html.TextBox("AgenciaDestino") %> Conta: <%= Html.TextBox("NumeroDestino") %>
    <br />

    Valor
    <br />
    R$ : <%= Html.TextBox("ValorTransferencia") %>  
    <br />
    
    <input type="submit" value="Confirmar" />
<% } %>



</asp:Content>
