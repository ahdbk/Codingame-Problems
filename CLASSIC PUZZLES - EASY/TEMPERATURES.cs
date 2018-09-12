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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        
        int index = 0 ; 
        int lastT = 0; 

        IEnumerable<int> temps = Console.ReadLine()
                                        .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                                        .Select(x=>Int32.Parse(x));
                                        
        var result  = temps.OrderBy(x=>Math.Abs(x))
                            .ThenByDescending(x=>x)
                            .FirstOrDefault();


        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}