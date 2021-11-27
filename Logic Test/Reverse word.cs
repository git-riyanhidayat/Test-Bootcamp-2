using System;

namespace Logictest
{
    class MainClass
    {
        static string reversString(string str)
        { 
        char[] letters = str.ToCharArray();
                Array.Reverse(letters);
                return new string(letters);
            }

            static void Main(string[] args)
            {

                string str;

                Console.WriteLine(" \n Logic Test Palindrome \n");
                Console.Write("Masukkan kata : ");
                str = Console.ReadLine();

                Console.WriteLine("***************************");
                Console.Write(reversString(str));

                Console.ReadLine();
            }

    }
}

