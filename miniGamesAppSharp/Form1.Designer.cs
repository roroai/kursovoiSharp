namespace miniGamesAppSharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SnakeButton = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.SudokuButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // SnakeButton
            // 
            this.SnakeButton.Location = new System.Drawing.Point(13, 49);
            this.SnakeButton.Name = "SnakeButton";
            this.SnakeButton.Size = new System.Drawing.Size(268, 72);
            this.SnakeButton.TabIndex = 1;
            this.SnakeButton.Text = "Змейка";
            this.SnakeButton.UseVisualStyleBackColor = true;
            this.SnakeButton.Click += new System.EventHandler(this.SnakeButton_Click);
            // 
            // GameButton
            // 
            this.GameButton.Location = new System.Drawing.Point(13, 127);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(268, 72);
            this.GameButton.TabIndex = 2;
            this.GameButton.Text = "2048";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // SudokuButton
            // 
            this.SudokuButton.Location = new System.Drawing.Point(13, 205);
            this.SudokuButton.Name = "SudokuButton";
            this.SudokuButton.Size = new System.Drawing.Size(268, 72);
            this.SudokuButton.TabIndex = 3;
            this.SudokuButton.Text = "Судоку";
            this.SudokuButton.UseVisualStyleBackColor = true;
            this.SudokuButton.Click += new System.EventHandler(this.SudokuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 288);
            this.Controls.Add(this.SudokuButton);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.SnakeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Сборник мини игр";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button SnakeButton;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button SudokuButton;
    }
}

