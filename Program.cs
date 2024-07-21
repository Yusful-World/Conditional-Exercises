using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Exercises
{
    public class Program
    {
        static void Main(string[] args)

        //conditional exercise 2
        {
            Console.WriteLine("Enter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The Max is " + max);
        }
        public void Exercise2()
        {
            
            //condition exercise 1
            Console.WriteLine("enter a number from 1 - 10");
            string input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number > 0 && number <= 10)
                Console.WriteLine("Valid");
            else if (number <=0)
                Console.WriteLine("Invalid");

        }

        
        

        
    }
}
