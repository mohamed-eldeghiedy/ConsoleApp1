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


    public class ComplexNumber
    {

        public double Real { get; set; }
        public double Imaginary { get; set; }      

        public ComplexNumber ( double real=0 , double imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }


        public override string ToString()
        {
            return $"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
        }


    }


}
