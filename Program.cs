using System;


namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            //upcast
            person = new Personal();
            person = new Corporate();

            //downcast
            var PersonPersonal = new Personal();
            var PersonCorporate = new Corporate();
            PersonPersonal = (Personal)person;
            PersonCorporate = (Corporate)person;
        }

    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Personal : Person
    {
        public string Cpf { get; set; }
    }

    public class Corporate : Person
    {
        public string CNPJ { get; set; }
    }
}