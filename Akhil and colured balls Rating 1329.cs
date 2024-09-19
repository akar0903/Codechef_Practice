using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int t  = int.Parse(Console.ReadLine());
		for(int i=0;i<t;i++){
		    string X = Console.ReadLine();
            string Y = Console.ReadLine();
            int N = X.Length;
            StringBuilder Z = new StringBuilder();
            for(int j=0;j<N;j++){
                if (X[j] != Y[j])
                    Z.Append('B');
                else if (X[j] == 'B')
                    Z.Append('W');
                else
                    Z.Append('B');
            }
            Console.WriteLine(Z.ToString());
		}
	}
}
