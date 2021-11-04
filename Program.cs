using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var payment = new Payment())
            {
                Console.WriteLine("Processing payment");
            }
        }

        class Payment : IDisposable
        {
            public Payment()
            {
                Console.WriteLine("Start payment");
            }

            public void Dispose()
            {
                Console.WriteLine("Finish payment");
            }
        }

    }
}