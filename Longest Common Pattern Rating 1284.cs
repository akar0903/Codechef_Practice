using System;

public class Test
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            Console.WriteLine(CommonChar(A, B));
        }
	}
	public static int CommonChar(string A, string B)
	{
	    int count =0;
	    int[] freqa = new int[256];
	    int[] freqb = new int[256];
	    for(int i=0;i<A.Length;i++){
	        freqa[A[i]]++;
	    }
	    for(int i=0;i<B.Length;i++){
	        freqb[B[i]]++;
	    }
	     for (int i = 0; i < 256; i++)
        {
            count += Math.Min(freqa[i], freqb[i]);
        }

        return count;
	    
	}
}
