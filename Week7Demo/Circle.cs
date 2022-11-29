using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo
{
    class Circle : Shape, IComparable<Circle>
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
        public int CompareTo(Circle c)
        {
            return FindArea().CompareTo(c.FindArea());
            /*
            if (Radius > c.Radius)
            {
                return 1;
            }
            else if (Radius == c.Radius)
            {
                return 0;
            }
            else
            {
                return -1;
            }
            */
        }
        public override string ToString()
        {
            return base.ToString() +
                        "\tRadius: " + Radius;
        }

    }
}
