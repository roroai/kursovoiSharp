namespace miniGamesAppSharp
{
    partial class SnakeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузапродолжитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.натройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.UpperBorder = new System.Windows.Forms.PictureBox();
            this.LowerBorder = new System.Windows.Forms.PictureBox();
            this.RightBorder = new System.Windows.Forms.PictureBox();
            this.LeftBorder = new System.Windows.Forms.PictureBox();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonApplySpeed = new System.Windows.Forms.Button();
            this.numericUpDownSpeedSetting = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.информацияОИгреToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.паузапродолжитьToolStripMenuItem,
            this.натройкиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // паузапродолжитьToolStripMenuItem
            // 
            this.паузапродолжитьToolStripMenuItem.Name = "паузапродолжитьToolStripMenuItem";
            this.паузапродолжитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.паузапродолжитьToolStripMenuItem.Text = "Пауза\\продолжить";
            this.паузапродолжитьToolStripMenuItem.Click += new System.EventHandler(this.паузапродолжитьToolStripMenuItem_Click);
            // 
            // натройкиToolStripMenuItem
            // 
            this.натройкиToolStripMenuItem.Name = "натройкиToolStripMenuItem";
            this.натройкиToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.натройкиToolStripMenuItem.Text = "Натройки";
            this.натройкиToolStripMenuItem.Click += new System.EventHandler(this.натройкиToolStripMenuItem_Click);
            // 
            // информацияОИгреToolStripMenuItem
            // 
            this.информацияОИгреToolStripMenuItem.Name = "информацияОИгреToolStripMenuItem";
            this.информацияОИгреToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.информацияОИгреToolStripMenuItem.Text = "Информация о игре";
            this.информацияОИгреToolStripMenuItem.Click += new System.EventHandler(this.информацияОИгреToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelScore);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные игры";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(7, 26);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(70, 20);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Счёт: 0";
            // 
            // UpperBorder
            // 
            this.UpperBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperBorder.Location = new System.Drawing.Point(0, 88);
            this.UpperBorder.Name = "UpperBorder";
            this.UpperBorder.Size = new System.Drawing.Size(550, 10);
            this.UpperBorder.TabIndex = 2;
            this.UpperBorder.TabStop = false;
            // 
            // LowerBorder
            // 
            this.LowerBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerBorder.Location = new System.Drawing.Point(0, 628);
            this.LowerBorder.Name = "LowerBorder";
            this.LowerBorder.Size = new System.Drawing.Size(550, 10);
            this.LowerBorder.TabIndex = 3;
            this.LowerBorder.TabStop = false;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightBorder.Location = new System.Drawing.Point(540, 88);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(10, 550);
            this.RightBorder.TabIndex = 4;
            this.RightBorder.TabStop = false;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftBorder.Location = new System.Drawing.Point(0, 88);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(10, 550);
            this.LeftBorder.TabIndex = 5;
            this.LeftBorder.TabStop = false;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelGameOver.Location = new System.Drawing.Point(199, 252);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(166, 25);
            this.labelGameOver.TabIndex = 6;
            this.labelGameOver.Text = "Игра окончена!";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.buttonApplySpeed);
            this.groupBoxSettings.Controls.Add(this.numericUpDownSpeedSetting);
            this.groupBoxSettings.Controls.Add(this.label2);
            this.groupBoxSettings.Location = new System.Drawing.Point(143, 125);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(274, 98);
            this.groupBoxSettings.TabIndex = 7;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки";
            this.groupBoxSettings.Visible = false;
            // 
            // buttonApplySpeed
            // 
            this.buttonApplySpeed.Location = new System.Drawing.Point(112, 53);
            this.buttonApplySpeed.Name = "buttonApplySpeed";
            this.buttonApplySpeed.Size = new System.Drawing.Size(94, 23);
            this.buttonApplySpeed.TabIndex = 2;
            this.buttonApplySpeed.Text = "Применить";
            this.buttonApplySpeed.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSpeedSetting
            // 
            this.numericUpDownSpeedSetting.Location = new System.Drawing.Point(152, 27);
            this.numericUpDownSpeedSetting.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSpeedSetting.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSpeedSetting.Name = "numericUpDownSpeedSetting";
            this.numericUpDownSpeedSetting.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownSpeedSetting.TabIndex = 1;
            this.numericUpDownSpeedSetting.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Скорость змейки в мс:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 636);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.LowerBorder);
            this.Controls.Add(this.UpperBorder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SnakeForm";
            this.Text = "SnakeForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузапродолжитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem натройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОИгреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox UpperBorder;
        private System.Windows.Forms.PictureBox LowerBorder;
        private System.Windows.Forms.PictureBox RightBorder;
        private System.Windows.Forms.PictureBox LeftBorder;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonApplySpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
    }
}