using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Массив коэфиициентов четного полинома Вандермонда.
            double[] V = new double[]
            { +1, -0.1666666664, +0.0083333315, -0.0001984090, +0.0000027526, -0.0000000239 };

            double z = 190;          // Задаем градусы
            double r = Unam(Radian(z));    // Переводим градусы в радианы.
            double sum = 0;
            for (int i = 0; i < V.Length; i++)
                sum += V[i] * Math.Pow(r, 2 * i);

            Console.WriteLine($"Синус {z} градусов = {sum * r}");
            
            Console.ReadKey();           
        }

        // Функция перевода градусов в радианы
        static double Radian(double z)
        {
            double result = z * Math.PI / 180;
            return result;
        }

        // Функция перевода градусов в область однозначности.
        static double Unam (double z)
        {
            double result = z;
            if (z < -360 || z > 360)
                result = z - 360 * Math.Truncate(z / 360);
            return result;
        }
    }
}
