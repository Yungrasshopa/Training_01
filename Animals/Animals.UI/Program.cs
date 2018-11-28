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

            // Using fields and properties
            // Using getters and setters with private field.
            dog.SetWeight(6);
            System.Console.WriteLine(dog.GetWeight());

            dog.Name = "Fido";
            System.Console.WriteLine(dog.Name);

            dog.Breed = "Golden Retriever";

            dog.GoTo("The park");

            Console.WriteLine("Hello World!");

            // ********

            IAnimal animal = new Dog();
            animal = new Eagle();
            // This is okay since both classes are an IAnimal type
            //  But you are not allowed to do dog/eagle specific
            //  things via this variable

            //animal.Fly(); // Will not work.
            // You can cast objects to specific types
            // Will fail at run-time if object is not the
            //  correctly casted type.
            Eagle e = (Eagle)animal;
            e.Fly();
            
            // Superclass = base class = parent class
            // subclass = derived class = child class


            DisplayName(new Dog());
            DisplayName(new Eagle());


        }
        public static void DisplayName(IAnimal animal)
        {
            Console.WriteLine(animal.Name);
        }
    }
}
