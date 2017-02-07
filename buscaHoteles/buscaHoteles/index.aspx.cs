using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace buscaHoteles
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            String hotel, fechain, fechasal, adul, nin;
            hotel = htl.Value;
            fechain = datepicker.Value;
            fechasal = datepicker2.Value;
            adul = SelectAdul.Value;
            nin = SelectNi.Value;


            Response.Redirect("busqueda.aspx?ht="+hotel+"&fi="+fechain+"&fs="+fechasal+"&ad="+adul+"&ni="+nin);
        }
    }
}