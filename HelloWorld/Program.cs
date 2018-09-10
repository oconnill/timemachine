using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the day of your birth");

            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of your birth");

            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year of your birth");

            int year = int.Parse(Console.ReadLine());

            DateTime dateValue = new DateTime(year, month, day);

            Console.WriteLine(dateValue.ToString("ddd"));



        }
    }
}
