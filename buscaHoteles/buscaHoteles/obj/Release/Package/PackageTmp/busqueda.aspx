﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="busqueda.aspx.cs" Inherits="buscaHoteles.busqueda" %>

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
         <div class="container-fluid">
      <div class="row">
          
          <div class="col-xs-2 col-sm-2 col-md-2 ">
          <div class="filtro">
              <h1>Afinar los Resultados</h1>
              <ul>
                  <li>
             <div class="form-group">
                  <label for="usr">Nombre de Hotel</label>
                  <input type="text" class="form-control" placeholder="Destino, hotel, lugar de interés o dirección" id="htl">
              </div>
                  </li>
                  <li>
                  <div class="form-group">
                  <label for="usr">Precio Minimo(C)</label>
              <select class="form-control" id="usr">
                <option value="0">0</option>
                  <option value="25000">25000</option>
                  <option value="45000">45000</option>
                  <option value="55000">55000</option>
              </select>
                  </div>
                      <div class="form-group">
                  <label for="usr">Precio Maximo(C)</label>
              <select class="form-control" id="usr">
                  <option value="0">0</option>
                  <option value="25000">25000</option>
                  <option value="45000">45000</option>
                  <option value="55000">55000</option>
              </select>
                  </div>
                  </li>
                   <li><div class="form-group">
                  <label for="usr">Categoria</label><br/>
                       <div class="checkbox">
                       <label><input type="checkbox" value=""><span class="icon-star-full"></span> 1</label>
                       <label><input type="checkbox" value=""> <span class="icon-star-full"></span> 2</label>
                       <label><input type="checkbox" value="" > <span class="icon-star-full"></span> 3</label>
                       <label><input type="checkbox" value="" > <span class="icon-star-full"></span> 4</label>
                        </div>
                 
                  </div></li>
                   <li>
                   <div class="form-group">
                  <label for="usr">Zona</label>
                 <div class="checkbox">
                          <label><input type="checkbox" value="">Jaco</label>
                        </div>
              </div>
                  </li>
                   <li>
             <div class="form-group">
                  <label for="usr">Tipo de Hospedaje</label>
                 <asp:PlaceHolder ID="TipoHospedaje" runat="server"></asp:PlaceHolder>
                  </li>
                   <li>
                 <div class="form-group">
                 <label for="usr">Servicios</label>
                     <asp:PlaceHolder ID="PlaceServicios" runat="server"></asp:PlaceHolder>
                 
              </div>
                  </li>
                   <li>
                 <div class="form-group">
                 <label for="usr">Atracciones</label>
                  <asp:PlaceHolder ID="PlaceAtraccion" runat="server"></asp:PlaceHolder>
              </div>
                  </li>
                  <li>
                  <input type="button" id="buscar"  value="Filtrar">
                  </li>
              </ul>
              </div>
          </div>
          <div class="col-xs-10 col-sm-10 col-md-10 ">

              <div class="container">
                     <div class="row">
          
          <div class="HoBuscar">
               
                   <div class="hdata">
          
             <div class="col-xs-10 col-sm-10 col-md-10">
                <p style=""><asp:Label ID="LbHotel" runat="server" Text="Label"></asp:Label>-<asp:Label ID="LBfechaIn" runat="server" Text="Label"></asp:Label> - <asp:Label ID="LBfechaSal" runat="server" Text="Label"></asp:Label>,</p><h5> <asp:Label ID="LBNumNoche" runat="server" Text="Label"></asp:Label> noche</h5>,<p> 1 habitación, <asp:Label ID="LBNumAdul" runat="server" Text="Label"></asp:Label> adultos,<asp:Label ID="LBNumNi" runat="server" Text="Label"></asp:Label> Niños</p>
                 
                 </div>
                  </div>
             </div>
         
             </div>

              </div>

       <div class="hoteles">
         <div class="hotel">
             
           
                  <asp:PlaceHolder ID="PlaceHoteles" runat="server"></asp:PlaceHolder>
              
           
            
                  
            
          
          
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