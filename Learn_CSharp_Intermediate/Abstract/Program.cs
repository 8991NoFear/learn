using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /*
     * "abstract" keyword => indicate that class and method are missing implementation
     * 
     * Rules:
     * +, if methods is abstract => class must be abstract too
     * +, derived class must implement all abstract method
     * +, abstract class can not instantiated
     * 
     * Why? to force other developer to folow your design
     */
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>() { new Circle(), new Rectange() };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
