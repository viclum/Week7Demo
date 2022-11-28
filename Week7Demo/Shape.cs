using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo
{
    abstract class Shape
    {
        // properties
        public string Type { get; set; }
        public string Color { get; set; }

        // behaviors (constructors and methods)
        public Shape() { }

        public Shape(string t, string c)
        {
            Type = t;
            Color = c;
        }

        // abstract method(s)
        public abstract double FindArea(); // no 'body'
        public override string ToString()
        {
            return "Type: " + Type +
                "\tColor: " + Color;
        }

    }

}
