
using System;


namespace RegexExceptionProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regex Exception Problem user registration");

            


            Console.WriteLine("Enter your First Name, Check valid or not");
            string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
                                                            //create object of RegexClass
            regexClass.ValidFirstName(TakeName);

            //UC2

            Console.WriteLine("Enter your Last Name, Check valid or not");
            string TakeLastName = Console.ReadLine();
            regexClass.ValidLastName(TakeLastName);


            Console.WriteLine("Enter your Email, Check valid or not");
            string Email = Console.ReadLine();
            regexClass.ValidEmail(Email);


            Console.WriteLine("Enter your Phone number, Check valid or not");
            string TakeNumber = Console.ReadLine();
            regexClass.CheckPhoneNumber(TakeNumber);


            Console.WriteLine("Enter your Password, Check valid or not");
            string Password = Console.ReadLine();
            regexClass.CheckPassword(Password);


            Console.WriteLine("Enter your EmailUC9, Check valid or not");
            string UC9Email = Console.ReadLine();
            regexClass.ValidEmailUC9(UC9Email);
        }
    }
}