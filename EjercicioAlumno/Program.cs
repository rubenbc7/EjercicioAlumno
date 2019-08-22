using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
           
            Console.WriteLine("Alumno: ");
            Console.WriteLine("Nombre: " + alumno.Nombre);
            Console.WriteLine("Matricula: " + alumno.Matricula);

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "juan";
            alumno2.Matricula = "131312";

            Console.WriteLine(" "); 
            Console.WriteLine("Alumno2: ");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            Alumno alumno3 = new Alumno("Ana","131314");

            Console.WriteLine(" ");
            Console.WriteLine("Alumno3: ");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);

            Console.Read();
        }
    }
}
