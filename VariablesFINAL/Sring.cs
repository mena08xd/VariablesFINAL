using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesFINAL
{
    class Sring
    {
        static void Main(string[] args)
        {
            String Nombre;
            String Ciudad;
            Console.WriteLine("Escribe tu nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu ciudad:");
            Ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre + " Bienvenido a " + Ciudad);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
