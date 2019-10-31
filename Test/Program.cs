using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Hello, Welcome to .Net Language Converter Library [Moraba.Converter.Core]");
            Console.WriteLine("The package can be easily installed via Nuget.");
            Console.WriteLine("Package Manager");
            Console.WriteLine("PM> Install-Package Moraba.Converter.Core -Version 1.0.1");
            Console.WriteLine();
            Console.WriteLine("please enter persian number : ");
            var input = Console.ReadLine();
            Console.WriteLine("result : {0}", Moraba.Converter.Numbers.Convert.PersianToEnglish(input));
            Console.WriteLine();
            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();
                
        }
    }
}
