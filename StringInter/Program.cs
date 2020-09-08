using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your first name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string LastName;
            LastName = Console.ReadLine();
            string FullName;
            FullName = Name + " " + LastName;
            //Console.WriteLine("Hello, " + FullName);
            Console.WriteLine($"Hello, {Name} {LastName}");
        }
    }
}
