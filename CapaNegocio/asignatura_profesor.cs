using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_AsignaturaProfesor
    {
        private CD_AsignaturaProfesor objetoCD = new CD_AsignaturaProfesor();

        public DataTable MostrarAsignaturaProfesor()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarAsignaturaProfesor();
            return tabla;
        }

        public void InsertarAsignaturaProfesor(string idAsignatura, string idProfesor)
        {
            objetoCD.InsertarAsignaturaProfesor(Convert.ToInt32(idAsignatura), Convert.ToInt32(idProfesor));
        }

        public void EditarAsignaturaProfesor(string idAsignaturaProfesor, string idAsignatura, string idProfesor)
        {
            objetoCD.ModificarAsignaturaProfesor(Convert.ToInt32(idAsignaturaProfesor), Convert.ToInt32(idAsignatura), Convert.ToInt32(idProfesor));
        }

        public void EliminarAsignaturaProfesor(string idAsignaturaProfesor)
        {
            objetoCD.EliminarAsignaturaProfesor(Convert.ToInt32(idAsignaturaProfesor));
        }
    }
}
