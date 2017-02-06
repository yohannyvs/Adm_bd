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
              <li  id="pr"><a href="#"><span class="icon-user"></span> Iniciar Sesion o Crear Cuenta</a></li>       
              </ul>
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
                       <p> jue, 2 de febrero de 2017 - vie, 3 de febrero de 2017,</p><h5> 1 noche</h5>,<p> 1 habitación, 2 adultos</p>
                 <div class="btnmb" id="btnmb"><span class="icon-circle-down"></span>ModificarBusqueda</div>
                 </div>
                  </div>
             </div>
              <div class="row">
               <div class="col-xs-12 col-sm-12 col-md-12 " id="hbus">
            
              <div class=" col-xs-12 col-sm-2 col-md-2">
              <div class="form-group">
                  <label for="usr">Destino lugar de interes</label>
                  <input type="text" class="form-control" placeholder="Destino, hotel, lugar de interés o dirección" id="htl">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
              <div class="form-group">
                  <label for="usr">Check-in</label>
                  <input type="text" class="form-control " placeholder="Check-in" id="datepicker">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
              <div class="form-group">
                <label for="usr">Check-out</label>
                  <input type="text" class="form-control" placeholder="Check-out" id="datepicker2">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-2">
             <div class="form-group">
                  <label for="usr">Adultos:</label>
              <select class="form-control" id="usr">
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
              <select class="form-control" id="usr">
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
                  <input type="button" id="btncheck" class="form-control input-lg" value="Buscar">
                  </div>
                   </div>
               </div>
              
                </div>
              </div>
             </div>
          
          <div class="row">
              <div class="infoHotel">
                    <div class="col-xs-12 col-sm-12 col-md-12">
                  <div class="infoEncabezado">
                      <ul>
                      <li><div id="iconoLuna"> <span class="icon-moon"></span><span class="icon-sun2"></span></div> </li>
                      <li><h1>Hotel Occidental Tamarindo</h1></li>
                          <div class="estrellas">
                      <li><span class="icon-star-full"></span></li>
                      <li><span class="icon-star-full"></span></li>
                      <li><span class="icon-star-full"></span></li>
                      <li><span class="icon-star-full"></span></li>
                      <li><span class="icon-star-empty"></span></li>
                              </div>
                          <li>Playa Langosta, Tamarindo, Guanacaste, 1150, Costa Rica, 0800-012-1776<br/></li>
                          <li>Ir a:<a> Información general</a> |<a> Opciones de habitación</a> |<a> Información del hotel</a></li>
                      </ul>
                    </div>
                  
              </div>
          <div class="col-xs-12 col-sm-12 col-md-8">
          <div class="hotelimg">
              <img src="images/Florida-Hotel-Orlando-Night.jpg">
              
              </div>
              
              <div class="hotelServ">
              
                  <div class="col-xs-12 col-sm-12 col-md-4">
                  <div class="Hservicios">
                      <span class="icon-office"></span><h4>Servicios Principales</h4>
                      <ul>
                          <li><span class="icon-checkmark"></span></li>
                          <li><span class="icon-checkmark"></span></li>
                          <li><span class="icon-checkmark"></span></li>
                          <li><span class="icon-checkmark"></span></li>
                      </ul>
                      </div>
                  
                  
                  </div>
                  <div class="col-xs-12 col-sm-12 col-md-4">
                  <div class="Hatraccion">
                      <span class="icon-pushpin"></span><h4>Atracciones</h4>
                      <ul>
                      <li><span class="icon-checkmark"></span></li>
                      <li><span class="icon-checkmark"></span></li>
                      <li><span class="icon-checkmark"></span></li>
                      <li><span class="icon-checkmark"></span></li>
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
                  <ul><li><input type="button" id="reserHotel" value="Reserva Ahora"></li></ul>
                  <ul><li></li></ul>
                  </div>
                  </div>
                  
              </div>
          
          
          
          </div>
                  <div class="row">
                 
                      <div class="Hmapa">
                       <iframe src="https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d2739.6969790360777!2d-83.92510547675015!3d9.861126668442392!3m2!1i1024!2i768!4f13.1!5e0!3m2!1ses!2ses!4v1486395637022" width="100%" height="100%" frameborder="0" style="border:0" allowfullscreen></iframe>
                       </div>
                      </div>
                 
             
          
          <div class="row">
              <div class="hotelHabitaciones">
                  <h1>Habitaciones</h1>
          <div class="col-xs-12 col-sm-12 col-md-12">
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
        <tr>
        <td><div class="contHabit">
            
            
            <div class="tbimg"><img src="images/Florida-Hotel-Orlando-Night.jpg"></div> 
            <span class="icon-user"></span>
            <span class="icon-user"></span>
            <span class="icon-user"></span>
            <span class="icon-user"></span>
            <p>Personas</p>
            <p id="tipohabi">Suite </p>
             </div>
            </td>
        <td>
            <ul>
            <li>Todo Incluido</li>
            <li>Parqueo Gratis</li>
            <li>Wi-fi</li>
            
            </ul> 
            </td>
        <td>24 hour deal: save 45%</td>
        <td> <p id="hprec">¢146.167</p> por noche<br/>
            <input type="button" value="reservar" id="reservar">
            </td>
        </tr>  
          <tr>
        <td><div class="contHabit">
            
            
            <div class="tbimg"><img src="images/Florida-Hotel-Orlando-Night.jpg"></div> 
            <span class="icon-user"></span>
            <span class="icon-user"></span>
            <span class="icon-user"></span>
            <span class="icon-user"></span>
            <p>Personas</p>
             </div>
            </td>
        <td>
            <ul>
            <li>Todo Incluido</li>
            <li>Parqueo Gratis</li>
            <li>Wi-fi</li>
            
            </ul> 
            </td>
        <td>24 hour deal: save 45%</td>
        <td> <p id="hprec">¢146.167</p> por noche
            <br/>
            <input type="button" value="reservar" id="reservar">
            </td>
        </tr> 
    </tbody>
  </table>
              
              
              </div>
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
              <li ><a href="#"><span class="icon-user"></span> Iniciar Sesion o Crear Cuenta</a></li>       
              </ul>
                  </center>
              </div>
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
