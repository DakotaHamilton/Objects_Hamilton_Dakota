using System;

namespace Objects_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Apple", "All-in-One", true); // Prints true to the Console
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true); // Prints False to the Console
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!"; // String Converted to Upper

            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);


            Console.WriteLine(myString == myComputer.ToString()); // Returns a String of the represented current myComputer Object
            Console.WriteLine(myString == myOtherComputer.ToString()); // Returns a String of the represented current myOtherComputer Object

            Console.WriteLine(myComputer.GetType()); // Gets the Computer Type
            Console.WriteLine(myBootUp.GetType()); // Gets the Computer BootUp

            myOtherComputer.PowerOnOff(); // Prints The Shutting Down Message to the Console

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i')); // Checks for whether the specified Character is in that string 
            Console.WriteLine(myString.ToUpper()); // Returns a copy of its string to Upper
        }
    }
}
