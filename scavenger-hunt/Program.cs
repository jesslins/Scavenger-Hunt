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

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Question 1: Who benefits from Treaties?");

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
                    Console.WriteLine("The answer is: all manitobans");
                }

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
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Question 2: What did Eastern Canada use to record treaty promises?");

                if (attempts == 1)
                {
                    Console.WriteLine("Hint 1: zdpsxp ehowv");
                }
                else if (attempts == 2)
                {
                    Console.WriteLine("Hint 2: Caeser Cipher");
                }
                else if (attempts == 3)
                {
                    Console.WriteLine("Hint 3: 3 to the right");
                }
                else if (attempts == 4)
                {
                    Console.WriteLine("Hint 4: “First Nation Treaties” page");
                }
                else if (attempts >= 5)
                {
                    Console.WriteLine("The answer is: wampum belts");
                }

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
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Question 3: How many nations make up Treaty 4?");
                if (attempts == 1)
                {
                    Console.WriteLine("Hint 1: 00110010 00100000 01010010 01101001 01100111 01101000 01110100 00101100 00100000 00110101 00100000 01000100 01101111 01110111 01101110 00101100 00100000 01010000 01100001 01110010 01100001 01100111 01110010 01100001 01110000 01101000 00100000 00110110");
                }
                else if (attempts == 2)
                {
                    Console.WriteLine("Hint 2: Binary");
                }
                else if (attempts == 3)
                {
                    Console.WriteLine("Hint 3: 2 Right, 5 Down, Paragraph 6");
                }
                else if (attempts == 4)
                {
                    Console.WriteLine("Hint 4: Lets Talk Treaties” --> “Numbered Treaties” --> Paragraph 6/Second Paragraph under Treaty No. 4");
                }
                else if (attempts >= 5)
                {
                    Console.WriteLine("The answer is: seven");
                }

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
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Question 4: Who said that the treaty is a relationship, which has no end?");
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
                }
            } while (correct == false);

            attempts = 0;
            correct = false;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Question 5: When is National Indigenous Peoples Day?");
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
