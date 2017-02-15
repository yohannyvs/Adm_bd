using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
 public class oferta
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

        private string desc;

        public string descuento
        {
            get { return desc; }
            set { desc = value; }
        }

        public oferta() { }

        public oferta(int idh , string nomH, string de) {
            Id_Hotel = idh;
            Nombre_hotel = nomH;
            descuento = de;

        }


    }
}
