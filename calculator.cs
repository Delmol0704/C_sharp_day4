using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class3
    {
        public void InputX()
        {
            Console.WriteLine("Enter first no : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum : " + (a + b));

        }
        static void Main()
        {
            Class3 obj = new Class3();
            obj.InputX();
            int exitkey = 1;
            while (exitkey > 0)
            {
                Console.WriteLine("You want to exit ? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    obj.InputX();
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }


    }
}