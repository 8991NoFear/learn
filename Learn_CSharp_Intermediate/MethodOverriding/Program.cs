using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    /*
     * What? Modyfing the implementation of an inherited method
     * 
     * How? use "virtual" and "override" keyword
     */
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>() { new Rectangle(), new Circle(), new Shape() };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
