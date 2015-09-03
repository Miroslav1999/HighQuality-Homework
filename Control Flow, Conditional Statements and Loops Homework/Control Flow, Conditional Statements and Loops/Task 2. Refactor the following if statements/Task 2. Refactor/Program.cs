namespace Task_2.Refactor
{
    using System;

    public class Program
    {
        public const int MinX = 20;
        public const int MaxX = 100;
        public const int MinY = 10;
        public const int MaxY = 90;

        public static void Main()
        {
            /// Task 1

            Potato potato = new Potato();

            ///... 

            if (potato != null) 
            { 
                throw new ArgumentNullException("Potato is not assigned");
            }
            else 
            {
                if (!potato.HasNotBeenPeeled && !potato.IsRotten) 
                {
                    Cook(potato);
                }
            }

            /// Task 2
            
            bool shouldVisitCell = false;
            int x = 0;
            int y = 0;

            bool isXInRange = IsInRange(x, MinX, MaxX);
            bool isYInRange = IsInRange(y, MinY, MaxY);

            if (isXInRange && isYInRange && shouldVisitCell) 
            { 
                VisitCell();
            }
        }

        public static void Cook(Potato potato)
        {
            throw new NotImplementedException("TODO");
        }

        public static void VisitCell()
        {
            throw new NotImplementedException("TODO");
        }

        public static bool IsInRange(int value, int start, int end)
        {
            if (start <= value && value <= end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
