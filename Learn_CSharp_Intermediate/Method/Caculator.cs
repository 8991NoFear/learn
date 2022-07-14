using System.Linq;

namespace Method
{
    class Caculator
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
