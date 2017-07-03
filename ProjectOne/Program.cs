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
            //Global Variables
            string readAnserUp;
            string firstUpper;
            string lastUpper;
            string custAgeStrUpper;
            string birthMonthUpper;
            string roybivChoiceUpper;
            string userContUpper;
            string vacationHome;
            string autoChoice;
            int custAge;
            int birthMonth1 = 0;
            int numSiblings;
            int yearRetire;
            decimal bankAcctFuture;
            string exitProgram = "";
            string[] birthMonthArray = new string[] {"QUIT","JANUNARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"};
            string[] roygbivArray = new string[] {"HELP", "RED", "ORANGE", "YELLOW", "GREEN", "BLUE", "INDIGO", "VIOLET", "R", "O", "Y", "G", "B", "I", "V" };

            //This first section will solicit buisness from the user


            while (exitProgram != "QUIT")
            {
                Console.Write("\t\t\tWelcome I am Madamme Zelda  \n\n\n");

                Console.Write("\t\tWould you like Madame Zelda to read your future?\n\n\n");

                Console.Write("\t\t\tPlease enter \"Yes\" or \"Quit\" :");

                string readAnsw = Console.ReadLine();

                readAnserUp = readAnsw.ToUpper();

                if (readAnserUp == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t\t  Au Revoir!!\n\n\n");

                    return;
                }
                else if (readAnserUp == "YES")
                {
                    Console.Clear();

                    Console.Write("\n********************************************************************************");

                    Console.Write("\n\t\tI see you are a brave soul, so lets get started.\n");

                    Console.Write("\n\n\t\tYou can type \"Quit\" anytime if you get scared\n\n");
                }
                else
                { 
                    Console.Write("\n\n\tMadame Zelda is worried you might not be able to read directions");

                    Console.Write("\n\n\t\t\tPlease enter \"Yes\" or \"Quit\" :");

                    readAnsw = Console.ReadLine();

                    readAnserUp = readAnsw.ToUpper();

                }

                if (readAnserUp == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t\t  Au Revoir!!\n\n\n");

                    return;
                }


                //This nesxt section will solicit the first and last name of the customer

                Console.Write("********************************************************************************");

                Console.Write("\nPlease give Madame Zelda your first name: ");

                string firstName = Console.ReadLine();

                firstUpper = firstName.ToUpper();

                if (firstUpper == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t\t  Au Revoir!!\n\n\n");

                    return;
                }

                if (firstUpper == "PETE" || firstUpper == "PETER")

                    Console.WriteLine("\n\nSuch a wonderful first nemae you have!!");

                    Console.Write("\n\nPlease give Zelga your last name: ");

                    string lastName = Console.ReadLine();

                    lastUpper = lastName.ToUpper();

                if (lastUpper == "FITTANTE")
                {

                    Console.Write("\n\nYour last name is magical!\n\n");

                    Console.Write("Madame Zelga says press enter to continue!");

                    Console.ReadLine();

                    Console.Clear();
                }
                else if (lastUpper == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t\t  Au Revoir!!\n\n\n");

                    return;
                }

                Console.Clear();

                //This section will solicit the age of the customer. The following code also handles the exception
                //thrown by the IDE when an the user enters an invalid string.  Example of an invalid string would be "test"

                Console.Write("\n********************************************************************************\n\n");

                Console.Write("\tRemember if you loose your nerve, you can type \" Quit\" and run!\n\n\n");

                Console.Write("********************************************************************************");

                Console.Write("\nPlease give Zelga your age! I promise to keep it a secret! ");

                string custAgeStr = Console.ReadLine();

                custAgeStrUpper = custAgeStr.ToUpper();

                if (custAgeStrUpper != "QUIT" && int.TryParse(custAgeStr, out custAge) == false)
                {
                    Console.Write("\nMadame Zelda needs a valid number to continue or \"Quit\" to escape!\n");

                    Console.Write("\nPlease give Zelga your correct age! ");

                    custAgeStr = Console.ReadLine();

                    custAgeStrUpper = custAgeStr.ToUpper();

                    Console.Clear();
                }

                if (custAgeStrUpper == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t\t  Au Revoir!!\n\n\n");

                    return;
                }
                else
                {
                    custAge = int.Parse(custAgeStr);
                }

                
                if (custAge < 1 || custAge > 120)
                {
                    Console.Write("\n\nYou are lying to Zelga\n");

                    Console.Write("\n\nPlease give Zelga your correct age! ");

                    custAgeStr = Console.ReadLine();

                    custAgeStrUpper = custAgeStr.ToUpper();

                    Console.Clear();

                }

                if (custAgeStrUpper == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t\t  Au Revoir!!\n\n\n");

                    return;
                }
                else
                {
                    custAge = int.Parse(custAgeStr);
                    Console.Clear();
                }

                //This section will solicit the month the customer was born. The following code also handles the exception
                //thrown by the IDE when an the user enters an invalid string.  Example of an invalid string would be "test"
                //This section of code allows the user to input the numerical value of the month or the noun name.

                Console.Write("\n********************************************************************************\n\n");

                Console.Write("\tRemember if you are getting scared, you can type \" Quit\" and run!\n\n\n");

                Console.Write("********************************************************************************");

                Console.Write("\nPlease tell Zelga the month you were born! ");

                string birthMonth = Console.ReadLine();

                birthMonthUpper = birthMonth.ToUpper();

                if(birthMonthArray.Contains(birthMonthUpper) == false && int.TryParse(birthMonth, out birthMonth1) == false)
                {
                    Console.Write("\nMadame Zelda needs a valid number or month to continue or \"Quit\" to escape!\n");

                    Console.Write("\nPlease give Zelga your correct birth month! ");

                    birthMonth = Console.ReadLine();

                    birthMonthUpper = birthMonth.ToUpper();

                    Console.Clear();
                    if (birthMonthUpper == "QUIT")
                    {
                        Console.Clear();

                        Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                        Console.WriteLine("\n\n\t\t\t             Au Revoir!!\n\n\n");

                        return;
                    }
                    else if (int.TryParse(birthMonth, out birthMonth1) == true)
                    {
                        birthMonth1 = int.Parse(birthMonth);
                        Console.Clear();
                    }

                }
                else if (birthMonthUpper == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t             Au Revoir!!\n\n\n");

                    return;
                }
                else if (int.TryParse(birthMonth, out birthMonth1) == true)
                {
                    birthMonth1 = int.Parse(birthMonth);
                    Console.Clear();
                }
                

                if (birthMonth1 == 10)
                {
                    Console.Clear();
                    Console.Write("\n********************************************************************************\n\n");
                    Console.Write("Madame Zelga says October is glorius month!\n\n\n");
                    Console.Write("\nPlease press \"Enter\" to continue");
                    Console.Write("\n********************************************************************************");
                    Console.ReadLine();
                    Console.Clear();
                }

                //This switch statement will take the birthmonth as entered from the user 
                //regardless of input type and convert into an int.

                if (birthMonthArray.Contains(birthMonthUpper))
                {

                    switch (birthMonthUpper)
                    {
                        case "JANUNARY":
                            birthMonth1 = 1;
                            Console.Clear();
                            break;
                        case "FEBRUARY":
                            birthMonth1 = 2;
                            Console.Clear();
                            break;
                        case "MARCH":
                            birthMonth1 = 3;
                            Console.Clear();
                            break;
                        case "APRIL":
                            birthMonth1 = 4;
                            Console.Clear();
                            break;
                        case "MAY":
                            birthMonth1 = 5;
                            Console.Clear();
                            break;
                        case "JUNE":
                            birthMonth1 = 6;
                            Console.Clear();
                            break;
                        case "JULY":
                            birthMonth1 = 7;
                            Console.Clear();
                            break;
                        case "AUGUST":
                            birthMonth1 = 8;
                            Console.Clear();
                            break;
                        case "SEPTEMBER":
                            birthMonth1 = 9;
                            Console.Clear();
                            break;
                        case "OCTOBER":
                            birthMonth1 = 10;
                            Console.Clear();
                            Console.Write("\n********************************************************************************\n\n");
                            Console.Write("Madame Zelga says October is glorius month!Switch\n\n\n");
                            Console.Write("Please press \"Enter\" to continue");
                            Console.Write("\n********************************************************************************");                           
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "NOVEMBER":
                            birthMonth1 = 11;
                            Console.Clear();
                            break;
                        case "DECEMBER":
                            birthMonth1 = 12;
                            Console.Clear();
                            break;
                        default:
                            birthMonth1 = int.Parse(birthMonth);
                            Console.Clear();
                            break;
                    }
                }
                
                //This section will solicit a favorite color from the user. This section provides a Help menu and allows
                // the user to intput a char for example "R" or the noun name of the color for example "Red"

                Console.Write("\n********************************************************************************\n\n");

                Console.Write("\tRemember if your spine is weakening, you can type \" Quit\" and breath!\n\n\n");

                Console.Write("********************************************************************************\n");

                Console.Write("Please enter your favorite \"ROYGBIV\" color for Zelga!\n");

                Console.Write("\n\nIf you do not know what \"ROYGBIV\" is, please type \"Help\"");

                Console.Write("\n\n\nZelga will gladly help you! ");

                string roygbivChoice = Console.ReadLine();

                roybivChoiceUpper = roygbivChoice.ToUpper();

                if (roybivChoiceUpper == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                    Console.WriteLine("\n\n\t\t\t             Au Revoir!!\n\n\n");

                    return;
                }

                if (roybivChoiceUpper == "HELP")
                {
                    Console.Clear();

                    Console.Write("\n\n********************************************************************************\n");

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

                    Console.Clear();

                    if (roybivChoiceUpper == "QUIT")
                    {
                        Console.Clear();

                        Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                        Console.WriteLine("\n\n\t\t\t             Au Revoir!!\n\n\n");

                        return;
                    }
                }

                if (roygbivArray.Contains(roybivChoiceUpper) == false)

                {
                    Console.Clear();

                    Console.Write("\n********************************************************************************\n\n");

                    Console.Write("Madame Zelga asks you to please enter a ROYGBIV color\n\n");

                    Console.Write("Please enter the first character for example \"R\" or \"Red\" ");

                    roygbivChoice = Console.ReadLine();

                    roybivChoiceUpper = roygbivChoice.ToUpper();

                    if (roybivChoiceUpper == "QUIT")
                    {
                        Console.Clear();

                        Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!\n\n\n");

                        Console.WriteLine("\n\n\t\t\t             Au Revoir!!\n\n\n");

                        return;
                    }

                }

                if (roygbivArray.Contains(roybivChoiceUpper) == true)

                {
                    
                    roybivChoiceUpper = roygbivChoice.ToUpper();
                    Console.Clear();
                }

                if (roygbivArray.Contains(roybivChoiceUpper) == true)
                
                {
                    switch (roybivChoiceUpper)
                    {
                        case "R":
                            roybivChoiceUpper = "RED";
                            Console.Clear();
                            break;
                        case "O":
                            roybivChoiceUpper = "ORANGE";
                            Console.Clear();
                            break;
                        case "Y":
                            roybivChoiceUpper = "YELLOW";
                            Console.Clear();
                            break;
                        case "G":
                            roybivChoiceUpper = "GREEN";
                            Console.Clear();
                            break;
                        case "B":
                            roybivChoiceUpper = "BLUE";
                            Console.Clear();
                            break;
                        case "I":
                            roybivChoiceUpper = "INDIGO";
                            Console.Clear();
                            break;
                        case "V":
                            roybivChoiceUpper = "VIOLET";
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                

                Console.Write("\n\n********************************************************************************\n");

                Console.Write("{0} is Zelga's favorite as well!\n", roybivChoiceUpper);

                Console.Write("\n\nMadame Zelga says press enter to continue!");

                Console.ReadLine();

                Console.Clear();

                //This section will solicit the number of siblings from the user

                Console.Write("\n\n********************************************************************************\n");

                Console.Write("\n Remember if your courage is weakening, you can type \" Quit\" and crawl away!\n");

                Console.Write("\n\n********************************************************************************");

                Console.Write("\nOur journey is almost complete my dear!\n");

                Console.Write("\n\nMadame Zelga has only one remaining question\n");

                Console.Write("\n\nMadame Zelga says press enter to continue!");

                Console.ReadLine();

                Console.Clear();

                Console.Write("\n\n********************************************************************************\n");

                Console.Write("\nMadame Zelga would like to know how my siblings you have! ");

                numSiblings = int.Parse(Console.ReadLine());

                if (numSiblings < 0)
                {
                    Console.Write("Madame Zelga thinks your funny! You cannot enter a number less than zero!");

                    Console.Write("\n\nMadame Zelga would like to know how my siblings you have! ");

                    numSiblings = int.Parse(Console.ReadLine());

                    Console.Clear();
                }

                Console.Clear();

                //This section will display the users fortune if they decide to continue

                Console.Write("\n\n********************************************************************************");

                Console.Write("\nMadame Zelga is now ready to tell your fortune!");

                Console.Write("\n\nIf you want to see into your future, please type \"Yes\"");

                Console.Write("\n\nIf you have lost you courage please typ \"Quit\" ");

                string userCont = Console.ReadLine();

                userContUpper = userCont.ToUpper();

                if (userContUpper == "QUIT")

                {
                    Console.WriteLine("\n\n\t\t\t    Nobody likes a quitter!!");

                    return;
                }
                else
                {
                    Console.WriteLine("\n\nA brave soul you are indeed!");
                    Console.Write("\n\nMadame Zelga says press enter to continue!");
                    Console.ReadLine();
                    Console.Clear();

                }

                //This if statement calculates the retirement age

                yearRetire = 0;

                if (custAge % 2 == 0 && custAge >= 1 && custAge <= 25)
                {
                    yearRetire = 35;
                }
                else if (custAge % 2 == 0 && custAge >= 26 && custAge <= 50)
                {
                    yearRetire = 25;
                }
                else if (custAge % 2 == 0 && custAge >= 51 && custAge <= 80)
                {
                    yearRetire = 15;
                }
                else if (custAge % 2 == 0 && custAge > 81)
                {
                    yearRetire = 3;
                }
                else if (custAge >= 1 && custAge <= 25)
                {
                    yearRetire = 25;
                }
                else if (custAge >= 26 && custAge <= 50)
                {
                    yearRetire = 20;
                }
                else if (custAge >= 51 && custAge <= 80)
                {
                    yearRetire = 15;
                }
                else if (custAge >= 81)
                {
                    yearRetire = 2;
                }

                //This switch statement will choose the vacation home location

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

                //This switch statement will choose the future mode of transportation 

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

                bankAcctFuture = 0.00m;

                if (birthMonth1 >= 1 && birthMonth1 <= 4)
                {
                    bankAcctFuture = 25000.00m;
                }
                else if (birthMonth1 >= 5 && birthMonth1 <= 8)
                {
                    bankAcctFuture = 28000.00m;
                }
                else if (birthMonth1 >= 9 && birthMonth1 <= 12)
                {
                    bankAcctFuture = 21000.00m;
                }



                //This section presents the future to the user
                Console.Write("*******************************************************************************\n\n");
                Console.Write("  Madame Zelga has looked into your future and she has seen your fortune\n\n");
                Console.Write("*  {0} {1} will retire in {2} years with ${3} in the bank,a vacation home\n\n", firstUpper, lastUpper, yearRetire, bankAcctFuture);
                Console.Write("*                          in uit{0} with a {1}.\n\n", vacationHome, autoChoice);
                Console.Write("*******************************************************************************\n\n");

                Console.WriteLine("Thank you for visiting Madame Zelga. Please enter \"Quit\" to exit the game.");
                exitProgram = Console.ReadLine();
                Console.Clear();


            }
        }
    }
}