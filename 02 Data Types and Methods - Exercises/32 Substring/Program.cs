﻿using System;

public class Substring_broken
{
	public static void Main()
	{
		string text = Console.ReadLine();
		int jump = int.Parse(Console.ReadLine());

        const char Search = 'p'; 
		bool hasMatch = false;

		for (int i = 0; i < text.Length; i++)
		{
            if (text[i].Equals(Search)) //.Equals() method isted of "==" operand
			{
				hasMatch = true;

				int length = jump+1 ; //not "endIndex" but "length" and +1

				if (length > text.Length-i)
				{
					length = text.Length-i;//-i
				}

				string matchedString = text.Substring( i,length);
				Console.WriteLine(matchedString);
				i += jump;
			}
		}

		if (!hasMatch)
		{
			Console.WriteLine("no");
		}
	}
}
