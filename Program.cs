using System;


namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            //You don't instance abstract classes.
            var payment = new Payment();
            var paymentdoc = new PaymentDocument();
        }

    }

    public class PaymentDocument : Payment
    {

    }
    public abstract class Payment : IPayment

    {
        public DateTime FinalDate { get; set; }

        public void Pay(double value)
        {

        }
    }

    public interface IPayment
    {
        DateTime FinalDate { get; set; }

        void Pay(double value);
    }
}