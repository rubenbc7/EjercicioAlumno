using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAlumno
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cumple { get; set; }


        public Alumno()

        {
            Nombre = "Pendiente";
            Matricula = "Sin asignar";
            Direccion = "pendiente";
            Telefono = "Sin asignar";
            Cumple = "Sin asignar";
          
            

        }


    }
}
