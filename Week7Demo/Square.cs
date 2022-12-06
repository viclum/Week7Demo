using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Demo
{
    class Square : Shape
    {
        public double Length { get; set; }

        public override double FindArea()
        {
            return Length * Length;
        }

    }
}
