using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return this.lector; }
        }

        public AccesoDatos ()
        {
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Carrera;Integrated Security=True");
            comando = new SqlCommand("",conexion);
        }
        public void settearSP(string SP)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = SP;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void settearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void cerrarConexion()
        {
            if(lector!=null)
                lector.Close();
            conexion.Close();
        }

       
    }
}
