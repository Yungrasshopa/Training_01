using System;

namespace Animals.Library
{
    public abstract class ABird : IAnimal
    {
        public abstract string Name {get;set;}
        public void GoTo(string location)
        {
            System.Console.WriteLine($"Flying to {location}.");


        }

        public abstract void MakeSound();

    }
}