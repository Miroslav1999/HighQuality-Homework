namespace Task_3.RefactorTheFollowingLoop
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int value = 0;

            for (int i = 0; i < 100; i++)
            {
                int currentValue = array[i];
                Console.WriteLine(currentValue);

                if ((i % 10 == 0) && (currentValue == expectedValue))
                {
                    value = 666;
                    break;
                }
            }

            if (value == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
