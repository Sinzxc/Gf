namespace GF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.линейныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гиперболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параболакубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ветвьПараболыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тригонометрическиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрическиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кардиоидаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спиральToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.декартовЛистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураЛиссажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 902);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 100);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Location = new System.Drawing.Point(59, 26);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged_1);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(103, 26);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(9, 50);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 249);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(955, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 303);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простыеToolStripMenuItem,
            this.тригонометрическиеToolStripMenuItem,
            this.параметрическиеToolStripMenuItem});
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.графикиToolStripMenuItem.Text = "Графики";
            // 
            // простыеToolStripMenuItem
            // 
            this.простыеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параболаToolStripMenuItem,
            this.линейныйToolStripMenuItem,
            this.гиперболаToolStripMenuItem,
            this.параболакубToolStripMenuItem,
            this.ветвьПараболыToolStripMenuItem});
            this.простыеToolStripMenuItem.Name = "простыеToolStripMenuItem";
            this.простыеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.простыеToolStripMenuItem.Text = "Простые";
            this.простыеToolStripMenuItem.Click += new System.EventHandler(this.простыеToolStripMenuItem_Click);
            // 
            // параболаToolStripMenuItem
            // 
            this.параболаToolStripMenuItem.Name = "параболаToolStripMenuItem";
            this.параболаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.параболаToolStripMenuItem.Text = "Парабола (кв)";
            this.параболаToolStripMenuItem.Click += new System.EventHandler(this.параболаToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Location = new System.Drawing.Point(28, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 70);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шаг";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.numericUpDown3);
            this.panel4.Location = new System.Drawing.Point(246, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 70);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Параметр";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.numericUpDown4);
            this.panel5.Location = new System.Drawing.Point(497, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 70);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Параметр";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(103, 26);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 2;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(768, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // линейныйToolStripMenuItem
            // 
            this.линейныйToolStripMenuItem.Name = "линейныйToolStripMenuItem";
            this.линейныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.линейныйToolStripMenuItem.Text = "Линейный";
            this.линейныйToolStripMenuItem.Click += new System.EventHandler(this.линейныйToolStripMenuItem_Click);
            // 
            // гиперболаToolStripMenuItem
            // 
            this.гиперболаToolStripMenuItem.Name = "гиперболаToolStripMenuItem";
            this.гиперболаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гиперболаToolStripMenuItem.Text = "Гипербола";
            this.гиперболаToolStripMenuItem.Click += new System.EventHandler(this.гиперболаToolStripMenuItem_Click);
            // 
            // параболакубToolStripMenuItem
            // 
            this.параболакубToolStripMenuItem.Name = "параболакубToolStripMenuItem";
            this.параболакубToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.параболакубToolStripMenuItem.Text = "Парабола (куб)";
            this.параболакубToolStripMenuItem.Click += new System.EventHandler(this.параболакубToolStripMenuItem_Click);
            // 
            // ветвьПараболыToolStripMenuItem
            // 
            this.ветвьПараболыToolStripMenuItem.Name = "ветвьПараболыToolStripMenuItem";
            this.ветвьПараболыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ветвьПараболыToolStripMenuItem.Text = "Ветвь параболы";
            this.ветвьПараболыToolStripMenuItem.Click += new System.EventHandler(this.ветвьПараболыToolStripMenuItem_Click);
            // 
            // тригонометрическиеToolStripMenuItem
            // 
            this.тригонометрическиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.tanToolStripMenuItem,
            this.aTanToolStripMenuItem});
            this.тригонометрическиеToolStripMenuItem.Name = "тригонометрическиеToolStripMenuItem";
            this.тригонометрическиеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.тригонометрическиеToolStripMenuItem.Text = "Тригонометрические";
            // 
            // sinToolStripMenuItem
            // 
            this.sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            this.sinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sinToolStripMenuItem.Text = "Sin";
            this.sinToolStripMenuItem.Click += new System.EventHandler(this.sinToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cosToolStripMenuItem.Text = "Cos";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // tanToolStripMenuItem
            // 
            this.tanToolStripMenuItem.Name = "tanToolStripMenuItem";
            this.tanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tanToolStripMenuItem.Text = "Tan";
            this.tanToolStripMenuItem.Click += new System.EventHandler(this.tanToolStripMenuItem_Click);
            // 
            // aTanToolStripMenuItem
            // 
            this.aTanToolStripMenuItem.Name = "aTanToolStripMenuItem";
            this.aTanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aTanToolStripMenuItem.Text = "ATan";
            this.aTanToolStripMenuItem.Click += new System.EventHandler(this.aTanToolStripMenuItem_Click);
            // 
            // параметрическиеToolStripMenuItem
            // 
            this.параметрическиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кардиоидаToolStripMenuItem,
            this.спиральToolStripMenuItem,
            this.декартовЛистToolStripMenuItem,
            this.фигураЛиссажуToolStripMenuItem,
            this.розаToolStripMenuItem,
            this.эллипсToolStripMenuItem});
            this.параметрическиеToolStripMenuItem.Name = "параметрическиеToolStripMenuItem";
            this.параметрическиеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.параметрическиеToolStripMenuItem.Text = "Параметрические";
            // 
            // кардиоидаToolStripMenuItem
            // 
            this.кардиоидаToolStripMenuItem.Name = "кардиоидаToolStripMenuItem";
            this.кардиоидаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кардиоидаToolStripMenuItem.Text = "Кардиоида";
            this.кардиоидаToolStripMenuItem.Click += new System.EventHandler(this.кардиоидаToolStripMenuItem_Click);
            // 
            // спиральToolStripMenuItem
            // 
            this.спиральToolStripMenuItem.Name = "спиральToolStripMenuItem";
            this.спиральToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.спиральToolStripMenuItem.Text = "Спираль";
            this.спиральToolStripMenuItem.Click += new System.EventHandler(this.спиральToolStripMenuItem_Click);
            // 
            // декартовЛистToolStripMenuItem
            // 
            this.декартовЛистToolStripMenuItem.Name = "декартовЛистToolStripMenuItem";
            this.декартовЛистToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.декартовЛистToolStripMenuItem.Text = "Декартов лист";
            this.декартовЛистToolStripMenuItem.Click += new System.EventHandler(this.декартовЛистToolStripMenuItem_Click);
            // 
            // фигураЛиссажуToolStripMenuItem
            // 
            this.фигураЛиссажуToolStripMenuItem.Name = "фигураЛиссажуToolStripMenuItem";
            this.фигураЛиссажуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фигураЛиссажуToolStripMenuItem.Text = "Фигура Лиссажу";
            this.фигураЛиссажуToolStripMenuItem.Click += new System.EventHandler(this.фигураЛиссажуToolStripMenuItem_Click);
            // 
            // розаToolStripMenuItem
            // 
            this.розаToolStripMenuItem.Name = "розаToolStripMenuItem";
            this.розаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.розаToolStripMenuItem.Text = "Роза";
            this.розаToolStripMenuItem.Click += new System.EventHandler(this.розаToolStripMenuItem_Click);
            // 
            // эллипсToolStripMenuItem
            // 
            this.эллипсToolStripMenuItem.Name = "эллипсToolStripMenuItem";
            this.эллипсToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.эллипсToolStripMenuItem.Text = "Эллипс";
            this.эллипсToolStripMenuItem.Click += new System.EventHandler(this.эллипсToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параболаToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem линейныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гиперболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параболакубToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ветвьПараболыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тригонометрическиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрическиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кардиоидаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спиральToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem декартовЛистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураЛиссажуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

