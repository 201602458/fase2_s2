<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="fase1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <LINK REL=StyleSheet HREF="css/estilo.css" TYPE="text/css" MEDIA=screen>
<body>

    <div id="titulo">
        Inicio De Sesion
    </div>
    <form id="formulario" action=" " method="post" runat="server">
        
        <label for="fname">Usuario</label><br>
        <asp:TextBox for="fname" ID="Tusu" runat="server" Height="25px" Width="285px"></asp:TextBox><br>

        <label for="fname">Contraseña</label><br>
        <asp:TextBox for="fname" ID="Tcontra" TextMode="Password" runat="server" Height="23px" Width="285px" /><br>
		
        <br>	
            <asp:Button ID="bname" runat="server" Text="Aceptar" OnClick="Button1_Click" />
        <br>	
        <br>	
	
		<a href="registro.aspx" id="linkR">Crea un nuevo usuario aqui!!</a>
    </form>
   
</body>
</html>
