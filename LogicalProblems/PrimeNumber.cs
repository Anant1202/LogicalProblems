using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumber
    {
        public void CheckingPrimeOrNot()
        {
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<n/2;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Not a Prime Number");
                    break;
                }
                else
                {
                    Console.WriteLine("It is a Prime Number");
                    break;
                }
            }
        }
    }
}
