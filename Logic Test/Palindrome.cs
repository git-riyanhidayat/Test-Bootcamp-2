using System;
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringp, rev;
            Console.Write("Input kata : ");
            stringp = Console.ReadLine();
            char[] ch = stringp.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = stringp.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + stringp + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + stringp + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
