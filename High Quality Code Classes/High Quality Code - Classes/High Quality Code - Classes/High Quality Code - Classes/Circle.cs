namespace High_Quality_Code___Classes
{
    using System;

    internal class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
                
        public override double Width
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be a positive");
                }

                this.radius = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        internal override double CalcSurface()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }
    }
}
