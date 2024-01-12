namespace Practice_task_02_OOP_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();

            Console.WriteLine("\nInheritance - child class inherits parent method:");
            Console.WriteLine($"Child class object calling parent method:");
            child.Print();

            Console.WriteLine("\nStatic polymorphism (method overloading) - methods with same names, in the same class, but with different signatures:");
            StaticPolymorphism s = new StaticPolymorphism();
            Console.WriteLine($"Calling Add method by passing two integers: 1 + 2 = {s.Add(1, 2)}");
            Console.WriteLine($"Calling Add method by passing two strings: a + b = {s.Add("a", "b")}");

            Console.WriteLine("\nDynamic polymorphism (method overriding) - methods with same names and signatures but in different classes:");
            DynamicPolymorphismParent parentD = new DynamicPolymorphismParent();
            DynamicPolymorphismChild childD = new DynamicPolymorphismChild();
            Console.WriteLine($"Calling parent Show method:");
            parentD.Show();  
            Console.WriteLine($"Calling child Show method:");
            childD.Show();


            Console.ReadLine();
        }
    }

    // Abstraction
    public abstract class MobilePhone
    {
        public void Calling() { }
        public void SendSMS() { }
    }

    public class Nokia1400 : MobilePhone
    {
        public void FMRadio() { }
        public void MP3() { }
        public void Camera() { }
    }

    public class BlackBerry : MobilePhone
    {
        public void FMRadio() { }
        public void MP3() { }
        public void Camera() { }
        public void Recording() { }
        public void ReadAndSendEmails() { }
    }

    // Encapsulation
    public class Bank
    {
        private double _amount;

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Please pass a positive value");
                }
                else
                {
                    _amount = value;
                }
            }
        }
    }

    // Inheritance
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent constructor.");
        }
        public void Print()
        {
            Console.WriteLine("Parent print method.");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child constructor.");
        }
    }

    // Polymorphism
    public class StaticPolymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float x, float y)
        {
            return x + y;
        }

        public string Add(string s1, string s2)
        {
            return s1 + s2;
        }
    }

    public class DynamicPolymorphismParent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent class Show method");
        }
    }

    public class DynamicPolymorphismChild : DynamicPolymorphismParent
    {
        public override void Show()
        {
            Console.WriteLine("Child class Show method");
        }
    }
}
