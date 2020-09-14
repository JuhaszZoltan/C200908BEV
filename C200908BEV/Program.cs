using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C200908BEV
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            //tömb / vektor / Array

            int[] t1 = new int[10];
            string[] t2 = { "alma", "kutya", "szék" };
            var t3 = new char[] { 'a', '%', '#' };

            for (int i = 0; i < t1.Length; i++)
            {
                t1[i] = rnd.Next();
            }

            foreach (int elem in t1)
            {
                //elem = 10; <= EZT NEM ENGEDI! - foreach-ben NEM módosíthatunk!!!
                Console.WriteLine(elem);
            }


            //lista, dinamikus tömb
            List<int> l1 = new List<int>();
            var l2 = new List<string>() { "alma", "kutya", "szék" };

            l2.Add("atomreaktor"); //új elemet hozzáadni
            l2.Remove("alma"); //adott elemet törölni
            l2.Add("hörcsög");

            l2.RemoveAt(3); //adott indexről elemet törölni

            foreach (var elem in l2)
            {
                Console.WriteLine(elem);
            }

            for (int i = 0; i < l2.Count; i++)
            {
                l2[i] = $"{i+1}. Padlizsán"; //adott indexen lévő elemet módosítani
            }

            foreach (var elem in l2)
            {
                Console.WriteLine(elem);
            }
            

            //elöltesztelős ciklus:
            int x = 2;
            while (x < 100000000)
            {
                Console.WriteLine(x);
                x *= 2;
            }

            //lehet, hogy nem fut le egyszer sem:
            x = 0;
            while (x < 0 && x > 0)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine("-------");


            //hátultesztelős ciklus:
            Console.WriteLine("myomd meg az ENTERT!");
            ConsoleKeyInfo billentyu;
            do
            {
                //egyszer MINDENKÉPP lefut:
                Console.Write("üsd: ");
                billentyu = Console.ReadKey();
                Console.Write("\n");
            } while (billentyu.Key != ConsoleKey.Enter);
            Console.WriteLine("na, csak megtaláltad!");


            //Random osztály

            int r1 = rnd.Next(); //tök véletlen egész szám
            int r2 = rnd.Next(20); //0 - 19 között fogok véletlen számot kapni
            int r3 = rnd.Next(-10, 20); //-10 - 19 között fogok véletlen számot kapni
            double r4 = rnd.NextDouble(); // 0 és 1 közötti véletlen szám

            r4 = rnd.NextDouble() * 10; // 0 és 10 közötti véletlen double szám
            Console.WriteLine(r4);

            //3-mal oszható, véletlen:
            int r5 = rnd.Next() * 3;

            //Math osztály
            //DateTime struktúra
            //TimeSpan struktúra

            //ConsoleColor
            //SetCursorePosition


            Console.ReadKey();

        }
    }
}
