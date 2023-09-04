using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Asignatura
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAsignaturas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAsignaturas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarAsignatura(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAsignatura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarAsignatura(int idAsignatura, string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarAsignatura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarAsignatura(int idAsignatura)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAsignatura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
