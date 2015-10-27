using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Knights_Tour
{
    public partial class frmMain : Form
    {
        private NewBoard ventanaNewBoard; //Variable para trabajar con el formulario de nuevo tablero
        private PosicionInicial ventanaPosicionInicial; //Variable para trabajar con el formulario de colocacion del caballo
        private TextBox[,] _chessBoardPanels; //Variable para crear el tablero de ajedrez del tamaño correcto
        private const int tileSize = 40; //Tamaño de los cuadrados del tablero
        private int boardSize = 0; //Tamaño del tablero
        private int panelSize = 24; //Variable del tamaño del panel menu
        private Stack<ValidMoveSpot> _solutionMoves = new Stack<ValidMoveSpot>();
        private int maxX = 0;
        private int maxY = 0;
        private int posX = 0;
        private int posY = 0;
        private int tiempo = 500;

        public frmMain()
        {
            InitializeComponent();
            ventanaNewBoard = new NewBoard();
            ventanaPosicionInicial = new PosicionInicial();
            _chessBoardPanels = null;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaNewBoard.Visible = false;
            ventanaNewBoard.control = false;
            ventanaNewBoard.ShowDialog();
            if(ventanaNewBoard.control)
            {
                if (_chessBoardPanels != null)
                {
                    for (var n = 0; n < boardSize; n++)
                    {
                        for (var m = 0; m < boardSize; m++)
                        {
                            Controls.Remove(_chessBoardPanels[n, m]);
                        }
                    }
                }
                boardSize = int.Parse(ventanaNewBoard.txtBoardSize.Text);
                maxX = boardSize;
                maxY = boardSize;
                var clr1 = Color.DarkGray;
                var clr2 = Color.White;

                // initialize the "chess board"
                _chessBoardPanels = new TextBox[boardSize, boardSize];

                for (var n = 0; n < boardSize; n++)
                {
                    for (var m = 0; m < boardSize; m++)
                    {
                        // create new Panel control which will be one 
                        // chess board tile
                        var newPanel = new TextBox
                        {
                            Size = new Size(tileSize, tileSize),
                            Location = new Point(tileSize * n, tileSize * m + panelSize),
                            Multiline = true,
                            BorderStyle = BorderStyle.FixedSingle,
                            ForeColor = Color.Black,
                            TextAlign = HorizontalAlignment.Center,
                            Font = new Font("Microsoft Sans Serif", 18),
                            ReadOnly = true,
                            Enabled = false
                        };

                        // add to Form's Controls so that they show up
                        Controls.Add(newPanel);

                        // add to our 2d array of panels for future use
                        _chessBoardPanels[n, m] = newPanel;

                        // color the backgrounds
                        if (n % 2 == 0)
                            newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                        else
                            newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                    }
                }
                this.Size = new Size(_chessBoardPanels[boardSize - 1, boardSize - 1].Location)
                    + new Size(tileSize + 16 + panel1.Width, tileSize + 38);
                colocarCaballoToolStripMenuItem.Visible = true;
                panel1.Visible = true;
            }
        }

        private void colocarCaballoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaPosicionInicial.Visible = false;
            ventanaPosicionInicial.control = false;
            ventanaPosicionInicial.ShowDialog();
            if (ventanaPosicionInicial.control)
            {
                posX = int.Parse(ventanaPosicionInicial.txtPosX.Text) - 1;
                posY = int.Parse(ventanaPosicionInicial.txtPosY.Text) - 1;
                _chessBoardPanels[posX, posY].BackColor = Color.LimeGreen;
                comenzarToolStripMenuItem.Visible = true;
                colocarCaballoToolStripMenuItem.Visible = false;
            }
        }

        private async void comenzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoToolStripMenuItem.Enabled = false;
            comenzarToolStripMenuItem.Enabled = false;
            var takenPositions = new bool[maxY, maxX];
            var solutionFound = await FindSolution(takenPositions, posX, posY);

            if (!solutionFound)
            {
                MessageBox.Show("No hay solucion");
            }

            nuevoToolStripMenuItem.Enabled = true;
            comenzarToolStripMenuItem.Visible = false;
            comenzarToolStripMenuItem.Enabled = true;
        }

        public void DrawBoard(ValidMoveSpot m, bool[,] takenPositions)
        {
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;
            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    if (j == m.X && i == m.Y)
                    {
                        _chessBoardPanels[j, i].Text = "K";
                        _chessBoardPanels[j, i].BackColor = Color.Red;
                    }
                    else if (takenPositions[i, j])
                    {
                        _chessBoardPanels[j, i].Text = "*";
                        _chessBoardPanels[j, i].BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        _chessBoardPanels[j, i].Text = "";
                        if (i % 2 == 0)
                            _chessBoardPanels[j, i].BackColor = j % 2 != 0 ? clr1 : clr2;
                        else
                            _chessBoardPanels[j, i].BackColor = j % 2 != 0 ? clr2 : clr1;
                    }
                }
            }
        }

        public async Task<bool> FindSolution(bool[,] takenPositions, int x, int y)
        {
            takenPositions[y, x] = true;
            ValidMoveSpot prueba = new ValidMoveSpot { X = x, Y = y };
            _solutionMoves.Push(prueba);
            DrawBoard(prueba, takenPositions);
            await Task.Delay(tiempo);

            if (_solutionMoves.Count == maxX * maxY)
            {
                return true;
            }

            foreach (var validMove in FindValidMoves(takenPositions, x, y))
            {
                var isFilled = await FindSolution(takenPositions, validMove.X, validMove.Y);
                if (isFilled)
                {
                    return true;
                }
            }

            takenPositions[y, x] = false;
            _solutionMoves.Pop();
            return false;
        }

        public List<ValidMoveSpot> FindValidMoves(bool[,] takenPositions, int x, int y)
        {
            var validMoves = new List<ValidMoveSpot>();

            if (x - 2 >= 0 && y - 1 >= 0 && !takenPositions[y - 1, x - 2])
            {
                validMoves.Add(new ValidMoveSpot { X = x - 2, Y = y - 1 });
            }
            if (x - 1 >= 0 && y - 2 >= 0 && !takenPositions[y - 2, x - 1])
            {
                validMoves.Add(new ValidMoveSpot { X = x - 1, Y = y - 2 });
            }
            if (x + 1 < maxX && y - 2 >= 0 && !takenPositions[y - 2, x + 1])
            {
                validMoves.Add(new ValidMoveSpot { X = x + 1, Y = y - 2 });
            }
            if (x + 2 < maxX && y - 1 >= 0 && !takenPositions[y - 1, x + 2])
            {
                validMoves.Add(new ValidMoveSpot { X = x + 2, Y = y - 1 });
            }
            if (x + 2 < maxX && y + 1 < maxY && !takenPositions[y + 1, x + 2])
            {
                validMoves.Add(new ValidMoveSpot { X = x + 2, Y = y + 1 });
            }
            if (x + 1 < maxX && y + 2 < maxY && !takenPositions[y + 2, x + 1])
            {
                validMoves.Add(new ValidMoveSpot { X = x + 1, Y = y + 2 });
            }
            if (x - 1 >= 0 && y + 2 < maxY && !takenPositions[y + 2, x - 1])
            {
                validMoves.Add(new ValidMoveSpot { X = x - 1, Y = y + 2 });
            }
            if (x - 2 >= 0 && y + 1 < maxY && !takenPositions[y + 1, x - 2])
            {
                validMoves.Add(new ValidMoveSpot { X = x - 2, Y = y + 1 });
            }

            return validMoves;
        }

        public struct ValidMoveSpot
        {
            public int X;
            public int Y;
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Knight's Tour creado para la clase de PROGRAMACION IV, CopyRight © 2015 - CICLO 02\nAutor: Cristian Sanchez\nSA120974\nNickname: Sancas", "Sobre mi...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tiempo = int.Parse(vScrollBar1.Value.ToString()) * 10;
        }
    }
}
