<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="carga.aspx.cs" Inherits="fase1.pagina.carga" ValidateRequest="false"%>

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
  
    <div id="contener">
        <asp:TextBox ID="Tvista" runat="server" Height="239px" TextMode="MultiLine" Width="239px"></asp:TextBox>
            <asp:FileUpload ID="Bsubir" runat="server"/>
            <asp:Button ID="Bup" runat="server" Text="Cargar Archivo" OnClick="Bup_Click" />
        
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generar tablero" Visible="False" />
        
    </div>
    </form>

</body>
  
</html>
