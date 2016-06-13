using System;
using System.Collections.Generic;
using System.Linq;

class Football_League
{
    static void Main()
    {
        string key = Console.ReadLine();
        Dictionary<string, long> teamScores = new Dictionary<string, long>();
        Dictionary<string, long> teamGoals = new Dictionary<string, long>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "final") break;
            string[] data = input
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] scores = data[2]
                            .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(long.Parse).ToArray();
            string[] teams = new string[] { data[0], data[1] };
            for (int i = 0; i < teams.Length; i++)
                teams[i] = GetValidName(teams[i], key); // string betweeen keys, reversed, uppercase            
            teamGoals = CalcGoals(teamGoals, teams, scores);
            teamScores = CalcScores(teamScores, teams, scores);
        }
        PrintStats(teamScores, teamGoals);
    }

    private static void PrintStats(Dictionary<string, long> teamScores, Dictionary<string, long> teamGoals)
    {
        Console.WriteLine("League standings:");
        List<string> teamRankings = teamScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                                    .Select(x => x.Key).ToList();
        for (int i = 0; i < teamRankings.Count; i++)
            Console.WriteLine("{0}. {1} {2}", i + 1, teamRankings[i], teamScores[teamRankings[i]]);
        Console.WriteLine("Top 3 scored goals:");
        foreach (var team in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
    }

    private static Dictionary<string, long> CalcGoals(Dictionary<string, long> teamGoals, string[] teams, long[] scores)
    {
        for (int i = 0; i < teams.Length; i++)
            if (!teamGoals.ContainsKey(teams[i]))
                teamGoals[teams[i]] = 0;
        for (int i = 0; i < teams.Length; i++)
            teamGoals[teams[i]] += scores[i];
        return teamGoals;
    }

    private static Dictionary<string, long> CalcScores(Dictionary<string, long> teamScores, string[] teams, long[] scores)
    {
        for (int i = 0; i < teams.Length; i++)
            if (!teamScores.ContainsKey(teams[i]))
                teamScores[teams[i]] = 0;
        if (scores[0] == scores[1])
        {
            teamScores[teams[0]]++;
            teamScores[teams[1]]++;
        }
        else if (scores[0] > scores[1])     teamScores[teams[0]] += 3;
        else                                teamScores[teams[1]] += 3;
        return teamScores;
    }
    
    private static string GetValidName(string text, string key)
    {
        int keyIndex = text.IndexOf(key);   // opening key index
        text = text.Substring(keyIndex + key.Length);
        keyIndex = text.IndexOf(key);       // closing key index
        text = text.Substring(0, keyIndex);
        text = ReverseText(text);
        return text.ToUpper();
    }

    private static string ReverseText(string text)
    {
        char[] reversedChars = text.ToCharArray().Reverse().ToArray();
        return string.Join("", reversedChars);
    }
}