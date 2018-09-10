<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFilme.aspx.cs" Inherits="ProjWebWCF1.CadastroFilme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="http://www.netmidiapropaganda.com.br/wordpress/wp-content/uploads/2016/07/32101-cinema-movie-desktop-wallpaper-1440x900.jpg" style="color:white; font-family:'Comic Sans MS';">


    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Filme</h1><br />
            
            <br />
            Nome do Filme:</div>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        Genero:<br />
        <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
        <br />
        Ano de Lançamento:<br />
        <asp:TextBox ID="txtAnoLancamento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        <br />
        <br />
        <asp:GridView ID="gvtFilme" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="Nome" FooterText="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Genero" FooterText="Genero" HeaderText="Genero" />
                <asp:BoundField DataField="AnoLancamento" FooterText="Ano Lançamento" HeaderText="Ano Lançamento" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
