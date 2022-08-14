using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AsignaturaNegocio
    {
        public List<Asignatura>listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Asignatura> lista = new List<Asignatura>();
            try
            {
                datos.settearSP("PA_CargarCombo");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Asignatura asignatura = new Asignatura();
                    if (!(datos.Lector["idAsignatura"] is DBNull))
                        asignatura.IdAsignatura = (int)datos.Lector["idAsignatura"];
                    if (!(datos.Lector["nombre"] is DBNull))
                        asignatura.Nombre = (string)datos.Lector["nombre"];
                    lista.Add(asignatura);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
