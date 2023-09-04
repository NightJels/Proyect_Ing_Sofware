using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_ClaseCurso
    {
        private CD_ClaseCurso objetoCD = new CD_ClaseCurso();

        public DataTable MostrarClaseCurso()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarClaseCurso();
            return tabla;
        }

        public void InsertarClaseCurso(string idCursos, string idHorariClase, string idAula, string idAsignaturaProfesor)
        {
            objetoCD.InsertarClaseCurso(Convert.ToInt32(idCursos), Convert.ToInt32(idHorariClase), Convert.ToInt32(idAula), Convert.ToInt32(idAsignaturaProfesor));
        }

        public void EditarClaseCurso(string idClaseCurso, string idCursos, string idHorariClase, string idAula, string idAsignaturaProfesor)
        {
            objetoCD.ModificarClaseCurso(Convert.ToInt32(idClaseCurso), Convert.ToInt32(idCursos), Convert.ToInt32(idHorariClase), Convert.ToInt32(idAula), Convert.ToInt32(idAsignaturaProfesor));
        }

        public void EliminarClaseCurso(string idClaseCurso)
        {
            objetoCD.EliminarClaseCurso(Convert.ToInt32(idClaseCurso));
        }
    }
}
