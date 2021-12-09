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
            double sum = 0;
            double x;
            int k;
            switch (name)
            {
                case "for":                   
                    for ( x = -1; x <= 1; x = x + 0.1)
                    {
                        for ( k = 1; k <= 10; k = k + 1)
                        {
                            double t = F(x, k);
                            sum += t;
                            Console.Write($"{Math.Round(t, 4)}\t");
                            //Console.Write("{0},{1} ", x, k);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(sum);
                    break;
                case "while":
                    x = -1;
                    while (x <= 1)
                    {
                        k = 1;
                        while (k <= 10)
                        {
                            double t = F(x, k);
                            sum += t;
                            Console.Write($"{Math.Round(t, 4)}\t");
                            //Console.Write("{0},{1} ", x, k);
                            k = k + 1;
                        }
                        Console.WriteLine();
                        x= x + 0.1;
                    }
                    Console.WriteLine(sum);
                    break;
                case "do-while":
                    x = -1;
                    do
                    {                        
                        k = 1;
                        do
                        {
                            double t = F(x, k);
                            sum += t;
                            Console.Write($"{Math.Round(t, 4)}\t");
                            k = k + 1;
                        }
                        while (k <= 10);
                        Console.WriteLine();
                        x = x + 0.1;
                    }
                    while (x <= 1);
                    Console.WriteLine(sum);
                    break;
            }
        }
    }
}