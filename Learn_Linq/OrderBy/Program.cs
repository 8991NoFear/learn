using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy
{
    /*
     * OrderBy, OderByDescending, ThenBy, ThenByDescending can be used to sort data
     * Reverse simply reverses the items in a given collection
     * 
     * OrderBy and OrderByDescending performs primary sort
     * Primary sort should be used only once in the LINQ query (if have multiple => the latter override the former)
     * 
     * ThenBy and ThenByDescending is used for adding secondary sort
     * Secondary sort can be used more than once in the same LINQ query
     */
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentRepo.GetListStudents();

            Console.WriteLine("List of students before sort");
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}\tTotal marks: {1}\tId: {2}", student.Name, student.TotalMarks, student.Id);
            }

            Console.WriteLine("\nList of students after sort");
            var sortedStudents = students.OrderByDescending(s => s.TotalMarks)
                                        .ThenBy(s => s.Name)
                                        .ThenBy(s => s.Id);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Name: {0}\tTotal marks: {1}\tId: {2}", student.Name, student.TotalMarks, student.Id);
            }

            Console.WriteLine("\nList of sorted students after reverse");
            var reverseStudents = sortedStudents.Reverse();
            foreach (var student in reverseStudents)
            {
                Console.WriteLine("Name: {0}\tTotal marks: {1}\tId: {2}", student.Name, student.TotalMarks, student.Id);
            }
        }
    }
}
