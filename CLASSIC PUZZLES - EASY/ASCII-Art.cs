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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        T = T.ToUpper(); 
        
        for (int i = 0; i < H; i++)
        {   
            string wordRow = string.Empty; 
            string ROW = Console.ReadLine();

            foreach(char c in T)
             {
                 int index = 0;

                index = char.IsLetter(c) ?(c - 65)*L : ROW.Length - L;

                wordRow =  wordRow + ROW.Substring(index,L);
              }
              
              Console.WriteLine(wordRow);
        }
    }
}