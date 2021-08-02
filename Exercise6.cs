using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnum, emptnum, i;
            Console.WriteLine("Ener the number of row");
            rnum = int.Parse(Console.ReadLine());

            //start row  i=1, i=2, i=3
            for(i=1; i<=rnum; i++)
            {
                // count empty space 
                for(emptnum=1;emptnum<=rnum-i; emptnum++)
                    Console.Write(" ");
                // count start space
                for(emptnum=1;emptnum<=i*2-1;emptnum++)
                    Console.Write("*");
                    Console.WriteLine();

            }
            //back row i=2,i=1,i=0
            for (i = rnum - 1; i>=1; i--)
            {
                // 2,1
                for(emptnum=1;emptnum<=rnum-i; emptnum++)
                    Console.Write(" ");
                for(emptnum=1;emptnum<=i*2-1;emptnum++)
                    Console.Write("*");
                 Console.WriteLine();

            }
        }
    }
}
