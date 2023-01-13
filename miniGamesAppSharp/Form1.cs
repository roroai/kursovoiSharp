using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniGamesAppSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы открыть нужную игру нажмите на соответствующую кнопку. \nПравила каждой игры можно будет узнать внутри игры. \nЯкимов А. ПИ-11.\nАлтГТУ 2022.", "О программе");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SnakeButton_Click(object sender, EventArgs e)
        {
            SnakeForm  snf = new SnakeForm();
            snf.Show();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            GameForm  gf = new GameForm();
            gf.Show();
        }

        private void SudokuButton_Click(object sender, EventArgs e)
        {
            SudokuForm sf = new SudokuForm();
            sf.Show();
        }
    }
}
