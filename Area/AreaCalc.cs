using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public abstract class AreaCalc
    {
        abstract public int Area();
    }
    class Square : AreaCalc
    {
        int side = 0;

        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    class Rectangle : AreaCalc
    {
        int length = 0;
        int breadth = 0;

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public override int Area()
        {
            return length * breadth;
        }
    }
}
   