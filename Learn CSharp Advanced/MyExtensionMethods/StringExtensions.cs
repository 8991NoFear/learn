using System.Linq;

namespace MyExtensionMethods
{
    public static class StringExtensions // class must static
    {
        public static string Shorten(this string str, int noWords) // method must static
        {
            if (noWords <= 0)
            {
                throw new System.ArgumentOutOfRangeException("noWords must be greater than 0");
            }

            var words = str.Split(' ');
            if (noWords <= words.Length)
            {
                return str;
            }

            return string.Join(" ", words.Take(noWords));
        }
    }
}
