class Box
{
    //! properties
    public double Length { get; set; }
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

    //! method
    public void Print()
    {
        Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}", Length, Breadth, Height);
    }
}