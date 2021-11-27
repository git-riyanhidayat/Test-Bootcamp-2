using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input awal tahun : ");
            int awal = int.Parse(Console.ReadLine());
            Console.Write("Input tahun terakhir: ");
            int akhir = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = awal + 1; i <= akhir; i++)
            {
                sum = sum + i;
                if (i % 4 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.ReadLine();
        }
    }
}
