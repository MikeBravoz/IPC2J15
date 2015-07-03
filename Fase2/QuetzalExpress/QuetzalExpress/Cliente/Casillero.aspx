<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Casillero.aspx.cs" Inherits="QuetzalExpress.Cliente.Casillero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css' />
<link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css' />
<link href="../css/Casillero.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>

    <form id="form1" runat="server">

<div id="wrapper">
	<div id="header-wrapper" class="container">
		<div id="header" class="container">
			<div id="logo">
				<h1><a href="#">Quetzal Express</a></h1>
			</div>
			<div id="menu">
				<ul>
					<li class="current_page_item"><a href="../Login.aspx">Inicio</a></li>
					<li><a href="#"></a></li>
					<li><a href="#"></a></li>
					<li><a href="#">Contactanos</a></li>
					<li><a href="../Login.aspx">Logout</a></li>
				</ul>
			</div>
		</div>
		<div><img src="../images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<!-- end #header -->
	<div id="banner">
		<div class="content"><img src="../images/img07.jpg" width="980" height="270" alt="" /></div>
		<div><img src="../images/img03.png" width="1000" height="40" alt="" /></div>
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
				<div style="clear: both;" id="comandos">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnVerPaquetes" runat="server" OnClick="btnVerPaquetes_Click" Text="VER PAQUETES" Width="135px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnTrack" runat="server" OnClick="btnTrack_Click" Text="TRACK PACKAGE" />
                    </div>
                <div style="clear: both; width: 617px;" id="datos">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="dgvCliente" runat="server" Height="200px" Width="227px">
                    </asp:GridView>
                    </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		    <div style="text-align: center">
                <asp:Label ID="Label1" runat="server" style="text-align: center" Text="Consultar Paquete"></asp:Label>
                <div>
                </div>
                <div style="text-align: left">
                    Cod Paquete<asp:TextBox ID="txtCodPaquete" runat="server"></asp:TextBox>
                    <div style="text-align: center">
                        <asp:Button ID="btnConsutarPaquete" runat="server" OnClick="btnConsutarPaquete_Click" Text="CONSULTAR" />
                        <div>
                            <asp:TextBox ID="txtArea" runat="server" Height="82px" TextMode="MultiLine" Width="263px"></asp:TextBox>
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
