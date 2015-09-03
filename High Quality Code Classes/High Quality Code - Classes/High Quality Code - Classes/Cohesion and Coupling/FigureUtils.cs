namespace Cohesion_and_Coupling
{
    using System;

    public class FigureUtils
    {
        private double width;
        private double height;
        private double depth;

        public FigureUtils(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative");
                }

                this.depth = value;
            }
        }          

        public static double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
