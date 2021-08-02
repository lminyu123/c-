using System;

namespace Exercise2
{

    public class Arithmetic
    {
        int num1, num2;
        int add, sub, mult;
        float div;

        public void GetdNum()
        {
            Console.WriteLine("Enter your First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter your Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());


            add = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

        }
        public void DisplayResult()
        {

            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Mutiplication " + mult);
            Console.WriteLine("Division: " + div);

        }




        class Program
        {
            public static int op { get; private set; }

            static void Main(string[] args)
            {

                Console.Write ("Enyer your Operation Method");
                op = Convert.ToInt32(Console.ReadLine());
               

            static void  ChoseMethd()
                {

                    switch (OperationMethod)
                    {
                        case "Add":
                            Console.WriteLine("You Choose Addition");
                            break;
                        case "Sub":
                            Console.WriteLine("You Choose Subtraction ");
                            break;
                        case "mult":
                            Console.WriteLine("You Choose Multiplication");
                            break;
                        case "div":
                            Console.WriteLine("You Choose Divison");
                            break;
                        default:
                            Console.WriteLine("You Choose Invalid Operationn");
                            break;
                    }
                }


                //Arithmetic a1 = new Arithmetic();
                //a1.GetdNum();
                //a1.DisplayResult();
                //Console.ReadKey();
            }
        }
    }
}
