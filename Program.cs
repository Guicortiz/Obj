using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();

        }

        class Payment
        {
            DateTime Finaldate;

            public void pay()
            {
                VerifyFoundsinCard();
            }

            private void VerifyFoundsinCard() { }
        }
    }
}
