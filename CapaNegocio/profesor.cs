using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Profesores
    {
        private CD_Profesores objetoCD = new CD_Profesores();

        public DataTable MostrarProfesores()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarProfesores();
            return tabla;
        }

        public void InsertarProfesor(string nombre, string apellido, string carrera, string correo)
        {
            objetoCD.InsertarProfesor(nombre, apellido, carrera, correo);
        }

        public void EditarProfesor(string idProfesor, string nombre, string apellido, string carrera, string correo)
        {
            objetoCD.ModificarProfesor(Convert.ToInt32(idProfesor), nombre, apellido, carrera, correo);
        }

        public void EliminarProfesor(string idProfesor)
        {
            objetoCD.EliminarProfesor(Convert.ToInt32(idProfesor));
        }
    }
}
