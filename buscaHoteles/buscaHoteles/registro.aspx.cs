using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace buscaHoteles
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrar_Click(object sender, ImageClickEventArgs e)
        {
            int ced = Int32.Parse( cedula.Value);
            String nombre = Nombre.Value;
            String ape = Apellido.Value;
            String email = Email.Value;
            int tel = Int32.Parse( Telefono.Value);
            String pass = Contraseña.Value;
            Int64 numt = Int64.Parse(cu.Text);
            String tipo = SelectTipo.Value;

            Metodos metodo = new Metodos();
            metodo.RegistrarCliente(ced,nombre,ape,email,tel,pass,numt,tipo);

            Response.Write("<script language=javascript>if(confirm('Registrado con Exito')==true){ location.href='index.aspx';}else { location.href='index.aspx';}</script>");

            cedula.Value = "";
            Nombre.Value = "";
            Apellido.Value = "";
            Email.Value = "";
            Telefono.Value = "";
            Contraseña.Value = "";
            cu.Text = "";
            SelectTipo.Value = "";

        }
    }
}