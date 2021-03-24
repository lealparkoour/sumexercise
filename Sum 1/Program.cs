using System;

namespace Sum_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n ;
            Console.Write("enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(recurSum(n));



        }
         static int recurSum(int n)
        {
            if (n <= 1)
                return n;
            return n + recurSum(n - 1);
        }
    }
}
