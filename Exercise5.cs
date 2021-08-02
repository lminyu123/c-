using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnum,lastint=0, cnum,i;
            Console.WriteLine("Enter the number of rows: ");
            rnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: ");
            for (i = 1; i <= rnum; i++)
            {
                for (cnum=1; cnum<=i; cnum++)
                {
                    if (lastint == 1)
                    {
                        Console.Write("0");
                        lastint = 0;
                    }
                    else if (lastint == 0)
                    {
                        Console.Write("1");
                        lastint = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}
