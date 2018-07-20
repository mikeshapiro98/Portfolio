using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Exercise_3_while_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            while (validInput == false)
            {
                Console.WriteLine("Please enter the name of one of these countries to hear a fact about it: USA, France, China.");
                var country = Console.ReadLine();
                if (country == "USA")
                {
                    Console.WriteLine("The USA has been taken over by facists.");
                    validInput = true;
                }
                else if (country == "France")
                {
                    Console.WriteLine("France has good cheese.");
                    validInput = true;
                }
                else if (country == "China")
                {
                    Console.WriteLine("China is the most populous country in the world.");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }
            Console.ReadLine();
        }
    }
}
                //    }
                //    //INTRODUCTION!
                //    introStart: //Label (Bad practice)
                //    Console.WriteLine("Time to try out some while loops. Are you ready?");
                //    string userResponse = Console.ReadLine();

                //    //Failed experiment!
                //    //string[] yes = { "y", "e", "s" };
                //    //Console.WriteLine(yes[1]);
                //    //End failed experiment!

                //    if (userResponse == "yes")
                //    {
                //        Console.WriteLine("Perfect! Let's get started");
                //        Console.WriteLine(" ");
                //        System.Threading.Thread.Sleep(1000);

                //    }
                //    else if (userResponse == "no")
                //    {
                //        Console.WriteLine("If you're not ready then come back later. This window will self destruct.");
                //        System.Threading.Thread.Sleep(3000);
                //        return;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Please type 'yes' or 'no'");
                //        System.Threading.Thread.Sleep(1000);
                //        goto introStart; //Bad Practice. Don't use again. 
                //    }
                //    //END INTRODUCTION!


                //    //FIRST WHILE STATEMENT!





                //    Console.WriteLine("Okay first up, let's test a while statment. Press Enter to start");
                //    Console.ReadLine();

                //    tryAgain://BAD PRACTICE ERROR CATCH
                //    Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //    System.Threading.Thread.Sleep(1000);
                //    Console.WriteLine("Your options are:");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("China");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("Canada");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("South Africa");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("USA");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("Mexico");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("France");
                //    System.Threading.Thread.Sleep(1000);
                //    Console.WriteLine("Which country would you like to know a fact about?");

                //    string userCountry = Console.ReadLine();
                //    System.Threading.Thread.Sleep(500);


                //    bool china = userCountry == "China";
                //    bool canada = userCountry == "Canada";
                //    bool southAfrica = userCountry == "South Africa";
                //    bool usa = userCountry == "USA";
                //    bool mexico = userCountry == "Mexico";
                //    bool france = userCountry == "France";


                //    //ERROR CATCH
                //    if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //    {
                //        Console.WriteLine(" ");
                //        Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //    }
                //    else
                //    {
                //        Console.WriteLine(" ");
                //        Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //        Console.WriteLine(" ");
                //        System.Threading.Thread.Sleep(1000);
                //        goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //    }
                //    //END ERROR CATCH


                //    string yesOrNo = Console.ReadLine();
                //    bool isYes = yesOrNo == "yes";
                //    bool isNo = yesOrNo == "no";

                //    //FAILED EXPERIMENT!
                //    //bool error = yesOrNo != "yes";
                //    //error = yesOrNo != "no";
                //    //END FAILED EXPERIMENT!

                //    while (isYes == true)
                //    {
                //        switch (userCountry)
                //        {
                //            //CHINA
                //            case "China":
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Did you know that the Chinese army has an Official Division of 10,000 Pigeons");
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Would you like to know a fact about another country?");
                //                yesOrNo = Console.ReadLine();
                //                if (yesOrNo == "yes")
                //                {
                //                    isYes = true;
                //                }
                //                else if (yesOrNo == "no")
                //                {
                //                    isNo = true;
                //                    isYes = false;
                //                    break;
                //                }
                //                else
                //                {
                //                    //Console.WriteLine("There was an error. Please only type 'yes' or 'no'");
                //                    //Console.WriteLine(" ");
                //                    //System.Threading.Thread.Sleep(1000);
                //                    isYes = false;
                //                    isNo = false;
                //                    break;
                //                }

                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);

                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH



                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;
                //            //END CHINA!

                //            //CANADA
                //            case "Canada":
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Did you know that Canada spans 9,984,670 sq km and comprises 6 time zones.");
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Would you like to know a fact about another country?");
                //                yesOrNo = Console.ReadLine();
                //                if (yesOrNo == "yes")
                //                {
                //                    isYes = true;
                //                }
                //                else if (yesOrNo == "no")
                //                {
                //                    isNo = true;
                //                    isYes = false;
                //                    break;
                //                }
                //                else
                //                {
                //                    isYes = false;
                //                    isNo = false;
                //                    break;
                //                }

                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);


                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH


                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;
                //            //END CANADA!

                //            //SOUTH AFRICA!
                //            case "South Africa":
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Did you know that the world’s largest diamond was found in the Premier Mine in Pretoria, South Africa on \n25 January 1905.");
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Would you like to know a fact about another country?");

                //                yesOrNo = Console.ReadLine();
                //                if (yesOrNo == "yes")
                //                {
                //                    isYes = true;
                //                }
                //                else if (yesOrNo == "no")
                //                {
                //                    isNo = true;
                //                    isYes = false;
                //                    break;
                //                }
                //                else
                //                {
                //                    isYes = false;
                //                    isNo = false;
                //                    break;
                //                }

                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);

                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH

                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;
                //            //END SOUTH AFRICA!

                //            //USA
                //            case "USA":
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Did you know that there is enough water in Lake Superior to cover the entire landmass of North and South America in one foot of liquid.");
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Would you like to know a fact about another country?");
                //                yesOrNo = Console.ReadLine();
                //                if (yesOrNo == "yes")
                //                {
                //                    isYes = true;
                //                }
                //                else if (yesOrNo == "no")
                //                {
                //                    isNo = true;
                //                    isYes = false;
                //                    break;
                //                }
                //                else
                //                {
                //                    isYes = false;
                //                    isNo = false;
                //                    break;
                //                }


                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);

                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH

                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;
                //            //END USA!

                //            //MEXICO
                //            case "Mexico":
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Did you know that the National University of Mexico was founded in 1551 by Charles V of Spain and is the oldest university in North America.");
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Would you like to know a fact about another country?");
                //                yesOrNo = Console.ReadLine();
                //                if (yesOrNo == "yes")
                //                {
                //                    isYes = true;
                //                }
                //                else if (yesOrNo == "no")
                //                {
                //                    isNo = true;
                //                    isYes = false;
                //                    break;
                //                }
                //                else
                //                {
                //                    isYes = false;
                //                    isNo = false;
                //                    break;
                //                }

                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);

                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH


                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;
                //            //END MEXICO!

                //            //FRANCE
                //            case "France":
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Did you know that the world’s first artificial heart transplant and face transplant both took place in France");
                //                Console.WriteLine(" ");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Would you like to know a fact about another country?");
                //                yesOrNo = Console.ReadLine();
                //                if (yesOrNo == "yes")
                //                {
                //                    isYes = true;
                //                }
                //                else if (yesOrNo == "no")
                //                {
                //                    isNo = true;
                //                    isYes = false;
                //                    break;
                //                }
                //                else
                //                {
                //                    isYes = false;
                //                    isNo = false;
                //                    break;
                //                }
                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);

                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH

                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;
                //            //END FRANCE!

                //            //DEFAULT SHOULD NEVER BE REACHED IN THEORY

                //            default:
                //                Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");

                //                Console.WriteLine(" ");
                //                Console.WriteLine("Type in one of the following countries to get a fact about that country.");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Your options are:");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("China");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Canada");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("South Africa");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("USA");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("Mexico");
                //                System.Threading.Thread.Sleep(500);
                //                Console.WriteLine("France");
                //                System.Threading.Thread.Sleep(1000);
                //                Console.WriteLine("Which country would you like to know a fact about?");

                //                userCountry = Console.ReadLine();
                //                System.Threading.Thread.Sleep(500);

                //                //ERROR CATCH
                //                china = userCountry == "China";
                //                canada = userCountry == "Canada";
                //                southAfrica = userCountry == "South Africa";
                //                usa = userCountry == "USA";
                //                mexico = userCountry == "Mexico";
                //                france = userCountry == "France";



                //                if (china == true || canada == true || southAfrica == true || usa == true || mexico == true || france == true)
                //                {
                //                    Console.WriteLine("You selected " + userCountry + ". Are you ready to hear a fact about that country?");
                //                }
                //                else
                //                {
                //                    Console.WriteLine("There was an error. Please make sure the country you typed is spelled correctly and capililized correctly.");
                //                    Console.WriteLine(" ");
                //                    System.Threading.Thread.Sleep(1000);
                //                    goto tryAgain;//AGAIN BAD PRACTICE STUPID!
                //                }
                //                //END ERROR CATCH

                //                yesOrNo = Console.ReadLine();
                //                isYes = yesOrNo == "yes";
                //                isNo = yesOrNo == "no";
                //                break;

                //                //END DEFAULT!

                //        }


                //    }
                //    while (isNo == true)
                //    {
                //        Console.WriteLine(" ");
                //        Console.WriteLine("Okay. Let's move on. Press enter to go to the next loop");
                //        Console.ReadLine();
                //        break;

                //    }


                //    //ERROR CATCH
                //    while (!isYes && !isNo)
                //    {
                //        Console.WriteLine(" ");
                //        Console.WriteLine("There was an error. Please only type 'yes' or 'no' ... Restarting");
                //        Console.WriteLine(" ");
                //        System.Threading.Thread.Sleep(1000);
                //        goto tryAgain;


                //    }
                //    //END ERROR CATCH

                //    //END FIRST WHILE STATEMENT!


                //    //START DO WHILE STATEMENT #2!

                //    Console.WriteLine("Now lets test a do while statement.");
                //    System.Threading.Thread.Sleep(1000);


                //    Console.WriteLine("A random number generator will select a number between 1 and 20. Guess that number to win. Press enter to start.");
                //    Console.ReadLine();

                //    Random rnd = new Random();
                //    int random = rnd.Next(1, 20);
                //    int lockIt = random;
                //    Console.WriteLine("Enter a number between 1 and 20");

                //    //DECLARE VARIABLES AND CHECK THAT USER INPUT IS CORRECT!
                //    string userString =Console.ReadLine();
                //    int userNum;
                //    bool res = int.TryParse(userString, out userNum); //This tests for a number AND assigns the user input to and int.
                //    bool isCorrect = lockIt == userNum;



                //    //DO WHILE!!
                //    do
                //    {

                //        if (res == false)
                //        {
                //            Console.WriteLine("Error. Please only enter whole numbers between 1 and 20");
                //            Console.WriteLine(" ");
                //            System.Threading.Thread.Sleep(1000);
                //            //Console.ReadLine();
                //        }

                //        switch (isCorrect)
                //        {
                //            case true:
                //                Console.WriteLine("Congratulations. You are Correct! YOU WIN! Press Enter to continue");
                //                break;

                //            case false:
                //                Console.WriteLine("Sorry but you are wrong. Try Again");
                //                Console.WriteLine("Enter a number between 1 and 20");
                //                userString = Console.ReadLine();
                //                //userNum;  UNNECISSARY
                //                res = int.TryParse(userString, out userNum);
                //                isCorrect = lockIt == userNum;
                //                break;
                //        }


                //    }
                //    while (!isCorrect);
                //    //END DO WHILE!


                //    Console.WriteLine("Congratulations. You are Correct! YOU WIN! Press Enter to continue");
                //    Console.ReadLine();

                //    //END DO WHILE STATEMENT #2!

                //    //FINISH PROGRAM!
                //    Console.WriteLine(" ");
                //    Console.WriteLine(" ");
                //    System.Threading.Thread.Sleep(500);
                //    Console.WriteLine("Thank you for completing this program and making it to the end. Press enter to close the window");
                //    Console.ReadLine();
                //    //END FINISH PROGRAM!

                //