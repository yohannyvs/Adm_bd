﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class habita
    {

        private int idhabi;
        public int IdHabitacion
        {
            get { return idhabi; }
            set { idhabi = value; }
        }

        private string es;
        public string Estado
        {
            get { return es; }
            set { es = value; }
        }

        private int? n_P;
        public int? nPersonas
        {
            get { return n_P; }
            set { n_P = value; }
        }


        private decimal? pre;
        public decimal? Precio
        {
            get { return pre; }
            set { pre = value; }
        }


        private string tip;
        public string Tipo
        {
            get { return tip; }
            set { tip = value; }
        }

        private string img;
        public string Imagen
        {
            get { return img; }
            set { img = value; }
        }

        private Int64? idtipoh;
        public Int64? id_TipoHabitacion
        {
            get { return idtipoh; }
            set { idtipoh = value; }
        }


        private int? idh;
        public int? IdHotel
        {
            get { return n_P; }
            set { n_P = value; }
        }
    
        public habita() { }

        public habita(int id,string esta,int? np,decimal? pre,string t, string image,Int64? idth,int? ih) {

            IdHabitacion = id;
            Estado = esta;
            nPersonas = np;
            Precio = pre;
            Tipo = t;
            Imagen = image;
            id_TipoHabitacion = idth;
            IdHotel=ih;
        }

    }
}
