﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Increasing_Subsequence
{
    class Largest_Increasing_Subsequence
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] len = new int[sequence.Length];   // length of the LIS up to respective index
            int[] prev = new int[sequence.Length];  // previous element index in LIS
            int maxLen = 1;
            int lastIndex = 0;
            // calculate the longest increasing sequence (LIS) parameters: 
            // LIS length, last index, prev elements indices
            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int prevIndex = 0; prevIndex < i; prevIndex++)
                {
                    if (sequence[prevIndex] < sequence[i] &&
                        len[prevIndex] >= len[i])
                    {
                        len[i]++;
                        prev[i] = prevIndex;
                    }
                    if (len[i] > maxLen)
                    {
                        maxLen = len[i];
                        lastIndex = i;
                    }
                }
            }
            List<int> longestIncreasingSeq = GetLongestIncreasingSequence(sequence, prev, lastIndex);
            Console.WriteLine(string.Join(" ", longestIncreasingSeq));
        }

        private static List<int> GetLongestIncreasingSequence(int[] sequence, int[] prev, int lastIndex)
        {
            //Console.WriteLine("maxLen: {0}", maxLen);
            //Console.WriteLine("lastIndex: {0}", lastIndex);
            //Console.WriteLine("len: {0}", string.Join(" ", len));
            //Console.WriteLine("prev: {0}", string.Join(" ", prev));
            List<int> longestIncreasingSeq = new List<int>();           
            while (lastIndex != -1)
            {
                longestIncreasingSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestIncreasingSeq.Reverse();
            return longestIncreasingSeq;
        }
    }
}