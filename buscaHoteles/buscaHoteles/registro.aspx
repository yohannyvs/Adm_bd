<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="buscaHoteles.registro" %>

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



    <div class="row" style="margin-top:4%;">
     <div class="container">
      <h2 style="text-align:center;">Formulario de Registro</h2>
    <div class="form-group">
          <label for="cedula">Cédula de Identidad</label>
          <input type="text" class="form-control" id="cedula" placeholder="Número de Cédula" runat="server">
    </div>
    <div class="form-group">
          <label for="Nombre">Nombre</label>
          <input type="text" class="form-control" id="Nombre" placeholder="Nombre" runat="server">
    </div>
          <div class="form-group">
          <label for="Apellido">Apellido</label>
          <input type="text" class="form-control" id="Apellido" placeholder="Apellido" runat="server">
    </div>
          <div class="form-group">
          <label for="Email">Email</label>
          <input type="email" class="form-control" id="Email" placeholder="Email" runat="server">
    </div>
          <div class="form-group">
          <label for="Telefono">Telefono</label>
          <input type="tel" class="form-control" id="Telefono" placeholder="Telefono" runat="server">
    </div>
    <div class="form-group">
          <label for="Contraseña">Contraseña</label>
          <input type="password" class="form-control" id="Contraseña" placeholder="Contraseña" runat="server">
       
    </div>
 
    </div>

     </div>

  <div class="row" style="margin-top:4%;">
     <div class="container">
      <h2 style="text-align:center;">Datos de Targeta</h2>
    <div class="form-group">
          <label for="cu">Numero de Targeta </label>
        <asp:TextBox  class="form-control" runat="server" placeholder="#### #### #### ####" ID="cu" MaxLength="16"></asp:TextBox>
          
    </div>
          <div class="form-group">
          <label for="cu">Tipo </label>
              <select id="SelectTipo"  class="form-control" runat="server">
                  <option>Master Card</option>
                   <option>Visa</option>
                   <option>American Express</option>
              </select>
          
    </div>
    
          <div class="form-group" style="margin-top:2%;">
         <center>
             
             <asp:ImageButton ID="Registrar" runat="server" ImageUrl="~/images/icono-registro.png" Width="80px" Height="80px" style="margin-top:2%;" OnClick="Registrar_Click"></asp:ImageButton>
         </center>
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
