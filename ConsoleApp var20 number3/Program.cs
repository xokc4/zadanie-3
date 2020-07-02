using System;

namespace ConsoleApp_var20_zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double p;
            Console.Write("Введите число банков: ");
            X = Int16.Parse(Console.ReadLine());
            Console.Write("Введите риск банкротства, разделитель дробной части - запятая: ");
            p = Double.Parse(Console.ReadLine());
            double[] riskList = new double[X + 1];
            for (int i = 1; i <= X; ++i)
            {
                riskList[i] = (factorial(X) / (factorial(i) * factorial(X - i) * 1.0)) * Math.Pow((1 - p), (X - i)) * Math.Pow((p), i);
            }

            for (int i = 0; i <= X; ++i)
            {
                Console.WriteLine("Xi = {0} Pi = {1:0.####}", i, riskList[i]);
            }

        }

        static int factorial(int n)
        {
            int fact = 1;   

            for (int i = 2; i <= n; i++) 
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
