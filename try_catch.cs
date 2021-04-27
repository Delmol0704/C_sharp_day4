using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class4
    {
        static void Main()
        {
            int x = 0;
            int[] a = new int[1];
            try
            {
                a[2] = 1;
                Console.WriteLine(x / 0);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            finally
            {
                Console.WriteLine("from finally block");
            }
            Console.ReadLine();
        }
    }
}
        