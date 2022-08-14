using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrera
    {
        private int cod_carrera;
        private string nombre;
        private string titulo;

        public int Cod_carrera
        {
            get { return cod_carrera; }
            set { cod_carrera = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }


        public override string ToString()
        {
            return cod_carrera.ToString();
        }
    }
}
