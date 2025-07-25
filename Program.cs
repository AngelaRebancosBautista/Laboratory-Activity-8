using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboaratory_Activity_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "your_input_here";

            if (int.TryParse(input, out int numericValue))
            {
                int result = numericValue + 10;
                Console.WriteLine($"Result after adding 10: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter a string containing only digits.");
            }
        }
    }
}
            
        
    
 

