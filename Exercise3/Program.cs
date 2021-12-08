using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите число");
                int x = Convert.ToInt32(Console.ReadLine());

                double R = x / 10.0;
                int i = 0;
                while (R >= 1)
                {
                    i++;
                    R = R / 10.0;

                }
                i = i + 1;

                if (i < 6)
                {
                    for (R = 0; R < (5 - i); R++)
                    {
                        Console.Write('0');
                    }
                    Console.Write(x);
                }
            }
        }
    }
}
//7.Ввести число.Если количество его разрядов меньше пяти, то вывести его на экран,
//дописав нули перед числом так, чтобы в итоге получилось пять знаков.
//Если количество разрядов больше пяти, то вывести только первые пять разрядов. Если число пятизначное, то вывести его как есть.