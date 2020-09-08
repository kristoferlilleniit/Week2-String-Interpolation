using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning!");
            Console.WriteLine("Hello, what's your first name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string LastName;
            LastName = Console.ReadLine();
            string FullName;
            FullName = Name + " " + LastName;
            //Console.WriteLine("Hello, " + FullName);
            //Console.WriteLine($"Hello, {Name} {LastName}");
            Console.WriteLine("What's your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            // parsing string to interger (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine($"Hello {FullName}, you are {Age} years old.");
        }
    }
}
