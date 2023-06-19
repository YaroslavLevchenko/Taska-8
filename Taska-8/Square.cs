using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taska_8
{
    public class Square : Shape
    {
        double side;

        public double Side
        {
            get => side;
            set => side = value;
        }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }
    }
}
