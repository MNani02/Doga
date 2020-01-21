using System;

namespace Doga_MD
{
    public class Program
    {
        public static int[] tömb = new int[10];
        public static int n = tömb.Length;
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                _ = new Rand();
                tömb[i] = Rand.randnum;
            }
            Console.Write("Rendezetlen: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", tömb[i]);
            }
            Console.WriteLine();
            Buborék.Rendezés();
            Console.Write("Rendezve: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", tömb[i]);
            }
            Console.ReadLine();
        }
    }
}
