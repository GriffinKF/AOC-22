using System;
using System.Collections.Generic;

class AOCDay5
{
    public static void Main(string[] args)
    {
        AOCDay5 AOCDay5 = new AOCDay5();
        char[] inStream = AOCDay5.ReadFile("input.txt").ToCharArray();
        Console.WriteLine("Part 1:");
        Console.WriteLine(AOCDay5.Compare(inStream)+1);
        Console.WriteLine("Part 2:");
        Console.WriteLine(AOCDay5.Compare2(inStream)+1);
    }

    public string ReadFile(string FileName) {
        string Input = System.IO.File.ReadAllText(FileName);
        return Input;
    }

    public int Compare(char[] inStream) {
        for (int i = 0; i < (inStream.Length)-4; i++) {
            if (inStream[i+3] != inStream[i+2] && inStream[i+3] != inStream[i+1] && inStream[i+3] != inStream[i]) {
                if (inStream[i+2] != inStream[i+1] && inStream[i+2] != inStream[i]) {
                    if (inStream[i+1] != inStream[i]) {
                        return i+3;
                    }
                }
            }
        }
        return 0;
    }

    public int Compare2(char[] inStream) {
        for (int i = 0; i < (inStream.Length)-14; i++) {
            if (inStream[i+13] != inStream[i+12] && inStream[i+13] != inStream[i+11] && inStream[i+13] != inStream[i+10] && inStream[i+13] != inStream[i+9] && inStream[i+13] != inStream[i+8] && inStream[i+13] != inStream[i+7] && inStream[i+13] != inStream[i+6] && inStream[i+13] != inStream[i+5] && inStream[i+13] != inStream[i+4] && inStream[i+13] != inStream[i+3] && inStream[i+13] != inStream[i+2] && inStream[i+13] != inStream[i+1] && inStream[i+13] != inStream[i]) {
                if (inStream[i+12] != inStream[i+11] && inStream[i+12] != inStream[i+10] && inStream[i+12] != inStream[i+9] && inStream[i+12] != inStream[i+8] && inStream[i+12] != inStream[i+7] && inStream[i+12] != inStream[i+6] && inStream[i+12] != inStream[i+5] && inStream[i+12] != inStream[i+4] && inStream[i+12] != inStream[i+3] && inStream[i+12] != inStream[i+2] && inStream[i+12] != inStream[i+1] && inStream[i+12] != inStream[i]) {
                    if (inStream[i+11] != inStream[i+10] && inStream[i+11] != inStream[i+9] && inStream[i+11] != inStream[i+8] && inStream[i+11] != inStream[i+7] && inStream[i+11] != inStream[i+6] && inStream[i+11] != inStream[i+5] && inStream[i+11] != inStream[i+4] && inStream[i+11] != inStream[i+3] && inStream[i+11] != inStream[i+2] && inStream[i+11] != inStream[i+1] && inStream[i+11] != inStream[i]) {
                        if (inStream[i+10] != inStream[i+9] && inStream[i+10] != inStream[i+8] && inStream[i+10] != inStream[i+7] && inStream[i+10] != inStream[i+6] && inStream[i+10] != inStream[i+5] && inStream[i+10] != inStream[i+4] && inStream[i+10] != inStream[i+3] && inStream[i+10] != inStream[i+2] && inStream[i+10] != inStream[i+1] && inStream[i+10] != inStream[i]) {
                            if (inStream[i+9] != inStream[i+8] && inStream[i+9] != inStream[i+7] && inStream[i+9] != inStream[i+6] && inStream[i+9] != inStream[i+5] && inStream[i+9] != inStream[i+4] && inStream[i+9] != inStream[i+3] && inStream[i+9] != inStream[i+2] && inStream[i+9] != inStream[i+1] && inStream[i+9] != inStream[i]) {
                                if (inStream[i+8] != inStream[i+7] && inStream[i+8] != inStream[i+6] && inStream[i+8] != inStream[i+5] && inStream[i+8] != inStream[i+4] && inStream[i+8] != inStream[i+3] && inStream[i+8] != inStream[i+2] && inStream[i+8] != inStream[i+1] && inStream[i+8] != inStream[i]) {
                                    if (inStream[i+7] != inStream[i+6] && inStream[i+7] != inStream[i+5] && inStream[i+7] != inStream[i+4] && inStream[i+7] != inStream[i+3] && inStream[i+7] != inStream[i+2] && inStream[i+7] != inStream[i+1] && inStream[i+7] != inStream[i]) {
                                        if (inStream[i+6] != inStream[i+5] && inStream[i+6] != inStream[i+4] && inStream[i+6] != inStream[i+3] && inStream[i+6] != inStream[i+2] && inStream[i+6] != inStream[i+1] && inStream[i+6] != inStream[i]) {
                                            if (inStream[i+5] != inStream[i+4] && inStream[i+5] != inStream[i+3] && inStream[i+5] != inStream[i+2] && inStream[i+5] != inStream[i+1] && inStream[i+5] != inStream[i]) {
                                                if (inStream[i+4] != inStream[i+3] && inStream[i+4] != inStream[i+2] && inStream[i+4] != inStream[i+1] && inStream[i+4] != inStream[i]) {
                                                   if (inStream[i+3] != inStream[i+2] && inStream[i+3] != inStream[i+1] && inStream[i+3] != inStream[i]) {
                                                        if (inStream[i+2] != inStream[i+1] && inStream[i+2] != inStream[i]) {
                                                            if (inStream[i+1] != inStream[i]) {
                                                                return i+13;
                                                            }
                                                        }
                                                    } 
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return 0;
    }
}