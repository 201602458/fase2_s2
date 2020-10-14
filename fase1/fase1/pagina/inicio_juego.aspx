<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio_juego.aspx.cs" Inherits="fase1.pagina.inicio_juego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <LINK REL=StyleSheet HREF="css/estilo.css" TYPE="text/css" MEDIA=screen>
<body>

    <form id="form1" runat="server">
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
        <div id="contener">
            <asp:Button ID="Button1" CssClass="b1" runat="server" Text="Individual" OnClick="Button1_Click" />
            <br>
            <br>
            <asp:Button ID="Button2" CssClass="b1" runat="server" Text="Versus" OnClick="Button2_Click" />
        
            <div>
            <br>
            <br>
            <asp:Label ID="L1" runat="server" Text="Ingrese nombre de los jugadores:" Visible="False"></asp:Label>
            <br>

            <asp:Label ID="L2" runat="server" Text="Jugador 1: " Visible="False"></asp:Label>
            <asp:TextBox ID="Tj1"  runat="server" Width="205px" Visible="False"></asp:TextBox><br>

            <asp:Label ID="L3" runat="server" Text="Jugador 2: " Visible="False"></asp:Label>
            <asp:TextBox ID="Tj2"  runat="server" Width="205px" Visible="False"></asp:TextBox>

             <br>
            <br>
            <asp:Button ID="Bplay" CssClass="b1" runat="server" Text="Jugar" Visible="False" OnClick="Bplay_Click" />
            </div>
        </div>
    
    </form>

</body>
</html>
