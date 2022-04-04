using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }
    }
}
