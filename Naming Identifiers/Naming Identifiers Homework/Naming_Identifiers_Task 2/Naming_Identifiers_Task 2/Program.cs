namespace Naming_Identifiers_Task_2
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Person firstPerson = new Person(15);
            Person secondPerson = new Person(10);

            Console.WriteLine("Name: {0}, age {1}, gender {2}", firstPerson.Name, firstPerson.Age, firstPerson.PersonGender);
            Console.WriteLine("Name: {0}, age {1}, gender {2}", secondPerson.Name, secondPerson.Age, secondPerson.PersonGender);
        }
    }
}
