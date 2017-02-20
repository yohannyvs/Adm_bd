using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Text;
using System.Collections;
namespace buscaHoteles
{
    public partial class busqueda : System.Web.UI.Page
    {
        Metodos metodo = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                string nombre = (string)Session["user"];

                StringBuilder htm9 = new StringBuilder();
                if (nombre == null)
                {
                    htm9.Append("<a data-toggle = 'modal' data-target='#myModal' ><span class='icon-user'></span> Iniciar Sesion</a>");
                    PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                }
                else
                {
                    htm9.Append("<a href='perfil.aspx'>Bienvenido :" + nombre + "</a>");
                    PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                }



                String hotel, fechain, fechasal, adul, nin, noc;

                hotel = Request.QueryString["ht"].ToString();

                fechain = Request.QueryString["fi"].ToString();

                fechasal = Request.QueryString["fs"].ToString();

                adul = Request.QueryString["ad"].ToString();

                nin = Request.QueryString["ni"].ToString();
                noc = Request.QueryString["no"].ToString();

                LbHotel.Text = hotel;
                LBfechaIn.Text = fechain;
                LBfechaSal.Text = fechasal;
                LBNumAdul.Text = adul;
                LBNumNi.Text = nin;
                LBNumNoche.Text = noc;





                /*Genera los check con los datos de los tipos de hotel almacenados en la base de datos*/
                var th = metodo.ObtenerTiposHotel();
                if (!this.IsPostBack)
                {


                    //Building an HTML string.
                    StringBuilder html = new StringBuilder();

                    foreach (var tipohotel in th)
                    {
                        ListItem item = new ListItem();

                        item.Text = tipohotel.Descripcion;
                        item.Value = tipohotel.Descripcion;
                        CheckBoxTipoHospedaje.Items.Add(item);

                    }




                    //Genera los check con los datos de los Servicios  almacenados en la base de datos


                    StringBuilder html2 = new StringBuilder();
                    var servi = metodo.ObtenerServicios();
                    foreach (var servicio in servi)
                    {
                        ListItem item = new ListItem();

                        item.Text = servicio.Descripcion;
                        item.Value = servicio.Descripcion;
                        CheckBoxServicios.Items.Add(item);



                    }



                    //Genera los check con los datos de las Atracciones  almacenados en la base de datos


                    StringBuilder html3 = new StringBuilder();
                    var atra = metodo.ObtenerAtracciones();
                    foreach (var Atraccion in atra)
                    {

                        ListItem item = new ListItem();

                        item.Text = Atraccion.Descripcion;
                        item.Value = Atraccion.Descripcion;
                        CheckBoxAtraccion.Items.Add(item);


                    }






                    /*Generar hoteles de la busqueda*/



                    StringBuilder html4 = new StringBuilder();
                    var ht = metodo.BuscarHotel(hotel);
                    foreach (var Hotel in ht)
                    {




                        html4.Append("<div class='row'>");
                        html4.Append("<div class='col -xs-4 col-sm-4 col-md-4'>");
                        html4.Append("<div class='Himg'><img src='images/" + Hotel.Imagen + "' width='100%'> </div>");
                        html4.Append("</div>");
                        html4.Append("<div class='col -xs-6 col-sm-6 col-md-6'>");
                        html4.Append("<div class='Hcaract'>");
                        html4.Append("<div class='Htit'><a href='#'><h3> " + Hotel.Nombre_hotel + "</h3></a></div>");
                        html4.Append("<div class='Hsubt'><span class='icon-location'></span><h5>" + Hotel.Localidad + " , " + Hotel.Direccion + " ," + Hotel.Id_Hotel + "</h5></div>");
                        html4.Append("<div class='Hadisp'>Quedan " + Hotel.numHabitacion + " habitaciones </div>");
                        html4.Append("<div class='tipPago'><span class='icon-checkmark'></span> " + Hotel.TipoPago + "</div>");
                        html4.Append("<div class='btnseleccionar'><a href='Hotel.aspx?ht=" + Hotel.Id_Hotel + "&fi=" + fechain + "&fs=" + fechasal + "&ad=" + adul + "&ni=" + nin + "&no=" + noc + "'>Seleccionar</a> </div>");
                        html4.Append("</div>");
                        html4.Append("</div> ");
                        html4.Append("</div>");






                    }

                    //Append the HTML string to Placeholder.
                    PlaceHoteles.Controls.Add(new Literal { Text = html4.ToString() });







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

        protected void buscar_Click(object sender, EventArgs e)
        { /*obtener estrellas de hotel*/
            ArrayList estrella = new ArrayList();
            foreach (ListItem li in this.CheckBoxEstrellas.Items)
            {

                if (li.Selected)
                {
                    estrella.Add(li.Text + ",");
                }

            }




            /*obtener tipos de hotel*/
            ArrayList thotel = new ArrayList();
            foreach (ListItem li in this.CheckBoxTipoHospedaje.Items)
            {

                if (li.Selected)
                {
                    thotel.Add(li.Text + ",");
                }

            }

            /*obtener Atracciones de hotel*/
            ArrayList Atracciones = new ArrayList();
            foreach (ListItem li in this.CheckBoxAtraccion.Items)
            {

                if (li.Selected)
                {
                    Atracciones.Add(li.Text + ",");
                }

            }

            /*obtener Servicios de hotel*/
            ArrayList Servicios = new ArrayList();
            foreach (ListItem li in this.CheckBoxServicios.Items)
            {

                if (li.Selected)
                {
                    Servicios.Add(li.Text + ",");
                }

            }

            string es = "";
            for (int i = 0; i < estrella.Count; i++)
            {
                es = es + estrella[i];
            }



            string th = "";
            for (int i = 0; i < thotel.Count; i++)
            {
                th = th + thotel[i];
            }

            string a = "";
            for (int i = 0; i < Atracciones.Count; i++)
            {
                a = a + Atracciones[i];
            }

            string s = "";
            for (int i = 0; i < Servicios.Count; i++)
            {
                s = s + Servicios[i];
            }

            String seleccionados;
            seleccionados = es + th + a + s;
            Response.Write("<script language=javascript>if(confirm('" + seleccionados + "')==true){ location.href='busqueda.aspx';}else { location.href='busqueda.aspx';}</script>");
        }
    }
}