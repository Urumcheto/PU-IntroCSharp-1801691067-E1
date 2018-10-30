using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Value1 = rnd.Next(33, 187);
            int Value2 = rnd.Next(33, 187);

            int area = Value1 * Value2;
            Console.WriteLine($"The area is {area:0.00}");
        }
    }
}
