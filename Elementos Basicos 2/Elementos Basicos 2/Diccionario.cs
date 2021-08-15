using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_2
{
    class Diccionario
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mydictionary = new Dictionary<string, string>();

            mydictionary.Add("18", "Jonathan");
            mydictionary.Add("24", "Adonis");
            mydictionary.Add("35", "Cristina");
            mydictionary.Add("13", "Leticia");


            Console.WriteLine(mydictionary["13"]);

            Console.ReadKey();
        }
    
    }
}

