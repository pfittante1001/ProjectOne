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

            Console.Write("\n\nPlease give Zelga your last name: ");
            string lastName = Console.ReadLine();
            string lastUpper = lastName.ToUpper();

            if (lastUpper == "FITTANTE")
                Console.WriteLine("\n\nYour last name is magical!\n\n");

            Console.Write("\n\nPlease give Zelga your age! I promise to keep it a secret! ");
            int custAge = int.Parse(Console.ReadLine());


            if (custAge < 1)
            {
                Console.WriteLine("\n\nYou are lying to Zelga\n\n");
                Console.Write("\n\nPlease give Zelga your correct age! ");
                custAge = int.Parse(Console.ReadLine());
            }

            Console.Write("\n\nPlease tell Zelga the month you were born! ");
            string birthMonth = Console.ReadLine();
            string birthMonthUpper = birthMonth.ToUpper();
            int birthMonth1;
            Console.WriteLine(birthMonthUpper);

            // This conditional statement is designed to ensure the correct user input. I know it is extremely long, and I hate using it. I would love some ideas
            if (birthMonthUpper != "JANUNARY" || birthMonthUpper != "FEBRUARY" || birthMonthUpper != "MARCH" || birthMonthUpper != "APRIL"
                || birthMonthUpper != "MAY" || birthMonthUpper != "JUNE" || birthMonthUpper != "JULY" || birthMonthUpper != "AUGUST"
                || birthMonthUpper != "SEPTEMBER" || birthMonthUpper != "OCTOBER" || birthMonthUpper != "NOVEMBER" || birthMonthUpper != "DECEMBER")
            {
            }
                else if (birthMonthUpper != "1" || birthMonthUpper != "2" || birthMonthUpper != "3" || birthMonthUpper != "4" || birthMonthUpper != "5"
                || birthMonthUpper != "6" || birthMonthUpper != "7" || birthMonthUpper != "8" || birthMonthUpper != "9" || birthMonthUpper != "10"
                || birthMonthUpper != "11" || birthMonthUpper != "12")
                {
                Console.Write("\n\nZelga says please enter a correct month of the year\n");
                Console.Write("\n\nPlease tell Zelga the month you were born! ");
                birthMonth = Console.ReadLine();
                birthMonthUpper = birthMonth.ToUpper();
                }
            
           
            switch (birthMonthUpper)
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
                    Console.WriteLine("\n\nA fine month is October!");
                    break;
                case "NOVEMBER":
                    birthMonth1 = 11;
                    break;
                case "DECEMBER":
                    birthMonth1 = 12;
                    break;
                default:
                    birthMonth1 = int.Parse(birthMonth);
                    break;
            }
            Console.WriteLine(birthMonth1);
            Console.Write("\n\nPlease enter your favorite \"ROYGBIV\" color for Zelga!\n");
            Console.Write("\n\nIf you do not know what \"ROYGBIV\" is, ");
            Console.Write("\n\n\nplease type \"Help\" and Zelga will help you! ");
        }
    }
}