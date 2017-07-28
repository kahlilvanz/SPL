using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            LaptopModels laptop = new LaptopModels();

            Console.Out.WriteLine(laptop.getLaptops());
            Console.ReadKey();
        }
    }

}
