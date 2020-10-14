<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="fase1.pagina.inicio" %>

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
    <div id="textos">
        <div id="titulos"><H2>Othello:</H2></div>
        <p>Es un juego entre dos personas, que comparten 64 fichas iguales, de caras distintas, que se van colocando por turnos en un tablero dividido en 64 escaques. Las caras de las fichas se distinguen por su color y cada jugador tiene asignado uno de esos colores, ganando quien tenga más fichas sobre el tablero al finalizar la partida. </p>

        <div id="titulos"><h2>Reglas:</h2></div>
        <p>
            Se emplea un tablero de 8 filas por 8 columnas y 64 fichas idénticas, redondas, blancas por una cara y negras por la otra (u otros colores). Las casillas se denotan numerando las columnas, comenzando por la esquina superior izquierda del tablero, con letras de la A a la H, e igual con las filas, pero con números del uno al ocho. A un jugador se le asigna un color y se dice que lleva las fichas de ese color, lo mismo para el adversario con el otro color.
        </p>

        <p>
            
            Se colocan cuatro fichas al centro del tablero: dos fichas blancas en D4 y E5, y dos negras en E4 y D5. 
 
        </p>

        <p>
            Los jugadores deben hacer un movimiento por turno, a menos que no puedan hacer ninguno, pasando en ese caso el turno al jugador contrario. El movimiento consiste en colocar una ficha de forma que flanquee una o varias fichas del color contrario y voltear esas fichas para que pasen a mostrar el propio color.
        </p>

        <p>
            Se voltean todas las fichas que se han flanqueado en ese turno al colocar la ficha del color contrario. Esas fichas, para que estén flanqueadas, deben formar una línea continua recta (diagonal u ortogonal) de fichas del mismo color entre dos fichas del color contrario (una de ellas la recién colocada y la otra ya presente).
        </p>

        <p>
            La partida finaliza cuando ningún jugador puede mover (normalmente cuando el tablero está lleno de fichas) y gana quien en ese momento tenga sobre el tablero más fichas mostrando su color.
        </p>
    </div>
</form>

</body>
</html>
