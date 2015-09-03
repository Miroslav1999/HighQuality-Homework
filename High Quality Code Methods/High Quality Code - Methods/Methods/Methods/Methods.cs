namespace Methods
{
    using System;

    public class Methods
    {
        /// <summary>
        /// Format modifier used when printing formatted string
        /// </summary>
        public enum FormatOptions
        {
            FixedPoint,
            Percent,
            AlignRight
        }

        /// <summary>
        /// The method calculates the area of a triangle
        /// </summary>
        /// <param name="sideA">side A of the triangle</param>
        /// <param name="sideB">side B of the triangle</param>
        /// <param name="sideC">side C of the triagle</param>
        /// <returns></returns>
        public static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
                return -1;
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        /// <summary>
        /// The moethod convert one-digit number to string containing the digit name
        /// </summary>
        /// <param name="number">The number to convert</param>
        /// <returns>String containing the digit name</returns>
        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("The number is negative or contains more than one digit");
            }
        }

        /// <summary>
        /// The method finds the maximal value in array of integer numbers
        /// </summary>
        /// <param name="elements">The array of integer number</param>
        /// <returns>Integer value</returns>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array of integers is empthy");
            }

            int maxValue = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// The methods prints an objects as a number using different format options
        /// </summary>
        /// <param name="number">the numeric objects</param>
        /// <param name="format">Enumeration of format options</param>
        public static void PrintAsNumber(object number, FormatOptions format)
        {
            switch (format) 
            {
                case FormatOptions.FixedPoint: 
                {
                    Console.WriteLine("{0:f2}", number);
                    return;
                }
                
                case FormatOptions.Percent:
                {
                    Console.WriteLine("{0:p0}", number);
                    return;
                }

                case FormatOptions.AlignRight: 
                {
                    Console.WriteLine("{0,8}", number);
                    return;
                }

                default:
                    throw new ArgumentException("Invalid format");
            }
        }

        /// <summary>
        /// The method calculates the length of a line segment in 2D Cartesian
        /// given start and end points of the segment
        /// </summary>
        /// <param name="x1">X-projection of the start point</param>
        /// <param name="y1">Y-projection of the start point</param>
        /// <param name="x2">X-projection of the end point</param>
        /// <param name="y2">Y-projection of the end point</param>
        /// <param name="isHorizontal">Output value: is the line horizontal?</param>
        /// <param name="isVertical">Output value: is the line vertical?</param>
        /// <returns></returns>
        public static double CalcDistance(
            double x1,
            double y1,
            double x2,
            double y2,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = y1 == y2;
            isVertical = x1 == x2;

            double xSize = x2 - x1;
            double ySize = y2 - y1;

            double distance = Math.Sqrt((xSize * xSize) + (ySize * ySize));
            return distance;
        }

        /// <summary>
        /// Test method
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("The area of triangle is: {0}", CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, FormatOptions.FixedPoint);
            PrintAsNumber(0.75, FormatOptions.Percent);
            PrintAsNumber(2.30, FormatOptions.AlignRight);

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov");
            peter.DateOfBirth = new DateTime(1999, 17, 05);
            peter.Town = "Vidin";

            Student stella = new Student("Stella", "Ivanova");
            stella.DateOfBirth = new DateTime(1994, 25, 11);
            stella.Town = "Burgas";

            Console.WriteLine(
                "\n{0} older than \n{1} -> \n{2}",
                peter.FirstName,
                stella.FirstName,
                peter.IsOlderThan(stella));
        }
    }
}
