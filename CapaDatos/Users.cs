using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Users
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarUsers()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsers";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarUser(string nombre, string contrasena, string rol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarUser";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarUser(int idUsers, string nombre, string contrasena, string rol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarUser";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsers", idUsers);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarUser(int idUsers)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUser";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsers", idUsers);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
