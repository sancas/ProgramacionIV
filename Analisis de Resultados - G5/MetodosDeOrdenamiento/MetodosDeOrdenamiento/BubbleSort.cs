using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosDeOrdenamiento
{
    public partial class frmBubbleSort : Form
    {
        string[] bubbleSortCode = new string[] {
            "for (int i = 0; i < a.Length; i++)",
            "{",
            "\tfor (int j = 0; j < a.Length -1; j++)",
            "\t\t{",
            "\t\tif (a [ j ] > a [j + 1])",
            "\t\t{",            "\t\t\tint aux = a [ j ];",            "\t\t\ta [ j ] = a [j + 1];",            "\t\t\ta [j + 1] = aux;",
            "\t\t}",
            "\t}",
            "}"
        };
        public frmBubbleSort()
        {
            InitializeComponent();
        }

        private void frmBubbleSort_Load(object sender, EventArgs e)
        {
            this.Focus();
            boxBubbleSortCode.Lines = bubbleSortCode;
            boxBubbleSortCode.AppendText("hola", Color.DarkGreen);
        }
    }
}
