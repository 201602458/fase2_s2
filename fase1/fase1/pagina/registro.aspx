<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="fase1.pagina.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<LINK REL=StyleSheet HREF="css/estilo.css" TYPE="text/css" MEDIA=screen>

<body>
    <div id="titulo">
        Registrate
    </div>
<form action="" id="formulario" method="post" runat="server">
        <label for="fname">Nombre</label><br>
        <asp:TextBox ID="Tnombre" for="fname" runat="server" Height="25px" Width="285px"></asp:TextBox><br>

        <label for="fname">Apellido</label><br>
        <asp:TextBox ID="Tapellido" for="fname" runat="server" Height="25px" Width="285px"></asp:TextBox><br>

        <label for="fname">Usuario</label><br>
        <asp:TextBox ID="Tusu" for="fname" runat="server" Height="25px" Width="285px"></asp:TextBox><br>

        <label for="fname">Contraseña</label><br>
        <asp:TextBox ID="Tcontra" for="fname" TextMode="Password" runat="server" Height="23px" Width="285px" /><br>
		
		<label for="fname">Confirmar Contraseña</label><br>
        <asp:TextBox ID="Tcontra2" for="fname" TextMode="Password" runat="server" Height="23px" Width="285px" /><br>
		
        <label for="fname">Fecha de Nacimiento:</label><br>     
        <asp:TextBox ID="TfechaNac" for="fname" TextMode="Date" runat="server" Height="25px" Width="281px"></asp:TextBox><br>

		<label for="fname">Pais</label><br>
    <asp:DropDownList ID="Tpais" runat="server" Height="38px" Width="292px"></asp:DropDownList>
        <br>

		<label for="fcorreo">Correo</label><br>
        <asp:TextBox ID="Tcorreo" for="fname" textMode="Email" runat="server" Height="25px" Width="285px"></asp:TextBox><br>
		
        <br>	
    <asp:Button ID="bname"  runat="server" Text="Guardar" OnClick="Button1_Click" />
	
		
		
		
        
        
    </form>
</body>
</html>
