using System;
using System.Collections.Generic;
using System.Linq;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            //var payments = new IEnumerable<Payment>();
            //var payments = new ICollection<Payment>();
            //var payments = new List<Payment>();

            IList<Payment> payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            foreach (var item in payments)
            {
                Console.WriteLine(item.Id);
            }

            var payment = payments.Where(x => x.Id == 3);
            var payment2 = payments.First(x => x.Id == 3);
            payments.Remove(payment2);

            foreach (var item in payments)
            {
                Console.WriteLine(item.Id);
            }

            var paidPayment = new List<Payment>();
            paidPayment.AddRange(payments);

            payments.AsEnumerable();
            payments.ToList();
            payments.ToArray();

        }
    }

    public class Payment
    {
        public Payment(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}