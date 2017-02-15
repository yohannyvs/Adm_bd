using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Tarjeta
    {
        public Tarjeta() { }
        private Int64? num;

        public Int64? num_Tarjeta
        {
            get { return num; }
            set { num = value; }
        }


        public Tarjeta(Int64? numt) {

            num_Tarjeta = numt;

        }
    }
}
