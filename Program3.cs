using System;
using System.Text;

namespace Lecture8.Example3
{
    class GenericCalculator<T> where T : IComparable<T>
    {
        private T value;

        public GenericCalculator(T initialValue)
        {
            value = initialValue;
        }

        public T FindSmaller(T a, T b)
        {
            return a.CompareTo(b) < 0 ? a : b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var calculator = new GenericCalculator<int>(0);
            Console.WriteLine($"Менше з 5 і 10: {calculator.FindSmaller(5, 10)}");

            var doubleCalculator = new GenericCalculator<double>(0.0);
            Console.WriteLine($"Менше з 2.5 і 3.5: {doubleCalculator.FindSmaller(2.5, 3.5)}");

            Console.ReadKey();
        }
    }
}

