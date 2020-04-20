<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="_lblWebAppOO" runat="server" Font-Bold="True" Font-Names="Verdana"
            Font-Size="Small" ForeColor="Olive" Text="WebAppOO - Cadastro de atividades"></asp:Label>
        <hr />
    
    </div>
        <asp:GridView ID="_grdAtividades" runat="server" AllowPaging="True" AllowSorting="True"
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"
            CellPadding="4" DataSourceID="_odsAtividades" Font-Names="Verdana" Font-Size="Small"
            ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="_grdAtividades_SelectedIndexChanged"
            PageSize="5">
            <FooterStyle BackColor="#CCCC99" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <hr />
        <asp:HyperLink ID="_hplInserirAtividade" runat="server" Font-Bold="True" Font-Names="Verdana"
            Font-Size="Small" ForeColor="Olive" NavigateUrl="InserirAtividade.aspx">Inserir atividade</asp:HyperLink>
        <br />
        <br />
        <asp:ObjectDataSource ID="_odsAtividades" runat="server" EnablePaging="True" SelectMethod="RetornaAtividades"
            SortParameterName="column" TypeName="AtividadeDAO"></asp:ObjectDataSource>
    </form>
</body>
</html>
