using System;

public class Test
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int x = int.Parse(input[1]);
            int[] a = new int[n];
            string[] marksInput = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(marksInput[i]);
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= x)
                {
                    count++;
                }
            }
            if (count > 0)
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
