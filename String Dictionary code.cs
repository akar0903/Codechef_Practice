using System;
using System.Collections.Generic;
public class Test
{
	public static void Main()
	{
		// your code goes here
		int t = int.Parse(Console.ReadLine());
		while(t-->0){
		    string input = Console.ReadLine();
		    Dictionary<char,int> dict = new Dictionary<char,int>();
		    bool greaterthantwo = false;
		    foreach(char c in input.ToLower()){
		        if(char.IsLetter(c)){
		            if(dict.ContainsKey(c)){
		                dict[c]++;
		            }
		            else
                    {
                        dict[c] = 1;
                    }
		        }
		    }
		    foreach (var kvp in dict)
            {
            if (kvp.Value >= 2)
            {
                greaterthantwo = true;
                break;
            }
            }
            if (greaterthantwo)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
		    
		}
	}
}
