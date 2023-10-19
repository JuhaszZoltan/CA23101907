using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA23101907
{
    internal class Program
    {
        static void Main()
        {
            var pontszerzok = new List<Pontszerzo>();
            using (var sr = new StreamReader(@"..\..\src\helsinki.txt"))
            {
                while (!sr.EndOfStream) pontszerzok.Add(new Pontszerzo(sr.ReadLine()));
            }
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"Pontszerző helyezések száma: {pontszerzok.Count}");

            Console.WriteLine($"4. feladat:");
            int f4a = pontszerzok.Count(p => p.Helyezes == 1);
            int f4e = pontszerzok.Count(p => p.Helyezes == 2);
            int f4b = pontszerzok.Count(p => p.Helyezes == 3);
            Console.WriteLine($"Arany: {f4a}");
            Console.WriteLine($"Ezüst: {f4e}");
            Console.WriteLine($"Bronz: {f4b}");
            Console.WriteLine($"Összesen: {f4a + f4e + f4b}");

            Console.WriteLine("5. feladat:");
            Console.WriteLine($"Olimpiai pontok száma: {pontszerzok.Sum(p => p.Pont)}");

            Console.WriteLine("6. feladat:");
            int f6u = pontszerzok.Count(p => p.Sportag == "uszas" && p.Helyezes <= 3);
            int f6t = pontszerzok.Count(p => p.Sportag == "torna" && p.Helyezes <= 3);
            if (f6u > f6t) Console.WriteLine("Úszás sportágban szereztek több érmet");
            else if (f6u < f6t) Console.WriteLine("Torna sportágban szereztek több érmet");
            else Console.WriteLine("Egyenlő volt az érmek száma");

            using (var sw = new StreamWriter(@"..\..\src\helsinki2.txt"))
            {
                foreach (var p in pontszerzok)
                {
                    string f7sa = p.Sportag == "kajakkenu" ? "kajak-kenu" : p.Sportag;
                    sw.WriteLine($"{p.Helyezes} {p.Sportolok} {p.Pont} {f7sa} {p.Versenyszam}");
                }
            }

            Console.WriteLine("8. feladat:");
            var f8 = pontszerzok.OrderBy(p => p.Sportolok).Last();
            Console.WriteLine($"Helyezés: {f8.Helyezes}");
            Console.WriteLine($"Sportág: {f8.Sportag}");
            Console.WriteLine($"Versenyszám: {f8.Versenyszam}");
            Console.WriteLine($"Sportolók száma: {f8.Sportolok}");


            Console.ReadKey(true);
        }
    }
}
