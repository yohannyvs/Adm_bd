<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hotel.aspx.cs" Inherits="buscaHoteles.Hotel" %>

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
                
                 <asp:Button ID="Button1" runat="server" Text="Login"  OnClick="login_Click"/> o <a href="registro.aspx">Registrarse</a>
              </div>
             
             </div>
            
            </div>
            
            
            
            
            
        </div>
     
      </div>
      
    </div>
  </div>
          
          </div>
 
    <div class="container">
             
            
      <div class="row">
          
          <div class="HoBuscar">
               
                   <div class="hdata">
             <div class="col-xs-4 col-sm-4 col-md-4">
                 <a href="busqueda.html"><span class="icon-circle-left"></span>Volver a los resultados de la busqueda</a>
               
                   </div>
             <div class="col-xs-8 col-sm-8 col-md-8">
                     <p style=""><asp:Label ID="LBfechaIn" runat="server" Text="Label"></asp:Label> - <asp:Label ID="LBfechaSal" runat="server" Text="Label"></asp:Label>,</p><h5> <asp:Label ID="LBNumNoche" runat="server" Text="Label"></asp:Label> noche</h5>,<p> 1 habitación, <asp:Label ID="LBNumAdul" runat="server" Text="Label"></asp:Label> adultos,<asp:Label ID="LBNumNi" runat="server" Text="Label"></asp:Label> Niños</p>
                 <div class="btnmb" id="btnmb"><span class="icon-circle-down"></span>ModificarBusqueda</div>
                 </div>
                  </div>
             </div>
              <div class="row">
               <div class="col-xs-12 col-sm-12 col-md-12 " id="hbus">
            
              <div class=" col-xs-12 col-sm-2 col-md-2">
              <div class="form-group">
                  <label for="usr">Destino lugar de interes</label>
                  <input type="text" class="form-control" placeholder="Destino, hotel, lugar de interés o dirección" id="htl" runat="server">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
              <div class="form-group">
                  <label for="usr">Check-in</label>
                  <input type="text" class="form-control " placeholder="Check-in" id="date1" runat="server">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
              <div class="form-group">
                <label for="usr">Check-out</label>
                  <input type="text" class="form-control" placeholder="Check-out"  id="date2" runat="server">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
             <div class="form-group">
                  <label for="usr">Adultos:</label>
              <select class="form-control" id="SelectAdul" runat="server">
                  <option value="1">1</option>
                  <option value="2">2</option>
                  <option value="3">3</option>
                  <option value="4">4</option>
              </select>
                  </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
                  <div class="form-group">
                       <label for="usr">Niños</label>
              <select class="form-control" id="SelectNi" runat="server">
                  <option value="0">0</option>
                  <option value="1">1</option>
                  <option value="2">2</option>
                  <option value="3">3</option>
              </select>
                  </div>
              </div>
               
              <div class="col-xs-12 col-sm-12 col-md-2">
               <div class="bt">   
               <div class="form-group">
                  <asp:Button ID="btncheck" class="form-control input-lg" runat="server" Text="Buscar" OnClick="btncheck_Click" />
                  </div>
                   </div>
               </div>
              
                </div>
              </div>
             </div>
          
          <div class="row">
              <div class="infoHotel">
                    <div class="col-xs-12 col-sm-12 col-md-12">
                        
                        <asp:PlaceHolder ID="placeEncabezadoHotel" runat="server"></asp:PlaceHolder>
                  
              </div>
          <div class="col-xs-12 col-sm-12 col-md-8">
          <div class="hotelimg">
              <asp:PlaceHolder ID="PlaceImagen" runat="server"></asp:PlaceHolder>
              
              </div>
              
              <div class="hotelServ">
              
                  <div class="col-xs-12 col-sm-12 col-md-4">
                  <div class="Hservicios">
                      <span class="icon-office"></span><h4>Servicios Principales</h4>
                      <ul>
                         
                          <asp:PlaceHolder ID="PlaceServicios" runat="server"></asp:PlaceHolder>
                      </ul>
                      </div>
                  
                  
                  </div>
                  <div class="col-xs-12 col-sm-12 col-md-4">
                  <div class="Hatraccion">
                      <span class="icon-pushpin"></span><h4>Atracciones</h4>
                      <ul>
                       <asp:PlaceHolder ID="PlaceAtracciones" runat="server"></asp:PlaceHolder>
                      </ul>
                      </div>
                  
                  </div>
              </div>
              
              
              
              
              
              </div>
              <div class="col-xs-12 col-sm-12 col-md-4">
                  <div class="hotelofer">
                      <div id="hoteloferHead">
                      <span class="icon-calendar"> Oferta de Dia</span>
                      </div>
                  <ul><li><label class="preA">¢ 264.635</label> <label class="preOF">¢ 238.172</label> </li></ul>
                  <ul><li>Precio por Noche</li></ul>
                  <ul><li id="reserHotel"><a  href="#habita">Reserva Ahora</a></li></ul>
                  <ul><li></li></ul>
                  </div>
                  </div>
                  
              </div>
          
          
          
          </div>
                  <div class="row">
                 
                      <div class="Hmapa">
                          <asp:PlaceHolder ID="PlaceMapa" runat="server"></asp:PlaceHolder>
                            </div>
                      </div>
                 
             
          
          <div class="row">
              <div class="hotelHabitaciones" id="habita" >
                  <h1>Habitaciones</h1>
         
    <table class="table table-condensed">
    <thead>
      <tr>
        <th>Tipo Habitacion</th>
        <th>Opciones</th>
        <th>Ofertas</th>
        <th>Precio de Hoy</th>
      </tr>
    </thead>
    <tbody>
        <asp:PlaceHolder ID="PlaceHabitacion" runat="server"></asp:PlaceHolder>
    </tbody>
  </table>
              
              
              </div>
          
          </div>
          <asp:PlaceHolder ID="PlaceId" runat="server"></asp:PlaceHolder>    
           
        

         
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
    </form>
     <!-- Librería jQuery requerida por los plugins de JavaScript -->
    <script src="http://code.jquery.com/jquery.js"></script>
    <script src="js/functions.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <!-- Todos los plugins JavaScript de Bootstrap (también puedes
         incluir archivos JavaScript individuales de los únicos
         plugins que utilices) -->
    <script src="js/bootstrap.min.js"></script>
       
</body>
</html>
