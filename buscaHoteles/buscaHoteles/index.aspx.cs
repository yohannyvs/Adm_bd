using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Text;

namespace buscaHoteles
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder htm9 = new StringBuilder();
            
                htm9.Append("<a data-toggle = 'modal' data-target='#myModal' ><span class='icon-user'></span> Iniciar Sesion</a>");
                PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });


            StringBuilder htm = new StringBuilder();
            Metodos metodo = new Metodos();
            var of = metodo.ObtenerOfertas();
            if (!this.IsPostBack)
            {
                foreach (var oferta in of) {

                    htm.Append("<div class='col-xs-12 col-sm-6 col-md-3'>");
                    htm.Append("<div class='oferta'>");
                    htm.Append("<div class='ofimg'><img src='images/LOGO-OFERTA.GIF' ></div>");
                    htm.Append("<div class='pordes'>Descuento del "+oferta.descuento+"%</div>");
                    htm.Append("<div class='nombrehotel'>"+oferta.Nombre_hotel+"</div>");
                    htm.Append("<div class='vermas'><a href='Hotel.aspx?ht="+oferta.Id_Hotel+ "&fi=14/02/2017&fs=15/02/2017&ad=1&ni=0&no=1'> Vermas..</a></div>");
                    htm.Append("</div>");
                    htm.Append("</div>");
                }
                PlaceOferta.Controls.Add(new Literal { Text = htm.ToString() });
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

            
            Response.Redirect("busqueda.aspx?ht="+hotel+"&fi="+fechain+"&fs="+fechasal+"&ad="+adul+"&ni="+nin+"&no="+Dias);
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
                if (!this.IsPostBack)
                {

                    htm9.Append("<a href='perfil.aspx'>Bienvenido :" + user+"</a>");
                    PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                }

                Session.Add("user", user);
                
                Session.Add("Ced",cedula);
                Server.Transfer("index.aspx");
                Server.Transfer("perfil.aspx");
                Server.Transfer("busqueda.aspx");
                Server.Transfer("Hotel.aspx");
                Server.Transfer("reserva.aspx");
                
                
            }
            else {
                Response.Write("<script language=javascript>if(confirm('Usuaro o Contraseña Incorrectos')==true){ location.href='index.aspx';}else { location.href='index.aspx';}</script>");
            }
        }
    }
}