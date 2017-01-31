﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hotel.aspx.cs" Inherits="buscaHoteles.Hotel" %>

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
             
            
      
          
          <div class="HoBuscar">
               <div class="row">
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
                  <option value="1">1</option>
                  <option value="2">2</option>
                  <option value="3">3</option>
                  <option value="4">4</option>
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
          <div class="col-xs-12 col-sm-12 col-md-6">
          
              </div>
              <div class="col-xs-12 col-sm-12 col-md-6">
              </div>
          
          
          
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