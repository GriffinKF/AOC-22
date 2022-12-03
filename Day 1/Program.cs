using System;

class AOCDay1
{
    public static void Main(string[] args)
    {
        AOCDay1 AOCDay1 = new AOCDay1();
        string[] Elves =  AOCDay1.ReadFile("input.txt").Split("\r\n\r\n");
        string[][] EachElf = new string[Elves.Length][];

        for (int i = 0; i < EachElf.Length; i++)
        {   
            string[] TempElf = Elves[i].Split("\n"); 
            EachElf[i] = new string[TempElf.Length]; 
            
            for (int k = 0; k < TempElf.Length; k++)
            {
                EachElf[i][k] = TempElf[k];
            }
        }

        int[] Totals = new int[EachElf.Length];

        for (int i = 0; i < EachElf.Length; i++)
        {
            Totals[i] = AOCDay1.CountTotal(EachElf[i]);
        }

        Array.Sort(Totals);
        Array.Reverse(Totals);
        Console.WriteLine("Part 1:");
        Console.WriteLine(Totals[0]);
        Console.WriteLine("");
        Console.WriteLine("Part 2:");
        Console.WriteLine(Totals[0] + Totals[1] + Totals[2]);
    }

    public string ReadFile(string FileName) {
        string Input = System.IO.File.ReadAllText(FileName);
        return Input;
    }

    public int CountTotal(string[] stringArray) {
        int[] intArray = new int[stringArray.Length];
        int Sum = 0;

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = Int32.Parse(stringArray[i]);
            Sum = Sum + intArray[i];
        }

        return Sum;
    }
}