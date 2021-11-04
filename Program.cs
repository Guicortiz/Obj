using System;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var Customer = new Customer();
            Customer.Name = "Guicortiz";
            Console.WriteLine(Customer.Name);
        }

        // Objeto(classe) é um tipo de referencia.
        // Struct é um tipo de valor.
        class Customer
        {
            public string Name;
        }
    }
}
