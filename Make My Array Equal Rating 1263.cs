using System;
using System.Collections.Generic;
public class Test
{
	public static void Main()
	{
		// your code goes here
		int t = int.Parse(Console.ReadLine());
		while(t-->0){
		    int size = int.Parse(Console.ReadLine());
		    long[] elements = new long[size];
		    Dictionary<long,int> nonZero = new Dictionary<long,int>();
		    string[] inputs = Console.ReadLine().Split();
		    for(int i=0;i<size;i++){
		        elements[i] = long.Parse(inputs[i]);
		        if(elements[i] != 0){
		            if(nonZero.ContainsKey(elements[i])){
		                nonZero[elements[i]]++;
		            }
		            else{
		                nonZero[elements[i]] = 1;
		            }
		        }
		    }
		    if(nonZero.Count == 1 || nonZero.Count == 0){
		        Console.WriteLine("YES");
		    }
		    else{
		        Console.WriteLine("NO");
		    }
		}
		
	}
}
