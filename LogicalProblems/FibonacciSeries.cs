using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class FibonacciSeries
    {
        public void CalculatingSeries()
        {
            int first = 0, second = 1,third;
            Console.WriteLine("Enter a number till which you want Fibonacci Series");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FibonacciSeries:" + first);
            Console.WriteLine(second);
            for(int i=0; i<(num-2); i++)
            {
                third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }
        }
    }
}
