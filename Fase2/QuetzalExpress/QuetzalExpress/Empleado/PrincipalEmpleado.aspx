﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalEmpleado.aspx.cs" Inherits="QuetzalExpress.Empleado.PrincipalCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css' />
<link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css' />
<link href="../css/PrincipalCliente.css" rel="stylesheet" type="text/css" media="screen" />
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
					<li><a href="../Login.aspx">LOGOUT</a></li>
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
				<h2 class="title"><a href="#">Bienvenido  </a>&nbsp;
                    <asp:Label ID="lblusuario" runat="server" style="font-size: x-large" Text="Anonimo" Visible="False"></asp:Label>
                </h2>
				<div id="fecha">
                    <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
                </div>
				<div style="clear: both;" id="usuario">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                <div style="clear: both;" id="password">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		    <div>
                <asp:Button ID="btnregistrar" runat="server" Text="Registrar Paquete" Width="184px" OnClick="btnregistrar_Click" />
                <div>
                    <asp:Button ID="btnagregar" runat="server" Text="Agregar a Lote" Width="185px" OnClick="btnagregar_Click" />
                    <div>
                        <asp:Button ID="btntracking" runat="server" Text="Tracking" Width="186px" OnClick="btntracking_Click" />
                        <div>
                            <asp:Button ID="btnAutorizarClientes" runat="server" OnClick="btnAutorizarClientes_Click" Text="Autorizar Clientes" Width="186px" />
                            <div>
                                <asp:Button ID="btnConsultarEquipo" runat="server" OnClick="btnConsultarEquipo_Click" Text="Consultar Equipo" Width="187px" />
                            </div>
                        </div>
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

