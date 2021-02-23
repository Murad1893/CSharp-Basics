using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class Program
    {

        static string func(string name) { return "Hello " + name; }

        static void Main(string[] args)
        {
            // Ctrl + F5 shortcut to run, only F5 to debug

            // Strings

            //Reversing a string
            string s = "Murad";
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(new string(c));

            // strings also support indexing
            // taking out substring
            Console.WriteLine(s.Substring(1,3));

            // divide operation
            Console.WriteLine(5/2);
            Console.WriteLine(5/2.0);

            // increment operators ++ and -- supported same as java, c
            int i = 9;
            Console.WriteLine(i++ + " " + ++i);

            // Using math library
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3,2)); // 3 ^ 2
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4,90)); // supports only 2 nums. Same goes for Math.Min()
            Console.WriteLine(Math.Round(4.6) + " " + Math.Round(4.5));

            // Taking user input
            Console.Write("\nEnter something: "); // we used write instead of writeline
            string input = Console.ReadLine();
            Console.WriteLine("Input: " + input);

            Console.WriteLine("Func output: " + func(input));

            // 2d arrays
            int[,] arr = new int[2, 2];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 3;
            arr[1, 1] = 4;

            Console.WriteLine("\nLength of arr: " + arr.Length);
            Console.WriteLine("\nDimensions of arr: " + arr.GetLength(0) + ", " + arr.GetLength(1));
            
            // special function instead of arr.Length we use arr.GetLength
            for (i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
