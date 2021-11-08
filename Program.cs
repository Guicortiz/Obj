using System;


namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1, "Andre Baltiere");
            var person2 = new Person(1, "Andre Baltiere");

            Console.WriteLine(person.Equals(person2));

        }

    }

    public class Person : IEquatable<Person>
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool Equals(Person other)
        {
            return Id == other.Id && Name == other.Name;
        }
    }


}