using System;

namespace Animals.Library
{
    public class Dog
    {
        // Properties
        public string Name {get; set;}

        // Auto-property
        public string Breed {get; set;}

        // Property with explicit backing field
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                // keyword value in setter
                //  takes in the assigned value
                _age = value;
            }
        }
        private int Weight;
        // Classic getters and setters
        public int GetWeight()
        {
            return Weight;
        }
        public void SetWeight(int weight)
        {
            Weight = weight;
        }

        public void Bark()
        {
            System.Console.WriteLine("Woof");
        }
        // prop snippet (+ propfull)
        public string propstring { get; set; }
        
    }
}
