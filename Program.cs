using System;

namespace LeapYearOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, reminder;
            Console.WriteLine("Please enter a year");
            number = Convert.ToInt32(Console.ReadLine());

            reminder = number % 4;
            reminder = number % 400;

            if (reminder == 0)
                Console.WriteLine("{0} is a leap year", number);
            else
                Console.WriteLine("{0} is a common year", number);

            Console.ReadKey();
        }
    }
}
