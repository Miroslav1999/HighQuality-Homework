namespace Naming_Identifiers_Task_2
{
    using System;

    public class Person
    {
        public Person(int age) 
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "Marto";
                this.PersonGender = Gender.Male;
            }
            else
            {
                this.Name = "Mary";
                this.PersonGender = Gender.Female;
            }
        }

        public enum Gender
        {
            Male,

            Female
        }

        public Gender PersonGender{ get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
