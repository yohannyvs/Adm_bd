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

            try {
                string nombre = (string)Session["user"];
                StringBuilder htm9 = new StringBuilder();
                if (nombre == null)
                {
                    htm9.Append("<a data-toggle = 'modal' data-target='#myModal' ><span class='icon-user'></span> Iniciar Sesion</a>");
                    PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                }
                else
                {
                    htm9.Append("<a href='perfil.aspx'>Bienvenido :" + nombre + "</a>" );
                    PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                }



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
                        html.Append("<li><h1>" + result.Nombre_hotel + "</h1></li>");
                        html.Append("<div class='estrellas'>");
                        for (int i = 0; i < result.Estrellas; i++)
                        {
                            html.Append("<li><span class='icon -star-full'>★</span></li>");
                        }

                        html.Append("</div>");
                        html.Append("<li>" + result.Direccion + " , " + result.Localidad + "<br/></li>");
                        html.Append("<li>Ir a:<a> Información general</a> |<a> Opciones de habitación</a> |<a> Información del hotel</a></li>");
                        html.Append("</ul>");
                        html.Append("</div>");

                        htm2.Append("<img src ='images/" + result.Imagen + "'>");
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

                        htm3.Append("<li><span class='icon-checkmark'></span>" + result.Descripcion + "</li>");
                    }
                    PlaceServicios.Controls.Add(new Literal { Text = htm3.ToString() });


                    //// genera las atracciones del hotel
                    var Atrah = metodo.ObtenerAtraccionesHotel(Int32.Parse(hotel));
                    StringBuilder htm4 = new StringBuilder();
                    foreach (var result in Atrah)
                    {
                        htm4.Append("<li><span class='icon-checkmark'></span>" + result.Descripcion + "</li>");
                    }
                    PlaceAtracciones.Controls.Add(new Literal { Text = htm4.ToString() });



                    //// genera las Habitacion del Hotel
                    var Habitacion = metodo.obtenerHabitacionHotel(Int32.Parse(hotel));
                    StringBuilder htm6 = new StringBuilder();
                    StringBuilder htm8 = new StringBuilder();
                    foreach (var result in Habitacion)
                    {
                        htm6.Append("");

                        htm6.Append("<tr>");
                        htm6.Append("<td>");
                        htm6.Append("<div class='contHabit'>");
                        htm6.Append("<div class='tbimg'><img src ='images/" + result.Imagen + "' ></div>");
                        htm6.Append("<p>" + result.nPersonas + "Personas</p>");
                        htm6.Append("<p id = 'tipohabi' > " + result.Tipo + " </p>");
                        htm6.Append("</div>");
                        htm6.Append("</td >");
                        htm6.Append("<td>");
                        htm6.Append("<ul>");
                        var sh = metodo.ObtenerServiciosHabitacion(result.IdHabitacion);
                        foreach (var servicio in sh)
                        {
                            htm6.Append("<li> " + servicio.Descripcion + "</li>");
                        }
                        htm6.Append("</ul>");
                        htm6.Append("</td>");
                        htm6.Append("<td>24 hour deal: save 45%</td>");
                        htm6.Append("<td> <p id ='prec' >¢" + result.Precio + "</p> por noche<br/>");

                        var numtipH = metodo.ObtenerCantidadHabitacionesTipo(Int32.Parse(hotel), result.id_TipoHabitacion);
                        foreach (var num in numtipH)
                        {
                            htm6.Append("<div class='Hadisp'>" + num.Descripcion + " habitaciones disponibles </div>");

                        }



                        htm6.Append("<div id='reservar'><a href='reserva.aspx?hb=" + result.IdHabitacion + "&fi=" + LBfechaIn.Text + "&fs=" + LBfechaSal.Text + "&n=" + LBNumNoche.Text + "&p=" + result.Precio + "&ih=" + result.IdHotel + "&it=" + result.id_TipoHabitacion + "'>Reservar</a> </div>");
                        htm6.Append("</td>");
                        htm6.Append("</tr>");



                    }
                    PlaceHabitacion.Controls.Add(new Literal { Text = htm6.ToString() });
                }



            }
            catch (Exception ex) { }



        }

        protected void login_Click(object sender, EventArgs e)
        {
            String user, pass;
            user = LUsuario.Value;
            pass = Lpassword.Value;
            Metodos metodo = new Metodos();

            if (metodo.login(user, pass) == true)
            {
                string cedula = metodo.ObtenerCedulaCliente(user);
                StringBuilder htm9 = new StringBuilder();
                htm9.Append("Bienvenido :" + user);
                PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                Session.Add("user", user);

                Session.Add("Ced", cedula);
                Server.Transfer("index.aspx");
                Server.Transfer("busqueda.aspx");
                Server.Transfer("Hotel.aspx");
                Server.Transfer("reserva.aspx");


            }
            else
            {
                Response.Write("<script language=javascript>if(confirm('Usuaro o Contraseña Incorrectos')==true){ location.href='index.aspx';}else { location.href='index.aspx';}</script>");
            }
        }


        protected void btncheck_Click(object sender, EventArgs e)
        {
            String hotel, fechain, fechasal, adul, nin;
            hotel = htl.Value;
            fechain = date1.Value;
            fechasal = date2.Value;
            adul = SelectAdul.Value;
            nin = SelectNi.Value;




            DateTime oldDate = DateTime.Parse(fechain);
            DateTime newDate = DateTime.Parse(fechasal);
            TimeSpan ts = newDate - oldDate;
            String Dias = ts.Days.ToString();


            Response.Redirect("busqueda.aspx?ht=" + hotel + "&fi=" + fechain + "&fs=" + fechasal + "&ad=" + adul + "&ni=" + nin + "&no=" + Dias);
        }


    }
}