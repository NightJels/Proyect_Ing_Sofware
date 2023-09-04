using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_HorariClase
    {
        private CD_HorariClase objetoCD = new CD_HorariClase();

        public DataTable MostrarHorariClase()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarHorariClase();
            return tabla;
        }

        public void InsertarHorariClase(string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            objetoCD.InsertarHorariClase(dia, horaEntrada, horaSalida);
        }

        public void EditarHorariClase(string idHorariClase, string dia, DateTime horaEntrada, DateTime horaSalida)
        {
            objetoCD.ModificarHorariClase(Convert.ToInt32(idHorariClase), dia, horaEntrada, horaSalida);
        }

        public void EliminarHorariClase(string idHorariClase)
        {
            objetoCD.EliminarHorariClase(Convert.ToInt32(idHorariClase));
        }
    }
}
