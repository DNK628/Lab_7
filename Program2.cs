using System;
using System.Text;

namespace Lecture8.Example2
{
    class Program
    {
        static void FindMinMax<T>(T[] array, out T min, out T max) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Масив не може бути пустим");

            min = array[0];
            max = array[0];

            foreach (T item in array)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
                if (item.CompareTo(max) > 0)
                    max = item;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.3, 0.7, 4.1 };

            FindMinMax(intArray, out int intMin, out int intMax);
            Console.WriteLine($"int: min={intMin}, max={intMax}");

            FindMinMax(doubleArray, out double doubleMin, out double doubleMax);
            Console.WriteLine($"double: min={doubleMin}, max={doubleMax}");

            Console.ReadKey();
        }
    }
}

