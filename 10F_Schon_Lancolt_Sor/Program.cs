using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _10F_Schon_Lancolt_Sor
{
    class Program
    {

        static void Main(string[] args)
        {
            /** /
            Queue<int> sor = new Queue<int>();
            sor.Enqueue(5); // ez a push
            int a = sor.Dequeue(); // ez a pop
            sor.Peek();
            /**/

            Sor<int> sor = new Sor<int>();
            sor.Enqueue(3);
            Console.WriteLine(sor);
            sor.Enqueue(5);
            Console.WriteLine(sor);
            sor.Enqueue(2);
            Console.WriteLine(sor);
            sor.Enqueue(1);
            Console.WriteLine(sor);
            sor.Enqueue(10);

            Console.WriteLine(sor);
            Console.WriteLine(sor.Dequeue());
            Console.WriteLine(sor);
            Console.WriteLine(sor.Dequeue());
            Console.WriteLine(sor);
            Console.WriteLine(sor.Dequeue());
            Console.WriteLine(sor);

            Console.ReadKey();
        }
    }
}
