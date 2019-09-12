/*
 Author: Adam Viera
 Date: 9/12/2019
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/

using System;

namespace Deliverable_2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Request the user to input a integer value for their expected grade
            Console.WriteLine("Enter in your expected numeric grade for ISM 4300 " +
                              "to see its respective letter grade: ");

            /* 
             * Use try catch to validate user input. If a error is made within the entry
             * the program will handle the error and a message will be displayed.
            */
            try
            {
                // Declaring a variable for user input
                string input = Console.ReadLine();

                /* 
                 * This variable is used to store the string input after
                 * the variable is parsed.
                */
                int grade = int.Parse(input);

                if ((grade <= 100) && (grade >= 90))
                {
                    Console.WriteLine("Your letter grade is 'A'");
                } 

                else if ((grade <= 89) && (grade >= 80))
                {
                    Console.WriteLine("Your letter grade is 'B'");
                }

                else if ((grade <= 79) && (grade >= 70))
                {
                    Console.WriteLine("Your letter grade is 'C'");
                }

                else if ((grade <= 69) && (grade >= 60))
                {
                    Console.WriteLine("Your letter grade is 'D'");
                    Console.WriteLine("Warning: In danger of failing class.");
                }

                else if (grade < 60)
                {
                    Console.WriteLine("Your letter grade is 'F'");
                    Console.WriteLine("Please see academic advising.");

                }

            } // end of try
            catch
            {
                Console.WriteLine("The value you entered must be an integer between the " +
                                  "values of 0-100.");
                Console.WriteLine("Press any key to exit the program and try again..");
            } // end of catch
        }
    }
}
