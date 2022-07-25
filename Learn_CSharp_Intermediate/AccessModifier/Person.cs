using System;

namespace AccessModifier
{
    class Person
    {
        private DateTime _birthdate;

        public Person()
        {

        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}
