

namespace Assignment06_oop
{
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }

    }

    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing .");
            base.Work();
        }
    }
}
