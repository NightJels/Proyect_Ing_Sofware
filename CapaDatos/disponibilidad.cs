using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Disponibilidad
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarDisponibilidades()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDisponibilidades";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarDisponibilidad(int idProfesor, string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDisponibilidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProfesor", idProfesor);
            comando.Parameters.AddWithValue("@dia", dia);
            comando.Parameters.AddWithValue("@horaEntrada", horaEntrada);
            comando.Parameters.AddWithValue("@horaSalida", horaSalida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarDisponibilidad(int idDisponibilidad, int idProfesor, string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarDisponibilidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idDisponibilidad", idDisponibilidad);
            comando.Parameters.AddWithValue("@idProfesor", idProfesor);
            comando.Parameters.AddWithValue("@dia", dia);
            comando.Parameters.AddWithValue("@horaEntrada", horaEntrada);
            comando.Parameters.AddWithValue("@horaSalida", horaSalida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarDisponibilidad(int idDisponibilidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDisponibilidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idDisponibilidad", idDisponibilidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
