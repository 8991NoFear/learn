using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{

    /*
     * Value type vs Reference type:
     *  +, Value type: store on the stack, they are primitive type (e.g. char, int, float, bool) or struct (e.g. DateTime)
     *  +, Reference type: store on the heap, they are any object created by class (e.g string)
     * 
     * Boxing: The process of coverting a value type instance to an object reference
     *  +, CLR create a new object in the heap and return the reference
     *  +, value type instance still remain on the stack
     * 
     * Unboxing: the opposite process of boxing
     * 
     * Boxing/Unboxing: Have performance penalty => should avoid
     */
    class Program
    {
        static void Main(string[] args)
        {
            string strNum = "10";
            //int intTen = int.Parse(strTen); // no boxing/unboxing

            int intNum = -1;
            intNum = (int) Convert.ChangeType(strNum, intNum.GetType()); // boxing/unboxing
            Console.WriteLine(intNum);
        }
    }
}
