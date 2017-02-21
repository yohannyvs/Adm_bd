using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace buscaHoteles
{
    public partial class elimina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Int64 idtipo, idhotel, idcarrito, idreserva;

            idtipo = Int64.Parse(Request.QueryString["idt"].ToString());
            idhotel = Int64.Parse(Request.QueryString["idh"].ToString());
            idcarrito = Int64.Parse(Request.QueryString["idc"].ToString());
            idreserva = Int64.Parse(Request.QueryString["idr"].ToString());

            Metodos metodo = new Metodos();

            metodo.cancelarReserva(idtipo, idhotel, idcarrito, idreserva);

            Response.Write("<script language=javascript>if(confirm('La reserva due cancelada ')==true){ location.href='perfil.aspx';}else { location.href='perfil.aspx';}</script>");

        }
    }
}