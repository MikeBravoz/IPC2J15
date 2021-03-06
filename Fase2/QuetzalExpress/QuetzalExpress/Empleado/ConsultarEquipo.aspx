﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarEquipo.aspx.cs" Inherits="QuetzalExpress.Empleado.ConsultarEquipo" %>

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
				<h2 class="title"><a href="#">Consultar Equipo  </a>&nbsp;
                    <asp:Label ID="lblusuario" runat="server" style="font-size: x-large" Text="Anonimo" Visible="False"></asp:Label>
                </h2>
				<div id="fecha">
                    <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
                </div>
				<div style="clear: both;" id="usuario">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                <div style="clear: both;" id="password">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnConsultarEquipo" runat="server" OnClick="btnClientesPendientes_Click" Text="Consultar Equipo" />
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Codigo Depto."></asp:Label>
                    <asp:TextBox ID="txtCodigoDepto" runat="server"></asp:TextBox>
                    </div>
			    <div>
                    <asp:GridView ID="dgvClientes" runat="server">
                    </asp:GridView>
                </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		    <div>
                <div>
                    <div>
                        <div style="text-align: center">
                            <asp:Label ID="Label1" runat="server" Text="Cod. Empleado"></asp:Label>
                            &nbsp;&nbsp;
                            <asp:TextBox ID="txtCodigoEmpleado" runat="server"></asp:TextBox>
                            <div>
                                <div style="text-align: center">
                                    <asp:Button ID="btnVerEmpleado" runat="server" OnClick="btnAutorizar_Click" Text="VER EMPLEADO" Width="164px" />
                                    <div>
                                        <asp:TextBox ID="txtArea" runat="server" Height="65px" TextMode="MultiLine" Width="269px"></asp:TextBox>
                                    </div>
                                </div>
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