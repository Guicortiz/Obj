using System;


namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
    public class Payment : IPayment

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