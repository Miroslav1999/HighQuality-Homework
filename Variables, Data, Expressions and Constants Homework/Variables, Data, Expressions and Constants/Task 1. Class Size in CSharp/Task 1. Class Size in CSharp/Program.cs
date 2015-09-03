namespace Task_1.Class_Size_in_CSharp
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get 
            {
                return this.Height;
            }

            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height have to be a positive double value");
                }

                this.Height = value;
            }
        }

        public double Width 
        {
            get 
            {
                return this.Width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width have to be a positive double value");
                }

                this.Width = value;
            }
        }

        public static Size GetRotatedSize(Size s, double angleOfTheFigureThatWillBeRotaed)
        {
            double oldWidth = oldSize.Width;
            double oldHeight = oldHeight.Height;

            var cos = Math.Cos(rotationAngel);
            var sin = Math.Sin(rotationAngel);

            var newWidth = Math.Abs((cos * oldWidth) + (sin * oldHeight));
            var newHeight = Math.Abs((sin * oldWidth) + (cos * oldHeight));

            var roatedSize = new Size(newWidth, newHeight);
            return roatedSize;
        }
    }
}
