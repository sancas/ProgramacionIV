using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class frmMainFrame : Form
    {
        public TextBox[][] Texts;
        public const int TextsSize = 30;
        public const int FontSize = 18;
        public static int Dimension = 9;
        public bool Creando;
        public bool Resolviendo;
        public bool probando = false; //Cambiar a true si se desea probar terminar el sudoku

        public frmMainFrame()
        {
            Creando = false;
            InitializeComponent();
        }

        private void yaTermino()
        {
            if (noHayErrores() && yaNoFaltan())
            {
                for (int i = 0; i < Dimension; i++)
                {
                    for (int j = 0; j < Dimension; j++)
                    {
                        Texts[i][j].ReadOnly = true;
                    }
                }
                SolverToolStripMenuItem.Enabled = false;
                MessageBox.Show("FELICIDADES!! Has terminado con exito el sudoku", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Display(Sudoku suk)
        {
            if (suk != null)
            {
                SolverToolStripMenuItem.Enabled = true;
                SolverToolStripMenuItem.Visible = true;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (suk != null)
                    {
                        if (suk.Fields[i][j].Value == 0)
                        {
                            Texts[i][j].Text = "";
                            Texts[i][j].ReadOnly = false;
                            Texts[i][j].ForeColor = Color.Black;
                            Texts[i][j].BackColor = Color.White;
                        }
                        else if(Resolviendo)
                        {
                            Texts[i][j].Text = suk.Fields[i][j].Value.ToString();
                            Texts[i][j].ReadOnly = true;
                        }
                        else
                        {
                            Texts[i][j].Text = suk.Fields[i][j].Value.ToString();
                            Texts[i][j].ReadOnly = true;
                            Texts[i][j].BackColor = Color.Gray;
                            Texts[i][j].ForeColor = Color.White;
                        }
                    }
                    else
                    {
                        if (Creando)
                        {
                            Texts[i][j].ReadOnly = false;
                            Texts[i][j].Text = "";
                            Texts[i][j].ForeColor = Color.White;
                            Texts[i][j].BackColor = Color.Aqua;
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error al crear el sudoku, el juego se cerrara", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void Texts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void Texts_Changed(object sender, EventArgs e)
        {
            TextBox miTextBox = (TextBox)sender;
            int i = int.Parse(miTextBox.Name[0].ToString());
            int j = int.Parse(miTextBox.Name[1].ToString());
            if (miTextBox.Text != "")
            {
                if (esPosibleInsertar(i, j, miTextBox.Text))
                {
                    miTextBox.BackColor = Color.GreenYellow;
                    if (!Creando && !Resolviendo) yaTermino();
                }
                else
                    miTextBox.BackColor = Color.Red;
            }
            else
            {
                if (Creando)
                    miTextBox.BackColor = Color.Aqua;
                else
                    miTextBox.BackColor = Color.White;
                comprobarTodos();
            }
        }

        private void comprobarTodos()
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (!Texts[i][j].ReadOnly && Texts[i][j].Text != "")
                    {
                        if (esPosibleInsertar(i, j, Texts[i][j].Text))
                            Texts[i][j].BackColor = Color.GreenYellow;
                        else
                            Texts[i][j].BackColor = Color.Red;
                    }
                }
            }
        }

        public Boolean esPosibleInsertar(int i, int j, string valor)
        {
            //Primeramente, se verifica que el valor no se encuentre en la misma fila
            for (int a = 0; a < Dimension; a++)
            {
                if (a != j && Texts[i][a].Text == valor)
                    return false;
            }

            //Luego, se verifica que el valor no se encuentre en la misma columna
            for (int a = 0; a < Dimension; a++)
            {
                if (a != i && Texts[a][j].Text == valor)
                    return false;
            }

            //Se verifica que el valor no se encuentre en la misma cuadricula
            int y = (i / 3) * 3;
            int x = (j / 3) * 3;

            for (int a = 0; a < Dimension / 3; a++)
            {
                for (int b = 0; b < Dimension / 3; b++)
                {
                    if ((a + y) != i && (b + x) != j && Texts[y + a][x + b].Text == valor)
                        return false;
                }
            }
            return true;
        }

        public Boolean yaNoFaltan()
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (Texts[i][j].BackColor == Color.White)
                        return false;
                }
            }
            return true;
        }

        public Boolean noHayErrores()
        {
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    if (Texts[i][j].BackColor == Color.Red)
                        return false;
                }
            }
            return true;
        }

        public Boolean sePuedeResolver(Sudoku ToBeSolved)
        {
            SudokuSolver Solver = new SudokuSolver();
            Sudoku Result = Solver.Solve(ToBeSolved, false, 4);
            if (Result != null)
                return true;
            else
                return false;
        }

        public Sudoku Resolver(Sudoku ToBeSolved)
        {
            SudokuSolver Solver = new SudokuSolver();
            Sudoku Result = Solver.Solve(ToBeSolved, false, 4);
            return Result;
        }
        private void frmMainFrame_Load(object sender, EventArgs e)
        {
            Texts = new TextBox[Dimension][];
            for (int i = 0; i < Dimension; i++)
            {
                Texts[i] = new TextBox[Dimension];
                for (int j = 0; j < Dimension; j++)
                {
                    Texts[i][j] = new TextBox();
                    this.Controls.Add(Texts[i][j]);
                    Texts[i][j].Name = i.ToString() + j.ToString();
                    Texts[i][j].Multiline = true;
                    Texts[i][j].Width = TextsSize;
                    Texts[i][j].Height = TextsSize;
                    if (j == 0)
                        Texts[i][j].Left = 3;
                    else if (j % 3 == 0)
                        Texts[i][j].Left = Texts[i][j - 1].Left + TextsSize + 6;
                    else
                        Texts[i][j].Left = Texts[i][j - 1].Left + TextsSize + 2;
                    if (i == 0)
                        Texts[i][j].Top = 30;
                    else if (i % 3 == 0)
                        Texts[i][j].Top = Texts[i - 1][j].Top + TextsSize + 6;
                    else
                        Texts[i][j].Top = Texts[i - 1][j].Top + TextsSize + 2;
                    Texts[i][j].BorderStyle = BorderStyle.None;
                    Texts[i][j].TextAlign = HorizontalAlignment.Center;
                    Font miFuente = new Font("Microsoft Sans Serif", FontSize);
                    Texts[i][j].Font = miFuente;
                    Texts[i][j].ReadOnly = true;
                    Texts[i][j].BackColor = Color.White;
                    Texts[i][j].MaxLength = 1;
                    Texts[i][j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texts_KeyPress);
                    Texts[i][j].TextChanged += new System.EventHandler(this.Texts_Changed);
                }
            }
            if(probando)
            {
                SudokuCreator Creator = new SudokuCreator();
                Sudoku Created = Creator.CreateRandomSudoku(1, 3);
                Display(Created);
            }
        }

        private void frmMainFrame_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.DrawLine(new Pen(new SolidBrush(Color.Black), 1), Texts[0][2].Left + TextsSize + 3, Texts[0][2].Top, Texts[8][2].Left + TextsSize + 3, Texts[8][2].Top + TextsSize);
            G.DrawLine(new Pen(new SolidBrush(Color.Black), 1), Texts[0][5].Left + TextsSize + 3, Texts[0][5].Top, Texts[8][5].Left + TextsSize + 3, Texts[8][5].Top + TextsSize);

            G.DrawLine(new Pen(new SolidBrush(Color.Black), 1), Texts[2][0].Left, Texts[3][0].Top - 4, Texts[2][8].Left + TextsSize, Texts[3][0].Top - 4);
            G.DrawLine(new Pen(new SolidBrush(Color.Black), 1), Texts[5][0].Left, Texts[6][0].Top - 4, Texts[5][8].Left + TextsSize, Texts[6][0].Top - 4);
        }

        private void muyFacilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuCreator Creator = new SudokuCreator();
            int Difficulty = 1;
            int TargetDel = 32;

            Sudoku Created = Creator.CreateRandomSudoku(Difficulty, 81 - TargetDel);
            Display(Created);
        }

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuCreator Creator = new SudokuCreator();
            int Difficulty = 1;
            int TargetDel = 30;

            Sudoku Created = Creator.CreateRandomSudoku(Difficulty, 81 - TargetDel);
            Display(Created);
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuCreator Creator = new SudokuCreator();
            int Difficulty = 2;
            int TargetDel = 29;

            Sudoku Created = Creator.CreateRandomSudoku(Difficulty, 81 - TargetDel);
            Display(Created);
        }

        private void dificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuCreator Creator = new SudokuCreator();
            int Difficulty = 3;
            int TargetDel = 28;

            Sudoku Created = Creator.CreateRandomSudoku(Difficulty, 81 - TargetDel);
            Display(Created);
        }

        private void muyDificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuCreator Creator = new SudokuCreator();
            int Difficulty = 4;
            int TargetDel = 26;

            Sudoku Created = Creator.CreateRandomSudoku(Difficulty, 81 - TargetDel);
            Display(Created);
        }

        private void createMineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminarToolStripMenuItem.Enabled = true;
            terminarToolStripMenuItem.Visible = true;
            SolverToolStripMenuItem.Visible = false;
            SolverToolStripMenuItem.Enabled = false;
            generateOneToolStripMenuItem.Enabled = false;
            Creando = true;
            MessageBox.Show("Puede empezar a meter los datos, cuando haya terminado haga click en el boton terminar del menu.", "Crear un Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Display(null);
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noHayErrores())
            {
                Sudoku OwnSudoku = new Sudoku(Texts);
                if (sePuedeResolver(OwnSudoku))
                {
                    Display(OwnSudoku);
                    terminarToolStripMenuItem.Visible = false;
                    terminarToolStripMenuItem.Enabled = false;
                    SolverToolStripMenuItem.Enabled = true;
                    SolverToolStripMenuItem.Visible = true;
                    generateOneToolStripMenuItem.Enabled = true;
                    Creando = false;
                }
                else
                {
                    MessageBox.Show("Lo hiciste tan dificil que no se puede resolver.", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Tienes errores con los numeros, revisa los cuadros rojos", "Errores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void SolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult EstaSeguro = MessageBox.Show("Esta seguro que desea resolver el sudoku actual? No podra terminarlo una vez haya confirmado."
                , "Resolver Sudoku?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EstaSeguro == DialogResult.Yes)
            {
                Sudoku ToBeSolved;
                List<int> Fields = new List<int>();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (Texts[i][j].Text == "")
                            Fields.Add(0);
                        else
                            Fields.Add(int.Parse(Texts[i][j].Text));
                    }
                }
                ToBeSolved = new Sudoku(Fields);
                SudokuSolver Solver = new SudokuSolver();
                Sudoku Result = Solver.Solve(ToBeSolved, false, 4);
                Resolviendo = true;
                Display(Result);
                Resolviendo = false;
                SolverToolStripMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Adelante no te desesperes, todavia se puede!", "Tu puedes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El juego de Sudoku creado para la clase de PROGRAMACION IV, CopyRight © 2015 - CICLO 02\nAutor: Cristian Sanchez\nSA120974\nNickname: Sancas", "Sobre mi...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
