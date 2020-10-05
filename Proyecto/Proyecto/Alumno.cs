using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Alumno
    {
        private string nombre;
        private string apellido;
        private string grado;
        //métodos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Grado
        {
            get { return grado; }
            set { grado = value; }
        }
    }
}
