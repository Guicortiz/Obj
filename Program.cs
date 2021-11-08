using System;


namespace Obj
{
    class Program
    {
        static void SetPay(double value)
        {
            Console.WriteLine($"Pago o valor de {value}");
        }

        static void Main(string[] args)
        {
            var pay = new Payment.Pay(SetPay);
            pay(25);
        }

    }

    public class Payment
    {
        public delegate void Pay(double value);
    }



}