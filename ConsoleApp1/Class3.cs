

namespace Assignment06_oop
{
    public class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message From BaseClass");

        }
    }

    public class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message From DerivedClass (override)");
    
        }
    }

    public class DerivedClass2 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message From DerivedClass2 (new)");
            
        }
    }
}   
