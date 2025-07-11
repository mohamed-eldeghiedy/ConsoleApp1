namespace Assignment06_oop
{
    public class Calculator()
    {

        public int Add(int a, int b)
        {
            return a + b;
        }


        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }


        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public Rectangle(int size)
        {
            Width = size;
            Length = size;
        }
        
        public override string ToString()
        {
            return $"Rectangle(Width={Width}, Height={Length})";
        }
    }

}
