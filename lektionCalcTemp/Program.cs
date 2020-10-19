using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lektionCalcTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare
            string userInput = "";
            double celsius = 0, fahrenheit = 0, kelvin = 0;
            
            //draw menu
            Menu();
            //user input
            Console.Write("Your selection: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Write("Enter Celsius value: ");
                celsius = double.Parse(Console.ReadLine());
                fahrenheit = CeltoFah(celsius);
                Console.Write("Your fahrenheit temperature is: {0} F", fahrenheit);
            }
            if (userInput == "2")
            {
                Console.Write("Enter Fahrenheit value: ");
                fahrenheit = double.Parse(Console.ReadLine());
                celsius = FahtoCel(fahrenheit);
                Console.WriteLine("Your celsius temperature is: {0} C", celsius);
            }
            if (userInput == "3")
            {
                Console.Write("Enter Celsius value: ");
                celsius = double.Parse(Console.ReadLine());
                kelvin = CelToKel(celsius);
                Console.WriteLine("Your kelvin temperature is: {0} K", kelvin);
            }
            if (userInput == "4")
            {
                Console.Write("Enter Kelvin value: ");
                kelvin = double.Parse(Console.ReadLine());
                fahrenheit = KelToFah(kelvin);
                Console.WriteLine("Your fahrenheit temperature is: {0} F", fahrenheit);
            }
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Convert your temperature!                                                  *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("* Select how you want to convert your temperature by typing in number 1 to 4.*");
            Console.WriteLine("* 1. Convert Celsius to Fahrenheit                                           *");
            Console.WriteLine("* 2. Convert Fahrenheit to Celsius                                           *");
            Console.WriteLine("* 3. Convert Celsius to Kelvin                                               *");
            Console.WriteLine("* 4. Convert Kelvin to Fahrenheit                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
        }
        static double CeltoFah (double celsius)
        {
            return 9 * celsius / 5 + 32;
        }
        static double FahtoCel (double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static double CelToKel (double kelvin)
        {
            return kelvin + 273.15;
        }
        static double KelToFah (double kelvin)
        {
            return (kelvin - 273.15) * 9 / 5 + 32;
        }

    }
}
