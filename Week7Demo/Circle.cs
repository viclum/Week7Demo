using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() : base("Circle", "Red")
        {
            Radius = 1.0;
        }
        public Circle(string c, double r) : base("Circle", c)
        {
            Radius = r;
        }
        // override the abstract method
        public override double FindArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return base.ToString() +
                        "\tRadius: " + Radius;
        }

    }
}
