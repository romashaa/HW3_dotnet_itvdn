using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("This is a regular print.");

            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.Print("This is a color print.");

            Console.ReadKey();
        }
    }
}
