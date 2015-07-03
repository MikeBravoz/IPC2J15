<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="QuetzalExpress.Administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>WildFlowers by TEMPLATED</title>
<link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet' type='text/css' />
<link href='http://fonts.googleapis.com/css?family=Abel' rel='stylesheet' type='text/css' />
<link href="css/Administrador.css" rel="stylesheet" type="text/css" media="screen" />
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
					<li><a href="Login.aspx">Logout</a></li>
				</ul>
			</div>
		</div>
		<div><img src="/images/img03.png" width="1000" height="40" alt="" /></div>
	</div>
	<!-- end #header -->
	<div id="banner">
		<div class="content"><img src="/images/img07.jpg" width="980" height="270" alt="" /></div>
		<div><img src="/images/img03.png" height="40" alt="" style="width: 1000px" /></div>
	</div>
	<div id="page">
		<div id="content">
			<div class="post">
				<h2 class="title"><a href="#">Administracion  </a>&nbsp;
                    <asp:Label ID="lblusuario" runat="server" style="font-size: x-large" Text="Anonimo" Visible="False"></asp:Label>
                </h2>
				<div id="fecha">
                    <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
                </div>
				<div style="clear: both;" id="usuario">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                <div style="clear: both;" id="password">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Cargar Archivos  .CSV"></asp:Label>
                    </div>
			    <div>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btncargar" runat="server" OnClick="btncargar_Click" Text="CARGAR" />
                </div>
                <div>
                    <asp:GridView ID="dgvDatos" runat="server" AutoGenerateColumns="False" DataKeyNames="codAsignacionSucursal" DataSourceID="SqlDataSource1" EnableModelValidation="True">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="codAsignacionSucursal" HeaderText="codAsignacionSucursal" InsertVisible="False" ReadOnly="True" SortExpression="codAsignacionSucursal" />
                            <asp:BoundField DataField="codDepartamento" HeaderText="codDepartamento" SortExpression="codDepartamento" />
                            <asp:BoundField DataField="codSucursal" HeaderText="codSucursal" SortExpression="codSucursal" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString3 %>" DeleteCommand="DELETE FROM [AsignacionSucursal] WHERE [codAsignacionSucursal] = @codAsignacionSucursal" InsertCommand="INSERT INTO [AsignacionSucursal] ([codDepartamento], [codSucursal]) VALUES (@codDepartamento, @codSucursal)" SelectCommand="SELECT * FROM [AsignacionSucursal]" UpdateCommand="UPDATE [AsignacionSucursal] SET [codDepartamento] = @codDepartamento, [codSucursal] = @codSucursal WHERE [codAsignacionSucursal] = @codAsignacionSucursal">
                        <DeleteParameters>
                            <asp:Parameter Name="codAsignacionSucursal" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="codDepartamento" Type="Int32" />
                            <asp:Parameter Name="codSucursal" Type="Int32" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="codDepartamento" Type="Int32" />
                            <asp:Parameter Name="codSucursal" Type="Int32" />
                            <asp:Parameter Name="codAsignacionSucursal" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                    <asp:TextBox ID="txtpantalla" runat="server" Height="151px" TextMode="MultiLine" Width="283px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                </div>
			</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
		    <div>
                <asp:Button ID="btnClasificacion" runat="server" OnClick="btnClasificacion_Click" Text="Clasificacion Paquetes" />
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
	<p>&copy;<a> Untitled. All rights reserved. Design by TED</a>. Photos by <a href="http://fotogrph.com/">Fotogrph</a>.</p>
</div>
<!-- end #footer -->
    </form>
</body>
</html>
