using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling configuration

            try 
            {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // converting num1 to int

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); // converting num2 to int

            Console.WriteLine(num1 / num2);
            }

            // If the try block gives and exception, then the catch block would execute


            /*

            catch
            {
                Console.WriteLine("Error !");

            }

           */

           // providing the exception reason with catch block

           catch (Exception e)
           {
               Console.WriteLine(e.Message);  // will provide the reason behind the exception : the error message
           }
        /*
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message); // will provide the reason behind the exception : divide by zero exception
            }
             
            catch (FormatException e)
            {
                Console.WriteLine(e.Message); // will provide the reason behind the exception
            }

            finally // it's optional
            {
                Console.WriteLine();    // It will execute, and it's a must
            }

        */
            Console.ReadLine();
        }
    }
}
