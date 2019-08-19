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

            alumno.Nombre = "Ernesto";
            alumno.Matricula = "189216";
            alumno.Direccion = "Nazas 897";
            alumno.Telefono = "1774178";
            alumno.Cumple = "17 de agosto de 1999";




            Console.WriteLine("Alumno: ");
            Console.WriteLine(" ");
            Console.WriteLine("Nombre: " + alumno.Nombre);
            Console.WriteLine("Matricula: " + alumno.Matricula);
            Console.WriteLine("Direccion: " + alumno.Direccion);
            Console.WriteLine("Telefono: " + alumno.Telefono);
            Console.WriteLine("Fecha de nacimiento: " + alumno.Cumple);

            Console.ReadLine();




        }
    }
}
