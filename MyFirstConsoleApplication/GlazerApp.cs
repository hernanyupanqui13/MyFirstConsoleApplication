using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class GlazerApp
    {
        // Computes the wood lenght and the glass area needed for a given width and height
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;

            Console.Write("Enter the width: ");
            string widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height: ");
            string heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine();

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

        }
    }
}
