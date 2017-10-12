using System;

class Numbers_In_Reversed_Order
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        Console.WriteLine(ReverseString(number));
    }

    static string ReverseString(string number)
    {
        char[] c = number.ToCharArray();
        string outr = c.ToString();
        Array.Reverse(c);
        return new string(c);
    }
    public static string ReverseXor(string s)
    {
        if (s == null) return null;
        char[] charArray = s.ToCharArray();
        int len = s.Length - 1;

        for (int i = 0; i < len; i++, len--)
        {
            charArray[i] ^= charArray[len];
            charArray[len] ^= charArray[i];
            charArray[i] ^= charArray[len];
        }

        return new string(charArray);
    }
}