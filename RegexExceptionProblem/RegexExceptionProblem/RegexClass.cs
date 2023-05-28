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
        public static string PhoneNumberRules = "^[0-9]{0,2}[+]{0,1}[8 9]{0,1}[0-9]{9}$";


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

        public void CheckPhoneNumber(string PhoneNumber)
        {
            try
            {


                if (Regex.IsMatch(PhoneNumber, PhoneNumberRules))
                    Console.WriteLine($"This is Valid PhoneNumber:{PhoneNumber}");
                else
                    Console.WriteLine($"This is Invalid PhoneNumber:{PhoneNumber}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valid Mobile Number");
            }

        }
    }
}
