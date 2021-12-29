using System;

namespace BoxApplication
{
    class Box
    {
        //! properties
        private double _length;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public double Breadth { get; set; }
        public double Height { get; set; }

        //! default constructor
        public Box()
        { }

        //! constructor with parameters
        public Box(double length, double breadth, double height)
        {
            Length = length;
            Breadth = breadth;
            Height = height;
        }

        //! methods
        public void Print()
        {
            Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}, private : {3}", Length, Breadth, Height, _length);
        }
    }

    class Boxtester
    {
        static void Main(string[] args)
        {
            //! box1 is an object
            Box box1 = new Box(6.0, 7.0, 5.0);

            box1.Print();
            box1.Length = 5;
            Console.WriteLine("{0}", box1.Length);
            Console.ReadKey();
        }
    }
}