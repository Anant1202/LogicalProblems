using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class TemperatureConversion
    {
        public void Temp()
        {
            //Getting Celsius and Fahrenheit value in double so that it can take decimal values
            Console.WriteLine("Enter Temperature value for Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Temperature value for Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            //Converting Celsius to Fahrenheit
            double celToFah = (celsius * 9 / 5) + 32;

            //Converting Fahrenheit to Celsius
            double fahToCel = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("After Convertion from Celsius to Fahrenheit : {0}",celToFah);
            Console.WriteLine("After Convertion from Fahrenheit to celsius : {0}", fahToCel);
        }
    }
}
