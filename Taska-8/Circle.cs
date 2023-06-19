using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taska_8
{
    public class Circle : Shape
    {
        double radius;

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * Math.PI * 2;
        }

        public override double Perimeter()
        {
            return radius * Math.Pow(Math.PI, 2);
        }

    }
}
