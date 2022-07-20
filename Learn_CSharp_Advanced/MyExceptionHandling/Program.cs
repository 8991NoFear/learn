using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptionHandling
{
    class Program
    {
        /*
         * Exception in C# has Data and InnerException property
         */
        static void Main(string[] args)
        {
            // SYNTAX 1
            StreamReader sr = default;
            try
            {
                sr = new StreamReader(@"C:\doesnotexist.txt");
                var content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // or Log
            }
            finally
            {
                if (sr != default)
                {
                    sr.Dispose();
                }
            }

            // SYNTAX 2
            try
            {
                using (var streamReader = new StreamReader(@"C:\doesnotexist.txt"))
                {
                    var content = streamReader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // PROBLEMS: trong catch ném tiếp exception:
            // 1) sau catch có tiếp catch thì như thế nào?
            // 2) sau catch chỉ có khối finally thì như thế nào?
        }
    }
}
