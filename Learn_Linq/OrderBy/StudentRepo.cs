using System.Collections.Generic;

namespace OrderBy
{
    class StudentRepo
    {
        public static List<Student> GetListStudents()
        {
            return new List<Student>()
            {
                new Student
                {
                    Id = 101,
                    Name = "Harry",
                    TotalMarks = 700,
                },
                new Student
                {
                    Id = 102,
                    Name = "Maguire",
                    TotalMarks = 750,
                },
                new Student
                {
                    Id = 103,
                    Name = "Paul",
                    TotalMarks = 900,
                },
                new Student
                {
                    Id = 104,
                    Name = "Harry",
                    TotalMarks = 700,
                },
                new Student
                {
                    Id = 105,
                    Name = "Ronaldo",
                    TotalMarks = 950,
                },
            };
        }
    }
}
