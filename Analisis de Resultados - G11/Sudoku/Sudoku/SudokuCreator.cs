using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuCreator
    {
        bool Finished;
        Random Rnd;
        Sudoku Result;

        public Sudoku CreateRandomSudoku(int Difficulty, int targetdels)
        {
            bool Start = true;

            bool Done = false;
            int Deleted = 0;
            int Tolerance = 10;

            // Various counters, we count the iterations we do in case the created instance somehow gets stuck, then we reset
            int FieldDelCounter = 0;
            int ResetCounter1 = 0;
            int ResetCounter2 = 0;
            Sudoku NewSudoku = null;
            Sudoku Fallback = null;
            int FallbackCounter = 0;

            while (!Done)
            {
                if (ResetCounter1 > 40)
                {
                    ResetCounter1 = 0;
                    Start = true;
                }
                if (ResetCounter2 > 40)
                {
                    ResetCounter2 = 0;
                    Start = true;
                }

                if (Start)
                {
                    // first, create a complete sudoku using brute force
                    NewSudoku = new Sudoku(new List<int>());
                    List<Sudoku.Field> ToDo = new List<Sudoku.Field>();
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            ToDo.Add(NewSudoku.Fields[i][j]);
                        }
                    }
                    Rnd = new Random();
                    Finished = false;
                    BruteForce(ToDo, 0, NewSudoku);
                    FallbackCounter = 0;
                    NewSudoku = Result.Copy();
                    Start = false;
                    Fallback = null;
                }

                Sudoku Cloned = NewSudoku.Copy();
                int difficulty = Difficulty;
                // take out one field and check if solutions still is unique and not harder than desired
                if (DeleteField(Cloned, ref difficulty))
                {
                    NewSudoku = Cloned;
                    Deleted++;

                    if (NewSudoku.Difficulty == Difficulty && Deleted >= targetdels)
                    {   // in this case we are done   
                        NewSudoku.Difficulty = difficulty;
                        return NewSudoku;
                    }
                    else if (difficulty == Difficulty && Deleted < targetdels)
                    { // matching difficulty found but more fields have to be deleted
                        Fallback = NewSudoku.Copy();
                    }
                    else if (Deleted >= targetdels + Tolerance) // enough fields deleted but not desired difficulty
                    {
                        if (FallbackCounter < 100 && Fallback != null) // first try fallback
                        {
                            NewSudoku = Fallback.Copy();
                        }
                        else
                        {
                            NewSudoku = Result.Copy();
                            ResetCounter1++;
                            FallbackCounter = 0;
                        }
                        Deleted = 0;

                    }
                }
                else
                {
                    FieldDelCounter++;
                    if (FieldDelCounter > 100) // probably no more field can be deleted to get the desired difficulty
                    {
                        FieldDelCounter = 0;
                        NewSudoku = Result.Copy();
                        Deleted = 0;
                        ResetCounter2++;
                    }
                    continue;
                }
            }

            return Result;
        }

        private bool DeleteField(Sudoku temp, ref int difficulty)
        {
            int i = Rnd.Next(0, 9); ;
            int j = Rnd.Next(0, 9); ;

            // select random not yet deleted field
            while (!temp.Fields[i][j].Filled)
            {
                i = Rnd.Next(0, 9);
                j = Rnd.Next(0, 9);
            }

            temp.Fields[i][j].Value = 0;
            temp.Fields[i][j].Filled = false;
            SudokuSolver Test = new SudokuSolver();
            int Difficulty = difficulty;
            // check the desired characteristics
            Sudoku Temp = Test.Solve(temp.Copy(), true, Difficulty);
            if (Temp == null)
                return false;
            temp.Difficulty = Temp.Difficulty;
            if (Temp.NrSolutions > 1 || Temp.Difficulty > Difficulty)
                return false;
            else
                return true;
        }

        private void BruteForce(List<Sudoku.Field> ToDo, int pos, Sudoku Temp)
        {   // the brute force implementation for creating complete sudokus
            if (Finished)
                return;
            for (int i = 1; i <= 9; i++)
            {
                Sudoku Copied = Temp.Copy();
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Filled = true;
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value = Rnd.Next(1, 10);
                bool Valid = true;
                foreach (Sudoku.Field f in Copied.GetGroup(ToDo[pos].i, ToDo[pos].j))
                {
                    if (f.Filled && f.Value == Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value)
                    {
                        Valid = false;
                        break;
                    }
                }
                if (Valid)
                {
                    if (pos < ToDo.Count - 1)
                        BruteForce(ToDo, pos + 1, Copied);
                    else
                    {
                        Finished = true;
                        Result = Copied;
                    }
                }
            }
        }
    }
}
