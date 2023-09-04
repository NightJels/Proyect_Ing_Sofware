using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Aula
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAulas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAulas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarAula(string nombre, string edificio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@edificio", edificio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarAula(int idAula, string nombre, string edificio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarAula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAula", idAula);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@edificio", edificio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarAula(int idAula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAula", idAula);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
