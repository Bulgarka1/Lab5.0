using System;

namespace Exercise1
{
    class Program
    {
        static double F(double x, int k)
        {
            return 1 / (Math.Pow(k, 2) + Math.Pow(x * k, 1 / 3));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите цикл: for, while,do-while");
            string name = Console.ReadLine();
            switch (name)
            {
                case "for":

                    for (double x = -1; x <= 1; x = x + 0.1)
                    {
                        for (int k = 1; k <= 10; k = k + 1)

                        {
                           double t = F(x, k);
                           Console.Write($"{Math.Round(t, 4)}\t");
                        }
                    }
                    break;

                case "while":
                    int b = 1;
                    while (b < 11)
                    {
                        double a = -1;
                        while (a < 2)
                        {
                            double t = F(a, b);
                            Console.Write($"{Math.Round(t, 4)}\t");
                            a = a + 0.1;

                        }
                        Console.WriteLine();
                        b++;
                    }
                    break;

                case "do-while":
                    int m = 1;
                    do
                    {
                        
                        double n = -1;
                        do
                        {
                            double t = F(n, m);
                            Console.Write($"{Math.Round(t, 4)}\t");
                            n = n + 0.1;
                        }

                        while (n < 2);
                        Console.WriteLine();
                        m++;
                    }
                    while (m < 11);
                    break;

            }
        }
    }
}