using System;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            WarriorChef();
        }
    }

    public static void WarriorChef()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]), h = int.Parse(firstLine[1]);
        int[] a = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
        int totalPower = 0;
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            totalPower += a[i];
            if (totalPower >= h)
            {
                result = a[i];
                break;
            }
        }
        Console.WriteLine(result);
    }
}
