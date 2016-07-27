using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string file = File.ReadAllText(@"e:/as.txt");
        int[] nums = file
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();
        foreach (int i in nums)
            Console.Write(i);
    }
}