using System;

namespace _1_Z
{
    class Program
    {
        /// <summary>
        /// Делегат вызывающий методы Get_Length, Get_Area, Get_Volume
        /// </summary>
        public delegate double CalcFigure(double R);
        /// <summary>
        /// Вычисляет длину окружности
        /// </summary>
        /// <param name="r">Радиус который вводит пользователь</param>
        /// <returns>длина окружности</returns>
        static double Get_Length(double r)
        {
            double D;
            D = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности = {0}",Math.Round(D, 3));
            return D;
        }
        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <param name="r">Радиус который вводит пользователь</param>
        /// <returns>площадь круга</returns>
        static double Get_Area(double r)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга = {0}", Math.Round(S, 3));
            return S;
        }
        /// <summary>
        /// Вычисляет объём шара
        /// </summary>
        /// <param name="r">Радиус который вводит пользователь</param>
        /// <returns>Объём шара</returns>
        static double Get_Volume(double r)
        {
            double V;
            V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("Объём шара = {0}",Math.Round(V, 3));
            return V;
        }
        public static void Zadan2(CalcFigure a)
        {
            Console.Write("Введите радиус- ");
            double rd = Convert.ToDouble(Console.ReadLine());
            a(rd);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус- ");
            double rad = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            CF += Get_Area;
            CF += Get_Volume;          
            CF(rad);
            Console.WriteLine("Задание");
            Zadan2(CF);
            Console.ReadLine();
        }
    }
}
