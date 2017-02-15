<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="buscaHoteles.perfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Hoteles</title>
 
    <!-- CSS de Bootstrap -->
  <link href="css/bootstrap.min.css" rel="stylesheet" media="screen">
  <link href="https://fonts.googleapis.com/css?family=Lato|Old+Standard+TT|Pathway+Gothic+One" rel="stylesheet">
  <link href="css/style.css" rel="stylesheet">
  <link href="css/mobile.css" rel="stylesheet">
  <link href="fonts/style.css" rel="stylesheet">
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
    <!-- librerías opcionales que activan el soporte de HTML5 para IE8 -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container-fluid">
          <div class="row">
          <div class="social">
                <div class="btn-menu" id="btn-menu">
                  <span class="icon-menu"></span>
              </div>
              
              <ul>
              <li><span class="icon-facebook"></span></li>
              <li><span class="icon-instagram"></span></li>      
              <li><span class="icon-youtube"></span></li>   
              <li><span class="icon-skype"></span></li>
              <li><span class="icon-google-plus"></span></li>      
              </ul>
              
              </div>
          </div>
      <div class="row">
          <div class="col-xs-2 col-sm-2 col-md-3">
          <div class="logo">
              
              </div>
          
          </div>
           
         <div class="col-xs-10 col-sm-10 col-md-9 ">
             <div class="menu" id="menu">
              <ul>
              <li id="hm"><a href="#"><span class="icon-home"></span> Home</a></li>
              <li id="sn"><a href="#"><span class="icon-newspaper"></span> Ofertas</a></li>
              <li id="gl"><a href="#"><span class="icon-file-empty"></span> Ayuda</a></li>
               <li  id="pr"><asp:PlaceHolder ID="PlaceLg" runat="server"></asp:PlaceHolder></li>     
              </ul>
               </div>
               </div>
                <div class="container">
  
  <!-- Trigger the modal with a button -->
 

  <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Login</h4>
        </div>
        <div class="modal-body">
         <div class="container">
            <div class="cuadroLogin ">
             
            
              <div class="form-group">
                  <label for="usr"><span class="icon-user"></span>User</label>
                  <input type="text" class="form-control" placeholder="User" id="LUsuario" runat="server">
                </div>
                <div class="form-group">
                  <label for="usr"><span class="icon-keyboard"></span>Pass</label>
                  <input type="password" class="form-control" placeholder="Pass" id="Lpassword" runat="server">
                </div>
                
                 <input type="button" value="login"> o <a href="registro.aspx">Registrarse</a>
              </div>
             
             </div>
            
            </div>
            
            
            
            
            
        </div>
     
      </div>
      
    </div>
  </div>
          
          </div>


          <div class="row">
              <div class="container" style="margin-top:5%;height:550px;">
                  <asp:ImageButton ID="btnDatos" runat="server" ImageUrl="~/images/usuario.jpg" Width="50px" Height="50px" OnClick="btnDatos_Click" /><asp:ImageButton ID="btnTarjeta" runat="server" ImageUrl="~/images/tarjeta.png" Width="50px" Height="50px" OnClick="btnTarjeta_Click" /><asp:ImageButton ID="btnHistorial" runat="server" ImageUrl="~/images/registro.png" Width="50px" Height="50px" OnClick="btnHistorial_Click" />
              <asp:MultiView ID="MultiView1" runat="server">

                  <asp:View ID="View1" runat="server">
                  
                      <asp:PlaceHolder ID="PlaceDatos" runat="server"></asp:PlaceHolder>
                     
                  </asp:View>
                 

                  <asp:View ID="View2" runat="server">
                      <div class="container" >
                          <div class="form-group">
                          <label for="pwd">Targetas Registradas</label>
                        <asp:DropDownList ID="DropDownList1"  class="form-control"  runat="server"></asp:DropDownList>
                       </div>
                         </div>
                  </asp:View>

                  <asp:View ID="View3" runat="server">
                        <div class="container">
                        <h2>Registro de Actividad</h2>
                             
                        <table class="table table-striped">
                        <thead>
                        <tr>
                        <th>Hotel</th>
                        <th>Numero de Habitacion</th>
                        <th>Tipo de Habitacion</th>
                        <th>Fecha de Ingreso </th>
                        <th>Fecha de Salida</th>
                        <th>Direccion del Hotel</th>
                        <th>Telefono del Hotel</th>
                        <th>Total</th>
                        <th>Estado de la Reserva</th>
                        </tr>
                        </thead>
                        <tbody>
                     
                            <asp:PlaceHolder ID="PlaceRegisto" runat="server"></asp:PlaceHolder>
                        </tbody>
                        </table>
                        </div>

                  </asp:View>
              </asp:MultiView>

          </div>
          </div>


           <div class="row">
          <div class="pie">
              <h1>Busca Hoteles</h1>
              <center>
               <ul>
              <li><a href="#"><span class="icon-home"></span> Home</a></li>
              <li><a href="#"><span class="icon-newspaper"></span> Ofertas</a></li>
              <li><a href="#"><span class="icon-file-empty"></span> Ayuda</a></li>
            <li ><a data-toggle="modal" data-target="#myModal"><span class="icon-user" ></span> Iniciar Sesion o Crear Cuenta</a></li>       
              </ul>
                  </center>
              </div>
          </div>
    
    </div>
    </div>
    </form>
</body>
</html>
