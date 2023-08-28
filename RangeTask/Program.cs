using System;

namespace RangeTask
{
    class Program
    {
        public static void Print(Range[] range)
        {
            foreach (Range e in range)
            {
                if (range == null)
                {
                    Console.WriteLine("[]");
                }

                Console.Write("[" + e.ToString() + "]");
            }
        }

        static void Main(string[] args)
        {
            // часть 1
            Console.WriteLine("Часть 1");
            Console.WriteLine("Введите начало числового диапазона:");
            double from = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конец числового диапазона:");
            double to = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(from, to);

            Console.WriteLine($"Длина числового диапазона: {range.GetLength()}");
            Console.WriteLine($"Число принадлежит данному диапазону (true/false): {range.IsInside(number)}" + Environment.NewLine);

            // часть 2
            Console.WriteLine("Часть 2");
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

            // ищем интервал пересечения
            Range intersection = range1.GetIntersection(range2);

            if (intersection == null)
            {
                Console.WriteLine("Пересечения нет.");
            }
            else
            {
                Console.WriteLine("Интервал пересечения: " + intersection.ToString());
            }

            // ищем интервал(ы) объединения
            Range[] union = range1.GetUnion(range2);

            Console.Write($"Интервал объединения: ");
            Print(union);

            Console.WriteLine();

            // ищем разность интервалов
            Range[] difference = range1.GetDifference(range2);

            Console.Write("Интервал разности: ");
            if (difference.Length == 0)
            {
                Console.WriteLine("Разности нет.");
            }
            else
            {
                Print(difference);
            }

            Console.WriteLine();
        }
    }
}
