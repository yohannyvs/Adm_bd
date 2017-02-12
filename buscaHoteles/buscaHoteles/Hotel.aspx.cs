using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace buscaHoteles
{
    public partial class Hotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String hotel, fechain, fechasal, adul, nin, noc;

            hotel = Request.QueryString["ht"].ToString();

            fechain = Request.QueryString["fi"].ToString();

            fechasal = Request.QueryString["fs"].ToString();

            adul = Request.QueryString["ad"].ToString();

            nin = Request.QueryString["ni"].ToString();
            noc = Request.QueryString["no"].ToString();
            
            LBfechaIn.Text = fechain;
            LBfechaSal.Text = fechasal;
            LBNumAdul.Text = adul;
            LBNumNi.Text = nin;
            LBNumNoche.Text = noc;


            Metodos metodo = new Metodos();

            //generar el contenido de la pagina
            if (!this.IsPostBack)
            {

                //generar datos del Hotel

                //Building an HTML string.
                StringBuilder html = new StringBuilder();
                StringBuilder htm2 = new StringBuilder();
                StringBuilder htm5 = new StringBuilder();

                var hoteles = metodo.ObtenerDatosHotel(Int32.Parse(hotel));
               
                foreach (var result in hoteles)
                {
                    html.Append("<div class='infoEncabezado'>");
                    html.Append("<ul>");
                    html.Append("<li><div id = 'iconoLuna' > <span class='icon-moon'></span><span class='icon-sun2'></span></div> </li>");
                    html.Append("<li><h1>"+result.Nombre_hotel+"</h1></li>");
                    html.Append("<div class='estrellas'>");
                    for (int i = 0; i <result.Estrellas; i++)
                    {
                        html.Append("<li><span class='icon -star-full'>★</span></li>");
                    }

                    html.Append("</div>");
                    html.Append("<li>"+result.Direccion+" , "+result.Direccion+"<br/></li>");
                    html.Append("<li>Ir a:<a> Información general</a> |<a> Opciones de habitación</a> |<a> Información del hotel</a></li>");
                    html.Append("</ul>");
                    html.Append("</div>");

                    htm2.Append("<img src ='images/"+result.Imagen+"'>");
                    htm5.Append("<iframe src = 'https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d2739.6969790360777!2d-83.92510547675015!3d9.861126668442392!3m2!1i1024!2i768!4f13.1!5e0!3m2!1ses!2ses!4v1486395637022' width = '100%' height = '100%' frameborder = '0' style = 'border:0' allowfullscreen ></iframe>");


               



                    }

                //Append the HTML string to Placeholder.
                placeEncabezadoHotel.Controls.Add(new Literal { Text = html.ToString() });
                PlaceImagen.Controls.Add(new Literal { Text = htm2.ToString() });
                PlaceMapa.Controls.Add(new Literal { Text = htm5.ToString() });

                //genera los servicios del Hotel
                StringBuilder htm3 = new StringBuilder();
               
                var serh = metodo.ObtenerServiciosHotel(Int32.Parse(hotel));
               
                foreach (var result in serh)
                {

                  htm3.Append("<li><span class='icon-checkmark'>"+result.Descripcion+"</span></li>");
                }
                PlaceServicios.Controls.Add(new Literal {Text = htm3.ToString() });
               

                //// genera las atracciones del hotel
                var Atrah = metodo.ObtenerAtraccionesHotel(Int32.Parse(hotel));
                StringBuilder htm4 = new StringBuilder();
                foreach (var result in Atrah)
                {
                    htm4.Append("<li><span class='icon-checkmark'>" + result.Descripcion + "</span></li>");
                }
                    PlaceAtracciones.Controls.Add(new Literal {Text = htm4.ToString() });



                //// genera las Habitacion del Hotel
                var Habitacion = metodo.obtenerHabitacionHotel(Int32.Parse(hotel));
                StringBuilder htm6 = new StringBuilder();
                foreach (var result in Habitacion)
                {
                    htm6.Append("");

                    htm6.Append("<tr>");
                    htm6.Append("<td>");
                    htm6.Append("<div class='contHabit'>");
                    htm6.Append("<div class='tbimg'><img src ='images/"+result.Imagen+"' ></div>");
                   
                        htm6.Append("<span class='icon -user'></span>");
                        htm6.Append("<span class='icon -user'></span>");
                        htm6.Append("<span class='icon -user'></span>");
                        htm6.Append("<span class='icon -user'></span>");
                    
                    htm6.Append("<p>Personas</p>");
                    htm6.Append("<p id = 'tipohabi' > "+result.Tipo+" </p>");
                    htm6.Append("</div>");
                    htm6.Append("</td >");
                    htm6.Append("<td>");
                    htm6.Append("<ul>");
                    htm6.Append("<li> Todo Incluido</li>");
                    htm6.Append("<li>Parqueo Gratis</li>");
                    htm6.Append("<li>Wi-fi</li>");
                    htm6.Append("</ul>");
                    htm6.Append("</td>");
                    htm6.Append("<td>24 hour deal: save 45%</td>");
                    htm6.Append("<td> <p id ='prec' >¢" + result.Precio+"</p> por noche<br/>");
                    htm6.Append("<input type = 'button' value= 'reservar' id= 'reservar'>");
                    htm6.Append("</td>");
                    htm6.Append("</tr>");



                }
              PlaceHabitacion.Controls.Add(new Literal { Text = htm6.ToString() });


                







               }


        }
    }
}