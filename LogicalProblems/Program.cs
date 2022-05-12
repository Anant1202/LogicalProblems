using System;

namespace LogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problem Programs");
            Console.WriteLine("Enter an option");
            int option = Convert.ToInt32(Console.ReadLine());
            while (option<6)
            {
                switch (option)
                {
                    case 1:
                        FibonacciSeries ob1 = new FibonacciSeries();
                        ob1.CalculatingSeries();
                        return;
                    case 2:
                        PerfectNumber ob2 = new PerfectNumber();
                        ob2.CalculatingSum();
                        return;
                    case 3:
                        PrimeNumber ob4 = new PrimeNumber();
                        ob4.CheckingPrimeOrNot();
                        return;
                    case 4:
                        ReverseNumber ob3 = new ReverseNumber();
                        ob3.Reverse();
                        return;
                    case 5:
                        Stopwatch ob5 = new Stopwatch();
                        ob5.StopwatchProgram();
                        return;
                    default:
                        Console.WriteLine("Enter value between 1 to 6");
                        return;
                }
            }
        }
    }
}
