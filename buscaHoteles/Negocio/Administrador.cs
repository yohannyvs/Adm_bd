using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class Administrador
    {
        hoteldbaDataContext Datos = new hoteldbaDataContext();

        #region Inserts
        public void insert_admi(int cedula, string email, string nombre, string password)
        {
            Datos.insertar_Adm(cedula,email,nombre,password);
        }

        public void insert_pais(string nombre_pais)
        {
            Datos.insertar_Pais(nombre_pais);
        }

        public void insert_region(int id_pais, string descripcion)
        {
            Datos.insertar_Region(id_pais, descripcion);
        }

        public void insert_localidad(string id_region, string descripcion)
        {
            Datos.insertar_Localidad(id_region, descripcion);
        }

        public void insert_categoria(string descripcion)
        {
            Datos.insertar_Categorias(descripcion);
        }
        public void insert_calalogo(string descripcion, int id_categoria)
        {
            Datos.insertar_Catalago(descripcion, id_categoria);
        }

        public void insert_tip_hotel(string tip_hotel)
        {
            Datos.insertar_tipo_hotel(tip_hotel);
        }
        public void insert_hotel(string nombre, int id_tip_hotel, string reseña, int telefono, string direccion, int id_localidad, int id_cat, string evaluacion, int n_habitaciones, int tip_pago, string coordenadas)
        {
            Datos.insertar_Hotel(nombre, id_tip_hotel, reseña, telefono, direccion, id_localidad, id_cat, evaluacion, n_habitaciones, tip_pago, coordenadas);
        }

        public void insert_tip_habitacion(string descripcion)
        {
            Datos.insertar_tipo_Habitacion(descripcion);
        }

        public void insert_n_habitaciones_tipo(int id_tip_habitacion, int cant_habitacion, int id_hotel)
        {
            Datos.insertar_NumHabitacionesTipo(id_tip_habitacion, cant_habitacion, id_hotel);
        }

        public void insert_habitacion(string estado, int n_personas, decimal precio, int id_tip_hab, int id_hotel)
        {
            Datos.insertar_Habitacion(estado, n_personas, precio, id_tip_hab, id_hotel);
        }

        public void insert_serv_habitacion(int id_cat, int id_habitacion)
        {
            Datos.insertar_Servicio_Habitacion(id_cat, id_habitacion);
        }

        public void insert_serv_hotel(int id_hotel, int id_cat)
        {
            Datos.insertar_Servicios_Hotel(id_hotel, id_cat);
        }

        public void insert_reserva(int cedula, int id_habitacion, string fecha_ing, string fecha_salida, decimal total, string estado)
        {
            Datos.insertar_Reserva(cedula, id_habitacion, fecha_ing, fecha_salida, total, estado);
        }

        public void insert_ofertas(int id_habitacion, decimal descuento, string fecha_fin)
        {
            Datos.insertar_Ofertas(id_habitacion, descuento, fecha_fin);
        }
        #endregion

        #region Modificar

        public void mod_categoria(int id_categoria, string descripcion)
        {
            Datos.actualizarCategoria(id_categoria, descripcion);
        }
        public void mod_Calalogo(int id_catalogo, string descripcion, int id_categoria)
        {
            Datos.actualizarCatalogo(id_catalogo, descripcion, id_categoria);
        }

        public void mod_hotel(int id_hotel, string nombre, int id_tip_hotel, string reseña, int telefono, string direccion, int id_localidad, int id_cat, string evaluacion, int n_habitaciones, int tip_pago, string coordenadas)
        {
            Datos.actualizarHotel(id_hotel, nombre, id_tip_hotel, reseña, telefono, direccion, id_localidad, id_cat, evaluacion, n_habitaciones, tip_pago, coordenadas);
        }

        public void mod_tip_habitacion(int id_tip_hab, string descripcion)
        {
            Datos.actualizarTipoHabitacion(id_tip_hab, descripcion);
        }

        public void mod_habitacion(int id_hab, string estado, int n_personas, decimal precio, int id_tip_hab, int id_hotel)
        {
            Datos.actualizarHabitacion(id_hab, estado, n_personas, precio, id_tip_hab, id_hotel);
        }

        public void mod_serv_habitacion(int id_serv_hab, int id_catalogo, int id_habitacion)
        {
            Datos.actualizarServicioHabitacion(id_serv_hab, id_catalogo, id_habitacion);
        }

        public void mod_serv_hotel(int id_serv_hotel, int id_hotel, int id_catalogo)
        {
            Datos.actualizarServiciosHotel(id_serv_hotel, id_hotel, id_catalogo);
        }

        public void mod_reserva(int id_reserva, int cedula, int id_habitacion, string fecha_ing, string fecha_salida, decimal total, string estado)
        {
            Datos.actualizarReserva(id_reserva, cedula, id_habitacion, fecha_ing, fecha_salida, total, estado);
        }

        public void mod_ofertas(int id_oferta, int id_habitacion, decimal descuento, string fecha_fin)
        {
            Datos.actualizarOfertas(id_oferta, id_habitacion, descuento, fecha_fin);
        }

        #endregion

        #region Eliminar

        public void delet_admi(int cedula)
        {
            Datos.eliminar_Administrador(cedula);
        }

        public void delet_categoria(int id_cat)
        {
            Datos.eliminar_Categorias(id_cat);
        }
        public void delet_catalogo(int id_catalogo)
        {
            Datos.eliminar_Catalogo(id_catalogo);
        }

        public void delet_tip_hotel(int id_tip_hotel)
        {
            Datos.eliminar_Tipo_Hotel(id_tip_hotel);
        }
        public void delet_hotel(int id_Hotel)
        {
            Datos.eliminar_Hotel(id_Hotel);
        }

        public void delet_tip_habitacion(int id_tip_hab)
        {
            Datos.eliminar_Tipo_Habitacion(id_tip_hab);
        }

        public void delet_serv_habitacion(int id_serv_hab)
        {
            Datos.eliminar_seviciosHabitaion(id_serv_hab);
        }

        public void delet_serv_hotel(int id_serv_hotel)
        {
            Datos.eliminar_seviciosHotel(id_serv_hotel);
        }

        public void delet_reserva(int id_reserva)
        {
            Datos.eliminar_Resrva(id_reserva);
        }

        public void delet_ofertas(int id_oferta)
        {
            Datos.eliminar_Ofertas(id_oferta);
        }

        #endregion
    }
}
