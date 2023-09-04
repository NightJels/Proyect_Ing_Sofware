using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_AsignaturaProfesor
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAsignaturaProfesor()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAsignaturaProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarAsignaturaProfesor(int idAsignatura, int idProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAsignaturaProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);
            comando.Parameters.AddWithValue("@idProfesor", idProfesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarAsignaturaProfesor(int idAsignaturaProfesor, int idAsignatura, int idProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarAsignaturaProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAsignaturaProfesor", idAsignaturaProfesor);
            comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);
            comando.Parameters.AddWithValue("@idProfesor", idProfesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarAsignaturaProfesor(int idAsignaturaProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAsignaturaProfesor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAsignaturaProfesor", idAsignaturaProfesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
