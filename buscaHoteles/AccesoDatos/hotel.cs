using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class hotel
    {
        private int idH;

        public int Id_Hotel
        {
            get { return idH; }
            set { idH = value; }
        }

        private string nom;

        public string Nombre_hotel
        {
            get { return nom; }
            set { nom = value; }
        }

        private string tip;

        public string Tipo
        {
            get { return tip; }
            set { tip = value; }
        }


        private string rese;
        public string Resena
        {
            get { return rese; }
            set { rese = value; }
        }

        private int? tel;

        public int? Telefono
        {
            get { return tel; }
            set { tel = value; }
        }


        private string dire;
        public string Direccion
        {
            get { return dire; }
            set { dire = value; }
        }


        private string loca;
        public string Localidad
        {
            get { return loca; }
            set { loca = value; }
        }


        private string estre;
        public string Estrellas
        {
            get { return estre; }
            set { estre = value; }
        }

        private string evalu;
        public string Evaluacion
        {
            get { return evalu; }
            set { evalu = value; }
        }



        private Int64? numh;

        public Int64? numHabitacion
        {
            get { return numh; }
            set { numh = value; }
        }



        private string tipop;
        public string TipoPago
        {
            get { return tipop; }
            set { tipop = value; }
        }


        private string coor;
        public string Coordenadas
        {
            get { return coor; }
            set { coor = value; }
        }


        public hotel() { }



        public hotel(int id,string nomb,string th,string rs,int? tl,string dir,string loc,string es,string ev, Int64? nh,string tp,string co) {
            Id_Hotel = id;
            Nombre_hotel = nomb;
            Tipo = th;
            Resena = rs;
            Telefono = tl;
            Direccion = dir;
            Localidad = loc;
            Estrellas = es;
            Evaluacion = ev;
            numHabitacion = nh;
            TipoPago = tp;
            Coordenadas = co;


        }

    }
}
