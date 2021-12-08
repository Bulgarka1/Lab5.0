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
            Console.WriteLine("Сумма ряда:");
            for (int k = 1; k < 10; k++)
            {
                double f = Function(x, k);
                //Console.WriteLine(f);
                sum += f;

                //Console.WriteLine();


            }
            Console.WriteLine(sum);
            Console.WriteLine("Произведение ряда:");


            for (int k = 1; k < 10; k++)
            {
                double f = Function(x, k);
                // Console.WriteLine(f);
                sum *= f;

                // Console.WriteLine();


            }
            Console.WriteLine(sum);
        }

    }
}