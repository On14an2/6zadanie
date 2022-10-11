using System;
using System.Numerics;
using System.Diagnostics;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            while (true)
            {

                Console.WriteLine("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                stopWatch.Start();
                var res = Requiem(n);
                stopWatch.Stop();
                Console.WriteLine("обычный, прошло времени: " + stopWatch.Elapsed);
                stopWatch.Restart();
                var res1 = SimpleFactorial(n);
                stopWatch.Stop();
                Console.WriteLine("рекурсия, прошло времени: " + stopWatch.Elapsed);
                //Console.WriteLine(res);
                //Console.WriteLine(res1);
            }

        }
        static BigInteger Requiem(int x)
        {
            BigInteger result = BigInteger.One;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        static BigInteger SimpleFactorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * SimpleFactorial(--x);
        }      
    }
}
    // рекурсивный факториал имеет меньшую область значений и выполняет вычисление в разы медленнее медленнее
    // икличный факториал более эффективен чем рекурсивный
    // рекурсивный факториал выглядит более простым и удобным чем цикличный