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

                SecretMessage(input);

                //BilanganJumlah(input);

                Console.WriteLine("\n==============");
                Console.Write("Ulang ? [Y/N] ");
                repeat = Console.ReadLine();
            }
            while (repeat == "Y" || repeat == "y");
            
        }

        private static void SecretMessage(string message)
        {
            int i, j, square, n;
            char[,] matriks = new char[10, 10];
            char[,] transpose = new char[10, 10];

            square = Convert.ToInt32(Math.Ceiling(Math.Sqrt(message.Length)));

            n = Convert.ToInt32(Math.Pow(square, 2)) - message.Length;

            string star = message;

            for (int p = 0; p < n; p++)
            {
                star = star.Insert(star.Length, "*");
            }

            char[] text = star.ToCharArray();

            for (i = 0; i < square; i++)
            {
                for (j = 0; j < square; j++)
                {
                    if (i == 0 && j <= square - 1)
                    {
                        matriks[i, j] = text[(i * j) + j];
                    }
                    else if (i != 0)
                    {
                        matriks[i, j] = text[(i * square) + j];
                    }
                }
            }

            //Console.WriteLine("\nMatriks: ");
            //for (i = 0; i < square; i++)
            //{
            //    for (j = 0; j < square; j++)
            //    {
            //        Console.Write(matriks[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            for (i = 0; i < square; i++)
            {
                for (j = 0; j < square; j++)
                {
                    transpose[i, j] = matriks[(square - 1) - j, i];
                }
            }

            //Console.WriteLine("\nHasil Transpose Matriks: ");
            //for (i = 0; i < square; i++)
            //{
            //    for (j = 0; j < square; j++)
            //    {
            //        Console.Write(transpose[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            for (i = 0; i < square; i++)
            {
                for (j = 0; j < square; j++)
                {
                    if (transpose[i, j] != '*')
                    {
                        Console.Write(transpose[i, j]);
                    }
                }
            }
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
