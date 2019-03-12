using System;
using System.IO;

namespace DatotecniSustav01
{
    class Program
    {
        static void Main(string[] args)
        {
            string direktorij = @"C:\";
            DirectoryInfo dirInfo = new DirectoryInfo(direktorij);

            var datoteke = dirInfo.GetFiles();
            long velicina = 0;

            Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");
            Console.WriteLine("| Veličina       B |          KB |      MB | Nazivi datoteka                          |");
            Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");
            foreach (FileInfo d in datoteke)
            {
                velicina += d.Length;
                Console.WriteLine("|{0, 15} B | {1, 8} KB | {2, 4} MB | {3,40} |", 
                    d.Length, 
                    d.Length / 1024, 
                    d.Length / (1024 * 1024),
                    d.FullName);
            }
            Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");
            Console.WriteLine("|{0, 15} B | {1, 8} KB | {2, 4} MB |                                          |",
                velicina,
                velicina / 1024,
                velicina / (1024 * 1024));
            Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");

            Console.SetCursorPosition(1, 3);
            Console.Write(">");
            int brojRedova = datoteke.Length + 6;

            int cekanjeTreperenje = 500;
            Console.CursorVisible = false;
            int pokazivacY = 3;
            while (true)
            {
                System.Threading.Thread.Sleep(cekanjeTreperenje);
                Console.SetCursorPosition(1, pokazivacY);
                Console.Write(" ");
                System.Threading.Thread.Sleep(cekanjeTreperenje);
                Console.SetCursorPosition(1, pokazivacY);
                Console.Write(">");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pritisnutaTipka = Console.ReadKey(true);
                    if (pritisnutaTipka.Key == ConsoleKey.DownArrow)
                    {
                        pokazivacY++;
                    }
                }
            }

            // Console.SetCursorPosition(0, brojRedova);
        } //Main
    }
}
