using System;

namespace InheritanceApplication
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    // Derived class
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Rectangle
    {
        public bool IsSquare()
        {
            if (Width == Height) return true;
            else return false;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Width = 5;
            rectangle.Height = 7;

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", rectangle.GetArea());

            //! Create a square... this square have all field and method of Rectangle and Shape Class!
            Square square = new Square();
            square.Width = 9;
            square.Height = 9;
            Console.WriteLine("Total area: {0}", square.GetArea());
            Console.WriteLine("Check is Square: {0}", square.IsSquare());
            Console.ReadKey();
        }
    }
}