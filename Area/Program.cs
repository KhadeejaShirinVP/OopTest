using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(6);
            Console.WriteLine("Area  = " + square.Area());
        }
    }
}
