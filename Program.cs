// the ourAnimals array will store the following: 
using System.Collections;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal's age");
    Console.WriteLine(" 6. Edit an animal's personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");

    // // pause code execution
    // readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            Console.Clear();

            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                Console.WriteLine();

                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                while (anotherPet == "y" && petCount < maxPets)
                {
                    // Console.Write("ID #: ");

                    // do
                    // {
                    //     readResult = Console.ReadLine();

                    //     if (readResult != "")
                    //     {
                    //         ourAnimals[petCount, 0] = "ID #: " + readResult;
                    //     }
                    // } while (readResult == "");

                    Console.WriteLine("\n\rEnter \"dog\" or \"cat\" to begin a new entry");
                    Console.Write("Species: ");

                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult == "cat" || readResult == "dog")
                        {
                            ourAnimals[petCount, 0] = "ID #: " + readResult.Substring(0, 1) + (petCount + 1).ToString();
                            ourAnimals[petCount, 1] = "Species: " + readResult;
                        }
                        else
                        {
                            Console.WriteLine("Enter \"dog\" or \"cat\".");
                        }
                    } while (readResult != "dog" && readResult != "cat");

                    Console.WriteLine();
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    Console.Write("Age: ");

                    int petAge;
                    bool validEntry;

                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult == "?")
                        {
                            ourAnimals[petCount, 2] = "Age: " + readResult;
                            validEntry = true;
                        }
                        else if (int.TryParse(readResult, out petAge) == true)
                        {
                            ourAnimals[petCount, 2] = "Age: " + petAge.ToString();
                            validEntry = true;
                        }
                        else
                        {
                            validEntry = false;
                        }
                    } while (readResult == "" || validEntry == false);

                    Console.WriteLine();
                    Console.WriteLine("Enter a nickname for the pet");
                    Console.Write("Nickname: ");
                    readResult = Console.ReadLine();
                    if (readResult == "")
                    {
                        readResult = "tbd";
                    }
                    ourAnimals[petCount, 3] = "Nickname: " + readResult;

                    Console.WriteLine();
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    Console.Write("Physical description: ");
                    readResult = Console.ReadLine();
                    if (readResult == "")
                    {
                        readResult = "tbd";
                    }
                    ourAnimals[petCount, 4] = "Physical description: " + readResult;

                    Console.WriteLine();
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    Console.Write("Personality: ");
                    readResult = Console.ReadLine();
                    if (readResult == "")
                    {
                        readResult = "tbd";
                    }
                    ourAnimals[petCount, 5] = "Personality: " + readResult;

                    Console.WriteLine();
                    Console.WriteLine("Do you want to enter info for another pet?");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");

                    petCount++;
                }
            }
            else
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 2] == "Age: ?")
                    {
                        int petAge;
                        bool validEntry = false;
                        Console.WriteLine();
                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");

                        do
                        {
                            readResult = Console.ReadLine();
                            validEntry = int.TryParse(readResult, out petAge);

                            if (validEntry == true)
                            {
                                ourAnimals[i, 2] = "Age: " + petAge.ToString();
                            }
                        } while (validEntry == false);
                    }

                    if (ourAnimals[i, 4] == "Physical description: tbd" || ourAnimals[i, 4] == "Physical description: ")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");

                        do
                        {
                            readResult = Console.ReadLine();

                            ourAnimals[i, 4] = "Physical description: " + readResult;

                        } while (readResult == "" || readResult == null);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    if (ourAnimals[i, 3] == "Nickname: tbd" || ourAnimals[i, 3] == "Nickname: ")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");

                        do
                        {
                            readResult = Console.ReadLine();
                            ourAnimals[i, 3] = "Nickname: " + readResult;

                        } while (readResult == "" || readResult == null);
                    }

                    if (ourAnimals[i, 5] == "Personality: tbd" || ourAnimals[i, 5] == "Personality: ")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");

                        do
                        {
                            readResult = Console.ReadLine();

                            ourAnimals[i, 5] = "Personality: " + readResult;

                        } while (readResult == "" || readResult == null);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

        case "5":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

        case "6":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

        case "7":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

        case "8":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            break;

        default:
            Console.WriteLine("There is not such option. Please select a valid number.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }
} while (menuSelection.ToLower() != "exit");