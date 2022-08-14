using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DetalleCarreraNegocio
    {
        public List<DetalleCarrera>listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<DetalleCarrera> lista = new List<DetalleCarrera>();
            try
            {
                datos.settearSP("PA_CargarGrilla_Detalle");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    DetalleCarrera detalleCarrera = new DetalleCarrera();

                    detalleCarrera.Carrera = new Carrera();
                    if (!(datos.Lector["cod_Carrera"] is DBNull))
                        detalleCarrera.Carrera.Cod_carrera = (int)datos.Lector["cod_Carrera"];

                    if (!(datos.Lector["cuatrimestre"] is DBNull))
                        detalleCarrera.Cuatrimestre = (string)datos.Lector["cuatrimestre"];

                    if (!(datos.Lector["anioCursado"] is DBNull))
                        detalleCarrera.AnioCursado = (DateTime)datos.Lector["anioCursado"];

                    detalleCarrera.Asignatura = new Asignatura();
                    if (!(datos.Lector["Asignatura"] is DBNull))
                        detalleCarrera.Asignatura.Nombre = (string)datos.Lector["Asignatura"];

                  lista.Add(detalleCarrera);
                   

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
        public void agregar(DetalleCarrera nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearSP("PA_AgregarDetalle");
                datos.settearParametros("@anioCursado", nueva.AnioCursado);
                datos.settearParametros("@cuatrimestre", nueva.Cuatrimestre);
                datos.settearParametros("@cod_carrera", nueva.Carrera.Cod_carrera);
                datos.settearParametros("@idAsignatura", nueva.Asignatura.IdAsignatura);
                datos.ejecutarAccion();


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

        public void modificar(DetalleCarrera detalle)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearSP("PA_ModificarDetalle");
                datos.settearParametros("@anioCursado",detalle.AnioCursado);
                datos.settearParametros("@cuatrimestre",detalle.Cuatrimestre);
                datos.settearParametros("@idAsignatura",detalle.Asignatura.IdAsignatura);
                datos.settearParametros("@cod_Carrera",detalle.Carrera.Cod_carrera);
                datos.ejecutarAccion();

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
        public void eliminar(int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearSP("PA_EliminarDetalle");
                datos.settearParametros("@cod_Carrera", codigo);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
