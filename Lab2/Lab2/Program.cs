using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {   //Input
                string input1 = "";
                string input2 = "";
                decimal length;
                decimal width;

                while (true)
                {
                    Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                    Console.WriteLine("Enter Room Length in decimal format:");
                    input1 = (Console.ReadLine());
                    Console.WriteLine("Enter Room Width in decimal format:");
                    input2 = (Console.ReadLine());
                    {
                        //Validation
                        if (decimal.TryParse(input1, out length) && decimal.TryParse(input2, out width))

                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid Entry, Please try again ");
                        }
                    }

                }
                Task(input1, input2);

                bool input = Continue();
                if (input == false)
                {
                    break;
                }


            }
            Console.WriteLine("Goodbye");
        }
        public static void Task(string value1, string value2)
        {
            decimal length = Convert.ToDecimal(value1);
            decimal width = Convert.ToDecimal(value2);

            decimal area = (length * width);
            decimal perimeter = ((length * 2) + (width * 2));

            Console.WriteLine("Length = " + length);
            Console.WriteLine("Width = " + width);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);


        }
        public static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue?");
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }
    }
}

