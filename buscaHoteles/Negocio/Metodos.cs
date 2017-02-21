using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Collections;
namespace Negocio
{
    public class Metodos
    {
        hoteldbaDataContext Datos = new hoteldbaDataContext();

        // metodo para logear
        public Boolean login(string user, string pass)
        {

            String contra = null;

            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.LogeoUsuario(user);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                contra = Descripcion.pass;


            }
            if (pass == contra)
            {

                return true;


            }
            else
            {
                return false;
            }


        }

        //metodo de registro
        public void RegistrarCliente(int cedula, String nombre, String Apellido, String email, int tel, String pass, Int64 numcuenta, String TipoTar)
        {
            try
            {
                Datos.registrarCliente(cedula, nombre, Apellido, email, tel, pass);
            }
            catch (Exception e)
            {


            }

            try
            {
                Datos.RegistrarTargeta(numcuenta, TipoTar, cedula);

            }
            catch (Exception ex) { }



        }


        // metodo para obtener los servicios
        public List<ServiAtrac> ObtenerServicios()
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();

            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtener_servicios();

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


        //Metodo obtener datos Hotel
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
                      habitacion.img,
                      habitacion.id_Tiphabitacion,
                      habitacion.id_Hotel
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



        //Metodo obtener Cantidad de Habitaciones por Tipo
        public List<ServiAtrac> ObtenerCantidadHabitacionesTipo(Int64 idHotel, Int64? idTipo)
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerNumeroHabitacionesTipo(idHotel, idTipo);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new ServiAtrac(
                       Descripcion.cantidadHabitacionTipo.ToString()
                    )
               );
            }
            return lista;


        }


        //Metodo obtener Cantidad los Servicios por Habitacion
        public List<ServiAtrac> ObtenerServiciosHabitacion(Int64 idHabitacion)
        {
            List<ServiAtrac> lista = new List<ServiAtrac>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.ObtenerServiciosHabitacion(idHabitacion);

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

        //Metodo obtener tarjetas clientes
        public List<Tarjeta> ObtenertarjetaCliente(int cedula)
        {
            List<Tarjeta> lista = new List<Tarjeta>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.ObtenerTarjetasCliente(cedula);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new Tarjeta(
                       Descripcion.num_Tarjeta
                    )
               );
            }
            return lista;


        }


        //Metodo obtener tarjetas clientes
        public String ObtenerCedulaCliente(string email)
        {
            String cedula = null;


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerCedula(email);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                cedula = Descripcion.cedula.ToString();
            }
            return cedula;


        }


        //Metodo Registrar
        public void registrarReserva(int cedula, Int64 idtipo, Int64 idhabitacion, Int64 idhotel, string fechaIngreso, string fechaSalida, decimal total, string estado)
        {
            Datos.reservar(cedula, idhabitacion, idtipo, idhotel, fechaIngreso, fechaSalida, total, estado);



        }


        //Metodo obtener ofertas
        public List<oferta> ObtenerOfertas()
        {
            List<oferta> lista = new List<oferta>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerOfertas();

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new oferta(
                       Descripcion.id_Hotel,
                       Descripcion.Nombre,
                       Descripcion.descuento
                    )
               );
            }
            return lista;


        }


        //Metodo obtener personas
        public List<persona> ObtenerPersona(int cedula)
        {
            List<persona> lista = new List<persona>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerdatosPersona(cedula);

            /*recorrer el resultado*/
            foreach (var Descripcion in resultado)
            {
                lista.Add(
                    new persona(
                       Descripcion.cedula,
                       Descripcion.Nombre,
                       Descripcion.Apellido,
                       Descripcion.Email,
                       Descripcion.Telefono,
                       Descripcion.pass
                    )
               );
            }
            return lista;


        }


        //Metodo obtener registro
        public List<registro> ObtenerRegistro(int cedula)
        {
            List<registro> lista = new List<registro>();


            /*Tipo de dato que se crea en tiempo de ejecución*/
            var resultado = Datos.obtenerRegistro(cedula);

            /*recorrer el resultado*/
            foreach (var r in resultado)
            {
                lista.Add(
                    new registro(
                       r.id_Hotel,
                       r.id_Reserva,
                       r.id_carrito,
                       r.id_Tiphabitacion,
                       r.Nombre,
                       r.id_habitacion,
                       r.nombre_Tiphabitacion,
                       r.fecha_ingreso,
                       r.fecha_salida,
                       r.direccion,
                       r.telefono,
                       r.total,
                       r.Estado
                    )
               );
            }
            return lista;


        }

        public void cancelarReserva(Int64 idtipo, Int64 idhotel, Int64 idCarrito, Int64 idreserva)
        {

            Datos.cancelarReserva(idhotel, idreserva, idCarrito, idtipo);


        }


    }
}
