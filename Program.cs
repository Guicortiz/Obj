using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
            payment.Finaldate = DateTime.Now;
            payment.pay();

        }
        //private, protected, internal e public
        class Payment
        {
            public DateTime Finaldate;

            protected void pay()
            {

            }
        }

        class PaymentDocument : Payment
        {
            void payment()
            {
                base.pay();

            }
        }
    }
}
