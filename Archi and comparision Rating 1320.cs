using System;

public class Test
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = arr[0];
            int b = arr[1];
            int n = arr[2];
            if (n % 2 == 0)
            {
                if (Math.Abs(a) > Math.Abs(b))
                {
                    Console.WriteLine(1);
                }
                else if (Math.Abs(a) < Math.Abs(b))
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(1);
                }
                else if (a < b)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
