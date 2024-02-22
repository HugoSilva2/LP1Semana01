﻿using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer Variables
            int num1 = 420 ;
            int num2 = 0x20 ;
            uint num3 = 0x69U ;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            //Character Variables
            char sharps = '\u1E9E';
            char omega = '\u03A9';
            char star = '\u2721';

            Console.WriteLine(sharps);
            Console.WriteLine(omega);
            Console.WriteLine(star);

        }
    }
}
