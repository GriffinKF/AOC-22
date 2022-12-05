using System;
using System.Collections.Generic;

class AOCDay5
{
    public static void Main(string[] args)
    {
        AOCDay5 AOCDay5 = new AOCDay5();
        Stack<string> stack1 = new Stack<string>(); stack1.Push("V"); stack1.Push("C"); stack1.Push("D"); stack1.Push("R"); stack1.Push("Z"); stack1.Push("G"); stack1.Push("B"); stack1.Push("W");
        Stack<string> stack2 = new Stack<string>(); stack2.Push("G"); stack2.Push("W"); stack2.Push("F"); stack2.Push("C"); stack2.Push("B"); stack2.Push("S"); stack2.Push("T"); stack2.Push("V");
        Stack<string> stack3 = new Stack<string>(); stack3.Push("C"); stack3.Push("B"); stack3.Push("S"); stack3.Push("N"); stack3.Push("W");
        Stack<string> stack4 = new Stack<string>(); stack4.Push("Q"); stack4.Push("G"); stack4.Push("M"); stack4.Push("N"); stack4.Push("J"); stack4.Push("V"); stack4.Push("C"); stack4.Push("P");
        Stack<string> stack5 = new Stack<string>(); stack5.Push("T"); stack5.Push("S"); stack5.Push("L"); stack5.Push("F"); stack5.Push("D"); stack5.Push("H"); stack5.Push("B");
        Stack<string> stack6 = new Stack<string>(); stack6.Push("J"); stack6.Push("V"); stack6.Push("T"); stack6.Push("W"); stack6.Push("M"); stack6.Push("N");
        Stack<string> stack7 = new Stack<string>(); stack7.Push("P"); stack7.Push("F"); stack7.Push("L"); stack7.Push("C"); stack7.Push("S"); stack7.Push("T"); stack7.Push("G");
        Stack<string> stack8 = new Stack<string>(); stack8.Push("B"); stack8.Push("D"); stack8.Push("Z");
        Stack<string> stack9 = new Stack<string>(); stack9.Push("M"); stack9.Push("N"); stack9.Push("Z"); stack9.Push("W");
        
        Stack<string> stack12 = new Stack<string>(); stack12.Push("V"); stack12.Push("C"); stack12.Push("D"); stack12.Push("R"); stack12.Push("Z"); stack12.Push("G"); stack12.Push("B"); stack12.Push("W");
        Stack<string> stack22 = new Stack<string>(); stack22.Push("G"); stack22.Push("W"); stack22.Push("F"); stack22.Push("C"); stack22.Push("B"); stack22.Push("S"); stack22.Push("T"); stack22.Push("V");
        Stack<string> stack32 = new Stack<string>(); stack32.Push("C"); stack32.Push("B"); stack32.Push("S"); stack32.Push("N"); stack32.Push("W");
        Stack<string> stack42 = new Stack<string>(); stack42.Push("Q"); stack42.Push("G"); stack42.Push("M"); stack42.Push("N"); stack42.Push("J"); stack42.Push("V"); stack42.Push("C"); stack42.Push("P");
        Stack<string> stack52 = new Stack<string>(); stack52.Push("T"); stack52.Push("S"); stack52.Push("L"); stack52.Push("F"); stack52.Push("D"); stack52.Push("H"); stack52.Push("B");
        Stack<string> stack62 = new Stack<string>(); stack62.Push("J"); stack62.Push("V"); stack62.Push("T"); stack62.Push("W"); stack62.Push("M"); stack62.Push("N");
        Stack<string> stack72 = new Stack<string>(); stack72.Push("P"); stack72.Push("F"); stack72.Push("L"); stack72.Push("C"); stack72.Push("S"); stack72.Push("T"); stack72.Push("G");
        Stack<string> stack82 = new Stack<string>(); stack82.Push("B"); stack82.Push("D"); stack82.Push("Z");
        Stack<string> stack92 = new Stack<string>(); stack92.Push("M"); stack92.Push("N"); stack92.Push("Z"); stack92.Push("W");

        Stack<string>[] stackArray = {stack1, stack2, stack3, stack4, stack5, stack6, stack7, stack8, stack9};
        Stack<string>[] stackArray2 = {stack12, stack22, stack32, stack42, stack52, stack62, stack72, stack82, stack92};

        string[] instruc = AOCDay5.ReadFile("input.txt").Split("\r\n");

        for (int i = 0; i < instruc.Length; i++) {
            int[] line = AOCDay5.moveOrder(instruc[i]);
            AOCDay5.mover(stackArray, line);
        }

        Console.WriteLine("Part 1: ");
        Console.Write(stack1.Pop());
        Console.Write(stack2.Pop());
        Console.Write(stack3.Pop());
        Console.Write(stack4.Pop());
        Console.Write(stack5.Pop());
        Console.Write(stack6.Pop());
        Console.Write(stack7.Pop());
        Console.Write(stack8.Pop());
        Console.Write(stack9.Pop());
        Console.WriteLine("");

        for (int i = 0; i < instruc.Length; i++) {
            int[] line = AOCDay5.moveOrder(instruc[i]);
            AOCDay5.mover2(stackArray2, line);
        }

        Console.WriteLine("Part 2: ");
        Console.Write(stack12.Pop());
        Console.Write(stack22.Pop());
        Console.Write(stack32.Pop());
        Console.Write(stack42.Pop());
        Console.Write(stack52.Pop());
        Console.Write(stack62.Pop());
        Console.Write(stack72.Pop());
        Console.Write(stack82.Pop());
        Console.Write(stack92.Pop());

    }

    public string ReadFile(string FileName) {
        string Input = System.IO.File.ReadAllText(FileName);
        return Input;
    }

    public int[] moveOrder(string line) {
        string[] tempLine = line.Split(" ");
        int[] ret = {Int32.Parse(tempLine[1]), Int32.Parse(tempLine[3]), Int32.Parse(tempLine[5])};
        return ret;
    }

    public Stack<string>[] mover(Stack<string>[] stackArray, int[] moveOrder) {
        for (int i = 0; i < moveOrder[0]; i++) {
            stackArray[moveOrder[2]-1].Push(stackArray[moveOrder[1]-1].Pop());
        }
        return stackArray;
    }

    public Stack<string>[] mover2(Stack<string>[] stackArray, int[] moveOrder) {
        
        string[] holder = new string[moveOrder[0]];

        for (int i = 0; i < holder.Length; i++) {
            holder[i] = stackArray[moveOrder[1]-1].Pop();
        }

        Array.Reverse(holder);

        for (int i = 0; i < holder.Length; i++) {
            stackArray[moveOrder[2]-1].Push(holder[i]);
        }

        return stackArray;
    }
}