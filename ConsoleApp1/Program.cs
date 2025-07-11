using Assignment06_oop;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            #region q1: Write a class named Calculator that contains a method named Add. Overload the Add method to:

            //Calculator calc = new Calculator();


            //Console.WriteLine(calc.Add(5,4));
            //Console.WriteLine(calc.Add(5, 4, 3));
            //Console.WriteLine(calc.Add(5.5, 4.0));

            #endregion


            #region q2: Create a class named Rectangle with the following constructors:


            //Rectangle rectangle = new Rectangle();

            //Rectangle rectangle1 = new Rectangle(5, 10);

            //Rectangle rectangle2 = new Rectangle(7);

            //Console.WriteLine(rectangle);
            //Console.WriteLine(rectangle1);
            //Console.WriteLine(rectangle2);



            #endregion


            #region q3: Define a class Complex Number that represents a complex number with real and imaginary parts. *Note: Overload the +, - operator to add and subtract two complex numbers.


            //ComplexNumber c1 = new ComplexNumber(8, 4);
            //ComplexNumber c2 = new ComplexNumber(3, -2);

            //ComplexNumber sum = c1 + c2;
            //ComplexNumber diff= c1 - c2;

            //Console.WriteLine($"c1 : {c1}");
            //Console.WriteLine($"c2 : {c2}");
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {diff}");
            #endregion


            #region q4: a) Create a base class named Employee with method That Work as it prints    "Employee is  working". b) Create a derived class named Manager that overrides the Work method to print "Manager is managing".

            //Employee employee = new Employee();
            //employee.Work();

            //Manager manager = new Manager();
            //manager.Work();

            #endregion


            #region q5: a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass". b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword. Then explain the difference between using override and new (using binding behavior)

            //BaseClass baseClass = new BaseClass();  
            //baseClass.DisplayMessage();


            //BaseClass derivedClass1 = new DerivedClass1();
            //derivedClass1.DisplayMessage(); 


            //BaseClass derivedClass2 = new DerivedClass2();
            //derivedClass2.DisplayMessage();
            #endregion


            #region q6: Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            //Duration d = new Duration(3, 55, 20);
            //d.Display();
            #endregion


            #region q7: -Override All System. Object Members [To String(), Equals(),GetHashCode() ] .


            Duration d1 = new Duration(1, 30, 25);
            Duration d2 = new Duration(1, 30, 25);
            Duration d3 = new Duration(6, 0, 0);



            Console.WriteLine(d1.ToString());           
            Console.WriteLine(d1.Equals(d2));           
            Console.WriteLine(d1.Equals(d3));           
            Console.WriteLine(d1.GetHashCode() == d2.GetHashCode());
            #endregion

        }
    } 
}
