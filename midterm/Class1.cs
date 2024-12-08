using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace game
{


    internal class Gamemenu
    {
        private string characterName;
        private string characterAge;

        string gender;
        int number;
        string appeal;
        int health = 100;
        int maxhealth = 100;
        int consoleWidth = Console.WindowWidth;
        public static string CenterText(string text, int consoleWidth)
        {
            if (text.Length >= consoleWidth)
                return text; // If the text is too long, just return it without centering.

            int spaces = (consoleWidth - text.Length) / 2;
            return new string(' ', spaces) + text;
        }



        public void chooseCharacter()

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("╔═══════════════════════╗", consoleWidth));
            Console.WriteLine(CenterText("║  Welcome to the game  ║", consoleWidth));
            Console.WriteLine(CenterText("╚═══════════════════════╝", consoleWidth));
            Console.WriteLine(CenterText("╔═══════════════════════╗", consoleWidth));
            Console.WriteLine(CenterText("║ Press Enter to Start  ║", consoleWidth));
            Console.WriteLine(CenterText("╚═══════════════════════╝", consoleWidth));
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "Please enter your character information.");
            Console.WriteLine("Enter your name:");
            characterName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            characterAge = Console.ReadLine();
            Console.WriteLine("Is your character male? (yes/no)\n(if you don't want to answer this question pass it)");
            gender = Console.ReadLine();


            if (gender == "yes")
            {
                gender = "Male";
            }
            else if (gender == "no")
            {
                gender = "Female";

            }
            else
            {
                gender = "*";
            }
            Console.WriteLine("Creating a character according to your preferences, Please wait .");
            for (int i = 0; i < 5; i++)
            {
                Console.Beep(100, 500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Creating...");
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Your character succesfully created.");
            Console.WriteLine("Name:" + characterName);
            if (int.TryParse(characterAge, out number))// tryparse methodu için ai dan yardım aldım.
            {
                Console.WriteLine("Age:" + characterAge);
            }
            else
            {
                Console.WriteLine("Age is not defiened.");

            }
            Console.WriteLine("Gender:" + gender);
        }
        public void quest()
        {
            string appeal;
            if (gender == "Male")
                appeal = "Mr.";
            else if (gender == "Female")
                appeal = "Ms.";
            else
                appeal = "";
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Welcome Again " + appeal + characterName +
                " Get ready to embark an adventurous game!!!");
            Thread.Sleep(5000);
            Console.Clear();
            Console.Beep(600, 500);
            Console.WriteLine("Game will start in 3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Beep(600, 500);
            Console.WriteLine("Game will start in 2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Beep(600, 500);
            Console.WriteLine("Game will start in 1");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Beep(600, 500);
            Console.WriteLine("GOOD LUCK");
            Thread.Sleep(1500);
            Console.Clear();



        }
        public void question1()
        {
         
            Console.WriteLine(appeal + characterName + " you find yourself standing at a crossroads in a dark forest.");
            Console.WriteLine("Do you:(Enter a number)");
            Console.WriteLine("1. Take the left path, where you hear strange noises.");
            Console.WriteLine("2. Take the right path, which is quiet but seems eerie.");
            Console.WriteLine("3. Stay where you are and wait for help.");
            bool valid1 = false;
            while (!valid1)
            {
                string choice1 = Console.ReadLine();


                if (choice1 == "1")
                {
                    Console.WriteLine("You bravely walk down the left path, your heart racing. The noises grow louder...");
                    valid1 = true;

                }
                else if (choice1 == "2")
                {
                    Console.WriteLine("You cautiously step down the quiet path. The silence is unnerving...");
                    valid1 = true;
                }
                else if (choice1 == "3")
                {
                    Console.WriteLine("You decide to wait. Hours pass, but no help arrives. The forest feels even more ominous now...");
                    valid1 = true;
                }
                else
                {
                    { Console.WriteLine("You make invalid choice, pick again!"); }
                }

            }
            Thread.Sleep(3000);
            Console.Clear();
        }
        public void question2()
        {

            Console.WriteLine(appeal + characterName + " you encounter a hungry wolf in the forest. ");
            Console.WriteLine("Do you:(Enter a number)");
            Console.WriteLine("1. Fight the wolf.");
            Console.WriteLine("2. Throw some food to distract it.");
            Console.WriteLine("3. Run away.");

            bool valid2 = false;
            while (!valid2)
            {
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("You bravely charge at the wolf with all your might. After a tense struggle, you manage to scare it away, but you're left with a few scratches.");
                    health -= 30;
                    valid2 = true;
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("The wolf lunges at you, but you skillfully dodge its attack. Using a nearby stick, you fend it off and it retreats into the forest.");
                    valid2 = true;
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine("Despite your courage, the wolf is too strong. You narrowly escape with some injuries, but your determination keeps you going.");
                    health -= 50;
                    valid2 = true;
                }
                else
                {
                    Console.WriteLine("You make invalid choice, pick again!");


                }

            }
            Thread.Sleep(3000);
            Console.Clear();

        }
        public void question3()
        {

            Console.WriteLine(appeal + characterName + " You stumble upon a dark and ominous cave. Strange noises echo from within. What will you do? ");
            Console.WriteLine("Do you:(Enter a number)");
            Console.WriteLine("1. Enter the cave to investigate.");
            Console.WriteLine("2. Wait outside until the noises stop.  ");
            Console.WriteLine("3. Leave the area immediately.  ");

            bool valid3 = false;
            while (!valid3)
            {
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("You enter the cave , but a trap injures you! ");
                    health -= 20;
                    valid3 = true;
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("You wait outside patiently, but lose valuable time");
                    health -= 10;
                    valid3 = true;
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine("You run away quickly but trip and twist your ankle.");
                    health -= 10;
                    valid3 = true;
                }
                else
                {
                    Console.WriteLine("You make invalid choice, pick again!");


                }

            }
            Thread.Sleep(3000);
            Console.Clear();

        }
        public void question4()
        {

            Console.WriteLine(appeal + characterName + " a strange-colored river blocks your path. It might be poisonous. What will you do? ");
            Console.WriteLine("Do you:(Enter a number)");
            Console.WriteLine("1. Swim across the river.");
            Console.WriteLine("2. Use branches or stones to cross carefully.  ");
            Console.WriteLine("3. Search for a safer crossing point along the river.");

            bool valid4 = false;
            while (!valid4)
            {
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine(" The water burns your skin! You barely make it across.");
                    health -= 30;
                    valid4 = true;
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("You manage to cross with effort.");
                    health -= 10;
                    valid4 = true;
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine(" You find a safer route but waste precious time.");
                    health -= 10;
                    valid4 = true;
                }
                else
                {
                    Console.WriteLine("You make invalid choice, pick again!");


                }

            }
            Thread.Sleep(3000);
            Console.Clear();

        }

        public void healthbar()
        {
            int barlength = 20;
            int filled = (health * barlength) / maxhealth;
            string healthbar = new string('■', filled) + new string('-', barlength - filled);

            int consoleWidth = Console.WindowWidth;
            string locHealthbar = healthbar.PadLeft(consoleWidth - barlength);

            string text = "HEALTH";
            string loctext = text.PadLeft(consoleWidth - barlength - 14);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(loctext);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(locHealthbar);
            Console.ForegroundColor = ConsoleColor.White;

        }
       
        

        public void rule()
        {
            if (health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("╔═══════════════════════╗", consoleWidth));
                Console.WriteLine(CenterText("║       GAME OVER       ║", consoleWidth));
                Console.WriteLine(CenterText("╚═══════════════════════╝", consoleWidth));
                Environment.Exit(0); 
            }
        }
        public void finish()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("", consoleWidth));
            Console.WriteLine(CenterText("╔═══════════════════════╗", consoleWidth));
            Console.WriteLine(CenterText("║          WIN          ║", consoleWidth));
            Console.WriteLine(CenterText("╚═══════════════════════╝", consoleWidth));
         
        }
      

    }
}
    


