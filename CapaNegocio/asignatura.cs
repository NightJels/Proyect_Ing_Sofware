using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Asignatura
    {
        private CD_Asignatura objetoCD = new CD_Asignatura();

        public DataTable MostrarAsignaturas()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarAsignaturas();
            return tabla;
        }

        public void InsertarAsignatura(string nombre)
        {
            objetoCD.InsertarAsignatura(nombre);
        }

        public void EditarAsignatura(string idAsignatura, string nombre)
        {
            objetoCD.ModificarAsignatura(Convert.ToInt32(idAsignatura), nombre);
        }

        public void EliminarAsignatura(string idAsignatura)
        {
            objetoCD.EliminarAsignatura(Convert.ToInt32(idAsignatura));
        }
    }
}
