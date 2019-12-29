using System;
using System.IO;
namespace Lista_plikow_folderu
{
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("PROGRAM DO WYSWIETLANIA ZAWARTOSCI KATALOGU BIEŻĄCEGO");
            Console.WriteLine("\n");
            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine("Bieżący katalog");
            Console.WriteLine(dir);
            Console.WriteLine("*************************************************************************\n");
            string[] dirs1 = Directory.GetFiles(dir, "*.exe", SearchOption.TopDirectoryOnly);
            string[] dirs2 = Directory.GetFiles(dir, "*.lnk", SearchOption.TopDirectoryOnly);
            Console.WriteLine("Lista Plikow z rozszerzeniem *exe");
            foreach (string name in dirs1)
            {
                Console.WriteLine(name);  
            }
            Console.WriteLine("\n");
            Console.WriteLine("Lista Plikow z rozszerzeniem *lnk-skroty");
            foreach (string name in dirs2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key do continue...");
            Console.ReadKey();
        }
    }
}




