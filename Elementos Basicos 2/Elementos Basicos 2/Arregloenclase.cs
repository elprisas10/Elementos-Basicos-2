using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_2
{
    class Arregloenclase
    {
        

        static void Main()
        {
            int[] notas = new int[10];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("escriba la nota {0}:", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("nota{0}: {1}", i, notas[i]);
            }

            Console.ReadKey();
        }
    }
}
    
