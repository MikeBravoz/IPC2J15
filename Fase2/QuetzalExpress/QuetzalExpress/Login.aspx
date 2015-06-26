<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuetzalExpress._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href="css/login.css" rel="stylesheet" type="text/css" media="screen" />
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
					<li class="current_page_item"><a href="Login.aspx">Inicio</a></li>
					<li><a href="#"></a></li>
					<li><a href="#"></a></li>
					<li><a href="SinLogin/Contacto.aspx">Contactanos</a></li>
					<li><a href="#"></a></li>
				</ul>
			</div>
		</div>
		<div><img src="images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<!-- end #header -->
	<div id="banner">
		<div class="content"><img src="images/img07.jpg" width="980" height="270" alt="" /></div>
		<div><img src="images/img03.png" width="1000" height="40" alt="" /></div>
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
				<div style="clear: both;" id="usuario">&nbsp;<asp:Label ID="Label1" runat="server" Text="USUARIO"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtusuario" runat="server" OnTextChanged="txtusuario_TextChanged"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnacceder" runat="server" OnClick="btnacceder_Click" Text="ACCEDER" Width="89px" />
                </div>
                <div style="clear: both;" id="password">&nbsp;<asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                </div>

			    <div id="nuevos">
                    
                    <asp:Label ID="Label3" runat="server" style="font-style: italic; font-weight: 700; font-family: Calibri; color: #669900;" Text="Aun no tienes cuenta?.."></asp:Label>
                    
                    <asp:Label ID="Label4"  runat="server" style="font-size: 16px; font-family: Calibri; font-weight: 700; font-style: italic; color: #000066" Text="Has clic AQUI!!!!"><a href="Cliente/FormularioNuevos.aspx">Has Clic Aqui!!!!!</a></asp:Label>
                    
                </div>

			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		</div>
		<!-- end #sidebar -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	<div class="container"><img src="images/img03.png" width="1000" height="40" alt="" /></div>
	<!-- end #page --> 
</div>
<div id="footer-content"></div>
<div id="footer">
	<p>&copy; Untitled. All rights reserved. Design by <a href="http://templated.co" rel="nofollow">Johnny Bravo</a>. Photos by <a href="http://fotogrph.com/">Fotogrph</a>.</p>
</div>
<!-- end #footer -->
    </form>
</body>
</html>
