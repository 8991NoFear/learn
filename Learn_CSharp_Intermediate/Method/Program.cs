using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number); // Weird
            if (result)
            {
                Console.WriteLine("number = {0}", number);
            }
            else
            {
                Console.WriteLine("Oops, can not parse");
            }
        }

        private static void useCaculator()
        {
            var sum1 = Caculator.Add(1, 2, 3, 4, 5);
            var sum2 = Caculator.Add(new int[] { 5, 4, 3, 2, 1 });
            Console.WriteLine("sum1 = {0}, sum2 = {1}", sum1, sum2);
        }

        private static void usePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
            }
            catch
            {
                Console.WriteLine("Oops, something went wrong :(");
            }
        }
    }
}
