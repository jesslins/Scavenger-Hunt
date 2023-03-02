using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scavenger_hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = false;
            int attempts = 0;

            Console.WriteLine("Welcome to my scavenger hunt!");
            Console.WriteLine("Go to tcrm.ca and enjoy :) ");
            Console.WriteLine("(Press any key)");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Question 1: Who benefits from Treaties?");

            do
            {
                string answer = Console.ReadLine();
                string lowercase = answer.ToLower();

                if (lowercase == "all manitobans")
                {
                    correct = true;
                }

                else
                {
                    attempts++;
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that is incorrect. Please try again.");
                    if (attempts == 1)
                    {
                        Console.WriteLine("Hint 1: 2, 2");
                    }
                    else if (attempts == 2)
                    {
                        Console.WriteLine("Hint 2: Section, Page");
                    }
                    else if (attempts == 3)
                    {
                        Console.WriteLine("Hint 3: Under the “Let’s Talk Treaties” tab");
                    }
                    else if (attempts == 4)
                    {
                        Console.WriteLine("Hint 4: Second paragraph");
                    }
                    else if (attempts >= 5)
                    {
                        Console.WriteLine("The answer is: all Manitobans");
                    }
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            Console.WriteLine(" ");
            Console.WriteLine("Question 2: What did Eastern Canada use to record treaty promises?");
            do
            {
                

                string answer = Console.ReadLine();
                string lowercase = answer.ToLower();

                if (lowercase == "wampum belts" | lowercase == "wampum belt")
                {
                    correct = true;
                }

                else
                {
                    attempts++;
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that is incorrect. Please try again.");
                    if (attempts == 1)
                    {
                        Console.WriteLine("Hint 1: LTT");
                    }
                    else if (attempts == 2)
                    {
                        Console.WriteLine("Hint 2: Lets Talk Treaties");
                    }
                    else if (attempts == 3)
                    {
                        Console.WriteLine("Hint 3: FNT");
                    }
                    else if (attempts == 4)
                    {
                        Console.WriteLine("Hint 4: “First Nation Treaties” page");
                    }
                    else if (attempts >= 5)
                    {
                        Console.WriteLine("The answer is: wampum belts");
                    }
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            Console.WriteLine("");
            Console.WriteLine("Question 3: How many nations make up Treaty 4?");
            do
            {
                string answer = Console.ReadLine();
                string lowercase = answer.ToLower();

                if (lowercase == "seven" | lowercase =="7")
                {
                    correct = true;
                }

                else
                {
                    attempts++;
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that is incorrect. Please try again.");
                    if (attempts == 1)
                    {
                        Console.WriteLine("Hint 1: Question 2's Hint 1");
                    }
                    else if (attempts == 2)
                    {
                        Console.WriteLine("Hint 2: 2 Right, 5 Down, Paragraph 6");
                    }
                    else if (attempts == 3)
                    {
                        Console.WriteLine("Hint 3: Numbered Treaties");
                    }
                    else if (attempts == 4)
                    {
                        Console.WriteLine("Hint 4: “Lets Talk Treaties” --> “Numbered Treaties” --> Paragraph 6/Second Paragraph under Treaty No. 4");
                    }
                    else if (attempts >= 5)
                    {
                        Console.WriteLine("The answer is: seven");
                    }
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            Console.WriteLine("");
            Console.WriteLine("Question 4: Who said that the treaty is a relationship, which has no end?");
            do
            {
                string answer = Console.ReadLine();
                string lowercase = answer.ToLower();

                if (lowercase == "aimee craft")
                {
                    correct = true;
                }

                else
                {
                    attempts++;
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that is incorrect. Please try again.");
                    if (attempts == 1)
                    {
                        Console.WriteLine("Hint 1: Cherry");
                    }
                    else if (attempts == 2)
                    {
                        Console.WriteLine("Hint 2: Red");
                    }
                    else if (attempts == 3)
                    {
                        Console.WriteLine("Hint 3: Home Page");
                    }
                    else if (attempts == 4)
                    {
                        Console.WriteLine("Hint 4: “Treaties Today”");
                    }
                    else if (attempts >= 5)
                    {
                        Console.WriteLine("The answer is: Aimee Craft");
                    }
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            Console.WriteLine("");
            Console.WriteLine("Question 5: When is National Indigenous Peoples Day?");
            do
            {
                string answer = Console.ReadLine();
                string lowercase = answer.ToLower();

                if (lowercase == "june 21" | lowercase == "june 21st")
                {
                    correct = true;
                }

                else
                {
                    attempts++;
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that is incorrect. Please try again.");
                    if (attempts == 1)
                    {
                        Console.WriteLine("Hint 1: Social Media");
                    }
                    else if (attempts == 2)
                    {
                        Console.WriteLine("Hint 2: Red");
                    }
                    else if (attempts == 3)
                    {
                        Console.WriteLine("Hint 3: Right");
                    }
                    else if (attempts == 4)
                    {
                        Console.WriteLine("Hint 4: Instagram");
                    }
                    else if (attempts >= 5)
                    {
                        Console.WriteLine("The answer is: June 21");
                    }
                }
            } while (correct == false);

            Console.WriteLine("");
            Console.WriteLine("Congratulations! You've completed the scavenger hunt!");
            Console.WriteLine("Unfortunately, I have no prize for you :(");
            Console.WriteLine("Have a great day, though! (Press any key)");
            Console.ReadKey();
        }
    }
}
