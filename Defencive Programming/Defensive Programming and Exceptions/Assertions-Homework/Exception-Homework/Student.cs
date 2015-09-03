namespace Exception_Homework
{
    using System;
using System.Collections;

    public class Student
    {
        public string firstName;
        public string lastName;
        public IList<Exam> exams;

        public string FirstName 
        {
            get 
            {
                return this.firstName;
            }

            set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("First name: ");
                }

                this.firstName = value;
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
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Last name: ");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams 
        {
            get 
            {
                return exams.Select(x => x).ToList();
            }

            set 
            {
                if (value == null) 
                {
                    throw new ArgumentException("Exams: ");
                }

                this.exams = value.Select(x => x).ToList();
            }
        }


        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentException("Exams!");
            }

            if (this.Exams.Count == 0)
            {
                return null;
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new ArgumentException("Exams");
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return 0;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = 
                    ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
}
