using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa_and_Chocolates_SANTACHOC
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (; T > 0; T--)
            {
                int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = nk[0];
                int K = nk[1];
                int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int sum = A.Sum();

                if (K == 0)
                    if ((sum > 0) && (sum % N == 0))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                else
                    if (sum < N)
                        Console.WriteLine("NO");
                    else
                        Console.WriteLine("YES");
            }
        }
    }
}
