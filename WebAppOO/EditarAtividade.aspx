<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditarAtividade.aspx.cs" Inherits="EditarAtividade" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="_lblWebAppOO" runat="server" Font-Bold="True" Font-Names="Verdana"
            Font-Size="Small" ForeColor="Olive" Text="WebAppOO - Inserir atividade"></asp:Label>
        <hr />
        <asp:Label ID="_lblCodigo" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="Small"
            Text="Código"></asp:Label><br />
        <asp:TextBox ID="_txtCodigo" runat="server" BackColor="Gainsboro" ReadOnly="True"
            Width="74px"></asp:TextBox><br />
        <br />
        <asp:Label ID="_lblNome" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="Small"
            Text="Nome"></asp:Label><br />
        <asp:TextBox ID="_txtNome" runat="server" Width="240px"></asp:TextBox><br />
        <br />
        <asp:Label ID="_lblDescricao" runat="server" Font-Bold="True" Font-Names="Verdana"
            Font-Size="Small" Text="Descrição"></asp:Label><br />
        <asp:TextBox ID="_txtDescricao" runat="server" Width="493px"></asp:TextBox>
        <hr />
        <asp:Button ID="_btnSalvar" runat="server" OnClick="_btnSalvar_Click" Text="Salvar" />&nbsp;
        <asp:Button ID="_btnCancelar" runat="server" OnClick="_btnCancelar_Click" Text="Cancelar" />&nbsp;
        <asp:Button ID="_btnExcluir" runat="server" OnClick="_btnExcluir_Click" Text="Excluir" /></div>
    </form>
</body>
</html>
