// Assignment 01

// Assignment: Use Visual Studio 2019 Community Edition write a console application.
// - Language: use C sharp
// - Framework: use DotNet Core
// - App type: Console application
// Specification: The application should let user input a string.  The application will scan the string.  If there's any potential words, replace them with "**".  The application will output the censored result.

// Additional resources: Use the word list provided by this link: https://www.cs.cmu.edu/~biglou/resources/bad-words.txt

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment_01
{
    class Program
    {
        static string[] LoadCensorWords(string filePath)
        {
            string[] CensorWords = File.ReadAllLines(filePath);
            return CensorWords;
        }

        static void Main(string[] args)
        {
            // collect user input
            string userString = Console.ReadLine();

            // load bad-words as an array
            var badWords = LoadCensorWords("bad-words.txt");

            // compare and replace the whole words
            foreach (string badWord in badWords)
            {
                string pattern = string.Format(@"\b{0}\b", badWord);
                string replace = new string('*', badWord.Length);
                string result = Regex.Replace(userString, pattern, replace, RegexOptions.IgnoreCase);
                userString = result;
            }

            // return to user
            Console.WriteLine(userString);
        }
    }

    
}