using System;

namespace AccessModifier
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ParticipationAt { get; set; }

        public Customer()
        {

        }

        public void Promote()
        {
            var participationDuration = caculateNOYearsOfParticipation();

            switch (participationDuration)
            {
                case 0:
                    Console.WriteLine("Promote user to Level 1");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Promote user to Level 2");
                    break;
                default:
                    Console.WriteLine("Promote user to Level 3");
                    break;
            }
        }
        
        protected float caculateRating()
        {
            var participationDuration = caculateNOYearsOfParticipation();

            switch (participationDuration)
            {
                case 0:
                    return 5.49F;
                case 1:
                case 2:
                    return 4.99F;
                default:
                    return 4.39F;
            }
        }

        private int caculateNOYearsOfParticipation()
        {
            var timespan = DateTime.Now - ParticipationAt;

            return timespan.Days / 365;
        }
    }
}
