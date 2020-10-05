using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Estudiante
    {
        string nombres;
        public string Nombre
        {
            get { return nombres; }
            set { nombres = value; }
        }
        string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        int grado;
        public int GradoE
        {
            get { return grado; }
            set { grado = value; }
        }

        string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       
    }
}
