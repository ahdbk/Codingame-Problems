using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int minDiff ;
        IList<int> horsePowers = new List<int>();
        
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            horsePowers.Add(pi);
        }
        
        horsePowers = horsePowers.OrderByDescending(x=>x)
                                 .ToList();
        
          if(horsePowers.Count==2)
          {
            minDiff = horsePowers[0] - horsePowers[1];
          }
          else 
          {
            minDiff = horsePowers.First();
        
            int diff ;
        
             for (int i = 0; i < horsePowers.Count -1; i++)
                {
                 diff = horsePowers[i] - horsePowers[i+1] ; 
            
                if(diff<minDiff)
                  minDiff = diff;
                }
          }

        
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        //Console.WriteLine(oneAndTow);

        Console.WriteLine(minDiff);
    }
}