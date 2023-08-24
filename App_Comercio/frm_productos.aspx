<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_productos.aspx.cs" Inherits="App_Comercio.frm_usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--<link href="estilos.css" rel="stylesheet" type="text/css" />--%>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <br />
            <div class="div">
                <br />
                <h3>Formulario de registro de productos</h3>
                <asp:TextBox ID="txt_codigo" runat="server" placeholder="Código" CssClass="cajas"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_nombre" runat="server" placeholder="Nombre" CssClass="cajas"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_existencia" runat="server" placeholder="Existencia" CssClass="cajas"></asp:TextBox>
                <asp:TextBox ID="txt_valor_compra" runat="server" placeholder="Valor Compra" CssClass="cajas"></asp:TextBox>
                <asp:TextBox ID="txt_ganancia" runat="server" placeholder="Ganancia" CssClass="cajas"></asp:TextBox>

                <asp:DropDownList ID="ddl_categoria" runat="server" placeholder="Ganacia" CssClass="cajas" DataSourceID="SqlDataSource1" DataTextField="Nomenclatura" DataValueField="Nomenclatura"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbs_comercioConnectionString %>" ProviderName="<%$ ConnectionStrings:dbs_comercioConnectionString.ProviderName %>" SelectCommand="SELECT [Nomenclatura] FROM [tblcategoria]"></asp:SqlDataSource>
                <asp:TextBox ID="txt_especificaciones" runat="server" placeholder="Especificaciones" CssClass="cajas"></asp:TextBox>
                <asp:TextBox ID="txt_valor_venta" runat="server" placeholder="Valor Venta" CssClass="cajas"></asp:TextBox>
                <asp:DropDownList ID="ddl_estado" runat="server" placeholder="Estado" CssClass="cajas" DataSourceID="SqlEstado" DataTextField="Nomenclatura" DataValueField="Nomenclatura"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlEstado" runat="server" ConnectionString="<%$ ConnectionStrings:dbs_comercioConnectionString %>" SelectCommand="SELECT [Nomenclatura] FROM [tblestado]"></asp:SqlDataSource>
                <asp:Label ID="lbl_usuarios" runat="server" Text="lbl_usuario" placeholder="Usuario" CssClass="cajas"></asp:Label>


                <asp:Button ID="btn_registrar" runat="server" Text="Registrar" CssClass="botones" OnClick="btn_registrar_Click" />
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="botones" OnClick="btn_cancelar_Click" />
                <asp:Button ID="bnt_consultar" runat="server" Text="Consultar" CssClass="botones" OnClick="bnt_consultar_Click" />
                <br />
                <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
            </div>
        </center>
    </form>
</body>
</html>
