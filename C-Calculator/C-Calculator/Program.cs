using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                       Basic Calculator by Trago");
            Console.WriteLine(" [ Hdouble: If you somehow choose the wrong one use the power of Ctrl + C ] ");
            Console.WriteLine(" ");
            Console.WriteLine("Please choose one from the following...");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");


            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("5) Exit");
            Console.WriteLine(" ");

            int npInput = Convert.ToInt32(Console.ReadLine());

            if (npInput == 1) {
                Console.WriteLine("Please enter number for addition");

                double addNum1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the 2nd number");
                double addNum2 = Convert.ToDouble(Console.ReadLine());

                double newNum3 = addNum1 + addNum2;
                Console.WriteLine(newNum3);
            } // breaker

            else if (npInput == 2) {
                Console.WriteLine("Please enter number for subtraction");
                double subNum1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the 2nd number");
                double subNum2 = Convert.ToDouble(Console.ReadLine());

                double subNum3 = subNum1 - subNum2;
                Console.WriteLine(subNum3);
            } // breaker

            else if (npInput == 3)
            {
                Console.WriteLine("Please enter number for multiplication");
                double mulNum1  = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the 2nd number");
                double mulNum2 = Convert.ToDouble(Console.ReadLine());

                double mulNum3 = mulNum1 * mulNum2;
                Console.WriteLine(mulNum3);
            } // breaker

            else if (npInput == 4)
            {
                Console.WriteLine("Please enter number for division");
                double divNum1 = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine("Please enter the 2nd number");
                double divNum2 = Convert.ToInt32((Console.ReadLine()));

                double divNum3 = divNum1 / divNum2;
                Console.WriteLine(divNum3);
            } // breaker

            else if (npInput == 5)
            {
                Console.WriteLine("Closing calculator...");
            }
        }
    }
}
