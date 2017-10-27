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
            if (args.Length == 0)
            {
                Console.WriteLine("Geef een argument mee !");
            } else
            {

                switch (args[0])
                {
                    case "-c":
                        Console.WriteLine("Current Directory");
                        break;
                    case "-f":
                        Console.WriteLine("Alle files in current directory:");
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }













            }
        }
    }
}
            
           