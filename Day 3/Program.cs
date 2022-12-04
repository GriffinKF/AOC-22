using System;

class AOCDay3
{
    public static void Main(string[] args)
    {
        AOCDay3 AOCDay3 = new AOCDay3();
        string[] Bags = AOCDay3.ReadFile("input.txt").Split("\r\n");
        char[] Items = new char[Bags.Length];
        int Score = 0;
        int Score2 = 0;

        for(int i = 0; i < Bags.Length; i++) {
            string[] Comparts = AOCDay3.splitBag(Bags[i]);
            Items[i] = AOCDay3.compareItems(Comparts[0].ToCharArray(), Comparts[1].ToCharArray());
            Score = Score + AOCDay3.Score(Items[i]);
        }

        for(int i = 0; i < Bags.Length; i = i + 3) {
            Score2 = Score2 + AOCDay3.compareGroupItems(Bags[i].ToCharArray(), Bags[i+1].ToCharArray(), Bags[i+2].ToCharArray());
        }

        Console.WriteLine("Part 1:");
        Console.WriteLine(Score);
        Console.WriteLine("");
        Console.WriteLine("Part 2:");
        Console.WriteLine(Score2);
    }

    public string ReadFile(string FileName) {
        string Input = System.IO.File.ReadAllText(FileName);
        return Input;
    }

    public string[] splitBag(string Bag) {
        string[] Comparts = {"",""};
        int Length = (Bag.Length/2);
        Comparts[0] = Bag.Substring(0, Length);
        Comparts[1] = Bag.Substring(Length);
        return Comparts;
    }

    public char compareItems(char[] left, char[] right) {
        IEnumerable<char> both = left.Intersect(right);
        foreach (char id in both) {
            return id; 
        }
        return '0'; //This is here cause I need it to be, it will literally never trigger, but I don't know a more elegant way to solve the error.
    }

    public int compareGroupItems(char[] left, char[] middle, char[] right) {
        IEnumerable<char> both = left.Intersect(middle);
        foreach (char id in both) {
            if (right.Contains(id)) {
                return Score(id);
            }
        }
        return '0'; //This is here cause I need it to be, it will literally never trigger, but I don't know a more elegant way to solve the error.
    }

    public int Score(char Item) {
        char[] lowerCase = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] upperCase = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        if (lowerCase.Contains(Item)) {
            return Array.IndexOf(lowerCase, Item) + 1;
        } else if (upperCase.Contains(Item)) {
            return Array.IndexOf(upperCase, Item) + 27;
        } else {
            Console.WriteLine("You done fucked up");
            return 0;
        }
    }
}