using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v;
            Console.WriteLine("Inserisci le componenti del vettore: ");
            v = Vector.Parse(Console.ReadLine());
            Vector v1 = new Vector(8, 7);
            if (v1 == v)
            {
                Console.WriteLine("I vettori sono uguali");
            }
            else
            {
                Console.WriteLine("I vettori non sono uguali");
            }
            Console.ReadLine();
        }
    }
}
