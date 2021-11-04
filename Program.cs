using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment.Date = DateTime.Now;
        }

        public static class Payment
        {
            public static DateTime Date { get; set; }
        }

    }
}