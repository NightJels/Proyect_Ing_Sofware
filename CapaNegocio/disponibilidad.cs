using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Disponibilidad
    {
        private CD_Disponibilidad objetoCD = new CD_Disponibilidad();

        public DataTable MostrarDisponibilidades()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarDisponibilidades();
            return tabla;
        }

        public void InsertarDisponibilidad(string idProfesor, string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            objetoCD.InsertarDisponibilidad(Convert.ToInt32(idProfesor), dia, horaEntrada, horaSalida);
        }

        public void EditarDisponibilidad(string idDisponibilidad, string idProfesor, string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            objetoCD.ModificarDisponibilidad(Convert.ToInt32(idDisponibilidad), Convert.ToInt32(idProfesor), dia, horaEntrada, horaSalida);
        }

        public void EliminarDisponibilidad(string idDisponibilidad)
        {
            objetoCD.EliminarDisponibilidad(Convert.ToInt32(idDisponibilidad));
        }
    }
}
