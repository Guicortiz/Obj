using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new PaymentCard();
            payment.pay();
            payment.Finaldate = DateTime.Now;
            payment.CreditcardNumber = 12345678;

            var paymentdoc = new PaymentDoc();
            paymentdoc.Document = "12345678";
            paymentdoc.pay();

        }

        class Payment
        {
            public DateTime Finaldate;

            public virtual void pay()
            {

            }
        }

        class PaymentCard : Payment
        {
            public int CreditcardNumber;

            public override void pay()
            {
                VerifyFoundsinCard();
                Console.WriteLine("Creditcard payment completed");
            }
            void VerifyFoundsinCard() { }
        }

        class PaymentDoc : Payment
        {
            public string Document;

            public override void pay()
            {
                DocumentNumber();
                Console.WriteLine("Document payment completed");
            }
            void DocumentNumber() { }
        }
    }
}
