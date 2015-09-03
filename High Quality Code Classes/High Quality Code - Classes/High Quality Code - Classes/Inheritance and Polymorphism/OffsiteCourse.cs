namespace Inheritance_and_Polymorphism
{
    using System;
    using System.Collections.Generic;

    internal class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : base(name, teacherName, students)
        { 
        }

        public OffsiteCourse(string name)
            : base(name)
        {
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Town cannot be null");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(base.ToString());

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (!string.IsNullOrEmpty(this.Town))
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
