using System;

namespace AccessModifier
{
    internal class GoldCustomer : Customer
    {
        public void offerInterestRate()
        {
            var ratings = caculateRating();
            Console.WriteLine("Offer interesting interest rate: {0}%", ratings);
        }
    }
}
