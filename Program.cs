using System;
using CalculatorApi;
namespace OperationUsingApi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Operations");
            Console.Write("Enter Var 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Var 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition: "+Operations.AddFn(a, b));
            Console.WriteLine("Sub: " + Operations.SubFn(a, b));
            Console.ReadKey();
        }
    }
}
