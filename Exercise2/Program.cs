using System;

namespace Exercise2
{
    class Program
    {
        static double Function(double x, double k)
        {

            double f = 1/(Math.Pow(k,2)+Math.Cbrt(x*k));
            return f;
        }
        static void Main(string[] args)

        {

            double x = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            double multi = 1;

            for (int k = 1; k <= 10; k++)
            {
                double f = Function(x, k);
                //Console.WriteLine(f);
                sum = sum + f;
                multi = multi * f;
                //Console.WriteLine();
            }
            Console.WriteLine("Сумма ряда:");
            Console.WriteLine(sum);
            Console.WriteLine("Произведение ряда:");
            Console.WriteLine(multi);
            // Console.WriteLine("Произведение ряда:");

            //sum = 1;
            // for (int k = 1; k <= 10; k++)
            {
                // double f = Function(x, k);
                // Console.WriteLine(f);
                //  sum = sum * f;
                // Console.WriteLine();
            }
            //Console.WriteLine(sum);
        }

    }
}