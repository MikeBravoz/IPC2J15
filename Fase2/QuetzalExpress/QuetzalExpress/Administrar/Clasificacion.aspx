<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clasificacion.aspx.cs" Inherits="QuetzalExpress.Administrar.Clasificacion" %>

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
					<li><a href="SinLogin/Contacto.aspx">Conctactanos</a></li>
					<li><a href="../Login.aspx">Logout</a></li>
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
				<h2 class="title"><a href="#">Clasificacino y Categorias  </a>&nbsp;
                    <asp:Label ID="lblusuario" runat="server" style="font-size: x-large" Text="Anonimo" Visible="False"></asp:Label>
                </h2>
				<div id="fecha">
                    <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
                </div>
				<div style="clear: both;" id="usuario">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                <div style="clear: both;" id="password">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Cargar Archivos  .CSV"></asp:Label>
                    </div>
			    <div>
                    <asp:FileUpload ID="FUcategorias" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btncargar" runat="server" OnClick="btncargar_Click" Text="CARGAR" />
                </div>
                <div>
                    <asp:GridView ID="dgvDatos" runat="server" AutoGenerateColumns="False" DataKeyNames="codImpuesto" DataSourceID="SqlDataSource1" EnableModelValidation="True">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="codImpuesto" HeaderText="codImpuesto" InsertVisible="False" ReadOnly="True" SortExpression="codImpuesto" />
                            <asp:BoundField DataField="categoriaImpuesto" HeaderText="categoriaImpuesto" SortExpression="categoriaImpuesto" />
                            <asp:BoundField DataField="impuesto" HeaderText="impuesto" SortExpression="impuesto" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString1 %>" DeleteCommand="DELETE FROM [Impuestos] WHERE [codImpuesto] = @codImpuesto" InsertCommand="INSERT INTO [Impuestos] ([categoriaImpuesto], [impuesto]) VALUES (@categoriaImpuesto, @impuesto)" SelectCommand="SELECT * FROM [Impuestos]" UpdateCommand="UPDATE [Impuestos] SET [categoriaImpuesto] = @categoriaImpuesto, [impuesto] = @impuesto WHERE [codImpuesto] = @codImpuesto">
                        <DeleteParameters>
                            <asp:Parameter Name="codImpuesto" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="categoriaImpuesto" Type="String" />
                            <asp:Parameter Name="impuesto" Type="Int32" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="categoriaImpuesto" Type="String" />
                            <asp:Parameter Name="impuesto" Type="Int32" />
                            <asp:Parameter Name="codImpuesto" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;
                </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		    <div>
                <asp:Button ID="Button1" runat="server" Text="Ver Paquete" />
                <div style="width: 270px">
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Ingrese el Codigo del Paquete"></asp:Label>
&nbsp;<div>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" Text="Ver" />
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
