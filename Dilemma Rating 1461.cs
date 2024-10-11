using System;
using System.Collections.Generic;

public class Test
{
    public static void Main ()
    {
        byte t = byte.Parse (Console.ReadLine ());
        for (byte i = 0; i < t; i++) {
            string s = Console.ReadLine ();
            Dictionary<char, int> countDict = new Dictionary<char, int>();
            foreach (char c in s) {
                if (countDict.ContainsKey(c))
                    countDict[c]++;
                else
                    countDict[c] = 1;
            }
            if (countDict.ContainsKey('1') && countDict['1'] % 2 == 1)
                Console.WriteLine ("WIN");
            else
                Console.WriteLine ("LOSE");
        }
    }
}
