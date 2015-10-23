using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public class Sudoku
    {
        public class Field
        {
            public int Value;
            public List<int> Candidates;
            public bool Filled;

            public int i;
            public int j;
            public bool NewFound;

            public Field(int _i, int _j)
            {
                Candidates = new List<int>();
                Filled = false;
                i = _i;
                j = _j;
                NewFound = false;
            }

            public Field Copy()
            {
                Field Result = new Field(i, j);
                foreach (int ii in Candidates)
                    Result.Candidates.Add(ii);
                Result.Filled = Filled;
                Result.Value = Value;
                Result.NewFound = NewFound;
                return Result;
            }
        }

        public Field[][] Fields;
        public int Difficulty;
        public int Rem1;
        public int Rem2;
        public int Rem3;
        public int NrSolutions;

        public Sudoku Copy()
        {
            Sudoku Result = new Sudoku(new List<int>());
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Result.Fields[i][j] = Fields[i][j].Copy();
                }
            }
            Result.Difficulty = Difficulty;
            Result.Rem1 = Rem1;
            Result.Rem2 = Rem2;
            Result.Rem3 = Rem3;
            Result.NrSolutions = NrSolutions;

            return Result;
        }

        public Sudoku(TextBox[][] values)
        {
            Difficulty = 1;
            Rem1 = -1;
            Rem2 = -1;
            Rem3 = -1;
            NrSolutions = 0;

            Fields = new Field[9][];
            for (int i = 0; i < 9; i++)
            {
                Fields[i] = new Field[9];
                for (int j = 0; j < 9; j++)
                {
                    Fields[i][j] = new Field(i, j);
                    if (values[i][j].Text != "")
                    {
                        Fields[i][j].Value = int.Parse(values[i][j].Text);
                        Fields[i][j].NewFound = true;
                        Fields[i][j].Filled = true;
                    }
                }
            }
        }

        public Sudoku(List<int> values)
        {
            Difficulty = 1;
            Rem1 = -1;
            Rem2 = -1;
            Rem3 = -1;
            NrSolutions = 0;

            Fields = new Field[9][];
            for (int i = 0; i < 9; i++)
            {
                Fields[i] = new Field[9];
                for (int j = 0; j < 9; j++)
                {
                    Fields[i][j] = new Field(i, j);
                }
            }

            // Llenar el sudoku con los valores dados
            int a = 0;
            int b = 0;
            for (int x = 0; x < values.Count; x++)
            {
                if (values[x] != 0)
                {
                    Fields[b][a].Value = values[x];
                    Fields[b][a].NewFound = true;
                    Fields[b][a++].Filled = true;
                }
                else
                    a++;
                if (a > 8)
                {
                    a = 0;
                    b++;
                }
            }
        }

        // returns all fields in a column
        public List<Field> GetColumn(int i, int j)
        {
            List<Field> Result = new List<Field>();
            for (int a = 0; a < 9; a++)
            {
                if (a != i)
                    Result.Add(Fields[a][j]);
            }
            return Result;
        }

        // returns all fields in a row
        public List<Field> GetRow(int i, int j)
        {
            List<Field> Result = new List<Field>();
            for (int a = 0; a < 9; a++)
            {
                if (a != j)
                    Result.Add(Fields[i][a]);
            }
            return Result;
        }

        // returns all fields in a box
        public List<Field> GetBox(int i, int j)
        {
            List<Field> Result = new List<Field>();
            int iStart = i - i % 3;
            int jStart = j - j % 3;

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (iStart + a != i || jStart + b != j)
                        Result.Add(Fields[iStart + a][jStart + b]);
                }

            }
            return Result;
        }

        // returns all fields in a group
        public List<Field> GetGroup(int i, int j)
        {
            List<Field> Row = GetRow(i, j);
            List<Field> Column = GetColumn(i, j);
            List<Field> Box = GetBox(i, j);
            List<Field> Result = new List<Field>();
            Result.AddRange(Row);
            Result.AddRange(Column);
            Result.AddRange(Box);
            return Result;
        }

        // returns all fields from either a row, column or box
        public List<Field> GetGroupPart(int i, int j, int part)
        {
            switch (part)
            {
                case 0:
                    return GetRow(i, j);
                case 1:
                    return GetColumn(i, j);
                case 2:
                    return GetBox(i, j);
                default:
                    return null;
            }
        }

        public string Debug(int Difficulty)
        {
            string Result = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Result += Fields[i][j].Value.ToString() + " ";
                }
                Result += Environment.NewLine;
            }
            Result += "  Difficulty: " + Difficulty.ToString();
            return Result;
        }

        public bool BelongsToBox(int i, int j, Field f)
        {
            int iStart = i - i % 3;
            int jStart = j - j % 3;
            if (f.i >= iStart && f.i <= iStart + 2 && f.j >= jStart && f.j <= jStart + 2)
                return true;
            else
                return false;
        }
    }
}
