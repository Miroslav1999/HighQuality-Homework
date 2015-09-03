namespace Exception_Homework
{
    using System;

    public class ExamResult
    {
        public int grade;
        public int minGrade;
        public int maxGrade;
        public string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (maxGrade <= minGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade should be bigger than min grade.");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Grade should be greater than or equal to zero.");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Min grade should be greater than or equal to zero.");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade { get; private set; }    

        public int Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Comments");
                }

                this.comments = value;
            }
        }
    }
}
