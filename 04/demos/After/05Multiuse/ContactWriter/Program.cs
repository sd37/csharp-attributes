using System;
using static System.Console;

namespace ContactWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact sarah = new Contact
            {
                FirstName = "Sarah",
                AgeInYears = 42
            };

            var sarahWriter = new ContactConsoleWriter(sarah);

            sarahWriter.Write();

            WriteLine("\n\nHit enter to exit...");
            ReadLine();
        }
    }
}
