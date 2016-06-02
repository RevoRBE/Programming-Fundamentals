using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Words_In_Sentence
{
    public class Reverse_Words_In_Sentence
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            List<string> reversedSentence = new List<string>();
            char[] separators = ". !?:;-\\/".ToCharArray();
            string word = "";
            string punctuation = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (separators.Contains(text[i]))
                {
                    if (word != "")
                    {
                        reversedSentence.Add(word);
                        word = "";
                    }
                    punctuation += text[i];
                }
                else
                {
                    if (punctuation != "")
                    {
                        reversedSentence.Add(punctuation);
                        punctuation = "";
                    }
                    word += text[i];
                }
                if (i == text.Length - 1)
                    if (word != "") reversedSentence.Add(word);
                    else            reversedSentence.Add(punctuation);

            }
            reversedSentence.Reverse();
            Console.WriteLine(string.Join("", reversedSentence));
        }
    }
}
