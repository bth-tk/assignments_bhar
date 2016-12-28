using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "y";

            while (con == "y" || con == "Y")
            {

                Console.WriteLine("Please select your operation \n 1. For addition \n 2. For substraction \n 3. For multiplication \n 4. For division");
                //Console.WriteLine("")
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter number 1");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter number 2");
                int num2 = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        int sum = num1 + num2;
                        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);

                        break;

                    case 2:
                        int diff = num1 - num2;
                        Console.WriteLine("The Difference of {0} and {1} is {2}", num1, num2, diff);
                        break;

                    case 3:
                        int mul = num1 * num2;
                        Console.WriteLine("The Product of {0} and {1} is {2}", num1, num2, mul);
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Denominator should not be zero in division");
                            break;
                        }
                        else
                        {
                            int div = num1 / num2;
                            Console.WriteLine("The Division of {0} and {1} is {2}", num1, num2, div);
                            break;
                        }

                    default:
                        Console.WriteLine("Please select legal option");
                        break;

                }

                Console.WriteLine("Do you wish to perform another operation: (y/n)");
                con = Console.ReadLine();

            }

            Console.WriteLine("Thanks for using calculator");
        }
    }
}
