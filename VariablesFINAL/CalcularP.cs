using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesFINAL
{
    class CalcularP
    {
        static void Main(string[] args)
        {
            int LadoA = 10;
            int LadoB = 10;
            int LadoC = 7;

            int P = LadoA + LadoB + LadoC;

            Console.WriteLine("El valor de la suma es:" + P);
            Console.WriteLine("Presiona cualquier tecla para continuar al finalizar:");
            Console.ReadKey();
        }
    }
}
