using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaDatos
{
    public class CD_VentasTaquillas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarVentasTaquillas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarBoletos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(int NumeroBoleto, double Precio, string HoraFuncion, string UbicacionPuesto,string Pelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NumeroBoleto", NumeroBoleto);
            comando.Parameters.AddWithValue("@PrecioBoleto", Precio);
            comando.Parameters.AddWithValue("@HoraFuncion", HoraFuncion);
            comando.Parameters.AddWithValue("@UbicacionPuestos", UbicacionPuesto);
            comando.Parameters.AddWithValue("@Pelicula", Pelicula);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void ModificarBoleto(int NumeroBoleto, double Precio, string HoraFuncion, string UbicacionPuesto, string Pelicula, int IdBoleto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarBoleto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NumeroBoleto", NumeroBoleto);
            comando.Parameters.AddWithValue("@PrecioBoleto", Precio);
            comando.Parameters.AddWithValue("@HoraFuncion", HoraFuncion);
            comando.Parameters.AddWithValue("@UbicacionPuestos", UbicacionPuesto);
            comando.Parameters.AddWithValue("@Pelicula", Pelicula);
            comando.Parameters.AddWithValue("@Id", IdBoleto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarBoleto(int IdBoleto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarBoleto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", IdBoleto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
