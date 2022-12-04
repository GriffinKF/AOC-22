using System;

class AOCDay2
{
    public static void Main(string[] args)
    {
        AOCDay2 AOCDay2 = new AOCDay2();
        string[] Round = AOCDay2.ReadFile("input.txt").Split("\r\n");

        int TotalScore1 = 0;
        int TotalScore2 = 0;

        for(int i = 0; i < Round.Length; i++) {
            TotalScore1 = TotalScore1 + AOCDay2.DecisionEnginePart1(Round[i][0], Round[i][2]);
            TotalScore2 = TotalScore2 + AOCDay2.DecisionEnginePart2(Round[i][0], Round[i][2]);
        }

        Console.WriteLine("Part 1:");
        Console.WriteLine(TotalScore1);
        Console.WriteLine("");
        Console.WriteLine("Part 2:");
        Console.WriteLine(TotalScore2);

    }

    public string ReadFile(string FileName) {
        string Input = System.IO.File.ReadAllText(FileName);
        return Input;
    }

    public int DecisionEnginePart1(char opMove, char propMove) {
        int Score = 0;
        Score = Score + moveScore(propMove);
        Score = Score + roundScore(opMove, propMove);
        return Score;
    }

    public int moveScore(char propMove) {
        if (propMove == 'X') { //Rock, 1 point
            return 1;
        } else if (propMove == 'Y') { //Paper, 2 points
            return 2;
        } else if (propMove == 'Z') { //Scissors, 3 points
            return 3;
        } else {
            Console.WriteLine("Should Never See This");
            return 0;
        }
    }

    public int roundScore(char opMove, char propMove) {
        if (opMove == 'A') { //Rock
            if (propMove == 'Y') {
                return 6;
            } else if (propMove == 'X') {
                return 3;
            } else {
                return 0;
            }
            
        } else if (opMove == 'B') { //Paper
            if (propMove == 'Z') {
                return 6;
            } else if (propMove == 'Y') {
                return 3;
            } else {
                return 0;
            }
        } else if (opMove == 'C') { //Scissors
            if (propMove == 'X') {
                return 6;
            } else if (propMove == 'Z') {
                return 3;
            } else {
                return 0;
            }
        } else {
            Console.WriteLine("Should Never See This");
            return 0;
        }
    }

    public int DecisionEnginePart2(char opMove, char propMove) {
        if (propMove == 'Z') { //Need to win
            return ScoreWin(opMove);
        } else if (propMove == 'Y') { //Need to draw
            return ScoreDraw(opMove);
        } else if (propMove == 'X') { //Need to lose
            return ScoreLose(opMove);
        } else {
            Console.WriteLine("Should Never See This");
            return 0;
        }
    }

    public int ScoreWin(char opMove) {
        int Score = 6;
        if (opMove == 'A') {
            Score = Score + 2;
        } else if (opMove == 'B') {
            Score = Score + 3;
        } else if (opMove == 'C') {
            Score = Score + 1;
        } else {
           Console.WriteLine("Should Never See This"); 
        }
        return Score;
    }

    public int ScoreDraw(char opMove) {
        int Score = 3;
        if (opMove == 'A') {
            Score = Score + 1;
        } else if (opMove == 'B') {
            Score = Score + 2;
        } else if (opMove == 'C') {
            Score = Score + 3;
        } else {
           Console.WriteLine("Should Never See This"); 
        }
        return Score;
    }

    public int ScoreLose(char opMove) {
        int Score = 0;
        if (opMove == 'A') {
            Score = Score + 3;
        } else if (opMove == 'B') {
            Score = Score + 1;
        } else if (opMove == 'C') {
            Score = Score + 2;
        } else {
           Console.WriteLine("Should Never See This"); 
        }
        return Score;
    }

}