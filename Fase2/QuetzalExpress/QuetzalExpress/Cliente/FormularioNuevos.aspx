<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioNuevos.aspx.cs" Inherits="QuetzalExpress.FormularioNuevos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css' />
<link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css' />
<link href="../css/FormularioNuevos.css" rel="stylesheet" type="text/css" media="screen" />
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
					<li><a href="#">Nosotros</a></li>
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
				<div style="clear: both;" id="usuario">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" style="font-size: 16px; font-weight: 700; font-family: Calibri; font-style: italic; color: #000066" Text="Por favor ingresa tu informacion"></asp:Label>
                    </div>
                <div style="clear: both;" id="password">
                    <asp:Label ID="Label2" runat="server" Text="Nombre            "></asp:Label>
                    <asp:TextBox ID="txtnombre" runat="server" style="margin-left: 83px" Width="260px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="txtapellido" runat="server" style="margin-left: 86px" Width="260px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="No. dpi"></asp:Label>
                    <asp:TextBox ID="txtdpi" runat="server" style="margin-left: 95px" Width="255px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Nit"></asp:Label>
                    <asp:TextBox ID="txtnit" runat="server" style="margin-left: 120px" Width="169px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="No. Telefono"></asp:Label>
                    <asp:TextBox ID="txttelefono" runat="server" style="margin-left: 55px" Width="168px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="txtdireccion" runat="server" style="margin-left: 77px" Width="258px"></asp:TextBox>
                    <br />
                    email<asp:TextBox ID="txtemail" runat="server" style="margin-left: 103px" Width="258px"></asp:TextBox>
                    <br />
                    Fecha Nacimiento<asp:TextBox ID="txtfecnac" runat="server" style="margin-left: 23px"></asp:TextBox>
                    </div>
			    <div>
                </div>
                <div>
                    <asp:Label ID="Label8" runat="server" Text="No. de Tarjeta"></asp:Label>
                    <asp:TextBox ID="txtnumtar" runat="server" style="margin-left: 45px" Width="256px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Tipo de Tarjeta"></asp:Label>
                    <asp:TextBox ID="txttiptar" runat="server" style="margin-left: 38px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="Fecha de Expiracion"></asp:Label>
                    <asp:TextBox ID="txtfecex" runat="server" style="margin-left: 6px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Banco"></asp:Label>
                    <asp:TextBox ID="txtbanco" runat="server" style="margin-left: 95px" Width="254px"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnenviar" runat="server" Height="46px" OnClick="btnenviar_Click" style="margin-left: 191px; margin-top: 18px; margin-bottom: 22px" Text="ENVIAR" Width="160px" />
                </div>
			    <div>
                    <asp:Label ID="lblmensaje" runat="server" Text="MensajeConfirmacion" Visible="False"></asp:Label>
                </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		</div>
		<!-- end #sidebar -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	<div class="container"><img src="../images/img03.png" width="1000" height="40" alt="" /></div>
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
