using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Pelicula
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarPelicula()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();  
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string Titulo, string Categoria, string Fecha_de_Salida, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Titulo",Titulo);
            comando.Parameters.AddWithValue("@Categoria",Categoria);
            comando.Parameters.AddWithValue("@Fecha_de_Salida",Fecha_de_Salida);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void ModificarPelicula(string Titulo, string Categoria, string Fecha_de_Salida, double precio, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@titulo", Titulo);
            comando.Parameters.AddWithValue("@Categoria", Categoria);
            comando.Parameters.AddWithValue("@Fecha_de_Salida", Fecha_de_Salida);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarPelicula(int IdEmpleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", IdEmpleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
