using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicalProblems
{
    public class StopwatchSimulator
    {
        public void StopwatchProgram()
        {
            Console.Write("Start the Stopwatch.Enter S or s:");
            char ch=Convert.ToChar(Console.Read());
            Stopwatch sw = Stopwatch.StartNew();
            if(ch=='s' || ch=='S')
            {
                sw.Start();
                Console.Write("\nStop the Stopwatch.Enter E or e:");
                char end=Convert.ToChar(Console.Read());
                if (end == 'e' || end == 'E')
                {
                    sw.Stop();
                    Console.WriteLine("\n Time Elapsed:" + sw.Elapsed.TotalSeconds + "seconds");
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }        
}
