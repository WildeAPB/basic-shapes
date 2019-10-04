using System;
using System.Threading;

namespace basic_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Welcome to the Rectangle Area Getter");
            Console.WriteLine("------------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine("Rectangle of width 34 & height 25. Area = {0}", AreaCalculator.GetArea(34, 35));
            Thread.Sleep(1000);
            Console.WriteLine("Rectangle of width 10 & height 5. Area = {0}", AreaCalculator.GetArea(10, 5));
            Thread.Sleep(1000);
            Console.WriteLine("Rectangle of width 15 & height 30. Area = {0}", AreaCalculator.GetArea(15, 30));
            Thread.Sleep(1000);
            Console.WriteLine("------------------------------------");
            while(true)
            {
                Console.WriteLine("Please enter your own width and height to calculate an area.");
                Console.WriteLine("Width: ");
                Console.WriteLine("Height: ");
                Console.WriteLine("Area: ");
                Console.WriteLine("------------------------------------");
                int cursorTop = Console.CursorTop;
                Console.SetCursorPosition(7, (cursorTop - 4));
                int.TryParse(Console.ReadLine(), out int userWidth);
                Console.SetCursorPosition(8, (cursorTop - 3));
                int.TryParse(Console.ReadLine(), out int userHeight);
                Console.SetCursorPosition(6, (cursorTop - 2));
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write(AreaCalculator.GetArea(userHeight, userWidth));
                Console.ForegroundColor = System.ConsoleColor.Gray;
                Console.SetCursorPosition(0, cursorTop);
            }
            
        }
    }

    class ShapeInput
    {

    }

    class AreaCalculator
    {
        public static int GetArea(int length, int width)
        {
            return (length * width);
        }
    }
}
