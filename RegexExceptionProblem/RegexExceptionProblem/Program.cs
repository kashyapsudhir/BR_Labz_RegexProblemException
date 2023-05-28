
using System;


namespace RegexExceptionProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Exception Problem user registration");

            Console.WriteLine("hello regex problem UC-1 first name");

            Console.WriteLine("Enter your First Name, Check valid or not");
            string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            regexClass.ValidFirstName(TakeName);


        }
    }
}