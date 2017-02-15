using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class persona
    {
        private int? ced;

        public int? num_Cedula
        {
            get { return ced; }
            set { ced = value; }
        }

        private string nom;

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        private string ap;

        public string Apelldio
        {
            get { return ap; }
            set { ap = value; }
        }

        private string correo;

        public string Email
        {
            get { return correo; }
            set { correo = value; }
        }

        private int? tel;

        public int? Telefono
        {
            get { return tel; }
            set { tel = value; }
        }



        private string pas;

        public string Contra
        {
            get { return pas; }
            set { pas = value; }
        }


        public persona() { }

        public persona(int? c,string n,string a,string e,int?tel,string p) {

            num_Cedula = c;
            Nombre = n;
            Apelldio = a;
            Email = e;
            Telefono = tel;
            Contra = p;

        }
    }
}
