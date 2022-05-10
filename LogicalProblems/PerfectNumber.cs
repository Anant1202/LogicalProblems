using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void CalculatingSum()
        {
            int sum = 0;
            Console.WriteLine("Enter a number to check whether it is Perfect Number or not");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    sum += i;
                    Console.Write(i+" " );
                }
            }
            Console.WriteLine(" Sum= "+sum);
        }
    }
}
