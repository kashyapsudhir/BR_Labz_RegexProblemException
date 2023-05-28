
using System;


namespace RegexExceptionProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Exception Problem user registration");

            Console.WriteLine("hello regex problem UC-2 Last Name");

            Console.WriteLine("Enter your Last Name, Check valid or not");
            //string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();//create object of RegexClass
            //regexClass.ValidFirstName(TakeName);

            //UC2
            string TakeLastName = Console.ReadLine();
            regexClass.ValidLastName(TakeLastName);


        }
    }
}