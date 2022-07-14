using System;

namespace Property
{
    class Person
    {
        private string _name;
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                return timeSpan.Days / 365;
            }
        }
    }
}
