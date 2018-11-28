using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {

        static void Main(string[] args)
        {
            // Naming conventions in c#:
            //  PascalCase (TitleCase)
            //   for classes, methods, properties, namespaces
            //  CamelCase for local variables
            Dog dog = new Dog();
            dog.Bark();

            Console.WriteLine("Hello World!");
        }
    }
}
