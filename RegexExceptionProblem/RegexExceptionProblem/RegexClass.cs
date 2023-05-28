using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExceptionProblem
{
    public class RegexClass
    {
        //public static string NameRules = "^[A-Z]{1}[a-z]{2,}$";
        //public static string LastNameRules = "^[A-Z]{1}[a-z]{2,}$";
        // public static string EmailRules = "^[a-z]+[.+-_]{0,1}[0-9 a-z]+[@][a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        //public static string PhoneNumberRules = "^[0-9]{0,2}[+]{0,1}[8 9]{0,1}[0-9]{9}$";
        //UC5- public static string PasswordRules = "^[0-9 A-Z a-z]{8,}$";
        //UC6- public static string PasswordRules = "^([A - Z]{0,1})[0-9A-Za-z]{8,}$";
        //UC7- public static string PasswordRules = "^[A-Z]{1,}[A-Za-z0-9]{1,10}";
        public static string PasswordRules = "^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$";




        //UC2

        //public void ValidFirstName(string Name)
        //{
        //    try
        //    {


        //        if (Regex.IsMatch(Name, NameRules))
        //            Console.WriteLine($"This is Valid Name:\n{Name}");
        //        else
        //            Console.WriteLine($"This is Invalid:\n{Name}");
        //    }

        //    catch (Exception e)
        //    {

        //        Console.WriteLine("Enter valid name formate");
        //    }
        //}

        //UC2

        //public void ValidLastName(string LastName)
        //{
        //    try
        //    {


        //        if (Regex.IsMatch(LastName, LastNameRules))
        //            Console.WriteLine($"This is Valid LastName:\n{LastName}");
        //        else
        //            Console.WriteLine($"This is Invalid LastName:\n{LastName}");
        //    }

        //    catch (Exception e)
        //    {

        //        Console.WriteLine("Enter valid Last Name formate");
        //    }
        //}

        //UC3

        //public void ValidEmail(string EmailCheck)
        //{

        //    if (Regex.IsMatch(EmailCheck, EmailRules))
        //        Console.WriteLine($"This is Valid Email:{EmailCheck}");
        //    else
        //        Console.WriteLine($"This is Invalid Email:{EmailCheck}");
        //}


        //UC4

        //public void CheckPhoneNumber(string PhoneNumber)
        //{
        //    try
        //    {


        //        if (Regex.IsMatch(PhoneNumber, PhoneNumberRules))
        //            Console.WriteLine($"This is Valid PhoneNumber:{PhoneNumber}");
        //        else
        //            Console.WriteLine($"This is Invalid PhoneNumber:{PhoneNumber}");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Please Enter Valid Mobile Number");
        //    }

        //}

        //UC5
        public void CheckPassword(string Password)
        {
            try
            {

                if (Regex.IsMatch(Password, PasswordRules))
                    Console.WriteLine($"This is Valid Password:{Password}");
                else
                    Console.WriteLine($"This is Invalid Password:{Password}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter valid password");
            }
        }

    }
}
