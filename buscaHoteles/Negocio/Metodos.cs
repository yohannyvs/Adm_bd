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


        //metodo de registro
        public void RegistrarCliente(int cedula,String nombre,String Apellido,String email,int tel,String pass,Int64 numcuenta,String TipoTar) {
            try {
                Datos.registrarCliente(cedula, nombre, Apellido, email, tel, pass);
            } catch (Exception e) {
                
   
            }

            try {
                Datos.RegistrarTargeta(numcuenta,TipoTar,cedula);

            } catch (Exception ex) { }
           
            

        }

        
        // metodo para obtener los servicios
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


        //metodo obtener las atracciones
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


        //Metodo obtener tipohotel
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



        //Metodo obtener Buscar Hotel
        public List<hotel> BuscarHotel(String Busca)
        {
            List<hotel> lista = new List<hotel>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.buscarHotel(Busca);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new hotel(
                      Descripcion.id_Hotel,
                      Descripcion.Nombre,
                      Descripcion.nombre_Tipo,
                      Descripcion.reseña,
                      Descripcion.telefono,
                      Descripcion.direccion,
                      Descripcion.Localidad,
                      Int32.Parse(Descripcion.Estrella),
                      Descripcion.evaluacion,
                      Descripcion.N_habitaciones,
                      Descripcion.tipoPago,
                      Descripcion.Coordenadas,
                      Descripcion.imagen
                    )
               );
            }
            return lista;


        }


        //Metodo obtener Buscar Hotel
        public List<hotel> ObtenerDatosHotel(int Busca)
        {
            List<hotel> lista = new List<hotel>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerDatosHotel(Busca);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new hotel(
                      Descripcion.id_Hotel,
                      Descripcion.Nombre,
                      Descripcion.nombre_Tipo,
                      Descripcion.reseña,
                      Descripcion.telefono,
                      Descripcion.direccion,
                      Descripcion.Localidad,
                      Int32.Parse(Descripcion.Estrella),
                      Descripcion.evaluacion,
                      Descripcion.N_habitaciones,
                      Descripcion.tipoPago,
                      Descripcion.Coordenadas,
                      Descripcion.imagen
                    )
               );
            }
            return lista;


        }


        //Metodo obtener Buscar Hotel
        public List<habita> obtenerHabitacionHotel(int id)
        {
            List<habita> lista = new List<habita>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.ObtenerHabitacionesPorHotel(id);

            /*recorrer el resultado*/
            foreach (var habitacion in resultado)
            {
                lista.Add(
                    new habita(
                      habitacion.id_habitacion,
                      habitacion.estado,
                      habitacion.n_Personas,
                      habitacion.precio,
                      habitacion.nombre_Tiphabitacion,
                      habitacion.img
                    )
               );
            }
            return lista;


        }

        //metodo obtener las atracciones por Hotel
        public List<ServiAtrac> ObtenerAtraccionesHotel(Int64 id)
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerAtraccionesHotel(id);

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

        //metodo obtener las Servicios por Hotel
        public List<ServiAtrac> ObtenerServiciosHotel(Int64 id)
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerServiciosHotel(id);

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



    }
}
