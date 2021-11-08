using System;
namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var subscription = new Subscription();
            var context = new DataContext<Person>();
            var context2 = new DataContext<Payment>();
            context.Save(person);
            context.Save(subscription);
        }

    }

    public class DataContext<T>
    where T : Person
    {
        public void Save(T entity)
        {

        }
    }

    public class Person { }

    public class Payment { }

    public class Subscription { }
}