using System;

class fizzbuzz
{

    public static void Main()
    {
        Console.Write("Input : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
                Console.Write("FizzBuzz" + " ");

            else if (i % 3 == 0)
                Console.Write("Fizz" + " ");

            else if (i % 5 == 0)
                Console.Write("Buzz" + " ");
            else
                Console.Write(i + " ");
        }
    }
}
