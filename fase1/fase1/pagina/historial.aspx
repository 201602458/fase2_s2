<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="historial.aspx.cs" Inherits="fase1.pagina.historial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <LINK REL=StyleSheet HREF="css/estilo.css" TYPE="text/css" MEDIA=screen>

<body>
<form action=" " method="post" runat="server"> 
    <div id="menu">  
             
            <ul>
                <li><asp:LinkButton ID="LBinicio" runat="server" OnClick="LBinicio_Click">Inicio</asp:LinkButton></li>
                <li><asp:LinkButton ID="LBjuego" runat="server" OnClick="LBjuego_Click">Jugar</asp:LinkButton></li>
                <li><asp:LinkButton ID="LBdesc" runat="server" OnClick="LBdesc_Click">Historial</asp:LinkButton></li>
                <li><asp:LinkButton ID="LBcarga" runat="server" OnClick="LBcarga_Click">Carga</asp:LinkButton></li>
                <li class="der"><a href="">Salir</a></li>
            </ul> 
              
    </div>
    <asp:Label ID="Lusu" runat="server" Text="Label"></asp:Label>

    <div id="Dtabla">
    </div>

</form>
    

</body>
</html>
