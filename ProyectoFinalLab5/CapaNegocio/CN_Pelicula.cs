using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Pelicula
    {
        private CD_Pelicula objetoCD = new CD_Pelicula();

        public DataTable MotrarPelicula()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarPelicula();
            return tabla;
        }
        public void InsertarPelicula(string Titulo, string Categoria, string Fecha_de_salida, string precio)
        {
            objetoCD.Insertar(Titulo,Categoria,Fecha_de_salida, Convert.ToDouble(precio));
        }
        public void editarPelicula(string Titulo, string Categoria, string Fecha_de_salida, string precio, string idPelicula)
        {
            objetoCD.ModificarPelicula(Titulo, Categoria, Fecha_de_salida, Convert.ToDouble(precio), Convert.ToInt32(idPelicula));
        }
        public void EliminarPelicula(string IdPelicula)
        {
            objetoCD.EliminarPelicula(Convert.ToInt32(IdPelicula));
        }

    }
}
