using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text
            Console.WriteLine("Insert 4 integers:");
            //Input1
            string s1 = Console.ReadLine();
            int num1 = int.Parse(s1);
            //Input2
            string s2 = Console.ReadLine();
            int num2 = int.Parse(s2);
            //Input3
            string s3 = Console.ReadLine();
            int num3 = int.Parse(s3);
            //Input4
            string s4 = Console.ReadLine();
            int num4 = int.Parse(s4);
            
            //print of everything
            Console.WriteLine($"{num1,6:d}  {num1,6:X}");
            Console.WriteLine($"{num2,6:d}  {num2,6:X}");
            Console.WriteLine($"{num3,6:d}  {num3,6:X}");
            Console.WriteLine($"{num4,6:d}  {num4,6:X}");

        }
    }
}
