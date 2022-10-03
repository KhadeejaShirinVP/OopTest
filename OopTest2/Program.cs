using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calc=new Calculation();
            Console.WriteLine("Add :{0}\nMultiple :{1}", calc.AddTwoNumbers(6, 9), calc.MultiplyTwoNumbers(6, 5));
        }
    }
}
