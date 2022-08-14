using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleCarrera
    {

        private Carrera carrera;
        private Asignatura asignatura;
        private DateTime anioCursado;
        private string cuatrimestre;

        public Carrera Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public Asignatura Asignatura

        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public DateTime AnioCursado
        {
            get { return anioCursado; }
            set { anioCursado = value; }
        }
        public string Cuatrimestre
        {
            get { return cuatrimestre;}
            set
            {
                cuatrimestre = value;
            }   
        }

        public override string ToString()
        {
            return Carrera.ToString();
        }

    }
}
