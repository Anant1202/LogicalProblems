using System;

namespace LogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Welcome to Logical Problem Programs");
            do
            {
                Console.WriteLine("Enter an option");
                Console.WriteLine("1.Fibonacci Series Program");
                Console.WriteLine("2.Perfect Number Program");
                Console.WriteLine("3.Prime Number Program");
                Console.WriteLine("4.Reverse Number Program");
                Console.WriteLine("5.Stopwatch Program");
                Console.WriteLine("6.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries ob1 = new FibonacciSeries();
                        ob1.CalculatingSeries();
                        break;
                    case 2:
                        PerfectNumber ob2 = new PerfectNumber();
                        ob2.CalculatingSum();
                        break;
                    case 3:
                        PrimeNumber ob4 = new PrimeNumber();
                        ob4.CheckingPrimeOrNot();
                        break;
                    case 4:
                        ReverseNumber ob3 = new ReverseNumber();
                        ob3.Reverse();
                        break;
                    case 5:
                        Stopwatch ob5 = new Stopwatch();
                        ob5.StopwatchProgram();
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Enter value between 1 to 6");
                        break;
                }
            } while (option != 6);
        }
    }
}
