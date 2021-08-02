using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter your Word");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length>=0)
            {
                reverse = reverse + str[Length];
                Length--;
            }

            //display the reverse word
            Console.WriteLine("Reverse word is: \n {0}", reverse);
            Console.ReadLine();
            
        }


    }
}
