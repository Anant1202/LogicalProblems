using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int remainder,reverse=0;
            Console.WriteLine("Enter a number to reverse");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n=n/10;
            }
            Console.WriteLine("Reversed Number:"+reverse);
        }
    }
}
