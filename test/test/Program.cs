using System;
using System.Collections.Immutable;
using System.IO;

namespace Test;

internal class Display
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(args[0].ToString());
        Array.Sort(lines, customSort);

        for(int i=0;  i<lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        File.WriteAllLines(@"sorted.txt", lines);
    }

    static int customSort(string a, string b)
    {
        string[] aArray = a.Split(' ');
        string[] bArray = b.Split(' ');
        string aLN = aArray[aArray.Length-1];
        string bLN = bArray[bArray.Length-1];

        int LNC =  string.Compare(aLN, bLN);

        if(LNC == 0)
        {
            return string.Compare(a, b);
        }
        else
        {
            return LNC;
        }
    }
}
