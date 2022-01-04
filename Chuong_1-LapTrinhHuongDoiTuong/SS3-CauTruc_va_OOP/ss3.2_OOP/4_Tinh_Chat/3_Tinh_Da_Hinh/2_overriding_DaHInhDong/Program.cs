using System;

namespace PolymorphismApplication
{
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override int GetArea()
        {
            return Width * Height;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 7);
            Console.WriteLine("Area: {0}", rectangle.GetArea());
            Console.ReadKey();
        }
    }
}