namespace Animals.Library
{
    public interface IAnimal
    {
        // An interface is a contract that a class has to follow
        //  specifying some methods it needs to have, with their
        //  argument  types and return type.

        // No implementation possible in interfaces
        // No data or fields
        // Just method names, arguments, and return type

        // No backing field or auto-implementation
        //  this is just method any IAnimal class must have 
        //  a Name property
        string Name {get; set;}

        void MakeSound();

        void GoTo(string location);

        // Every interface memeber must have the access modifier
        //  of the whole interface

    }
}