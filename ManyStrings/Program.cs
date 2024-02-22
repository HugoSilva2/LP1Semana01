using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formating strings
            double xx = 1.23456;
            int ii = 19;

            //Real with 2 decimal
            Console.WriteLine($"{xx}= {xx:f2}");
            //Percentage with 1 decimal
            Console.WriteLine($"{xx} = {xx:p1}");
            //Hexadecimal
            Console.WriteLine($"{ii} = {ii:x}");
            //Currency
            Console.WriteLine($"{ii} = {ii:c}");


            //Strings

            string frase1 = "Damn, what a nice string I am!\n";
            string frase2 = "Oh! I didn't noticed you there!\n";
            string frase3 = "HA!\tHA!\tHA!\tHA!";
            Console.WriteLine(frase1);
            Console.WriteLine(frase2);
            Console.WriteLine(frase3);

            //Concatenated strings

            string frase4 = "I" + "Love" + "Programming.";
            string frase5 = "Number" + 69;
            Console.WriteLine(frase4);
            Console.WriteLine(frase5);

            //Interpolated strings
            string frase6 = $"The first phrase was: {frase1}";
            string frase7 = $"And now... I'll laugh: {frase3}";
            Console.WriteLine(frase6);
            Console.WriteLine(frase7);
        }
    }
}
