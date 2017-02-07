using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Negocio
{
   public class Metodos
    {
        hoteldbaDataContext Datos = new hoteldbaDataContext();

        public void RegistrarCliente(int cedula,String nombre,String Apellido,String email,int tel,String pass,int numcuenta,String TipoTar) {
            try {
                Datos.registrarCliente(cedula, nombre, Apellido, email, tel, pass);
            } catch (Exception e) {
                

            }

            try {
                Datos.RegistrarTargeta(numcuenta,TipoTar,cedula);

            } catch (Exception ex) { }
           
            

        }


        public List<ServiAtrac> ObtenerServicios() {
            List<ServiAtrac> lista = new List<ServiAtrac>();

          
            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado =  Datos.obtener_servicios();

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new ServiAtrac(
                       Descripcion.descripcion
                    )
               );
            }
            return lista;


        }


        public List<ServiAtrac> ObtenerAtracciones()
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtener_Atraccion();

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new ServiAtrac(
                       Descripcion.descripcion
                    )
               );
            }
            return lista;


        }


        public List<ServiAtrac> ObtenerTiposHotel()
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.ObtenerTiposHotel();

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new ServiAtrac(
                       Descripcion.nombre_Tipo
                    )
               );
            }
            return lista;


        }


    }
}
