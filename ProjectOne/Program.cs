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
            
            //This section will assist the user in entering the correct favorite color

            Console.Write("\n\nPlease enter your favorite \"ROYGBIV\" color for Zelga!\n");
            Console.Write("\n\nIf you do not know what \"ROYGBIV\" is, please type \"Help\"");
            Console.Write("\n\n\nZelga will gladly help you! ");
            string roygbivChoice = Console.ReadLine();
            string roybivChoiceUpper = roygbivChoice.ToUpper();

            if (roybivChoiceUpper == "HELP")
            {
                Console.WriteLine("\n\nR = Red");
                Console.WriteLine("O = Orange");
                Console.WriteLine("Y = Yellow");
                Console.WriteLine("G = Green");
                Console.WriteLine("B = Blue");
                Console.WriteLine("I = Indigo");
                Console.WriteLine("V = Violet");
                Console.WriteLine("\n\n\nNow that Madame Zelga helped you, please give"); 
                Console.Write("\n\nMadame Zelga your favorite \"ROYGBIV\" color! ");
                roygbivChoice = Console.ReadLine();
                roybivChoiceUpper = roygbivChoice.ToUpper();
            }
            else
            {
                Console.Write("\n\n{0} is Zelga's favorite as well!\n", roybivChoiceUpper);
            }

            Console.WriteLine("\n\nOur journey is almost complete my dear!");
            Console.WriteLine("\n\nMadame Zelga has only one remaining question");
            Console.Write("\n\n\nMadame Zelga would like to know how my siblings you have! ");
            int numSiblings = int.Parse(Console.ReadLine());

            if (numSiblings < 0)
            {
                Console.WriteLine("Madame Zelga thinks your funny! You cannot enter a number less than zero!");
                Console.Write("\n\n\nMadame Zelga would like to know how my siblings you have! ");
                numSiblings = int.Parse(Console.ReadLine());
            }

            //This section will display the users fortune if they decide to continue

            Console.WriteLine("\n\n\nMadame Zelga is now ready to tell your fortune!");
            Console.WriteLine("\n\nIf you want to see into your future, please type \"Yes\"");
            Console.Write("\n\nIf you have lost you courage please typ \"Quit\" ");
            string userCont = Console.ReadLine();
            string userContUpper = userCont.ToUpper();


            if (userContUpper == "QUIT")
            {
                Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!");
                return;
            }
            else
            {
                Console.WriteLine("\n\nA brave soul you are indeed!");
                               
            }

            //This section calulates the users fortune

            //This if statement calculates the retirement age

            int yearRetire = 0;

            if (custAge % 2 == 0 && custAge >= 1 && custAge <= 25)
            {
                yearRetire = 2045;
            }
            else if (custAge % 2 == 0 && custAge >= 26 && custAge <= 50)
            {
                yearRetire = 2035;
            }
            else if (custAge % 2 == 0 && custAge >= 51 && custAge <= 80)
            {
                yearRetire = 2025;
            }
            else if (custAge % 2 == 0 && custAge > 81)
            {
                yearRetire = 2017;
            }
            else if (custAge >= 1 && custAge <= 25)
            {
                yearRetire = 2055;
            }
            else if (custAge >= 26 && custAge <= 50)
            {
                yearRetire = 2045;
            }
            else if (custAge >= 51 && custAge <= 80)
            {
                yearRetire = 2035;
            }
            else if (custAge >= 81)
            {
                yearRetire = 2018;
            }

            //This switch statement will choose the vacation home for the user

            string vacationHome;
            switch (numSiblings)
            {
                case 0:
                    vacationHome = "Amsterdam";
                    break;
                case 1:
                    vacationHome = "London";
                    break;
                case 2:
                    vacationHome = "Egypt";
                    break;
                case 3:
                    vacationHome = "Prauge";
                    break;
                default:
                    vacationHome = "Cleveland Texas";
                    break;
            }

            //This switch statement will provide the future mode of transportation to the user

            string autoChoice;
            switch (roybivChoiceUpper)
            {
                case "RED":
                    autoChoice = "BMW C250";
                    break;
                case "ORANGE":
                    autoChoice = "1967 Ford Bronco";
                    break;
                case "YELLOW":
                    autoChoice = "Ford Escape";
                    break;
                case "BLUE":
                    autoChoice = "1967 Beetle";
                    break;
                case "INDIGO":
                    autoChoice = "Harley RoadKing";
                    break;
                default:
                    autoChoice = "VW Cabrolet";
                    break;
            }


            //This if else statement will process the users future bank account
            //The user input does no allow for entering anyhting less than 1 or greater than 12

           double bankAcctFuture = 0.00;

            if (birthMonth1 >= 1 && birthMonth1 <= 4)
            {
                bankAcctFuture = 25000.00;
            }
            else if (birthMonth1 >= 5 && birthMonth1 <= 8)
            {
                bankAcctFuture = 28000.00;
            }
            else if (birthMonth1 >= 9 && birthMonth1 <= 12)
            {
                bankAcctFuture = 21000.00;
            }

            

            //This section presents the future to the user
            Console.WriteLine("********************************************************************************\n");





        }
    }
}