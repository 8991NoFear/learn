using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensionMethods
{
    class Program
    {
        /*
         * 
         * Extension method allow us to add new methods to an existing class without:
         * +) Changing its source code or
         * +) Create new class that inherits from it
         * 
         */
        static void Main(string[] args)
        {
            var blogPost = "This is supposed to be a very long post ...";
            var shortenedPost = blogPost.Shorten(13); // Shorten is available because of the namespace
        }
    }
}
