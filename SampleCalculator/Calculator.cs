using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Choose from operations: 1.Add 2. Sub 3.Mult 4.Div \nOption: ");
            int choice = 0;
            try {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Environment.Exit(1); // used to sys.exit()
            }
            double[] num = new double[2];
            try
            {
                for (int i = 1; i <= 2; i++)
                {
                    Console.Write("Enter num" + i + ": ");
                    num[i - 1] = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (Exception e){
                Console.WriteLine("Error: ", e.Message);
                Environment.Exit(1); // used to sys.exit()
            }
            // To display type of variable
            //Console.WriteLine(num[0].GetType());

            // Included limiting decimal places
           
            if (choice == 1)
            {
                Console.WriteLine("Answer: " + Math.Round(num[0] + num[1], 3));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Answer: " + Math.Round(num[0] - num[1], 3));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Answer: " + Math.Round(num[0] * num[1], 3));
            }
            else if (choice == 4)
            {
                Console.WriteLine("Answer: " + Math.Round(num[0] / num[1], 3));
            }
            else {
                Console.WriteLine("Incorrect option");
            }
        }
    }
}
