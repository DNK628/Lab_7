namespace Lecture8.Example1
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine($"int: a={a}, b={b}");

            double x = 1.5;
            double y = 2.5;
            Swap(ref x, ref y);
            Console.WriteLine($"double: x={x}, y={y}");

            string str1 = "Hello";
            string str2 = "World";
            Swap(ref str1, ref str2);
            Console.WriteLine($"string: str1={str1}, str2={str2}");

            Console.ReadKey();
        }
    }
}

