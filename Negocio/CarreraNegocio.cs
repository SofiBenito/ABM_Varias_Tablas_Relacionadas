using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class CarreraNegocio
    {
        public List<Carrera>listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Carrera> lista = new List<Carrera>();
            try
            {
                datos.settearSP("PA_grillaCarrera");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Carrera carrera = new Carrera();
                    if (!(datos.Lector["cod_Carrera"] is DBNull))
                        carrera.Cod_carrera = (int)datos.Lector["cod_Carrera"];
                    if (!(datos.Lector["nombre"] is DBNull))
                        carrera.Nombre = (string)datos.Lector["nombre"];
                    if (!(datos.Lector["titulo"] is DBNull))
                        carrera.Titulo = (string)datos.Lector["titulo"];
                    lista.Add(carrera);
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

        public void agregar(Carrera nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearSP("PA_AgregarCarrera");
                datos.settearParametros("@cod_Carrera",nueva.Cod_carrera);
                datos.settearParametros("@nombre",nueva.Nombre);
                datos.settearParametros("@titulo", nueva.Titulo);
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

        public void modificar(Carrera carrera)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearSP("PA_ModificarCarrera");
                datos.settearParametros("@nombre",carrera.Nombre);
                datos.settearParametros("@titulo",carrera.Titulo);
                datos.settearParametros("@cod_Carrera",carrera.Cod_carrera);
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

        public void eliminar (int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearSP("PA_EliminarCarrera");
                datos.settearParametros("@cod_Carrera",codigo);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
