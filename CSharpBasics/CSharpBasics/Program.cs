using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Local Variables and Types
            int x = 0;
            double y = 4.58; // 64-bit  float
            decimal z = 5.001m; // Even more precision

            string s = "string";
            bool b = true;
            b = false;

            // Base class of everything is object
            //  This can be any of these
            object o = s;

            // var type; compiler type inference.
            //  Determines type if possible
            var xyz = "Hello"; // var resolves to string here.
            var b1 = true; // resolves to bool
            // xyz = false; // error since xyz resolved to string. Cannot change

            // Control structures
            // for loops
            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }

            // while
            while(false)
            {

            }

            // do while
            do
            {

            } while (false);

            // if / else
            if(true)
            {

            }
            else if(true)
            {

            }
            else
            {

            }

            // foreach
            List<string> list = new List<string>();
            list.Add("One");
            list.Add("Two");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Object oriented
            //   We have objects that associate data and 
            //    related behavior to represent "entities" / nouns (instances)
            //    create those objects from templates called classes
            //    which define a contrace for those objects at runtime

            // Part of the .NET platform

            // Strongly typed (statically typed)
            // statically typed means, variables are locked
            //  to a certain type at comiple time

            // Unified type system
            //  Primitives (types with value semantics instead of reference semantics)
            //   also inherit from object.

            // Garbage collection based language
            //  "managed" language; memory is managed for youf
            // The run-time is responsible for freeing unused objects 
            //  from memory. This saves development time, fewer bugs
            //  at the cost of some preformance penalty.

            // CSharp is somewhat functional. Not quite first-class 
            // LINQ ( Language-Integraded Query Language)

            //  Asynchronoous programming support with TPL (Task Processing Library)

            // There is also exception handling.
        }
    }
}
