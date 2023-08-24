<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_usuarios.aspx.cs" Inherits="App_Comercio.frm_usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <br />
            <div class="div">
                <br />
                <h3>Formulario de Registro de Usuarios</h3>
                <asp:TextBox ID="txt_codigo" runat="server" placeholder="Código" CssClass="cajas" required="true"></asp:TextBox>*
                <br />
                <asp:TextBox ID="txt_nombre" runat="server" placeholder="Nombre" CssClass="cajas"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_contacto" runat="server" placeholder="Contacto" CssClass="cajas"></asp:TextBox>
                <asp:TextBox ID="txt_correo" runat="server" placeholder="Correo" CssClass="cajas"></asp:TextBox>
                <asp:TextBox ID="txt_direccion" runat="server" placeholder="Dirección" CssClass="cajas"></asp:TextBox>
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
