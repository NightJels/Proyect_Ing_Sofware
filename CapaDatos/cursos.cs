using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Cursos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCursos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCursos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarCurso(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarCurso(int idCursos, string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCursos", idCursos);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarCurso(int idCursos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCursos", idCursos);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
