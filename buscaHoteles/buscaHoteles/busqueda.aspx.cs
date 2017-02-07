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
    public partial class busqueda : System.Web.UI.Page
    {
        Metodos metodo = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            String hotel, fechain, fechasal, adul, nin;

            hotel = Request.QueryString["ht"].ToString();

            fechain = Request.QueryString["fi"].ToString();

            fechasal = Request.QueryString["fs"].ToString();

            adul = Request.QueryString["ad"].ToString();

            nin = Request.QueryString["ni"].ToString();

            LbHotel.Text = hotel;
            LBfechaIn.Text = fechain;
            LBfechaSal.Text = fechasal;
            LBNumAdul.Text = adul;
            LBNumNi.Text = nin;






            /*Genera los check con los datos de los tipos de hotel almacenados en la base de datos*/
            var th = metodo.ObtenerTiposHotel();
            if (!this.IsPostBack)
            {
                //Populating a DataTable from database.
                //DataTable dt = this.GetData();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                foreach (var tipohotel in th)
                {
                    html.Append("<div class='checkbox'>");
                    html.Append("<label><input type ='checkbox' value='"+ tipohotel.Descripcion + "'>" + tipohotel.Descripcion + "</label>");
                    html.Append("</div>");
                     
                     
                 
              
                }

                //Append the HTML string to Placeholder.
                TipoHospedaje.Controls.Add(new Literal { Text = html.ToString() });

                //Genera los check con los datos de los Servicios  almacenados en la base de datos


                StringBuilder html2 = new StringBuilder();
                var servi = metodo.ObtenerServicios();
                foreach (var servicio in servi)
                {
                    html2.Append("<div class='checkbox'>");
                    html2.Append("<label><input type ='checkbox' value='" + servicio.Descripcion + "'>" + servicio.Descripcion + "</label>");
                    html2.Append("</div>");




                }

                //Append the HTML string to Placeholder.
                PlaceServicios.Controls.Add(new Literal { Text = html2.ToString() });

                //Genera los check con los datos de las Atracciones  almacenados en la base de datos


                StringBuilder html3 = new StringBuilder();
                var atra = metodo.ObtenerAtracciones();
                foreach (var Atraccion in atra)
                {
                    html3.Append("<div class='checkbox'>");
                    html3.Append("<label><input type ='checkbox' value='" + Atraccion.Descripcion + "'>" + Atraccion.Descripcion + "</label>");
                    html3.Append("</div>");




                }

                //Append the HTML string to Placeholder.
                PlaceAtraccion.Controls.Add(new Literal { Text = html3.ToString() });


            }


        }
	}
}