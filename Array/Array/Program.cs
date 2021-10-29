using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, n;
            int[] a;
            Console.WriteLine("Ingrese el tamaño del Array: ");
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero para sacar los multiplos: ");
            n = int.Parse(Console.ReadLine());
            a = new int[t];
            for (int f = 0; f < t; f++)
            {
                a[f] = (f + 1) * n;
                Console.WriteLine("Los multiplos son: " + a[f]);
            }
            Console.ReadKey();
        }
    }
}
