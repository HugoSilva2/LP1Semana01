using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input of an integer
            Console.WriteLine("Input an integer:");
            string inteiro = Console.ReadLine();
            //convert string to integer(saving as a variable)
            int num1 = int.Parse(inteiro); 
            //Input of a real number
            Console.WriteLine("Input a real number(ex: decimal):");
            string numeroreal = Console.ReadLine();
            //convert string to float(saving as a variable)
            float num2 = float.Parse(numeroreal);
            //Addition of both variables 
            Console.WriteLine($"{num1 + num2}");

        }
    }
}
