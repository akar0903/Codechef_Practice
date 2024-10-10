using System;
public class Test
{
    static long gcd(long a, long b)
    {
        while (a > 0 && b > 0)
        {
            if (a > b)
                a = a % b;
            else
                b = b % a;
        }
        if (a == 0) return b;
        return a;
    }
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine()); 
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine()); 
            long[] A = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse); 
            long ans = A[0]; 
            for (int i = 1; i < N; i++)
            {
                ans = gcd(ans, A[i]); 
                if (ans == 1) break; 
            }
            Console.WriteLine(N * ans); 
        }
    }
}
