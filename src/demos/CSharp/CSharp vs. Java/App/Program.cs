using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoJava();
            Console.ForegroundColor = ConsoleColor.Green;
            DemoCSharp();
        }

        static void DemoJava()
        {
            JavaType first, second;
            first = new JavaType();
            second = new JavaType();
            Console.WriteLine($"First is {first.Count(0)}, and second is {second.Count(0)}");

            SetCountJava(first, 42);
            SetCountJava(second, -5);
        }

        static void SetCountJava(JavaType item, int count)
        {
            item.Count() = count;
        }

        static void DemoCSharp()
        {
            CSharpType first, second;
            first = new CSharpType();
            second = new CSharpType();
            Console.WriteLine($"First is {first.Count}, and second is {second.Count}");

            SetCountCSharp(first, 42);
            SetCountCSharp(second, -5);
        }

        static void SetCountCSharp(CSharpType item, int count)
        {
            item.Count = count; //Change the value
        }

    }
}
