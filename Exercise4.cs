using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your start number : ");
            int StartNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your end number : ");
            int EndNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Armstrong Numbers between {StartNumber} and {EndNumber} are : ");
            for (int i=StartNumber; i<=EndNumber; i++)
            {
                if (ArmstrongNumber(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static bool ArmstrongNumber(int number)
        {
            int sum = 0;
            int tempnumber = number;
            int temp = 0;
            int length = number.ToString().Length;

            while(number !=0)
            {
                temp = number % 10;
                number = number / 10;
                sum += (int)Math.Pow(temp, length);
                //sum =sum+(temp*temp*temp);
            }
            if (sum ==tempnumber)
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
