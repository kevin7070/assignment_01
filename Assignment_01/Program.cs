// Assignment 01

// Assignment: Use Visual Studio 2019 Community Edition write a console application.
// - Language: use C sharp
// - Framework: use DotNet Core
// - App type: Console application
// Specification: The application should let user input a string.  The application will scan the string.  If there's any potential words, replace them with "**".  The application will output the censored result.

// Additional resources: Use the word list provided by this link: https://www.cs.cmu.edu/~biglou/resources/bad-words.txt

// Once you finish the application (it should be a Visual Studio solution), upload it to a GitHub repository that you create, and send me the GitHub link, so that I can review the code.

using System;
using System.IO;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert bad-words to array
            string[] texts = File.ReadAllLines("/Users/kevinkwan/LoveCoding/bad-words.txt");

            // get user input
            string userString = Console.ReadLine();

            // search bad-words
            foreach (string text in texts)
            {
                if (userString.Contains(text))
                {
                    // genning *
                    string newText = new string('*', text.Length);
                    // replace *
                    string newString = userString.Replace(text, newText);
                    // the final userString with *
                    userString = newString;
                }
            }

            Console.WriteLine(userString);

        }
    }

    
}

// how to fully * the bad words... is there any other keyword better than contains()?