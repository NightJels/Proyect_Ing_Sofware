using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Users
    {
        private CD_Users objetoCD = new CD_Users();

        public DataTable MostrarUsers()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarUsers();
            return tabla;
        }

        public void InsertarUser(string nombre, string contrasena, string rol)
        {
            objetoCD.InsertarUser(nombre, contrasena, rol);
        }

        public void EditarUser(string idUsers, string nombre, string contrasena, string rol)
        {
            objetoCD.ModificarUser(Convert.ToInt32(idUsers), nombre, contrasena, rol);
        }

        public void EliminarUser(string idUsers)
        {
            objetoCD.EliminarUser(Convert.ToInt32(idUsers));
        }
    }
}
