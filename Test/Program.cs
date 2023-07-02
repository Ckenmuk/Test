using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decode(0) = " + (Decode("0"))); // 0
            Console.WriteLine("Decode(123) = " + (Decode("123"))); // 123
            Console.WriteLine("Decode(1.23) = " + (Decode("1.23"))); // 123
            Console.WriteLine("Decode(1...2..3) = " + (Decode("1...2..3"))); //123
            Console.WriteLine("Decode(1010) = " + (Decode("1010"))); // 1010
            Console.WriteLine("Decode(1025) = " + (Decode("1025"))); // 1
            Console.WriteLine("Decode(1..02.6) = " + (Decode("1..02.6"))); // 2


        }

        private static string Decode(string a)
        {
            a = a.Replace(".", "");

            int b = int.Parse(a);

                return (b % 1024).ToString();
        }
    }
}
