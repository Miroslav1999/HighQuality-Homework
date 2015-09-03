namespace Methods
{
    using System;

    /// <summary>
    /// The class Student describes
    /// </summary>
    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string town = string.Empty;

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(this.firstName, "First name cannot be null value.");
                }
            }
        }

        public string LastName 
        {
            get 
            {
                return this.lastName;
            }

            set 
            { 
                if (value == null) 
                {
                    throw new ArgumentNullException(this.lastName, "Last name cannot be null value.");
                }
            }
        }

        public DateTime DateOfBirth 
        {
            get 
            { 
                return this.dateOfBirth;
            }

            set 
            { 
                if (value == null) 
                { 
                    throw new ArgumentNullException("Date of birth cannot be null value.");
                }
            }
        }

        public string Town { get; set; }

        /// <summary>
        /// The method compares the birth date of given student to other student`s birth date
        /// </summary>
        /// <param name="The other student whose birth date will be compared"></param>
        /// <returns>true - if the student is older then the other student</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            return this.DateOfBirth < otherStudent.DateOfBirth;
        }
    }
}
