namespace Task_2.PrintStatisticsInCSharp
{
    using System;

    public class Program
    {
        public static void Main()
        {
            /// THING
        }

        public void PrintStatistics(double[] collection, int elementCount)
        {
            double minValue = double.MinValue;
            double maxValue = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < elementCount; i++)
            {
                if (collection[i] > maxValue)
                {
                    maxValue = collection[i];
                }

                if (collection[i] < minValue)
                {
                    minValue = collection[i];
                }

                sum += collection[i];
            }

            double averageSum = sum / elementCount;

            this.PrintAverage(averageSum);
            this.PrintMin(minValue);
            this.PrintMax(maxValue);
        }

        private void PrintMax(double maxValue)
        {
            throw new NotImplementedException("TODO");
        }

        private void PrintMin(double minValue)
        {
            throw new NotImplementedException("TODO");
        }

        private void PrintAverage(double averageSum)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
