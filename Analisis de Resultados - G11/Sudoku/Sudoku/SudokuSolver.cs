using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuSolver
    {
        Sudoku Input; // Workung Sudoku
        int SolCounter; // Solution counter
        int Remaining; // Fields yet to be found
        bool Finished; // true when done

        bool Changed;

        public Sudoku Solve(Sudoku suk, bool count, int maxDifficulty)
        {
            Remaining = 81;
            Input = suk;
            InitCandidates();
            SolCounter = 0;

            int Difficulty = 1;
            int HighestDifficulty = 1;

            Input.Rem1 = -1;
            Input.Rem2 = -1;
            Input.Rem3 = -1;

            while (Remaining > 0)
            {
                int oldRem = Remaining;

                if (Grade0())
                    continue;

                if (Grade1())
                    continue;

                if (Difficulty >= 2)
                {
                    if (Input.Rem1 == -1)
                        Input.Rem1 = Remaining;

                    if (GradeX(2))
                    {
                        continue;
                    }
                    if (CandidateLine())
                    {
                        continue;
                    }
                }

                if (Difficulty >= 3)
                {
                    if (Input.Rem2 == -1)
                        Input.Rem2 = Remaining;

                    if (GradeX(3))
                        continue;
                    if (XWing())
                    {
                        continue;
                    }
                }

                if (Difficulty >= 4)
                {   // this completes the sudoku in one step
                    if (Input.Rem3 == -1)
                        Input.Rem3 = Remaining;

                    NonLogic(count);
                }

                if (Remaining == oldRem)
                {
                    Difficulty++;
                    if (Difficulty > HighestDifficulty)
                        HighestDifficulty = Difficulty;

                    if (Difficulty > maxDifficulty)
                    {
                        Input.Difficulty = HighestDifficulty;
                        Input.NrSolutions = 0;
                        return null;
                    }
                    if (Difficulty > 4)
                        break;
                }
                else
                    Difficulty = 1;
            }

            // brute force counts the number of solutions
            Input.NrSolutions = SolCounter;
            if (Input.NrSolutions == 0)
                Input.NrSolutions = 1; // no brute force used

            Input.Difficulty = HighestDifficulty;
            return Input;
        }

        private void InitCandidates()
        {
            Remaining = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int z = 1; z <= 9; z++)
                        {
                            Input.Fields[i][j].Candidates.Add(z);
                        }
                        Remaining++;
                        Input.Fields[i][j].NewFound = false;
                    }
                    else
                        Input.Fields[i][j].NewFound = true;
                }
            }
        }

        private bool Grade0()
        {
            bool Change = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Input.Fields[i][j].NewFound)
                    {
                        foreach (Sudoku.Field f in Input.GetGroup(i, j))
                        {
                            if (!f.Filled)
                            {   // remove all candidates which have already been placed in the group
                                if (f.Candidates.Remove(Input.Fields[i][j].Value))
                                    Change = true;
                            }
                        }
                        Input.Fields[i][j].NewFound = false;
                    }
                }
            }

            return Change;
        }

        private bool Grade1()
        {
            // Direct = Naked Single
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled && Input.Fields[i][j].Candidates.Count == 1)
                    {   // for fields with only one remaining candidate chose that
                        Input.Fields[i][j].Value = Input.Fields[i][j].Candidates[0];
                        Input.Fields[i][j].Filled = true;
                        Input.Fields[i][j].NewFound = true;
                        Remaining--;
                        return true;
                    }
                }
            }
            // Inverse = Hidden Single
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int a = 0; a < Input.Fields[i][j].Candidates.Count; a++)
                        {
                            for (int part = 0; part < 3; part++)
                            {
                                bool Found = false;
                                foreach (Sudoku.Field f in Input.GetGroupPart(i, j, part))
                                {
                                    if (!f.Filled && f.Candidates.Contains(Input.Fields[i][j].Candidates[a]))
                                    {
                                        Found = true;
                                        break;
                                    }
                                }
                                if (!Found)
                                {   // if one candidate of field X never occurs in the candidate lists of the other fields in one part of the group of X, chose that
                                    Input.Fields[i][j].Value = Input.Fields[i][j].Candidates[a];
                                    Input.Fields[i][j].Filled = true;
                                    Input.Fields[i][j].NewFound = true;
                                    Remaining--;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool GradeX(int x)
        {
            // Direct = Hidden Double, Triple etc.
            Changed = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled && Input.Fields[i][j].Candidates.Count >= x)
                    {
                        for (int a = 0; a < Input.Fields[i][j].Candidates.Count; a++)
                        {
                            List<int> Temp = new List<int>();
                            Temp.Add(a);
                            RekGradeX(i, j, Temp, 1, x); // recursively try the direct version
                        }
                    }
                }
            }

            // Opposite = Naked Double, Triple etc.
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled && Input.Fields[i][j].Candidates.Count == x)
                    {
                        for (int part = 0; part < 3; part++)
                        {
                            int FoundCounter = 0;
                            List<int> FoundI = new List<int>();
                            List<int> FoundJ = new List<int>();
                            foreach (Sudoku.Field f in Input.GetGroupPart(i, j, part))
                            {
                                if (!f.Filled && f.Candidates.Count == x)
                                {
                                    bool Found = true;
                                    for (int z = 0; z < x; z++)
                                    {
                                        if (!f.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                        {
                                            Found = false;
                                            break;
                                        }
                                    }
                                    if (Found)
                                    {
                                        FoundCounter++;
                                        FoundI.Add(f.i);
                                        FoundJ.Add(f.j);
                                    }
                                }

                            }
                            // now we know that all of the x candidates of field i, j appear in x - 1 other fields in that part of the group
                            if (FoundCounter == x - 1)
                            {   // they have to be filled to one of these x fields, delete the candidates in all other fields of the group part
                                bool ErasedSomething = false;
                                foreach (Sudoku.Field ff in Input.GetGroupPart(i, j, part))
                                {
                                    if (FoundI.Contains(ff.i) && FoundJ.Contains(ff.j))
                                        continue;
                                    for (int z = 0; z < x; z++)
                                    {
                                        if (ff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                            ErasedSomething = true;
                                    }
                                }
                                return ErasedSomething;
                            }
                        }
                    }
                }
            }
            if (Changed)
                return true;
            else
                return false;
        }

        private void RekGradeX(int i, int j, List<int> current, int depth, int x)
        {
            if (depth < x)
            {
                for (int a = 0; a < Input.Fields[i][j].Candidates.Count; a++)
                {
                    if (!current.Contains(a))
                    {
                        List<int> Copied = Copy(current);
                        Copied.Add(a);
                        RekGradeX(i, j, Copied, depth + 1, x);
                    }
                }
            }
            else
            {
                // when reached the bottom of the recursion, x candidates of field i, j have been selected
                for (int part = 0; part < 3; part++)
                {
                    int Found = 0;
                    List<int> FoundI = new List<int>();
                    List<int> FoundJ = new List<int>();

                    foreach (Sudoku.Field f in Input.GetGroupPart(i, j, part))
                    {
                        if (!f.Filled)
                        {
                            for (int z = 0; z < x; z++)
                            {
                                if (f.Candidates.Contains(Input.Fields[i][j].Candidates[current[z]]))
                                {
                                    Found++;
                                    FoundI.Add(f.i);
                                    FoundJ.Add(f.j);
                                    break;
                                }
                            }
                            if (Found > x - 1)
                                break;
                        }
                    }
                    if (Found == x - 1)
                    {
                        // now we know that the selected x candidates only occur in x - 1 fields in that part of the group
                        bool Match = true;
                        for (int a = 0; a < FoundI.Count; a++)
                        {
                            for (int z = 0; z < x; z++)
                            {   // now we check if those x - 1 fields contain all x candidates
                                if (!Input.Fields[FoundI[a]][FoundJ[a]].Candidates.Contains(Input.Fields[i][j].Candidates[current[z]]))
                                {
                                    Match = false;
                                    break;
                                }
                            }
                        }
                        if (Match)
                        {   // if yes, they have to be filled to one of these x fields, delete all other candidates
                            List<int> Candidates = new List<int>();

                            for (int z = 0; z < x; z++)
                            {
                                Candidates.Add(Input.Fields[i][j].Candidates[current[z]]);
                            }

                            if (Input.Fields[i][j].Candidates.Count() != Candidates.Count)
                                Changed = true;
                            Input.Fields[i][j].Candidates = new List<int>();
                            for (int z = 0; z < x; z++)
                            {
                                Input.Fields[i][j].Candidates.Add(Candidates[z]);
                            }
                            for (int a = 0; a < FoundI.Count; a++)
                            {
                                if (Input.Fields[FoundI[a]][FoundJ[a]].Candidates.Count() != Candidates.Count)
                                    Changed = true;
                                Input.Fields[FoundI[a]][FoundJ[a]].Candidates = new List<int>();
                                for (int z = 0; z < x; z++)
                                {
                                    Input.Fields[FoundI[a]][FoundJ[a]].Candidates.Add(Candidates[z]);
                                }
                            }
                            return;
                        }
                    }
                }
            }
        }

        private void NonLogic(bool count)
        {
            // find all not yet solved fields
            List<Sudoku.Field> ToDo = new List<Sudoku.Field>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                        ToDo.Add(Input.Fields[i][j]);
                }
            }
            Finished = false;
            // solve these by trying out all combinations
            BruteForce(ToDo, 0, Input, count);
        }

        private void BruteForce(List<Sudoku.Field> ToDo, int pos, Sudoku Temp, bool count)
        {
            if (Finished)
                return;
            for (int i = 0; i < ToDo[pos].Candidates.Count; i++)
            {
                Sudoku Copied = Temp.Copy();
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Filled = true;
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].NewFound = false;
                // place a random value and ...
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value = ToDo[pos].Candidates[i];
                bool Valid = true;
                // ... check if solution is still valid
                foreach (Sudoku.Field f in Copied.GetGroup(ToDo[pos].i, ToDo[pos].j))
                {
                    if (f.Filled && f.Value == Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value)
                    {
                        Valid = false;
                        break;
                    }
                }
                if (Valid)
                {   // if yes, go to the next position
                    if (pos % 5 == 0)
                        Grade0();
                    if (pos < ToDo.Count - 1)
                        BruteForce(ToDo, pos + 1, Copied, count);
                    else
                    {   // or otherwise, we are done
                        if (!count)
                        {
                            Finished = true;
                            Input = Copied;
                            Remaining = 0;
                        }
                        else
                        {   // if we want to count the solutions, we do not stop after having found the first one
                            SolCounter++;
                            Remaining = 0;
                            if (SolCounter > 1)
                            {
                                Finished = true;
                            }
                        }
                    }
                }
            }
        }

        private bool CandidateLine()
        {
            bool Found = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int z = 0; z < Input.Fields[i][j].Candidates.Count; z++)
                        {
                            int Direction = 0; // 1 = Vertical, 2 = Horizontal
                            foreach (Sudoku.Field f in Input.GetBox(i, j))
                            {
                                if (!f.Filled && f.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                {
                                    if (Direction == 0)
                                    {
                                        if (f.i == i)
                                            Direction = 2;
                                        else if (f.j == j)
                                            Direction = 1;
                                        else
                                            Direction = -1;
                                    }
                                    else
                                    {
                                        if (f.i == i && Direction == 2)
                                            Direction = 2;
                                        else
                                        {
                                            Direction = -1;
                                            break;
                                        }
                                        if (f.j == j && Direction == 1)
                                            Direction = 1;
                                        else
                                        {
                                            Direction = -1;
                                            break;
                                        }
                                    }
                                }
                            }

                            if (Direction == 1)
                            {
                                foreach (Sudoku.Field f in Input.GetColumn(i, j))
                                {
                                    if (!Input.BelongsToBox(i, j, f) && !f.Filled)
                                    {
                                        if (f.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                            Found = true;
                                    }
                                }
                            }
                            if (Direction == 2)
                            {
                                foreach (Sudoku.Field f in Input.GetRow(i, j))
                                {
                                    if (!Input.BelongsToBox(i, j, f) && !f.Filled)
                                        if (f.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                            Found = true;
                                }
                            }

                            if (Found)
                                return true;
                        }
                    }
                }
            }

            return Found;
        }

        private bool XWing()
        {
            bool Found = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int z = 0; z < Input.Fields[i][j].Candidates.Count; z++)
                        {
                            bool RowPossible1 = true;
                            bool ColumnPossible1 = true;
                            bool RowPossible2 = true;
                            bool ColumnPossible2 = true;

                            int RowCounter1 = 1;
                            foreach (Sudoku.Field a in Input.GetColumn(i, j))
                            {
                                if (!a.Filled && a.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                {
                                    RowCounter1++;
                                }
                            }
                            if (RowCounter1 != 2)
                                RowPossible1 = false;

                            int ColumnCounter1 = 1;
                            foreach (Sudoku.Field a in Input.GetRow(i, j))
                            {
                                if (!a.Filled && a.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                {
                                    ColumnCounter1++;
                                }
                            }
                            if (ColumnCounter1 != 2)
                                ColumnPossible1 = false;


                            if (!RowPossible1 && !ColumnPossible1)
                                continue;

                            foreach (Sudoku.Field f in Input.GetRow(i, j))
                            {
                                if (!f.Filled && f.Candidates.Contains(Input.Fields[i][j].Candidates[z]) && !Input.BelongsToBox(i, j, f)) // 2nd point
                                {
                                    int RowCounter2 = 1;
                                    RowPossible2 = true;
                                    foreach (Sudoku.Field b in Input.GetColumn(f.i, f.j))
                                    {
                                        if (!b.Filled && b.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                        {
                                            RowCounter2++;
                                        }
                                    }
                                    if (RowCounter2 != 2)
                                        RowPossible2 = false;

                                    foreach (Sudoku.Field ff in Input.GetColumn(i, j))
                                    {
                                        if (!ff.Filled && ff.Candidates.Contains(Input.Fields[i][j].Candidates[z]) && !Input.BelongsToBox(i, j, ff)) // 3rd point
                                        {
                                            int ColumnCounter2 = 1;
                                            ColumnPossible2 = true;
                                            foreach (Sudoku.Field c in Input.GetRow(ff.i, ff.j))
                                            {
                                                if (!c.Filled && c.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                                {
                                                    ColumnCounter2++;
                                                }
                                            }
                                            if (ColumnCounter2 != 2)
                                                ColumnPossible2 = false;

                                            if ((!RowPossible1 || !RowPossible2) && (!ColumnPossible1 || !ColumnPossible2))
                                                continue;

                                            Sudoku.Field fff = Input.Fields[ff.i][f.j];
                                            {
                                                if (!fff.Filled && !Input.BelongsToBox(ff.i, ff.j, fff) && fff.Candidates.Contains(Input.Fields[i][j].Candidates[z])) // 4th point
                                                {
                                                    if (ColumnPossible1 && ColumnPossible2)
                                                    {
                                                        foreach (Sudoku.Field ffff in Input.GetColumn(i, j))
                                                        {
                                                            if (ffff.i == ff.i && ffff.j == ff.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                        foreach (Sudoku.Field ffff in Input.GetColumn(f.i, f.j))
                                                        {
                                                            if (ffff.i == fff.i && ffff.j == fff.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                    }

                                                    if (RowPossible1 && RowPossible2)
                                                    {
                                                        foreach (Sudoku.Field ffff in Input.GetRow(i, j))
                                                        {
                                                            if (ffff.i == f.i && ffff.j == f.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                        foreach (Sudoku.Field ffff in Input.GetRow(ff.i, ff.j))
                                                        {
                                                            if (ffff.i == fff.i && ffff.j == fff.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (Found)
                                return true;
                        }

                    }
                }
            }
            return Found;
        }

        private List<int> Copy(List<int> dummy)
        {
            List<int> Result = new List<int>();
            foreach (int i in dummy)
                Result.Add(i);
            return Result;
        }
    }
}
