using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int sum;

            Console.WriteLine("Please enter the first number: ");
            numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            numberTwo = int.Parse(Console.ReadLine());

            sum = numberOne + numberTwo;

            if(sum > 10){
                Console.WriteLine("The sum of these two numbers is greater than ten.");
            }else{
                Console.WriteLine("The sum of these two numbers is lesss than ten");
            }

        }
    }
}
