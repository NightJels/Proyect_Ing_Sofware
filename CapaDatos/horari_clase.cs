using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_HorariClase
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarHorariClase()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarHorariClase";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarHorariClase(string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarHorariClase";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dia", dia);
            comando.Parameters.AddWithValue("@horaEntrada", horaEntrada);
            comando.Parameters.AddWithValue("@horaSalida", horaSalida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarHorariClase(int idHorariClase, string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarHorariClase";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idHorariClase", idHorariClase);
            comando.Parameters.AddWithValue("@dia", dia);
            comando.Parameters.AddWithValue("@horaEntrada", horaEntrada);
            comando.Parameters.AddWithValue("@horaSalida", horaSalida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarHorariClase(int idHorariClase)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarHorariClase";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idHorariClase", idHorariClase);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
