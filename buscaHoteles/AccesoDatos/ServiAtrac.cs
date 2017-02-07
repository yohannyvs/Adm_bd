using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ServiAtrac
    {
        private string des;

        public string Descripcion
        {
            get { return des; }
            set { des = value; }
        }

        public ServiAtrac(){
        }


        public ServiAtrac(String d)
        {
            Descripcion = d;
        }

    }
}
