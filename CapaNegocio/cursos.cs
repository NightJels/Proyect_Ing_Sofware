using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cursos
    {
        private CD_Cursos objetoCD = new CD_Cursos();

        public DataTable MostrarCursos()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarCursos();
            return tabla;
        }

        public void InsertarCurso(string nombre)
        {
            objetoCD.InsertarCurso(nombre);
        }

        public void EditarCurso(string idCursos, string nombre)
        {
            objetoCD.ModificarCurso(Convert.ToInt32(idCursos), nombre);
        }

        public void EliminarCurso(string idCursos)
        {
            objetoCD.EliminarCurso(Convert.ToInt32(idCursos));
        }
    }
}
