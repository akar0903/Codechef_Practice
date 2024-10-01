using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int t = int.Parse(Console.ReadLine());
		while(t-->0){
		    string[] input = Console.ReadLine().Split();
            long l = long.Parse(input[0]);
            long r = long.Parse(input[1]);
            if (r >= 2 * l)
                Console.WriteLine(-1);
            else
                Console.WriteLine(r);
		}
	}
}
