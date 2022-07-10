namespace Class
{
    partial class Program
    {
        class Person
        {
            public string Name;

            public Person()
            {

            }

            public void Introduce(string to)
            {
                System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }

            public static Person Parse(string name)
            {
                var p = new Person();
                p.Name = name;

                return p;
            }
        }
    }
}
