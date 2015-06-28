<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPaquete.aspx.cs" Inherits="QuetzalExpress.Empleado.RegistrarPaquete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css' />
<link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css' />
<link href="../css/Administrador.css" rel="stylesheet" type="text/css" media="screen" />
    <style type="text/css">
        .auto-style1 {
            width: 227px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

<div id="wrapper">
	<div id="header-wrapper" class="container">
		<div id="header" class="container">
			<div id="logo">
				<h1><a href="#">Quetzal Express </a></h1>
			</div>
			<div id="menu">
				<ul>
					<li class="current_page_item"><a href="#">Inicio</a></li>
					<li><a href="#"></a></li>
					<li><a href="#"></a></li>
					<li><a href="#"></a></li>
					<li><a href="#"></a></li>
				</ul>
			</div>
		</div>
		<div><img src="/images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<!-- end #header -->
	<div id="banner">
		<div class="content"><img src="/images/img07.jpg" width="980" height="270" alt="" /></div>
		<div><img src="/images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<div id="page">
		<div id="content">
			<div class="post">
				<h2 class="title"><a href="#">Registrar Paquete  </a>&nbsp;
                    <asp:Label ID="lblusuario" runat="server" style="font-size: x-large" Text="Anonimo" Visible="False"></asp:Label>
                </h2>
				<div id="fecha">
                    <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
                </div>
				<div style="clear: both;" id="usuario">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style1">CATEGORIAS:</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Accesorio de Telefonia</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Accesorio Deportivo</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Articulos de Cuero</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Videocintas</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Videojuegos Blue-Ray</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Zapatos</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    </div>
                <div style="clear: both;" id="password">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
			    <div>
                    <asp:Label ID="Label1" runat="server" Text="CLASIFICACION"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtclasificacion" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="DESCRIPCION"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="PESO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtpeso" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <div>
                    <div style="height: 25px">
                        CASILLA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtcasilla" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                </div>
                <div style="text-align: center">
                    <asp:Button ID="btnregistrar" runat="server" OnClick="btnregistrar_Click1" Text="REGISTRAR" Width="110px" />
                </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		    <div>
                <div>
                    <div>
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </div>
                </div>
            </div>
		</div>
		<!-- end #sidebar -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	<div class="container"><img src="/images/img03.png" width="1000" height="40" alt="" /></div>
	<!-- end #page --> 
</div>
<div id="footer-content"></div>
<div id="footer">
	<p>&copy; Untitled. All rights reserved. Design by <a href="http://templated.co" rel="nofollow">TEMPLATED</a>. Photos by <a href="http://fotogrph.com/">Fotogrph</a>.</p>
</div>
<!-- end #footer -->
    </form>
</body>
</html>