using Hangman; 

// Displaying initial message to the player
Console.WriteLine("\nსიკვდილი ყველას გვაშინებს \nსხვას თუ ჰკვლენ ცქერა გვწადია\nკაცნი ვერ გრძნობენ ბევრჯერა\nროგორ დიდ ცოდვას სჩადიან\"\n\tვაჟა-ფშაველა\n\nWelcome to Hangman! You have 6 tries to guess the correct word. \nEnter a single letter at a time!");
Console.WriteLine("_______________ \n|\n|\n|\n|\n|\n|\n|\n|\n|\n|");

// List to keep track of user's tries
List<char> userTries = new List<char>();
// Array of words for the game
string[] words = { "tiger", "laptop", "mountain", "telescope", "sunshine", "perfume", "guitar", "ocean", "bottle", "backpack" };
// Generating a random word from the array
Random random = new Random();
string randomWord = words[random.Next(0, words.Length)];

Console.WriteLine();

char[] chars = randomWord.ToArray();
// Creating an array of blanks to display to the player
string[] blank = Enumerable.Repeat(" _ ", chars.Length).ToArray();

int correct = 0; // Counter to keep track of correct guesses
int tries = 6; // Number of tries the player has


while (tries != 0 && correct != randomWord.Length)
{
    // Displaying the current state of the word with blanks
    foreach (string item in blank)
    {
        Console.Write(item);
    }
    Console.WriteLine();
    Console.WriteLine("Enter a letter:");

    
    char userTry = char.Parse(Console.ReadLine().ToLower());

    try
    {
        // Checking if user input is within the valid range of lowercase letters
        if ((int)userTry < 97 || (int)userTry > 122)
        {
            throw new WrongInputException(); // Throwing an exception for invalid input
        }
        else
        {
            
            if (chars.Contains(userTry) && !userTries.Contains(userTry))
            {
                // If user's guess is correct
                userTries.Add(userTry); // Adding the guessed letter to the list of tries
                for (int i = 0; i < chars.Length; i++)
                {
                    if (userTry == randomWord[i])
                    {
                        // Replacing the blank with the guessed letter
                        blank[i] = userTry.ToString();
                        correct++; // Incrementing correct guess counter
                    }
                }
                if (correct == randomWord.Length)
                {
                    // If all letters are guessed correctly, player wins
                    Console.WriteLine("You won!");
                    foreach (string item in blank)
                    {
                        Console.Write(item); 
                    };
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You guess was correct!"); 
                    printM pr = new printM();
                    pr.printMan(tries); // Printing hangman figure
                }
            }
            else if (userTries.Contains(userTry))
            {
                // If user has already guessed the letter
                printM pr = new printM();
                pr.printMan(tries); // Printing hangman figure
                Console.WriteLine($"You have already guessed letter {userTry}");
            }
            else
            {
                // If user's guess is incorrect
                tries--; // Decrementing remaining tries
                printM pr = new printM();
                pr.printMan(tries); // Printing hangman figure
                if (tries != 0)
                    Console.WriteLine($"Your guess is incorrect! Now you have {tries} tries left!"); 
            }
        }
    }
    catch (WrongInputException ex)
    {
        Console.WriteLine(ex.Message); 
    }
}
