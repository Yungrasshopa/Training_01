using System;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
        // Properties
        public string Name 
        {
            get { return "Bob"; } 
            set { System.Console.WriteLine("Inside property setter");}
        }

        private string _breed;
        // Auto-property
        public string Breed 
        {
            get
            {
                return _breed;
            } 
            set
            {
                if(value != null && value != "")
                {
                    _breed = value;
                }
            }
        }

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

        public void MakeSound()
        {
            Bark();
        }

        public void GoTo(string location)
        {
            // String interpolation syntax
            //  prefix with $ (changes the meaning of {})
            //  inside {} you should give an expression
            //  either string or any other object that ToString 
            //  will be called on
            string output = $"Walking to {location}.";
            System.Console.WriteLine(output);
        }

        // prop snippet (+ propfull)
        public string propstring { get; set; }
        
    }
}
