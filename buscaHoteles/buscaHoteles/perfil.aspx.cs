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
    public partial class perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string cedula = (string)Session["Ced"];
                StringBuilder html = new StringBuilder();

                Metodos metodo = new Metodos();
                var persona = metodo.ObtenerPersona(int.Parse(cedula));
                foreach (var p in persona)
                {
                    html.Append("<div class='alert alert-warning'>");
                    html.Append("<strong>Cedula:</strong> " + p.num_Cedula + "");
                    html.Append("</div>");
                    html.Append("<div class='alert alert-warning'>");
                    html.Append("<strong>Nombre:</strong> " + p.Nombre + "");
                    html.Append("</div>");
                    html.Append("<div class='alert alert-warning'>");
                    html.Append("<strong>Apellido:</strong> " + p.Apelldio + "");
                    html.Append("</div>");
                    html.Append("<div class='alert alert-warning'>");
                    html.Append("<strong>Email:</strong> " + p.Email + "");
                    html.Append("</div>");
                    html.Append("<div class='alert alert-warning'>");
                    html.Append("<strong>Telefono:</strong> " + p.Telefono + "");
                    html.Append("</div>");

                }
                PlaceDatos.Controls.Add(new Literal { Text = html.ToString() });

                DropDownList1.DataSource = metodo.ObtenertarjetaCliente(int.Parse(cedula));
                DropDownList1.DataTextField = "num_Tarjeta";
                DropDownList1.DataValueField = "num_Tarjeta";
                DropDownList1.DataBind();




                StringBuilder registro = new StringBuilder();

                var regis = metodo.ObtenerRegistro(int.Parse(cedula));
                foreach (var r in regis)
                {

                    registro.Append("<tr>");
                    registro.Append("<td>" + r.nom_Hotel + "</td>");
                    registro.Append("<td>" + r.id_habitacion + "</td>");
                    registro.Append("<td>" + r.tipo_Habitacion + "</td>");
                    registro.Append("<td>" + r.Fecha_Ingreso + "</td>");
                    registro.Append("<td>" + r.fecha_salida + "</td>");
                    registro.Append("<td>" + r.Direccion + "</td>");
                    registro.Append("<td>" + r.telefono + "</td>");
                    registro.Append("<td>" + r.total + "</td>");


                    if (r.estado == "P")
                    {
                        registro.Append("<td>La Reserva ya fue Pagada</td>");
                    }
                    else if (r.estado == "C")
                    {
                        registro.Append("<td>La Reserva Fue Cancelada</td>");

                    }
                    else
                    {
                        registro.Append("<td>La Reserva esta pendiente de pago</td>");

                    }

                    if (r.estado == "C")
                    {
                        registro.Append("<td><span class='icon-cancel-circle'>Cancelar</span></a></td>");
                    }
                    else
                    {
                        registro.Append("<td><a href='elimina.aspx?idh=" + r.id_Hotel + "&idr=" + r.id_Reserva + "&idc=" + r.id_Carrito + "&idt=" + r.id_tipo + "'><span class='icon-cancel-circle'>Cancelar</span></a></td>");
                    }
                    registro.Append("</tr>");
                }
                PlaceRegisto.Controls.Add(new Literal { Text = registro.ToString() });

            }
            catch (Exception ex) { }



        }

        protected void btnDatos_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnTarjeta_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnHistorial_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }
    }
}