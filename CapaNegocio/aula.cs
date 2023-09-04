using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Aula
    {
        private CD_Aula objetoCD = new CD_Aula();

        public DataTable MostrarAulas()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarAulas();
            return tabla;
        }

        public void InsertarAula(string nombre, string edificio)
        {
            objetoCD.InsertarAula(nombre, edificio);
        }

        public void EditarAula(string idAula, string nombre, string edificio)
        {
            objetoCD.ModificarAula(Convert.ToInt32(idAula), nombre, edificio);
        }

        public void EliminarAula(string idAula)
        {
            objetoCD.EliminarAula(Convert.ToInt32(idAula));
        }
    }
}
