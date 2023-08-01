using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало первого числового диапазона:");
            double from1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конец первого числового диапазона:");
            double to1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите начало первого числового диапазона:");
            double from2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конец первого числового диапазона:");
            double to2 = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(from1, to1);
            Range range2 = new Range(from2, to2);

            // ищем интервал-пересечения
            Range intersectionRange = range1.GetIntersection(range2);

            if (intersectionRange == null)
            {
                Console.WriteLine("Пересечения нет.");
            }
            else
            {
                Console.WriteLine($"Интервал-пересечения: {intersectionRange.From} - {intersectionRange.To}");
            }

            // ищем интервал(ы)-объединения
            Range[] unionRange = range1.GetUnion(range2);

            foreach (Range range in unionRange)
            {
                Console.WriteLine($"Интервал-объединения: {range.From} - {range.To}");
            }

            // ищем разность интервалов
            Range[] differenceRange = range1.GetDifference(range2);

            if (differenceRange.Length == 0)
            {
                Console.WriteLine("Разности нет.");
            }
            else
            {
                foreach (Range range in differenceRange)
                {
                    Console.WriteLine($"Интервал-разность: {range.From} - {range.To}");
                }
            }
        }
    }
}
