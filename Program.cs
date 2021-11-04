using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
        }
        //private, protected, internal e public
        class Payment
        {
            DateTime Finaldate;

            Address Billingaddress;

        }

        public class Address
        {
            string zipCode;
        }
    }
}
