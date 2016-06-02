using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_Sentences
{
    public class Extract_Sentences
    {
        public static void Main()
        {
            char[] sentenceSeparators = ".?!".ToCharArray();
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine()
                .Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            List<char> wSeparators = new List<char>();  // non-letter separators
            for (int i = 32; i < 127; i++)
                if (!char.IsLetter((char)i))
                    wSeparators.Add((char)i);
            char[] wordSeparators = wSeparators.ToArray();

            List<string> resultSentences = new List<string>();
            foreach (string sentence in sentences)
            {
                string[] words = sentence.ToLower()
                    .Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (words.Contains(word))   resultSentences.Add(sentence);
            }
            Console.WriteLine(string.Join("\n", resultSentences));
        }
    }
}