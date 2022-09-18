using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("请输入一个值给a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个值给b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个值给c");
            c = Convert.ToDouble(Console.ReadLine());
            if (a + b <= c || a + c <= b || b + c <= a) Console.WriteLine("不构成三角形");
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("可以构成三角形");
                if (a == b && b == c) Console.WriteLine("构成等边三角形");
                if (a == b || a == c || b == c) Console.WriteLine("构成等腰三角形");
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) Console.WriteLine("构成直角三角形");
            }
            Console.Read();
        }
    }
}