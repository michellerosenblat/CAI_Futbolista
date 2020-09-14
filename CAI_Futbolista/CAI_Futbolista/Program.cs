using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Futbolista
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolista Martin = new Delantero("Martin", "FC Barcelona");
            Martin.JugarPartido();
            Console.WriteLine("La cantidad de goles que lleva " + Martin.Nombre + " es: " + Martin.Goles);
            Martin.JugarPartido();
            Martin.JugarPartido();
            try {
                Martin.JugarPartido();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
              
            Console.WriteLine("La cantidad de goles que lleva " + Martin.Nombre + " es: " + Martin.Goles);
            Console.ReadLine();
        }
    }
}
