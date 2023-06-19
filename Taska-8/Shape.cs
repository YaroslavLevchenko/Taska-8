using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taska_8
{
    public abstract class Shape
    {
        string name;
        public abstract double Perimeter();
        public abstract double Area();
        public string Name
        {
            get => name;
            set => name = value;
        }

        protected Shape(string name)
        {
            this.name = name;
        }
    }
}
