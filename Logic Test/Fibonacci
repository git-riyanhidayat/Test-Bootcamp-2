using System;

class NearestFibonacci
{

    // Fungsi untuk mencari Fibonacci
    // angka yang paling dekat dengan N
    static void nearestFibonacci(int num)
    {
    
        if (num == 0)
        {
            Console.Write(0);
            return;
        }

        // Inisialisasi yang pertama & kedua
        // suku deret Fibonacci
        int first = 0, second = 1;
        int third = first + second;


        while (third <= num)
        {

            // pertama
            first = second;

            // kedua
            second = third;

            // ketiga
            third = first + second;
        }
        // Simpan angka Fibonacci
        // memiliki perbedaan yang lebih kecil dengan N
        int ans = (Math.Abs(third - num) >=
                Math.Abs(second - num)) ?
                        second : third;

        Console.Write(ans);
    }
    public static void Main(string[] args)
    {
        Console.Write("Input : ");
        int N = int.Parse(Console.ReadLine());
        nearestFibonacci(N);
    }
}

