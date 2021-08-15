using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_2
{
    class arreglos
    {
        static void Main()

        {

            // Se Declara y se llena lo que es el array
            string[] nombres = { "Jonathan", "Adonis", "Yennis", "Leticia", "Cristina" };

            //Se calcula lo que es el array
            int length = nombres.Length;

            //Se utiliza el metodo sort para ordernar los nombres
            Array.Sort(nombres);

            Array.Reverse(nombres);
            Console.WriteLine("Array ordenado con el metodo Sort()");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Console.ReadKey();
        }
    }
}
    

