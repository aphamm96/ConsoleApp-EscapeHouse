using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EscapeHouse
{
    public class ProgramUI
    {

        int lighterHave = 0; //done
        int bookCode = 0; //done
        int codeHave = 0; //done
        int ladderHave = 1; //done
        int waterCanHave = 0; //done
        int poolBallHave = 0; //done
        int crowbarHave = 0; //done
        int escapeKey = 0; //done
        bool tableFlipped = false; //done
        int filledWater = 0; //done
        bool crateBroken = false; //done
        public void Run()
        {
            PlayGame();
        }

        private void PlayGame()
        {
            Console.WriteLine("You awaken alone in the foyer of a mysterious house.");
            Console.WriteLine("You do not know how you got here, but you know you must escape.\n");
            Console.WriteLine("You move around the house by typing directions.\n" +
                "Each room you can examine to find things of note.\n" +
                "Anything that is in all caps LIKE THIS can be interacted with. by typing the object name.");
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();
            Foyer();
        }
        private void Foyer()
        {
            bool foyerValid = false;
            while (!foyerValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Foyer. Do you go UP, LEFT, RIGHT, DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();

                if (response == "UP")
                {
                    Console.WriteLine("You head up to the dining hall.");
                    Thread.Sleep(2000);
                    DiningHall();
                    foyerValid = true;

                }
                else if (response == "LEFT")
                {
                    Console.WriteLine("You head left into the conservatory.");
                    Thread.Sleep(2000);
                    Conservatory();
                    foyerValid = true;

                }
                else if (response == "RIGHT")
                {
                    Console.WriteLine("You head right into the living room.");
                    Thread.Sleep(2000);
                    LivingRoom();
                    foyerValid = true;

                }
                else if (response == "DOWN")
                {
                    if (escapeKey < 1)
                    {
                        Console.WriteLine("Try as you might, you cannot get the door open. You need a key to unlock it.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (escapeKey == 1)
                    {
                        Console.WriteLine("You insert the key into the key hole. It takes some forcing, but eventually it turns with a clack.\n" +
                            "The door slowly pushes open. You are free to escape the house.");
                        Escaped();
                        foyerValid = true;
                    }
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("You look around...you notice a RUG, a CLOCK, ARMOR, and a TOOLBOX.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                }
                else if (response == "RUG")
                {
                    Console.WriteLine("A large decorative rug is sprawled across the floor.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "CLOCK")
                {
                    Console.WriteLine("An ornate grandfather clock stands against the wall... good heavens look at the time! You're going to be late!\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "ARMOR")
                {
                    Console.WriteLine("A suit of armor stands in the corner... were those red eyes glowing in the eye slot?\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "TOOLBOX")
                {
                    if (ladderHave < 1)
                    {
                        Console.WriteLine("You cannot reach the toolbox. Perhaps a tool will let you reach it?\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (ladderHave == 1)
                    {
                        Console.WriteLine("You use the ladder to climb up to the toolbox. It is empty except for a crowbar.\n" +
                            "You don't know why, but you have a strong urge to hit crabs with it.\n" + //HL2 reference
                            "Regardless, you now have a crowbar.\n" +
                            "Press any key to continue...");
                        crowbarHave += 1;
                        ladderHave += 1;
                        Console.ReadKey();
                    }
                    else if (ladderHave > 1)
                    {
                        Console.WriteLine("There is nothing left in the toolbox for you to use.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }
        private void DiningHall()
        {
            bool diningValid = false;
            while (!diningValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the dining hall. Do you go UP, LEFT, RIGHT, DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();

                if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the foyer.");
                    Thread.Sleep(2000);
                    Foyer();
                    diningValid = true;
                }
                else if (response == "UP")
                {
                    Console.WriteLine("You head up into the kitchen.");
                    Thread.Sleep(2000);
                    Kitchen();
                    diningValid = true;
                }
                else if (response == "LEFT")
                {
                    Console.WriteLine("You head left into the library.");
                    Thread.Sleep(2000);
                    Library();
                    diningValid = true;
                }
                else if (response == "RIGHT")
                {
                    Console.WriteLine("You head right into the game room.");
                    Thread.Sleep(2000);
                    GameRoom();
                    diningValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("The dining room is filled with many things, however a not pushed in CHAIR,\n"
                        + "a PICTURE on the wall, the TABLE, and the CANDLES seem to interest you heavily.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "CHAIR")
                {
                    Console.WriteLine("You push the chair in. Good for you!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "PICTURE")
                {
                    Console.WriteLine("You squint at the picture trying to find its hidden meaning. There is none you can see.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "TABLE")
                {
                    Console.WriteLine("There is a dusty tablecloth on the table. It appears nobody has eaten here in a long time.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "CANDLES")
                {
                    if (lighterHave < 1)
                    {
                        Console.WriteLine("These candles look like they can be lit with the right tool.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (lighterHave == 1)
                    {
                        Console.WriteLine("You light the candles with the lighter. A panel opens with something inside it.\n" +
                            "Inside the panel was a watering can. Something like this belongs in a garden shed, right?\n" +
                            "You now have a watering can.\n" +
                            "Press any key to continue...");
                        lighterHave += 1;
                        waterCanHave += 1;
                        Console.ReadKey();
                    }
                    else if (lighterHave > 1)
                    {
                        Console.WriteLine("You already lit the candles with the lighter.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
            }

        }
        private void Conservatory()
        {
            bool conservatoryValid = false;
            while (!conservatoryValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Conservatory. Do you go UP, RIGHT, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();

                if (response == "UP")
                {
                    Console.WriteLine("You head up into the library.");
                    Thread.Sleep(2000);
                    Library();
                    conservatoryValid = true;
                }
                else if (response == "RIGHT")
                {
                    Console.WriteLine("You head right into the foyer.");
                    Thread.Sleep(2000);
                    Foyer();
                    conservatoryValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("When you enter the Conservatory, you notice it is obviously full of plants\n" +
                        "One PLANT in particular stands out. It is near a RAKE.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "RAKE")
                {
                    Console.WriteLine("You step on the rake. It hits you in the face. What did you think was going to happen?");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "PLANT")
                {
                    if (filledWater < 1)
                    {
                        Console.WriteLine("This plant looks thirsty. If you had some water, you could fulfill it's needs.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (filledWater == 1)
                    {
                        Console.WriteLine("You sprinkle water onto the plant. It flourishes once more, and a cue ball falls out of it.\n" +
                            "You don't know how or why the plant had a cue ball. It's best not to question it.\n" +
                            "You now have a cue ball.\n" +
                            "Press any key to continue...");
                        poolBallHave += 1;
                        filledWater += 1;
                        Console.ReadKey();
                    }
                    else if (filledWater > 1)
                    {
                        Console.WriteLine("The plant has already had some water. It needs no more.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }

        private void Library()
        {
            bool libraryValid = false;
            while (!libraryValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Library. Do you go UP, RIGHT, DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();

                if (response == "UP")
                {
                    Console.WriteLine("You head up into the study.");
                    Thread.Sleep(2000);
                    Study();
                    libraryValid = true;
                }
                else if (response == "RIGHT")
                {
                    Console.WriteLine("You head right into the dining hall.");
                    Thread.Sleep(2000);
                    DiningHall();
                    libraryValid = true;
                }
                else if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the conservatory.");
                    Thread.Sleep(2000);
                    Conservatory();
                    libraryValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("The Library is filled with shelves of BOOKS of all sorts. Each shelf has a LADDER,\n"
                        + "there is also a TABLE with some books on it.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "BOOK")
                {
                    if (bookCode < 1)
                    {
                        Console.WriteLine("There are so many books here. It would take a lifetime to read them all.\n" +
                            "Press any key to continue.");
                        Console.ReadKey();
                    }
                    else if (bookCode == 1)
                    {
                        Console.WriteLine("Using the code from underneath the table, you open Moby Dick to page 79 and find a numerical code there. This should come in handy.\n" +
                            "Press any key to continue...");
                        bookCode += 1;
                        codeHave += 1;
                        Console.ReadKey();
                    }
                    else if (bookCode > 1)
                    {
                        Console.WriteLine("There are so many books... who even wants this many books anyways?\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (response == "TABLE")
                {
                    Console.WriteLine("A table sits along the wall covered in books. None of them appear to be for children.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "LADDER")
                {
                    Console.WriteLine("You climb up the ladder. You climb down the ladder.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void LivingRoom()
        {
            bool livingValid = false;
            while (!livingValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Living Room. Do you go UP, LEFT, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();

                if (response == "UP")
                {
                    Console.WriteLine("You head up into the game room.");
                    Thread.Sleep(2000);
                    GameRoom();
                    livingValid = true;
                }
                else if (response == "LEFT")
                {
                    Console.WriteLine("You head left into the foyer.");
                    Thread.Sleep(2000);
                    Foyer();
                    livingValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("Upon entering the Living Room, you notice a SHELF, PURSE, and a TABLE.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "TABLE")
                {
                    if (tableFlipped == false)
                    {
                        Console.WriteLine("You approach the table. You feel a sudden urge to flip the table, and you do.\n" +
                            "The table goes flying end over end and crashes into the wall. It was beautiful.\n" +
                            "Now that the table is lying upside down, you can see something written on the bottom. It looks like... a clue?\n" +
                            "It says 'Moby Dick 79'. What a peculiar message.\n" +
                            "Press any key to continue...");
                        bookCode += 1;
                        tableFlipped = true;
                        Console.ReadKey();

                    }
                    else if (tableFlipped == true)
                    {
                        Console.WriteLine("The table remains flipped. You feel pretty proud of yourself for doing that.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (response == "SHELF")
                {
                    Console.WriteLine("A wide variety of pictures sit on the shelf. You don't recognize anybody in them.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "PURSE")
                {
                    Console.WriteLine("You touch the purse. A voice rings out. 'THAT'S MY PURSE! I DON'T KNOW YOU!'\n" +
                        "Fearing injury, you decide to leave the purse alone.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void Study()
        {
            bool studyValid = false;
            while (!studyValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Study. Do you go DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();
                if (response == "RIGHT")
                {
                    Console.WriteLine("You head right into the kitchen.");
                    Thread.Sleep(2000);
                    Kitchen();
                    studyValid = true;
                }
                else if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the library.");
                    Thread.Sleep(2000);
                    Library();
                    studyValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("The Study appears to be dark, although the fire is illuminating parts of the room.\n"
                        + "You make out a DESK, a GLOBE, and an obvious FIREPLACE.\n" +
                        "On the desk appears to be a LIGHTER.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "LIGHTER")
                {
                    if (lighterHave == 0)
                    {
                        Console.WriteLine("You pick up the lighter.\n" +
                            "Press any key to continue...");
                        lighterHave += 1;
                        Console.ReadKey();
                    }
                    else if (lighterHave > 0)
                    {
                        Console.WriteLine("You already have the lighter.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (response == "FIREPLACE")
                {
                    Console.WriteLine("The fire illuminates the dark room, revealing an embarassing family photo.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "GLOBE")
                {
                    Console.WriteLine("You spin the globe. Suddenly it ramps up to a speed of Mach 5. Should probably call a Foundation or something.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "DESK")
                {
                    Console.WriteLine("A large elegant desk sits in the middle of the Study.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void Kitchen()
        {
            bool kitchenValid = false;
            while (!kitchenValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Kitchen. Do you go LEFT, DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();
                if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the dining hall.");
                    Thread.Sleep(2000);
                    DiningHall();
                    kitchenValid = true;
                }
                else if (response == "LEFT")
                {
                    Console.WriteLine("You head left into the study.");
                    Thread.Sleep(2000);
                    Study();
                    kitchenValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("This kitchen is filthy! The SINK is in disrepair, I'm sure it still works.\n"
                        + "The FRIDGE smells! The CABINETS are in shambles, and where is the STOVE?");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "SINK")
                {
                    if (waterCanHave < 1)
                    {
                        Console.WriteLine("You turn the water on. Water flows from the faucet down the drain. You turn the water off.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (waterCanHave == 1)
                    {
                        Console.WriteLine("You turn the water on and fill up the watering can. You now have a can that can water things.\n" +
                            "Press any key to continue...");
                        waterCanHave += 1;
                        filledWater += 1;
                        Console.ReadKey();
                    }
                    else if (waterCanHave > 1)
                    {
                        Console.WriteLine("You wash your hands.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }

                }
                else if (response == "STOVE")
                {
                    Console.WriteLine("There is a space where the stove should be! This kitchens not the same without you!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "FRIDGE")
                {
                    Console.WriteLine("Something needed to be thrown away years ago...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "CABINETS")
                {
                    Console.WriteLine("Broken dishes scatter within the cabinets, covered in dust and cobwebs.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                }

            }
        }
        private void Bedroom()
        {
            bool bedroomValid = false;
            while (!bedroomValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Bedroom. Do you go UP, DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();
                if (response == "UP")
                {
                    Console.WriteLine("You head up into the attic.");
                    Thread.Sleep(2000);
                    Attic();
                    bedroomValid = true;
                }
                else if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the game room.");
                    Thread.Sleep(2000);
                    GameRoom();
                    bedroomValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("This bedroom is pretty standard with a CLOSET, BED, VANITY and a...LADDER?\n"
                        + "Upon further inspection there appears to be a LARGE CHEST and SMALL CHEST.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "CLOSET")
                {
                    Console.WriteLine("You open the closet. Inside you find skeletons. You close the closet, unsure of what you just saw.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "BED")
                {
                    Console.WriteLine("Clean, pristene sheets cover the bed, yet the rest of the room is dusty.\n" +
                        "Best not to think about it too much.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "VANITY")
                {
                    Console.WriteLine("You look into the vanity's mirror. Nothing looks back at you.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "LADDER")
                {
                    Console.WriteLine("There are a lot of ladders in this house...\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "LARGE CHEST")
                {
                    Console.WriteLine("You try to open the chest. But this is a soviet chest. The chest opens you.\n" +
                        "Thankfully, you are unharmed.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "SMALL CHEST")
                {
                    Console.WriteLine("You try to open the chest. The chest opens up about it's feelings.\n" +
                        "You have a long and engaging talk with the chest.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void Attic()
        {
            bool atticValid = false;
            while (!atticValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Attic. Do you go DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();
                if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the bedroom.");
                    Thread.Sleep(2000);
                    Bedroom();
                    atticValid = true;
                }
                else if (response == "EXAMINE")
                {
                    if (crateBroken == false)
                    {
                        Console.WriteLine("Inside this dusty attic lies various FURNITURE covered in sheets. In the corner, a large CRATE can be seen.\n" +
                            "The only way out is back down the ladder.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (crateBroken == true)
                    {
                        Console.WriteLine("Splinters from the CRATE are strewn everywhere. A small SAFE sits where the CRATE once sat.\n" +
                            "The only way out is back down the ladder.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (response == "CRATE")
                {
                    if (crowbarHave < 1)
                    {
                        Console.WriteLine("This appears to be a sturdy crate. The lid is nailed shut.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (crowbarHave == 1)
                    {
                        Console.WriteLine("With a mighty swing from the crowbar, the crate shatters into splinters, revealing a safe inside.\n" +
                            "Press any key to continue...");
                        crowbarHave += 1;
                        crateBroken = true;
                        Console.ReadKey();
                    }
                    else if (crowbarHave > 1)
                    {
                        Console.WriteLine("You examine the splinters. You discover nothing anomalous.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (response == "SAFE")
                {
                    if (crateBroken == true)
                    {
                        if (codeHave < 1)
                        {
                            Console.WriteLine("You input random numbers, but you do not get the right combination.\n" +
                                "Press any key to continue...");
                            Console.ReadKey();
                        }
                        else if (codeHave == 1)
                        {
                            Console.WriteLine("You carefully input the code you found in the book. Fifteen digits later, there's a beep. The safe swings open.\n" +
                                "Inside the safe you find an ornate key.\n" +
                                "Press any key to continue...");
                            escapeKey += 1;
                            codeHave += 1;
                            Console.ReadKey();
                        }
                        else if (codeHave > 1)
                        {
                            Console.WriteLine("Nothing remains in the safe.\n" +
                                "Press any key to continue.");
                            Console.ReadKey();
                        }


                    }
                    else if (crateBroken == false)
                    {

                    }

                }
                else if (response == "FURNITURE")
                {
                    Console.WriteLine("Dusty sheets cover all the furniture in the attic. You lift a sheet and a spider crawls out and disappears from view.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }

            }
        }
        private void GameRoom()
        {
            bool gameroomValid = false;
            while (!gameroomValid)
            {
                Console.Clear();
                Console.WriteLine("You are in the Game Room. Do you go UP, LEFT, DOWN, or EXAMINE?");
                string response = Console.ReadLine().ToUpper();
                if (response == "DOWN")
                {
                    Console.WriteLine("You head down into the living room.");
                    Thread.Sleep(2000);
                    LivingRoom();
                    gameroomValid = true;
                }
                else if (response == "LEFT")
                {
                    Console.WriteLine("You head left into the dining hall.");
                    Thread.Sleep(2000);
                    DiningHall();
                    gameroomValid = true;
                }
                else if (response == "UP")
                {
                    Console.WriteLine("You head up into the bedroom.");
                    Thread.Sleep(2000);
                    Bedroom();
                    gameroomValid = true;
                }
                else if (response == "EXAMINE")
                {
                    Console.WriteLine("The game features a BILLIARDS table centered prominently in the room. Along the wall, various shelves host all sorts of board games.\n" +
                        "Alongside one wall, and ARCADE machine sits, it's screen flickering every few seconds.\n" +
                        "Along another, a BALL RACK sits, with cue sticks next to it. It seems they have been heavily used in their lifetime.\n" +
                        "The the north is the bedroom, the south the living room, and to the east the dining hall.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "BALL RACK")
                {
                    if (poolBallHave < 1)
                    {
                        Console.WriteLine("There is an empty space in the ball rack. It looks like something used to be there.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (poolBallHave == 1)
                    {
                        Console.WriteLine("You put the cue ball back in it's spot, and there is a loud crash behind you.\n" +
                            "A ladder has fallen onto the pool table. Where did it come from? Where did it go? Where did it come from Cotton-Eye-Joe?\n" +
                            "You now have a ladder from the ceiling.\n" +
                            "Press any key to continue.");
                        ladderHave += 1;
                        poolBallHave += 1;
                        Console.ReadKey();
                    }
                    else if (poolBallHave > 1)
                    {
                        Console.WriteLine("All the balls are in a row.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                    }

                }
                else if (response == "BILLIARDS")
                {
                    Console.WriteLine("Dust covers the billiards table. Surprisingly it looks like someone played a game recently.\n" +
                        "Maybe a ghost?\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
                else if (response == "ARCADE")
                {
                    Console.WriteLine("You play a round of a fighting game. Then you realize the machine isn't plugged in. You quickly step away.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        public void Escaped()
        {
            Console.Clear();
            Console.WriteLine("Congratulations!\n" +
                "\n" +
                "You have escaped from the house!\n" +
                "\n" +
                "YOU ARE WINNER");
            Console.ReadKey();
        }
    }
}
