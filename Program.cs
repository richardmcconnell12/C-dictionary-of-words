using System;
using System.Collections.Generic;

namespace dictionaryWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            var wordsAndDefinitions = new Dictionary<string, string>()
                {
                    {"Aesthetic", "Concerned with beauty or the appreciation of beauty"},
                    {"Montage", "The technique of producing a new composite whole from fragments of pictures, text, or music"},
                    {"Music", "vocal and instrumental sounds combined in such a way as to produce beauty of form, harmony, and express emotion"}
                };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Aesthetic"]);
            Console.WriteLine(wordsAndDefinitions["Montage"]);

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            // List of defintions exercise
            Console.WriteLine("Definitions after first exercise");
            var dictionaryOfWords = new List<Dictionary<string, string>>();

            var excitedWord = new Dictionary<string, string>();

            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            dictionaryOfWords.Add(excitedWord);
            dictionaryOfWords.Add(wordsAndDefinitions);

            // Iterate the List of Dictionaries
            foreach (var dict in dictionaryOfWords)
                foreach (var moreWords in dict)
                    Console.WriteLine($"{moreWords.Key} definition: {moreWords.Value}");

        }
    }
}
