using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;

            do
            {
                Console.Write("Masukkan input : ");
                string input = Console.ReadLine();

                Console.WriteLine("=== OUTPUT ===");

                BilanganJumlah(input);

                Console.WriteLine("===============");
                Console.Write("Ulang ? [Y/N] ");
                repeat = Console.ReadLine();
            }
            while (repeat == "Y" || repeat == "y");
            
        }

        private static void BilanganJumlah(string input)
        {
            int angka = Convert.ToInt32(input);
            int hasil;

            for (int i = angka; i >= 1; i--)
            {
                hasil = i;

                if (hasil == angka)
                {
                    Console.WriteLine(i);
                }

                for (int j = i; j >= 1; j--)
                {
                    hasil = i + j;

                    if (hasil == angka)
                    {
                        Console.WriteLine("{0},{1}", i, j);
                    }

                    for (int k = j; k >= 1; k--)
                    {
                        hasil = i + j + k;

                        if (hasil == angka)
                        {
                            Console.WriteLine("{0},{1},{2}", i, j, k);
                        }

                        for (int l = k; l >= 1; l--)
                        {
                            hasil = i + j + k + l;

                            if (hasil == angka)
                            {
                                Console.WriteLine("{0},{1},{2},{3}", i, j, k, l);
                            }

                            for (int m = l; m >= 1; m--)
                            {
                                hasil = i + j + k + l + m;

                                if (hasil == angka)
                                {
                                    Console.WriteLine("{0},{1},{2},{3},{4}", i, j, k, l, m);
                                }

                            }

                        }
                    }
                }
            }
        }
    }
}
