using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало числового диапазона:");
            double from = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конец числового диапазона:");
            double to = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(from, to);

            Console.WriteLine($"Длина числового диапазона: {range.GetLength()}");
            Console.WriteLine($"Число принадлежит данному диапазону (true/false): {range.IsInside(number)}");
        }
    }
}
