using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
{
    /*
     * GroupBy creates and returns a sequence of IGrouping<K,V>
     */
    class Program
    {
        static void Main(string[] args)
        {
            //GroupBy
            GroupByMultipleKeys();
        }

        private static void GroupByMultipleKeys()
        {
            var eGroups = EmployeeRepo.GetListEmployees()
                                    .GroupBy(e => new { e.Department, e.Gender })
                                    .OrderBy(g => g.Key.Department)
                                    .ThenBy(g => g.Key.Gender)
                                    .Select(g => new
                                    {
                                        Department = g.Key.Department,
                                        Gender = g.Key.Gender,
                                        Employees = g.OrderBy(e => e.Name)
                                    });

            foreach (var eGroup in eGroups)
            {
                Console.WriteLine("Department: {0} - Gender: {1}", eGroup.Department, eGroup.Gender);
                Console.WriteLine("----------------------");
                foreach (var e in eGroup.Employees)
                {
                    Console.WriteLine("Name: {0}\tSalary: {1}", e.Name, e.Salary);
                }
                Console.WriteLine(); Console.WriteLine();
            }
        }

        private static void GroupBy()
        {
            var eGroups = EmployeeRepo.GetListEmployees()
                                    .GroupBy(e => e.Department)
                                    .OrderBy(g => g.Key)
                                    .Select(g => new
                                    {
                                        Key = g.Key,
                                        Employees = g.OrderBy(e => e.Name),
                                    });

            foreach (var eGroup in eGroups)
            {
                Console.WriteLine("Department: {0} - Total salaries: {1}", eGroup.Key, eGroup.Employees.Sum(e => e.Salary));
                Console.WriteLine("----------------------");

                foreach (var e in eGroup.Employees)
                {
                    Console.WriteLine("Name: {0}\tSalary: {1}", e.Name, e.Salary);
                }
                Console.WriteLine(); Console.WriteLine();
            }
        }
    }
}
