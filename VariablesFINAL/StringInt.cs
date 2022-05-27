using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesFINAL
{
    class StringInt
    {
        static void Main(string[] args)
        {
            String Nombre;
            int Edad;
            Console.WriteLine("Escribe tu nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            Edad = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Te llamas " + Nombre + " y tienes " + Edad + " años");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
