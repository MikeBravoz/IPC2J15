<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Whizz_Hard_Books.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css' />
<link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css' />
<link href="style.css" rel="stylesheet" type="text/css" media="screen" />
    <style type="text/css">
        .auto-style15 {
            width: 212px;
            height: 43px;
        }
        .auto-style16 {
            width: 212px;
            height: 25px;
        }
        .auto-style17 {
            width: 212px;
        }
        .auto-style18 {
            width: 107px;
            height: 43px;
        }
        .auto-style19 {
            width: 107px;
            height: 25px;
        }
        .auto-style20 {
            width: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div id="wrapper">
	<div id="header-wrapper" class="container">
		<div id="header" class="container">
			<div id="logo">
				<h1><a href="#">Whizz Hard Books </a></h1>
			</div>
			<div id="menu">
				<ul>
					<li class="current_page_item"><a href="#">Homepage</a></li>
					<li><a href="#">Blog</a></li>
					<li><a href="#">Photos</a></li>
					<li><a href="#">About</a></li>
					<li><a href="#">Contact</a></li>
				</ul>
			</div>
		</div>
		<div><img src="images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<!-- end #header -->
	<div id="banner">
		<div class="content"><img src="images/libro1.jpg" width="980" height="270" alt="" /></div>
		<div><img src="images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<div id="page">
		<div id="content">
			<div class="post">
				<h2 class="title"><a href="#">Bienvenido </a>&nbsp;&nbsp; <a href="#">
                    <asp:Label ID="lblusuario" runat="server" Text="Invitado"></asp:Label>
                    </a></h2>
				<p class="meta">
                    <asp:Label ID="lbldate" runat="server" Text="label"></asp:Label>
                </p>
				<div style="clear: both;">&nbsp;</div>
				<div class="entry">
					<p> 
                        <asp:Label ID="Label1" runat="server" Text="INGRESE SU USUARIO Y PASSWORD"></asp:Label>
                        ...</p>
				</div>
			</div>
			<div class="post">
				<table style="animation-play-state">
                    <tr>
                        <td class="auto-style18">
                            <asp:Label ID="lblnombre" runat="server" Text="Usuario"></asp:Label>
                        </td>
                        <td class="auto-style15">
                            <asp:TextBox ID="txtusuario" runat="server" Width="231px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19">
                            <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td class="auto-style16">
                            <asp:TextBox ID="txtpass" runat="server" TextMode="Password" Width="229px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td class="auto-style17">
                            <asp:Button ID="btnlogin" runat="server" Text="Login" Width="111px" />
                        </td>
                    </tr>
                </table>
				<p class="meta">&nbsp;</p>
				<div style="clear: both;">&nbsp;</div>
				<div class="entry">
					<p>&nbsp;</p>
					<p class="links">&nbsp;</p>
				</div>
			</div>
			<div style="clear: both;">&nbsp;</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
			<ul>
				<li>
					<h2>Categories</h2>
					<ul>
						<li><a href="#">Aliquam libero</a></li>
						<li><a href="#">Consectetuer adipiscing elit</a></li>
						<li><a href="#">Metus aliquam pellentesque</a></li>
						<li><a href="#">Suspendisse iaculis mauris</a></li>
						<li><a href="#">Urnanet non molestie semper</a></li>
						<li><a href="#">Proin gravida orci porttitor</a></li>
					</ul>
				</li>
				<li>
					<h2>Blogroll</h2>
					<ul>
						<li><a href="#">Aliquam libero</a></li>
						<li><a href="#">Consectetuer adipiscing elit</a></li>
						<li><a href="#">Metus aliquam pellentesque</a></li>
						<li><a href="#">Suspendisse iaculis mauris</a></li>
						<li><a href="#">Urnanet non molestie semper</a></li>
						<li><a href="#">Proin gravida orci porttitor</a></li>
					</ul>
				</li>
				<li>
					<h2>Archives</h2>
					<ul>
						<li><a href="#">Aliquam libero</a></li>
						<li><a href="#">Consectetuer adipiscing elit</a></li>
						<li><a href="#">Metus aliquam pellentesque</a></li>
						<li><a href="#">Suspendisse iaculis mauris</a></li>
						<li><a href="#">Urnanet non molestie semper</a></li>
						<li><a href="#">Proin gravida orci porttitor</a></li>
					</ul>
				</li>
			</ul>
		</div>
		<!-- end #sidebar -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	<div class="container"><img src="images/img03.png" width="1000" height="40" alt="" /></div>
	<!-- end #page --> 
</div>
<div id="footer-content"></div>
<div id="footer">
	<p>&copy; Untitled. All rights reserved. Design by <a href="http://templated.co" rel="nofollow">Johnny Bravo</a>. Photos by <a href="http://fotogrph.com/">BravosPictures</a>.</p>
</div>
<!-- end #footer -->
    </form>
</body>
</html>