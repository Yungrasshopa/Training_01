using System;

namespace Animals.Library
{
    // Can only derive from one class but can
    //  have multiple interfaces
    public class Eagle : ABird
    {
        public override string Name 
        { 
            get;
            set;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Caw");
        }

        public void Fly()
        {
            System.Console.WriteLine("Flying...");
        }
    }
}