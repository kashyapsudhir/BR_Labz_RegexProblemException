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
        public static string LastNameRules = "^[A-Z]{1}[a-z]{2,}$";

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

        public void ValidLastName(string LastName)
        {
            try
            {


                if (Regex.IsMatch(LastName, LastNameRules))
                    Console.WriteLine($"This is Valid LastName:\n{LastName}");
                else
                    Console.WriteLine($"This is Invalid LastName:\n{LastName}");
            }

            catch (Exception e)
            {

                Console.WriteLine("Enter valid Last Name formate");
            }
        }
    }
}
