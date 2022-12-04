using System;

class AOCDay4
{
    public static void Main(string[] args)
    {
        AOCDay4 AOCDay4 = new AOCDay4();
        string[] Rows = AOCDay4.ReadFile("input.txt").Split("\r\n");
        string[][] EachRow = new string[Rows.Length][];
        int totalOverlaps = 0;
        int partialOverlaps = 0;

        for(int i = 0; i < Rows.Length; i++) {
            EachRow[i] = new string[4];

            for(int j = 0; j < EachRow[i].Length; j++) {
                EachRow[i][j] = AOCDay4.ParseRow(Rows[i])[j];
            }
        }

        for(int i = 0; i < EachRow.Length; i++) {
            if(AOCDay4.fullOverlap(EachRow[i])) {
                totalOverlaps = totalOverlaps + 1;
            }
        }

        for(int i = 0; i < EachRow.Length; i++) {
            if(AOCDay4.partialOverlap(EachRow[i])) {
                partialOverlaps = partialOverlaps + 1;
            }
        }

        Console.WriteLine("Part 1:");
        Console.WriteLine(totalOverlaps);
        Console.WriteLine("");
        Console.WriteLine("Part 2:");
        Console.WriteLine(partialOverlaps);

    }

    public string ReadFile(string FileName) {
        string Input = System.IO.File.ReadAllText(FileName);
        return Input;
    }

    public string[] ParseRow(string Rows) {
        return Rows.Split('-',',');
    }

    public bool fullOverlap(string[] Row) {
        int start1 = Int32.Parse(Row[0]);
        int end1 = Int32.Parse(Row[1]);
        int start2 = Int32.Parse(Row[2]);
        int end2 = Int32.Parse(Row[3]);

        if (((start1 <= start2) && (end1 >= end2)) || ((start2 <= start1) && (end2 >= end1))) {
            return true;
        } else {
            return false;
        }
    }

    public bool partialOverlap(string[] Row) {
        int start1 = Int32.Parse(Row[0]);
        int end1 = Int32.Parse(Row[1]);
        int start2 = Int32.Parse(Row[2]);
        int end2 = Int32.Parse(Row[3]);

        if(fullOverlap(Row)) {
            return true;
        } else if (((end1 >= start2) && (start1 < start2))  || ((end2 >= start1) && (start2 < start1))) {
            return true;
        } else {
            return false;
        }
    }
}