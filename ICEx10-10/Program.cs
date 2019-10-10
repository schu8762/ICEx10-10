using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@author Jacob Schuller
namespace ICEx10_10
{
    class Program
    {
        static void Main(string[] args)
        { /* Functions 10/10/2019
           * functions should only do one thing
           * static <return Type> <FunctionName>(){}
           *  in class example
           *  just know how to make it - can't put a function inside a function - above or below
           */

            double val2 = 5;
            var sum = Add(3, val2);
            Console.WriteLine($" 3 + {val2} = {sum}");

            //FizzBuzz(15);

            for (int i = 1; i <= 101; i++)
            {
                FizzBuzz[i];
            }

            Console.ReadKey();
        }

      
        /// <summary>
        ///   Adds up to two values  
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        static double Add(double val1, double val2) //2 values
        {
            double result = val1 + val2;

            return result; // need to put this here so the red line under add goes away, output the same type
        }

        static void FizzBuzz(int num) // don't need anything back from us so void
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");          
            }
            else if(num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        
        }   
    } 
}
