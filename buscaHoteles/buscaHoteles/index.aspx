<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="buscaHoteles.index" %>


<!DOCTYPE html>
<html lang="es">
  <head>
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
                  <li  id="pr"><a data-toggle="modal" data-target="#myModal"><span class="icon-user" ></span> Iniciar Sesion o Crear Cuenta</a></li>
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
                  <input type="text" class="form-control" placeholder="User">
                </div>
                <div class="form-group">
                  <label for="usr"><span class="icon-keyboard"></span>Pass</label>
                  <input type="password" class="form-control" placeholder="Pass">
                </div>
                
                 <input type="button" value="login">
              </div>
             
             </div>
            
            </div>
            
            
            
            
            
        </div>
     
      </div>
      
    </div>
  </div>
      
  
</div>
          
          
          
          
       
         
      
      <div class="row">
      <div class="fonimagen">
          <div class="text">
          <h1> Encuentra un Hotel </h1>.
              <center>
          <div class="linea"></div>
                  </center>
          <h2> Facil y Rapido a tan solo un click!</h2>
          </div>
          </div>
          <div class="container">
          <div class="Cbusca col-xs-12 col-sm-12 col-md-12 ">
              <div class=" col-xs-12 col-sm-12 col-md-3">
                  <h1>Encuentra Ahora <br/> los Mejores precios Online</h1> 
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-12">
              <div class="form-group">
                  <label for="usr">Destino</label>
                  <input type="text" class="form-control" placeholder="Destino, hotel, lugar de interés o dirección" id="htl">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-4">
              <div class="form-group">
                  <label for="usr">Check-in</label>
                  <input type="text" class="form-control " placeholder="Check-in" id="datepicker">
              </div>
              </div>
              <div class=" col-xs-12 col-sm-12 col-md-4">
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
               
              <div class=" col-xs-12 col-sm-12 col-md-8">
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
          
          
              <center>
              <div id="of">
              <h1>Ofertas</h1>
                  </div>
              </center>
              <div class="ofertas">
              <div class="col-xs-12 col-sm-6 col-md-3">
           <div class="oferta"> 
              <div class="ofimg"><img src="images/1da34920-3194-11e6-a413-d89d672bd508.jpg"></div>
              <div class="pordes">Descuento del 50%</div>
              <div class="nombrehotel">Hard Rock Hotel</div>
              <div class="vermas"><a href="#">Vermas..</a></div>
             </div>       
              </div>
               <div class="col-xs-12 col-sm-6 col-md-3">
            <div class="oferta"> 
              <div class="ofimg"><img src="images/1da34920-3194-11e6-a413-d89d672bd508.jpg"></div>
              <div class="pordes">Descuento del 50%</div>
              <div class="nombrehotel">Hard Rock Hotel</div>
              <div class="vermas"><a href="#">Vermas..</a></div>
             </div>      
              </div>
               <div class="col-xs-12 col-sm-6 col-md-3">
            <div class="oferta"> 
              <div class="ofimg"><img src="images/1da34920-3194-11e6-a413-d89d672bd508.jpg"></div>
              <div class="pordes">Descuento del 50%</div>
              <div class="nombrehotel">Hard Rock Hotel</div>
              <div class="vermas"><a href="#">Vermas..</a></div>
            </div>   
              </div>
               <div class="col-xs-12 col-sm-6 col-md-3">
            <div class="oferta">   
              <div class="ofimg"><img src="images/1da34920-3194-11e6-a413-d89d672bd508.jpg"></div>
              <div class="pordes">Descuento del 50%</div>
              <div class="nombrehotel">Hard Rock Hotel</div>
              <div class="vermas"><a href="#">Vermas..</a></div>
                </div>  
                   </div> 
              </div>
              
              </div>
          
          <div class="row">
          <center>
              <div id="of">
              <h1>Destinos Recomendados</h1>
                  </div>
              </center>
          
              <div class="recomendaciones">
                  <div class="container">
              <div class="row">
                  <div class="col-xs-12 col-sm-6 col-md-8">
                      <div class="reco1">
                      <div id="destNom">San Jose</div>
                      </div>
                  
                  </div>
                  <div class="col-xs-12 col-sm-6 col-md-4">
                      <div class="reco2">
                      <div id="destNom">Puntarenas</div>
                      </div>
                 
                  </div>
                  <div class="col-xs-12 col-sm-6 col-md-4">
                      <div class="reco2">
                      <div id="destNom">Guanacaste</div>
                      </div>
                 
                  </div>
               
                  <div class="col-xs-12 col-sm-6 col-md-4">
                      <div class="reco2">
                      <div id="destNom">Orlando Florida</div>
                      </div>
                 
                  </div>
                  <div class="col-xs-12 col-sm-6 col-md-4">
                      <div class="reco2">
                      <div id="destNom">Jaco</div>
                      </div>
                 
                  </div>
                <div class="col-xs-12 col-sm-6 col-md-4">
                 <div class="reco2">
                    <div id="destNom">Tamarindo</div>
                    </div>
                  
                  </div>
                 <div class="col-xs-12 col-sm-6 col-md-8">
                      <div class="reco1">
                     <div id="destNom">Cartago</div>
                     </div>
                  
                  </div>
                  <div class="col-xs-12 col-sm-6 col-md-4">
                      <div class="reco2">
                      <div id="destNom">Panama</div>
                      </div>
                 
                  </div>
                  <div class="col-xs-12 col-sm-6 col-md-4">
                      <div class="reco2">
                      <div id="destNom">Mexico</div>
                      </div>
                 
                  </div>         
                          
                          
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
              <li ><a data-toggle="modal" data-target="#myModal"><span class="icon-user" ></span> Iniciar Sesion o Crear Cuenta</a></li>       
              </ul>
                  </center>
              </div>
          </div>
      
      </div>
 
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