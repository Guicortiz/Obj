using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public sealed class Payment
        {
            public DateTime Date { get; set; }
        }

        public class PaymentDocument : Payment
        {

        }

    }
}