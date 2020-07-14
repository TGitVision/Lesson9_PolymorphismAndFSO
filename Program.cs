using System;

namespace Lesson9_PolymorphismAndFSO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson9_PolymorphismAndFSO!");

            PolymorphismMethods polymorphismMethods = new PolymorphismMethods();

            Console.WriteLine($"Add Overload 1 {polymorphismMethods.Add(10, 10)}");

            Console.WriteLine($"Add Overload 2 {polymorphismMethods.Add("The", "Cat")}");

            Console.WriteLine($"Add Overload 3 {polymorphismMethods.Add(10, 10, 10)}");

            PolyChild polyChild = new PolyChild();

            if (polyChild is PolymorphismMethods)
            {
                Console.WriteLine("The polyChild class is also a PolymorphismMethods class.");
            }
        }
    }
}
