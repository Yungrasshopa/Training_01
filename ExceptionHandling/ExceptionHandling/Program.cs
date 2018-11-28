using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions are objects and defined by classes like anything else

            // Segment of code to try and handle an exception from
            try
            {
                BadCode();


                var x = 5;
                var y = x / 0;

                Console.WriteLine("This line never prints because there is an exception");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divided by zero, moving on.");
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("Handled bad cast.");
                // throw new DivideByZeroException();
                //  How to throw exception
                // throw; by itself throws current exceptino
                //  only works inside catch
            }
            // Finally?


            Console.WriteLine("Program continues...");
        }

        static void BadCode()
        {
            try
            {
                object o = true;
                string s = (string)o;
            }
            catch(DivideByZeroException e)
            {
                // Not handling the correct exception so it will
                //  propagate up the call sate to main
                //  and eventually crash the app if never handled
                Console.WriteLine("Won't print because this isn't a divid by zero.");
            }
        }

    }
}
