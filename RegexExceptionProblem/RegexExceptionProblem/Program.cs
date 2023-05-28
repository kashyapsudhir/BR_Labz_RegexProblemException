
using System;


namespace RegexExceptionProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Exception Problem user registration");

            Console.WriteLine("Enter your Phone number  UC4, CheckNumber valid or not");


            //Console.WriteLine("Enter your Last Name, Check valid or not");
            //string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            //create object of RegexClass
            //regexClass.ValidFirstName(TakeName);

            //UC2


            //string TakeLastName = Console.ReadLine();
            //regexClass.ValidLastName(TakeLastName);


            //string Email = Console.ReadLine();
            //regexClass.ValidEmail(Email);

            string TakeNumber = Console.ReadLine();
            regexClass.CheckPhoneNumber(TakeNumber);


        }
    }
}