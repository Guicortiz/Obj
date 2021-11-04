using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment(DateTime.Now, 10);
            Console.WriteLine("Payment: " + payment.date);
            Console.WriteLine("Payment: " + payment.value);

        }

        class Payment
        {
            public Payment()
            {

            }

            public Payment(DateTime date, decimal value)
            {
                this.date = date;
                this.value = value;
            }

            public DateTime date { get; set; }

            public Decimal value { get; set; }
            public virtual void pay(Decimal amount)
            {

            }
            public void pay(Decimal amount, DateTime Paymentdate)
            {

            }
            public void pay(Decimal amount, DateTime Paymentdate, decimal descount)
            {

            }
        }

    }
}