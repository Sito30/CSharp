namespace ChooseYourOwnAdventure
{
    internal class Project
    {
        static void Main(string[] args)
        {
            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            //Start of story
            Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall.\nDo you go investigate?");
            Console.Write("Type YES or NO: ");
            //store user's decision
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();
            //Story progression by users choice
            if (noiseChoice == "NO")
            {
            Console.Write("Not much of an adventure if we don't leave our room!");
            Console.Write("THE END.");
            }
            else if (noiseChoice == "YES")
            { 
                Console.Write("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
                Console.Write("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.Write("A voice behind the door speaks./n It says,\"Answer this riddle: \"");
                    Console.Write("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.Write("Type your answer:");
                    string riddleAnswer = Console.ReadLine();
                    riddleAnswer = riddleAnswer.ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                    Console.Write($"The door opens and {riddleAnswer} is there. You turn off the light and run back to your room and lock the door.\nTHE END");
                    }
                    else
                    {
                    Console.Write("You answered incorrectly. A shadow appears from under the door and a shadowy hand appears from under and grabs ahold of you foot.");
                    Console.Write("It starts to slowly drag you to the shadow realm and no help appears before you!\nTHE END!");
                    }
                }
                else if (doorChoice == "OPEN")
                    {
                    Console.Write("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number 1-3:");
                    string keyChoice = Console.ReadLine();
                    keyChoice = keyChoice.ToUpper();
                    switch (keyChoice)
                        {
                        case "1":
                            Console.Write("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
                            break;
                        case "2":
                            Console.Write("You choose the second key. The door doesn't open.\nYou hear a weird scratching sound behind the door!\nTHE END?");
                            break;
                        case"3":
                            Console.Write("You choose the second key. The door doesn't open.\nYou hear a weird scratching sound behind the door!\nTHE END?");
                            break;
                        default:
                            break;
                        }
                }
            }
            
        }
    }
}
