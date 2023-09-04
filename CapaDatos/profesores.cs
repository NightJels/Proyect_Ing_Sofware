using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Profesores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProfesores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProfesores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProfesor(string nombre, string apellido, string carrera, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@carrera", carrera);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarProfesor(int idProfesor, string nombre, string apellido, string carrera, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProfesor", idProfesor);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@carrera", carrera);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarProfesor(int idProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProfesor", idProfesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
