using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment2
{
    // Simple print menu class
    class UserInterface
    {
        // Prints menu and reads line, returns string as option
        public string PrintMenu()
        {
            Console.WriteLine("Enter 1 to solve maze" + Environment.NewLine + "Enter 2 to solve transposed maze");
            string option = Console.ReadLine();
            return option;
        }
    }
}
