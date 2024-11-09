// the ourAnimals array will store the following: 
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
string[][] ourAnimals = new string[maxPets][];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++) {
    switch (i) {
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
            animalPhysicalDescription = "tbd";
            animalPersonalityDescription = "tbd";
            animalNickname = "tbd";
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

    ourAnimals[i] = new string[] {
                            "ID #: " + animalID,
                            "Species: " + animalSpecies,
                            "Age: " + animalAge,
                            "Nickname: " + animalNickname,
                            "Physical description: " + animalPhysicalDescription,
                            "Personality: " + animalPersonalityDescription
                        };
}

// display the top-level menu options
do {
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
    if (readResult != null) {
        menuSelection = readResult.Trim().ToLower();
    }

    Console.WriteLine();
    switch (menuSelection) {
        case "1":
            foreach (string[] descricao_animal in ourAnimals) {
                if (descricao_animal[0] == "ID #: ") {
                    continue;
                }

                foreach (string caracteristica in descricao_animal) {
                    Console.WriteLine(caracteristica);
                }

                Console.WriteLine();
            }
            break;
        
        case "2":
            int cont_pets = 0;
            foreach (string[] descricao_animal in ourAnimals) {
                cont_pets += (descricao_animal[0] != "ID #: ") ? 1 : 0;
            }

            if (cont_pets < maxPets) {
                Console.WriteLine($"We currently have {cont_pets} pets that need homes. We can manage {(maxPets - cont_pets)} more.");
            }

            string outro_pet = "y";
            while (outro_pet == "y" && cont_pets < maxPets) {
                Console.WriteLine("\"cat\" or \"dog\"?");
                do {
                    readResult = Console.ReadLine();
                    animalSpecies = (readResult != null) ? readResult.Trim().ToLower() : "";
                } while (animalSpecies != "cat" && animalSpecies != "dog");

                animalID = animalSpecies[0] + (cont_pets + 1).ToString();

                Console.WriteLine("Enter the pet's age or \"?\" if unknown.");
                int parse_dump;
                do {
                    readResult = Console.ReadLine();
                    animalAge = (!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "";

                } while (animalAge != "?" && !int.TryParse(animalAge, out parse_dump));

                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                animalPhysicalDescription = (!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "tbd";

                Console.WriteLine("Enter a description of the pet's personality (likes os dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                animalPersonalityDescription = (!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "tbd";

                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                animalNickname = (!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "tbd";

                ourAnimals[cont_pets] = new string[] {
                            "ID #: " + animalID,
                            "Species: " + animalSpecies,
                            "Age: " + animalAge,
                            "Nickname: " + animalNickname,
                            "Physical description: " + animalPhysicalDescription,
                            "Personality: " + animalPersonalityDescription
                        };
                cont_pets++;

                Console.WriteLine("Do you want to enter info for another pet? (y/n)");
                do {
                    readResult = Console.ReadLine();
                    outro_pet = (!string.IsNullOrEmpty(readResult)) ? readResult.Trim().ToLower() : "";
                } while (!"y n".Contains(outro_pet));
            }

            if (cont_pets == maxPets) {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            }
            break;

        case "3":
            foreach (string[] descricao_animal in ourAnimals) {
                if (descricao_animal[0] == "ID #: ") {
                    continue;
                }
                string id_pet = descricao_animal[0].Substring(6);

                while (descricao_animal[2].Substring(5) == "?") {
                    Console.WriteLine($"Enter an age for ID #: {id_pet}");
                    readResult = Console.ReadLine();
                    animalAge = (!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "";

                    int parse_dump;
                    descricao_animal[2] = "Age: " + ((int.TryParse(animalAge, out parse_dump)) ? animalAge : "?");
                }
                
                while (descricao_animal[4].Substring(22) == "tbd") {
                    Console.WriteLine($"Enter a physical description for ID #: {id_pet}");
                    readResult = Console.ReadLine();
                    descricao_animal[4] = "Physical description: " + ((!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "tbd");
                }
            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            break;
        
        case "4":
            foreach (string[] descricao_animal in ourAnimals) {
                if (descricao_animal[0] == "ID #: ") {
                    continue;
                }
                string id_pet = descricao_animal[0].Substring(6);

                while (descricao_animal[3].Substring(10) == "tbd") {
                    Console.WriteLine($"Enter a nickname for ID #: {id_pet}");
                    readResult = Console.ReadLine();
                    descricao_animal[3] = "Nickname: " + ((!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "tbd");
                }
                
                while (descricao_animal[5].Substring(13) == "tbd") {
                    Console.WriteLine($"Enter a personality description for ID #: {id_pet}");
                    readResult = Console.ReadLine();
                    descricao_animal[5] = "Personality: " + ((!string.IsNullOrEmpty(readResult)) ? readResult.Trim() : "tbd");
                }
            }

            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            break;

        case "exit":
            break;
        default:
            Console.WriteLine("This feature is coming soon...");
            break;
    }

    Console.WriteLine("Press the Enter key to continue");
    readResult = Console.ReadLine();
} while (menuSelection != "exit");