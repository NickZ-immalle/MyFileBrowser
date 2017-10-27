using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pets = { "dog", "cat", "bird" };
            foreach (string value in pets)
            {
                Console.WriteLine(value);
            }

            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument mee !");
            } else
            {

                switch (args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllfilesInCurrentDirectory();
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }
        }
        static void ShowCurrentDirectory()
        {
            Console.WriteLine("Current Directory");
        }

        static void ShowAllfilesInCurrentDirectory()
        {
            Console.WriteLine("Alle files in current directory:");

        }
    }
}
            
           