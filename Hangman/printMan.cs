using System;
namespace Hangman
{
    // printing different parts of Hangman corresponding to the remaining tries 
    public class printM
    {
        public void printMan(int tries)
        {
            if (tries == 0)
            { Console .WriteLine  ("_______________ \n|        |\n|       / \\ \n|      |X X|\n|       \\_/\n|        |\n|       /|\\ \n|        |\n|       / \\\n|      /   \\\n|"); Console.WriteLine("You lost!"); }
            else if (tries == 6)
            { Console.WriteLine("_______________ \n|\n|\n|\n|\n|\n|\n|\n|\n|\n|");}
            else if (tries == 5)

            { Console.WriteLine("_______________ \n|        |\n|       / \\ \n|      |x x|\n|       \\_/\n|\n|\n|\n|\n|\n|"); }

            else if (tries == 4)

            { Console.WriteLine("_______________ \n|        |\n|       / \\ \n|      |x x|\n|       \\_/\n|        |\n|        |\n|        |\n|\n|\n|"); }

            else if (tries == 3)

            { Console.WriteLine ("_______________ \n|        |\n|       / \\ \n|      |x x|\n|       \\_/\n|        |\n|       /|\n|        |\n|\n|\n|"); }

            else if (tries == 2)

            { Console.WriteLine("_______________ \n|        |\n|       / \\ \n|      |x x|\n|       \\_/\n|        |\n|       /|\\ \n|        |\n|\n|\n|"); }

            else if (tries ==1)
            Console.WriteLine("_______________ \n|        |\n|       / \\ \n|      |x x|\n|       \\_/\n|        |\n|       /|\\ \n|        |\n|       /\n|      /\n|");

        }
    }

}