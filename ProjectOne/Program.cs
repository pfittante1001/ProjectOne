using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Pete Fittante
 * WeCanCodeITBootCamp First Project
 * 6/30/2017
 * A console application that will tell the user’s fortune based on data received from the user.
 * 
 * This program receives input from a user, and developes an output based on the users input,
 * and presents a prdiction of the users future.
 * 
 * 
 * */
namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //This first section will solicit buisness from the user

            Console.Write("\t\t\tWelcome I am Madamme Zelgas  \n\n\n");

            Console.Write("\t\tWould you like Madame Zelga to read your future?\n\n\n");

            Console.Write("\t\t\tPlease enter \"Yes\" or \"Quit\" :");
            string readAnsw = Console.ReadLine();
            string readAnserUp = readAnsw.ToUpper();

            if (readAnserUp == "QUIT")
            {
                Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!");
                    return;
            }
            else if (readAnserUp == "YES")
            {
                Console.WriteLine("\n\n\t\tI see you are a brave soul, so lets get started.\n\n");
            }

            //This nesxt section will solicit the required information from the user
            Console.WriteLine("********************************************************************************\n");
            Console.Write("Please give Zelga your first name: ");
            string firstName = Console.ReadLine();
            string firstUpper = firstName.ToUpper();

            if (firstUpper == "PETE" || firstUpper == "PETER")
                Console.WriteLine("\n\nSuch a wonderful first nemae you have!!");

            Console.Write("\n\nPlease give Zelga your last name: \n\n\n");
            string lastName = Console.ReadLine();
            string lastUpper = lastName.ToUpper();

            if (lastUpper == "FITTANTE")
                Console.WriteLine("\n\nYour last name is magical!\n\n");

            Console.Write("\nPlease give Zelga your age! I promise to keep it a secret! \n\n\n");
            int custAge = int.Parse(Console.ReadLine());

           
            if (custAge < 1)
            {
                Console.WriteLine("You are lying to Zelga\n\n");
                Console.Write("\n\nPlease give Zelga your correct age!\n\n");
                custAge = int.Parse(Console.ReadLine());
            }

            Console.Write("\n\nPlease tell Zelga the month you were born! ");
            string birthMonth = Console.ReadLine();
            string birthMonthUpper = birthMonth.ToUpper();
            int birthMonth1;

            switch (birthMonth)
            {
                case "JANUNARY":
                    birthMonth1 = 1;
                    break;
                case "FEBRUARY":
                    birthMonth1 = 2;
                    break;
                case "MARCH":
                    birthMonth1 = 3;
                    break;
                case "APRIL":
                    birthMonth1 = 4;
                    break;
                case "MAY":
                    birthMonth1 = 5;
                    break;
                case "JUNE":
                    birthMonth1 = 6;
                    break;
                case "JULY":
                    birthMonth1 = 7;
                    break;
                case "AUGUST":
                    birthMonth1 = 8;
                    break;
                case "SEPTEMBER":
                    birthMonth1 = 9;
                    break;
                case "OCTOBER":
                    birthMonth1 = 10;
                    Console.WriteLine("A fine month is October!");
                    break;
                case "NOVEMBER":
                    birthMonth1 = 11;
                    break;
                case "DECEMBER":
                    birthMonth1 = 8;
                    break;
                default:
                    birthMonth1 = int.Parse(birthMonth);
                    break;
            }
            Console.WriteLine(birthMonth);
        }
    }
}