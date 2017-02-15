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
    public partial class reserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            MultiView1.ActiveViewIndex = 0;
            try
            {
                string nombre = (string)Session["user"];

                StringBuilder htm9 = new StringBuilder();
                if (nombre == null)
                {
                    Response.Write("<script language=javascript>if(confirm('Logeate Primero Para Poder Reservar')==true){ location.href='index.aspx';}else { location.href='index.aspx';}</script>");
                }
                else
                {
                    htm9.Append("Bienvenido : " + nombre);
                    PlaceLg.Controls.Add(new Literal { Text = htm9.ToString() });
                }

                if (!this.IsPostBack)
                {
                    String habitacion, fechain, fechasal, noches, precio, cedula, idHote, idtipo;

                    habitacion = Request.QueryString["hb"].ToString();

                    fechain = Request.QueryString["fi"].ToString();

                    fechasal = Request.QueryString["fs"].ToString();

                    noches = Request.QueryString["n"].ToString();

                    precio = Request.QueryString["p"].ToString();
                    Labelph.Text = precio;
                    Labelah.Text = precio;

                    idtipo = Request.QueryString["it"].ToString();
                    idHote = Request.QueryString["ih"].ToString();
                    cedula = (string)Session["Ced"];
                    ced.Text = cedula;
                    idh.Text = habitacion;
                    fi.Text = fechain;
                    fs.Text = fechasal;
                    idhotel.Text = idHote;
                    Labeltipo.Text = idtipo;
                    decimal pre = decimal.Parse(precio);

                    int noche = int.Parse(noches);

                    decimal tota = pre * noche;


                    labeltotal.Text = tota.ToString();
                    int c = int.Parse(cedula);

                    DropDownList1.DataSource = metodo.ObtenertarjetaCliente(c);
                    DropDownList1.DataTextField = "num_Tarjeta";
                    DropDownList1.DataValueField = "num_Tarjeta";
                    DropDownList1.DataBind();



                    ced2.Text = cedula;
                    idh2.Text = habitacion;
                    fi2.Text = fechain;
                    fs2.Text = fechasal;
                    idhotel2.Text = idHote;
                    Labeltipo2.Text = idtipo;
                    

                    


                    labeltotal2.Text = tota.ToString();
                   

                    DropDownList2.DataSource = metodo.ObtenertarjetaCliente(c);
                    DropDownList2.DataTextField = "num_Tarjeta";
                    DropDownList2.DataValueField = "num_Tarjeta";
                    DropDownList2.DataBind();




                }

            }
            catch (Exception ex) { }

            
            
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnReserva_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void usr_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(ced.Text);
            Int64 idHabitacion = Int64.Parse(idh.Text);
            Int64 idtipo = Int64.Parse(Labeltipo.Text);
            Int64 idHotel = Int64.Parse(idhotel.Text);
            string fechaIn = fi.Text;
            string fechasal = fs.Text;
            decimal total = decimal.Parse(labeltotal.Text);
            Metodos metodo = new Metodos();
            metodo.registrarReserva(cedula,idtipo,idHabitacion,idHotel,fechaIn,fechasal,total,"P");
            Response.Write("<script language=javascript>if(confirm('Su Reserva Fue procesada y Pagada con Exito')==true){ location.href='Hotel.aspx';}else { location.href='Hotel.aspx';}</script>");

        }

        protected void usr2_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(ced2.Text);
            Int64 idHabitacion = Int64.Parse(idh2.Text);
            Int64 idtipo = Int64.Parse(Labeltipo2.Text);
            Int64 idHotel = Int64.Parse(idhotel2.Text);
            string fechaIn = fi2.Text;
            string fechasal = fs2.Text;
            decimal total = decimal.Parse(labeltotal2.Text);
            Metodos metodo = new Metodos();
            metodo.registrarReserva(cedula, idtipo, idHabitacion, idHotel, fechaIn, fechasal, total, "R");
            Response.Write("<script language=javascript>if(confirm('Su Reserva fue echa y esta pendiente a pagar en el Hotel')==true){ location.href='Hotel.aspx';}else { location.href='Hotel.aspx';}</script>");


        }
    }
}