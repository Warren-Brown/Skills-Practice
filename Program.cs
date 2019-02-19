using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringReversal3
{
    class Program

    //TODO
    //Is it right?
    //Does it work with one word?
    //Punctuation? 2, 3 Spaces?
    //*Preserve Whitespace
    //check if last word if so don't add whitespace
    {
        static void Main(string[] args)
        {
            //EX: "The Cat Ran Fast" => "Fast Ran Cat The"
            //1. Take a user input string.
            Console.WriteLine("Please enter the string that you want to have reversed.");
            //1a. Store the users input.
            string ogStr = Console.ReadLine();
            //1b. create variable and set = to revStr
            string newStr = revStr(ogStr);
            //4. Print the reversed user input.
            Console.WriteLine($"The original string was: {ogStr}.");
            Console.WriteLine($"The reversed string is: {newStr}.");
            Console.ReadKey();
        }
        //2. Split the individual words within the string.
        //2a. Create a method that takes ogStr as input param.
        static string revStr(string input)
        {
            int i = 0; //stores current index
            int j = 0; //stores whitespace index

            //2b. Create a variable to store chars in as the input is iterated through.           
            string[] words = new string[input.Length]; //stores words array as = input.Length
            string rev = string.Empty; //stores reverse array.  
                                       //2c. Iterate through the input
            for (i = 0; i < input.Length; i++)
            {
                char curr = input[i]; // stores the character at the current index
                char prev = ' ';// creates var prev and set it = ' ' so that it is checked by the !char if statement

                if (i > 0)
                {
                    prev = input[i - 1];
                }
                //2d. "If" statment to find whitespace which signifies a new word.
                if (char.IsWhiteSpace(curr)) // check if the current index is whitespace.
                {
                    prev += ' ';

                    if (!char.IsWhiteSpace(prev))//checks if the prev character was NOT whitespace
                    {
                        j++; // if curr char is whitespace && prev char is NOT whitespace update j.
                    }
                }
                else
                {
                    words[j] += curr; // updates 'word' variable to store the value of 'j' =+ the curr char.
                    //This will pack each letter into words at the curr 'j' index. 'j' remains 0 until it encoutners a whitespace and then increments
                    //this causing the following letters to be packed into the next index of 'j'.
                }
            }
            //3. Reverse the order of the words in the string.
            for (i = words.Length - 1; i >= 0; i--) //Sets the length of input minus 1 equal to the current index.
            {
                //3a. Determines if the index is >= 1, rev will be updated to store the word at that index and concatenate a space.
                if (i > 0 && j > 0)// <-- THIS IS FIXED?
                {
                    rev += words[j] + " ";//If 'j' is greater than 0, update rev to words @ index 'j' and add whitespace.
                }
                else if (j == 0)
                {
                    rev += words[j];// if 'j' is equal to 0, update rev to words @ index 'j' without whitespace.
                }
                j--;//subtract 1 from 'j' to access the next index.
            }
            //3b. Determines if the index is !>= 1, rev will be updated to store the word at that index and not concatenate a space to remove excess whitespace.
            return rev;// return the string rev.
        }
    }
}
