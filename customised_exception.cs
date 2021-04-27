using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MyException : ApplicationException
    {
        public void MyNullException()
        {
            Console.WriteLine("Exception occered : object is null");
        }

    }
    class Class6
    {
        public static void Main()
        {
            Class6 class6 = new Class6();
            class6 = null;
            try
            {
              
                if (class6 == null)
                {
                    throw new MyException();
                }
            }
            catch (MyException ex)
            {
                ex.MyNullException();
            }
            Console.ReadLine();
        }

    }
}
