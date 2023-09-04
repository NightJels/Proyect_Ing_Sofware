using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_VentasTaquillas
    {
        private CD_VentasTaquillas objetoCD = new CD_VentasTaquillas();

        public DataTable MostVentasTaquillas()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            tabla = objetoCD.MostrarVentasTaquillas();
            return tabla;
        }
        public void InsertarBoleto(string NumeroBoleto, string Precio, string HoraFuncion, string UbicacionPuesto, string Pelicula)
        {
            objetoCD.Insertar(Convert.ToInt32(NumeroBoleto), Convert.ToDouble(Precio), HoraFuncion, UbicacionPuesto, Pelicula);
        }
        public void ModificarBoleto(string NumeroBoleto, string Precio, string HoraFuncion, string UbicacionPuesto, string Pelicula, string IdBoleto)
        {
            objetoCD.ModificarBoleto(Convert.ToInt32(NumeroBoleto), Convert.ToDouble(Precio), HoraFuncion, UbicacionPuesto, Pelicula, Convert.ToInt32(IdBoleto));
        }
        public void EliminarBoleto(string IdBoleto)
        {
            objetoCD.EliminarBoleto(Convert.ToInt32(IdBoleto));
        }
    }
}
