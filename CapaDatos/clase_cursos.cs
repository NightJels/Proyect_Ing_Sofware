using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_ClaseCurso
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarClaseCurso()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClaseCurso";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarClaseCurso(int idCursos, int idHorariClase, int idAula, int idAsignaturaProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarClaseCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCursos", idCursos);
            comando.Parameters.AddWithValue("@idHorariClase", idHorariClase);
            comando.Parameters.AddWithValue("@idAula", idAula);
            comando.Parameters.AddWithValue("@idAsignaturaProfesor", idAsignaturaProfesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModificarClaseCurso(int idClaseCurso, int idCursos, int idHorariClase, int idAula, int idAsignaturaProfesor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarClaseCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idClaseCurso", idClaseCurso);
            comando.Parameters.AddWithValue("@idCursos", idCursos);
            comando.Parameters.AddWithValue("@idHorariClase", idHorariClase);
            comando.Parameters.AddWithValue("@idAula", idAula);
            comando.Parameters.AddWithValue("@idAsignaturaProfesor", idAsignaturaProfesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarClaseCurso(int idClaseCurso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarClaseCurso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idClaseCurso", idClaseCurso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
