using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
            payment.description = "New payment";
            payment.Value = 10;
            Console.WriteLine(payment.Value);


        }
        //private, protected, internal e public
        class Payment
        {
            //prop, propg e propfull
            DateTime Finaldate;

            public string description { get; set; }

            private Decimal _Value;
            public Decimal Value
            {
                get
                {
                    _Value = _Value * 2;
                    return _Value;
                }
                set
                {
                    _Value = _Value - 2;
                    _Value = value;
                }
            }


            Address Billingaddress;

        }

        public class Address
        {
            string zipCode;
        }
    }
}
