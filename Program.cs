using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Fibonacci dizisinin kaç terimini görmek istiyorsunuz? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Dizisi:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.ReadLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
