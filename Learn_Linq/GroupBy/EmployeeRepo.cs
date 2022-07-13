using System.Collections.Generic;

namespace GroupBy
{
    class EmployeeRepo
    {
        public static List<Employee> GetListEmployees()
        {
            return new List<Employee>()
            {
                new Employee() { Id = 1, Name = "John", Gender = "Male", Department = "IT", Salary = 1122},
                new Employee() { Id = 2, Name = "Mosh", Gender = "Male", Department = "HR", Salary = 1221},
                new Employee() { Id = 3, Name = "Harry", Gender = "Female", Department = "IT", Salary = 1321},
                new Employee() { Id = 4, Name = "Maguire", Gender = "Male", Department = "IT", Salary = 765},
                new Employee() { Id = 5, Name = "Catherine", Gender = "Female", Department = "HR", Salary = 333},
                new Employee() { Id = 6, Name = "Louis", Gender = "Female", Department = "SI", Salary = 559},
                new Employee() { Id = 7, Name = "Louis", Gender = "Female", Department = "IT", Salary = 413},
                new Employee() { Id = 8, Name = "Alice", Gender = "Female", Department = "HR", Salary = 507},
                new Employee() { Id = 9, Name = "Bob", Gender = "Male", Department = "IT", Salary = 1579},
                new Employee() { Id = 10, Name = "Cristiano", Gender = "Male", Department = "SI", Salary = 2575},
                new Employee() { Id = 11, Name = "Ronaldo", Gender = "Male", Department = "SI", Salary = 1309},
            };
        }
    }
}
