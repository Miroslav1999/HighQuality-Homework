namespace Problem_1.Odd_or_Even_Integers
{
    using System;

    /// <summary>
    /// Solution of this problem
    /// </summary>
    public class OddOrEven
    {
        public static void Main()
        {
            Console.WriteLine("Enter number: ");
            float number = float.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
