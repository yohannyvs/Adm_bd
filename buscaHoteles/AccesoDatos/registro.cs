using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
   public class registro
    {



        private int? idhotel;

        public int? id_Hotel
        {
            get { return idhotel; }
            set { idhotel = value; }
        }

        private Int64? idRes;

        public Int64? id_Reserva
        {
            get { return idRes; }
            set { idRes = value; }
        }


        private Int64? idC;

        public Int64? id_Carrito
        {
            get { return idC; }
            set { idC = value; }
        }

        private Int64? idt;
        public Int64? id_tipo
        {
            get { return idt; }
            set { idt = value; }
        }

        private string ho;

        public string nom_Hotel
        {
            get { return ho; }
            set { ho = value; }
        }

        private int? idh;

        public int? id_habitacion
        {
            get { return idh; }
            set { idh = value; }
        }


        private string tipoH;

        public string tipo_Habitacion
        {
            get { return tipoH; }
            set { tipoH = value; }
        }

        private string fi;

        public string Fecha_Ingreso
        {
            get { return fi; }
            set { fi = value; }
        }

        private string fs;

        public string fecha_salida
        {
            get { return fs; }
            set { fs = value; }
        }



        private string dr;

        public string Direccion
        {
            get { return dr; }
            set { dr = value; }
        }

        private int? tel;

        public int? telefono
        {
            get { return tel; }
            set { tel = value; }
        }

        private decimal? tot;

        public decimal? total
        {
            get { return tot; }
            set { tot = value; }
        }


        private string es;

        public string estado
        {
            get { return es; }
            set { es = value; }
        }


        public registro() { }

        public registro(int? idh, Int64? idr, Int64? idc, Int64? idt, string n, int? ih, string t, string i, string s, string d, int? te, decimal? to, string e)
        {
            id_Hotel = idh;
            id_Reserva = idr;
            id_tipo = idt;
            id_Carrito = idc;
            nom_Hotel = n;
            id_habitacion = ih;
            tipo_Habitacion = t;
            Fecha_Ingreso = i;
            fecha_salida = s;
            Direccion = d;
            telefono = te;
            total = to;
            estado = e;

        }






    }
}
