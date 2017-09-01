using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Methods
{
    class Program
    {
        //main is the only thing that runs 
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 50;
            // passing the method (int, int)
            int total = Add(number1,number2);
            // Console.WriteLine(total);
            // passing second method 
            //Console.WriteLine(Multiply(number2, number1));
            Greeting();
            string name = "Will Robenson";
            RobotWarning(name);
        }
        //method 
        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
        //method
        public static int Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;
            return product;
        }
        //method
        public static void Greeting()
        {
            Console.WriteLine("Hello World!");
        }
        //method
        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger!, "+ name);
        }
    }
}
