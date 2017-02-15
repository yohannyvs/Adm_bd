<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reserva.aspx.cs" Inherits="buscaHoteles.reserva" %>

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


              <asp:MultiView ID="MultiView1" runat="server">

                  <asp:View ID="View1" runat="server">
                       <!--Vista de inicio -->

    <div class="container">
      
        <div class="row">
                <div class="Metpago">
                <h4 id="cp">Escoge Como Quieres Pagar</h4>
                <div class="col-xs-6 col-sm-6 col-md-6" style="border-right:1px solid gray;">
                <center>
                <div class="Cpa">
                <h6>Pagar todo Ahora mismo</h6>
                <h5>₡<asp:Label ID="Labelah" runat="server" Text="Label"></asp:Label></h5>
                <p>Precio por Noche</p>
                </div>
            
                <ul>
                <li><span class='icon-checkmark'></span>Se te hará el cargo en USD</li>
                <li><span class='icon-checkmark'></span>Cancela sin cargo hasta el período permitido por el hotel</li>
                <li><span class='icon-checkmark'></span>Acumula y canjea noches </li>
                </ul> 
               <asp:Button id="btnPagar" Text="Pagar todo Ahora mismo" runat="server" OnClick="btnPagar_Click"  ></asp:Button>
               </center>
                </div>
              
                <div class="col-xs-6 col-sm-6 col-md-6">
                <center>
                <div class="Cpa">
                <h6>Reserva y Paga en Hotel</h6>
                <h5>₡<asp:Label ID="Labelph" runat="server" Text="Label"></asp:Label></h5>
                <p>Precio por Noche</p>
                </div>
            
                <ul>
                <li><span class='icon-checkmark'></span>Se te hará el cargo en USD</li>
                <li><span class='icon-checkmark'></span>Cancela sin cargo hasta el período permitido por el hotel</li>
                <li><span class='icon-checkmark'></span>Acumula y canjea noches </li>
                </ul>
                <asp:Button runat="server" id="btnReserva" Text="Reservar" OnClick="btnReserva_Click"></asp:Button>
                </center>
                </div>
              
                </div>
         </div>
      
      </div>
      

                  </asp:View>
                 

                  <asp:View ID="View2" runat="server">
                      <!--Vista de Pagar Ahora -->
                      <div class="container" style="margin-top:5%;">
                          <div class="alert alert-success">
                          <strong>Cliente:</strong> <asp:Label ID="ced" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Hotel :</strong> <asp:Label ID="idhotel" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Habitacion:</strong> <asp:Label ID="idh" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>tipo:</strong> <asp:Label ID="Labeltipo" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Fecha Ingreso</strong> <asp:Label ID="fi" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Fecha Salida</strong> <asp:Label ID="fs" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Total</strong> <asp:Label ID="labeltotal" runat="server" Text=""></asp:Label>
                          </div>
                           

                          <asp:Label ID="Label1" runat="server" Text="Tarjetas"></asp:Label>
                          <br />
                          <div class="form-group">
                          <asp:DropDownList ID="DropDownList1"  class="form-control" runat="server">
                           
                          </asp:DropDownList>
                              </div>
                          
                          <div class="form-group">
                          <asp:Button class="form-control" id="usr" runat="server" Text="Reservar" OnClick="usr_Click" />
                        </div>

                          
                      </div>
                     
                  </asp:View>

                  <asp:View ID="View3" runat="server">
                      <!--Vista de Pagar en Hotel -->
                       <div class="container" style="margin-top:5%;">
                          <div class="alert alert-success">
                          <strong>Cliente:</strong> <asp:Label ID="ced2" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Hotel :</strong> <asp:Label ID="idhotel2" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Habitacion:</strong> <asp:Label ID="idh2" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>tipo:</strong> <asp:Label ID="Labeltipo2" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Fecha Ingreso</strong> <asp:Label ID="fi2" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Fecha Salida</strong> <asp:Label ID="fs2" runat="server" Text=""></asp:Label>
                          </div>
                          <div class="alert alert-success">
                          <strong>Total</strong> <asp:Label ID="labeltotal2" runat="server" Text=""></asp:Label>
                          </div>
                           

                          <asp:Label ID="Label9" runat="server" Text="Tarjetas"></asp:Label>
                          <br />
                          <div class="form-group">
                          <asp:DropDownList ID="DropDownList2"  class="form-control" runat="server">
                           
                          </asp:DropDownList>
                              </div>
                          
                          <div class="form-group">
                          <asp:Button class="form-control" id="usr2" runat="server" Text="Reservar" OnClick="usr2_Click" />
                        </div>

                          
                      </div>


                  </asp:View>
              </asp:MultiView>

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
