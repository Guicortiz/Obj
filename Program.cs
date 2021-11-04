using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new PaymentCard();
            payment.VerifyFoundsinCard();
            payment.Finaldate = DateTime.Now;
            payment.CreditcardNumber = 12345678;

            var paymentdoc = new PaymentDoc();
            paymentdoc.Document = "12345678";
            paymentdoc.DocumentNumber();

        }

        class Payment
        {
            public DateTime Finaldate;

            public void pay()
            {

            }
        }

        class PaymentCard : Payment
        {
            public int CreditcardNumber;
            public void VerifyFoundsinCard() { }
        }

        class PaymentDoc : Payment
        {
            public string Document;
            public void DocumentNumber() { }
        }
    }
}
