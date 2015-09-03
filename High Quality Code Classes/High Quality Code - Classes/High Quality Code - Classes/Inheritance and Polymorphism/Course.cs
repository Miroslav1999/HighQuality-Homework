namespace Inheritance_and_Polymorphism
{
    using System;
    using System.Collections;

    internal class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        protected Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        protected Course(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(base.ToString());

            if (!string.IsNullOrEmpty(this.Lab))
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students.Count == 0)
            {
                return "{ }";
            }           
           
            return "{ " + string.Join(", ", this.Students) + " }";            
        }
    }
}
