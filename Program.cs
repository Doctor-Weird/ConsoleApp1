using System;

namespace test
{
    class BaseClass 
    {
        public BaseClass()
        {
            Console.WriteLine("BaseType Default Constructor");
        }
        public BaseClass(int i)
        {
            Console.WriteLine($"BaseType Non-Default Constructor:parameter 1,{i}");
        }
    }
    class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Default Constructor");
        }
        public DerivedClass(int i,int j):base(i)
        {
            Console.WriteLine($"DerivedClass Non-Default Constructor:parameter 1,{i};parameter 2,{j}");
        }
    }
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass(2, 3);
            Console.ReadKey();
        }
    }
}