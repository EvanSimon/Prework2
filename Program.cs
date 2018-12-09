using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("What activity would you like to get up to? \n1. Action \n2. Chill TImes \n3. Danger \n4. Good Food");//Prompting user to pick their activity and storing it as a string
                string userTask = Console.ReadLine();
                Console.WriteLine("How many people are in your party?");//prompting the user to enter how many people are in there party
                string people = Console.ReadLine();

                while (userTask == "1")//while loop for Action
                {
                    if (people == "0")// if statements for how many people the user has for in task 1
                    {
                        Console.WriteLine("Take your sneakers and go rock climbing brah.");
                        break;
                    }

                    else if (people == "1" || people == "2" || people == "3" || people == "4")
                    {
                        Console.WriteLine("Hop in your subaru so you and your broskis can hit the montains!");
                        break;
                    }

                    else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                    {
                        Console.WriteLine("You and your bro's can take the shaggin wagon to the montain!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Whoa dude you'er gonna need to take a plane to those montains!");
                        break;
                    }

                }

                while (userTask == "2")// while loop for Chil Times
                {
                    if (people == "0") //if statment for the amount of people in the chill times loop
                    {
                        Console.WriteLine("Grab your loafers and and take a stroll throught the park you lonly sack");
                        break;
                    }

                    else if (people == "1" || people == "2" || people == "3" || people == "4")
                    {
                        Console.WriteLine("You can take your prius to the park, because you seem to have some human friends");
                        break;
                    }

                    else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                    {
                        Console.WriteLine("Ok wow you've got a lot of human friends, you should take your van to the park.\nMaybe you have room for a lonly computer program in that van?");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Um wow ok you can take a plane to this so called \"park\". \nYou could have also extended a ivite to your favorite computer program but whatever");
                        break;
                    }

                }

                while (userTask == "3")//while loop for the Danger Zone 
                {

                    if (people == "0")// if statement for how many people are in the danger zone
                    {
                        Console.WriteLine("Grab your shoes anf your best chute, it's time for BASE jumping");
                        break;
                    }

                    else if (people == "1" || people == "2" || people == "3" || people == "4")
                    {
                        Console.WriteLine("You and your friends can put your BASE jumping chutes in the back of the jetta, make sure your REVVIN' UP YOUR ENGINE, LISTEN TO HER HOWLIN' ROAR!");
                        break;
                    }

                    else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                    {
                        Console.WriteLine("Jeez ok your gonna need to take a van to the jump site, make sure you take the HIGHWAY TO THE DANGER ZONE!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("You and your gonna have to fly to that summit, it'll take RIGHT IN TO THE DANGER ZONE");
                        break;
                    }

                }

                while (userTask == "4")//loop for good food 
                {
                    if (people == "0")// if statments for good food
                    {
                        Console.WriteLine("Grab your sneakers and head to the nearest ramen shop");
                        break;
                    }

                    else if (people == "1" || people == "2" || people == "3" || people == "4")
                    {
                        Console.WriteLine("You and your friends can hop in the car hit up the best sushi joint");
                        break;
                    }

                    else if (people == "5" || people == "6" || people == "7" || people == "8" || people == "9" || people == "10")
                    {
                        Console.WriteLine("Take the van and you and your buddies can try a chinese hot pot restaurant. Trust me it's delcious");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Ok your gonna need a plane for that many people. But if you'er taking a plane to go out to eat you gotta rethink your life choices");
                        break;
                    }


                }

                Console.WriteLine("Would you like to to run this program agian y/n");// asking the user to if they want to restart or quit the program
                string userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == "y")//if the enter a y it will continue back to the top of the loop 
                {
                    continue;

                }
                else if (userAnswer == "n")//if n is entered the the loop will break and the program will end
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

            }
        }

    }
}
