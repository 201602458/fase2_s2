<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="juego_vs.aspx.cs" Inherits="fase1.pagina.juego_vs" %>

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
  
        <div id="titulo">
            <asp:Label ID="Label1" runat="server" Text="Label">Turno de: Negra</asp:Label>
        </div>
        <div id="padre">
        <div id="tablaJ">
            <table class="tg">
<thead>
  <tr>
    <th class="tg-0lax"></th>
    <th class="tg-0lax">A</th>
    <th class="tg-0lax">B</th>
    <th class="tg-0lax">C</th>
    <th class="tg-0lax">D</th>
    <th class="tg-0lax">E</th>
    <th class="tg-0lax">F</th>
    <th class="tg-0lax">G</th>
    <th class="tg-0lax">H</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0lax">1</td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pagina/imagenes/fondo.png"  Height="43px" Width="44px" OnClick="ImageButton1_Click2" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton2_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton3_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton4_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton5_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton7_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton8_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton6_Click" /></td>
</tr>
  <tr>
    <td class="tg-0lax">2</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton9_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton10_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton11_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton12_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton13_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton14_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton15_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton16_Click" /></td>  
    </tr>
  <tr>
    <td class="tg-0lax">3</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton17_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton18_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton19" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton19_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton20" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton20_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton21" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton21_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton22" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton22_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton23" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton23_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton24" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton24_Click" /></td>  
  </tr>
  <tr>
    <td class="tg-0lax">4</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton25" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton25_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton26" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton26_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton27" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton27_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton28" runat="server" ImageUrl="~/pagina/imagenes/blanca.png" Height="43px" Width="44px" OnClick="ImageButton28_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton29" runat="server" ImageUrl="~/pagina/imagenes/negra.png" Height="43px" Width="44px" OnClick="ImageButton29_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton30" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton30_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton31" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton31_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton32" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton32_Click" /></td>  
  </tr>
  <tr>
    <td class="tg-0lax">5</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton33" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton33_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton34" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton34_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton35" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton35_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton36" runat="server" ImageUrl="~/pagina/imagenes/negra.png" Height="43px" Width="44px" OnClick="ImageButton36_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton37" runat="server" ImageUrl="~/pagina/imagenes/blanca.png" Height="43px" Width="44px" OnClick="ImageButton37_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton38" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton38_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton39" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton39_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton40" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton40_Click" /></td>  
  </tr>
  <tr>
    <td class="tg-0lax">6</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton41" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton41_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton42" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton42_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton43" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton43_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton44" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton44_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton45" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton45_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton46" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton46_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton47" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton47_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton48" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton48_Click" /></td>  
  </tr>
  <tr>
    <td class="tg-0lax">7</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton49" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton49_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton50" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton50_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton51" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton51_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton52" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton52_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton53" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton53_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton54" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton54_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton55" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton55_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton56" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton56_Click" /></td>  
    </tr>
  <tr>
    <td class="tg-0lax">8</td>
<td class="tg-0lax"><asp:ImageButton ID="ImageButton57" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton57_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton58" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton58_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton59" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton59_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton60" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton60_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton61" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton61_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton62" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton62_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton63" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton63_Click" /></td>
    <td class="tg-0lax"><asp:ImageButton ID="ImageButton64" runat="server" ImageUrl="~/pagina/imagenes/fondo.png" Height="43px" Width="44px" OnClick="ImageButton64_Click" /></td>  
    </tr>
</tbody>
</table>
            Nombre del archivo:<asp:TextBox ID="Bsubir" runat="server" Height="21px" Width="159px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Descargar" OnClick="Button1_Click" />
        </div>

        

            
            
        </div>
    </form>

</body>


  
</html>
