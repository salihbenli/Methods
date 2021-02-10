using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] sayi1 = new int[] {1,2,3 };
            int[] sayi2 = new int[] { 10, 20, 30 };
            sayi1 = sayi2;
            Console.WriteLine("sadsada"+sayi1[0]);
            sayi2[0] = 65;
            Console.WriteLine(sayi1[0]);
        }
    }
}
