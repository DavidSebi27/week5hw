using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double CalculateArea()
        { 
            return (Width * Height);
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
