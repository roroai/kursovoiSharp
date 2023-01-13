using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;



namespace miniGamesAppSharp
{
    public partial class SnakeForm : Form
    {
        private PictureBox fruit;
	    private PictureBox[] Snake;
	    private bool play;
        private bool die;
        private bool firstLaunch;
        private int score = 0;
        private int step = 10;
        private int updateInterval = 100;
        public struct Vector2
        {
            public int X, Y;
        };
        public Vector2 direction;
        public Vector2 positionFruit;
        public Vector2 gameArea;

        public SnakeForm()
        {
            InitializeComponent();
            //Задаем размеры игровой зоны
            gameArea.X = 500;
            gameArea.Y = 500;
            firstLaunch = true;//первый запуск
            NewGame();//новая игра
        }



        private void GeneratePositionFruit()
        {
            //Генерируем позицию фрукта

            Random rand = new Random();
            positionFruit.X = rand.Next(50, gameArea.X);
            positionFruit.Y = rand.Next(150, gameArea.Y);

            //Проверка, что фрукт не на змейке
            for (int i = 0; i < score; i++)
            {
                if (positionFruit.X == Snake[i].Location.X && positionFruit.Y == Snake[i].Location.Y)
                    GeneratePositionFruit();
            }
            //Преобразование значения, чтобы оно было кратно шагу

            int tempX = positionFruit.X % step;
            positionFruit.X -= tempX;
            int tempY = positionFruit.Y % step;
            positionFruit.Y -= tempY;

            //Даем фрукту позицию

            fruit.Location = new Point(positionFruit.X, positionFruit.Y);

            //Добавляем объект на форму

            this.Controls.Add(fruit);
        }


        private void Eating()
        {
            //Проверяем позицию головы змеи и фрукта

            if (Snake[0].Location.X == positionFruit.X && Snake[0].Location.Y == positionFruit.Y)
            {
                labelScore.Text = "Счет: " + ++score;

                //Добавляем змейке новый сегмент

                Snake[score] = new PictureBox();
                Snake[score].Location = new Point(Snake[score - 1].Location.X + step * direction.X, Snake[score - 1].Location.Y + step * direction.Y);
                Snake[score].BackColor = Color.Red;
                Snake[score].Width = step;
                Snake[score].Height = step;
                this.Controls.Add(Snake[score]);
                GeneratePositionFruit();
            }
        }


        private void Movement()
        {
            //Двигаем каждый компонент змейки

            for (int i = score; i >= 1; i--)
            {
                Snake[i].Location = Snake[i - 1].Location;
            }
            Snake[0].Location = new Point(Snake[0].Location.X + step * direction.X, Snake[0].Location.Y + step * direction.Y);
        }


        private void EatYourself()
        {
            //Проверка каждого сегмента

            for (int i = 1; i < score; i++)
            {
                if (Snake[0].Location == Snake[i].Location)
                    GameOver();
            }
        }


        void GameOver()
        {
            play = true;
            die = true;
            labelGameOver.Visible = true;
        }


        private void NewGame()
        {
            if (!firstLaunch)
            {
                this.Controls.Remove(fruit);
                for (int i = 0; i <= score; i++)
                    this.Controls.Remove(Snake[i]);
                score = 0;
            }
            else
                firstLaunch = false;
            //Инициализируем змейку
            Snake = new PictureBox[400];
            Snake[0] = new PictureBox();
            Snake[0].Location = new Point(200, 200);
            Snake[0].BackColor = Color.Green;
            Snake[0].Width = step;
            Snake[0].Height = step;
            score = 0;
            this.Controls.Add(Snake[0]);

            //Инициализируем фрукт
            fruit = new PictureBox();
            fruit.Location = new Point(200, 200);
            fruit.BackColor = Color.Yellow;
            fruit.Width = step;
            fruit.Height = step;
            GeneratePositionFruit();

            //Задаем интервал обновления для таймера и запускаем его
            timer.Interval = updateInterval;
            timer.Start();

            //Задаем направление на запуске
            direction.X = 1;
            direction.Y = 0;

            //Можно играть
            play = true;
            die = false;
            labelScore.Text = "Счет: 0";

            //Скрываем ненужные компоненты на форме
            labelGameOver.Visible = false;
            groupBoxSettings.Visible = false;
        }


        private void CheckBorders()
        {
            if (Snake[0].Location.X >= RightBorder.Location.X || Snake[0].Location.X <= LeftBorder.Location.X)
                GameOver();
            if (Snake[0].Location.Y <= UpperBorder.Location.Y || Snake[0].Location.Y >= LowerBorder.Location.Y)
                GameOver();
        }


        private void buttonApplySpeed_Click(object sender, EventArgs e)
        {
            updateInterval =  Convert.ToInt32(numericUpDownSpeedSetting.Value);
            timer.Interval = updateInterval;
            buttonApplySpeed.Enabled = false;
            numericUpDownSpeedSetting.Enabled = false;
            groupBoxSettings.Visible = false;
            //Запускаем игру
            play = true;
            timer.Start();
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void информацияОИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры: \n1. Для управления использовать стрелки\n2. Ешьте фрукты для увелечения счета и змейки\n3. Нельзя есть себя и врезаться в стенки", "Информация о игре");
        }


        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }


        private void паузапродолжитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (play)
                play = false;
            else
            {
                play = true;
                timer.Start();
            }
        }


        private void натройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBoxSettings.Visible == false)
            {
                play = false;
                buttonApplySpeed.Enabled = true;
                numericUpDownSpeedSetting.Enabled = true;
                groupBoxSettings.Visible = true;
            }
            else
            {
                play = true;
                buttonApplySpeed.Enabled = false;
                numericUpDownSpeedSetting.Enabled = false;
                groupBoxSettings.Visible = false;
            }
        }

        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Считываем нажатую клавишу
            if (e.KeyCode.ToString() == "Right")
            {
                direction.X = 1;
                direction.Y = 0;
            }
            if (e.KeyCode.ToString() == "Left")
            {
                direction.X = -1;
                direction.Y = 0;
            }
            if (e.KeyCode.ToString() == "Up")
            {
                direction.X = 0;
                direction.Y = -1;
            }
            if (e.KeyCode.ToString() == "Down")
            {
                direction.X = 0;
                direction.Y = 1;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!die && play)
            {
                Movement();
                Eating();
                EatYourself();
                CheckBorders();
            }
            else if (die && play)
            {
                timer.Stop();
                MessageBox.Show("Игра окончена!", "Внимание!");
            }
            else if (!die && !play)
            {
                timer.Stop();
                MessageBox.Show("Игра приостановлена", "Внимание!");
            }
        }
    }
}
