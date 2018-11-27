namespace Cubes_and_words
{
    partial class MainForm
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
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView_Cubes = new System.Windows.Forms.DataGridView();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.listBox_dictionary = new System.Windows.Forms.ListBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.textBox_Word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cubes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(448, 334);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(75, 23);
            this.btn_About.TabIndex = 0;
            this.btn_About.Text = "Задание";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(448, 392);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dataGridView_Cubes
            // 
            this.dataGridView_Cubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cubes.Location = new System.Drawing.Point(233, 34);
            this.dataGridView_Cubes.Name = "dataGridView_Cubes";
            this.dataGridView_Cubes.ReadOnly = true;
            this.dataGridView_Cubes.Size = new System.Drawing.Size(169, 381);
            this.dataGridView_Cubes.TabIndex = 2;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(551, 221);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(115, 20);
            this.textBox_Result.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(448, 275);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Очистить";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.Location = new System.Drawing.Point(448, 34);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(221, 23);
            this.btn_LoadFromFile.TabIndex = 6;
            this.btn_LoadFromFile.Text = "Загрузить словарь из файла";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(566, 95);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(103, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Добавить слово";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // listBox_dictionary
            // 
            this.listBox_dictionary.FormattingEnabled = true;
            this.listBox_dictionary.Location = new System.Drawing.Point(12, 34);
            this.listBox_dictionary.Name = "listBox_dictionary";
            this.listBox_dictionary.Size = new System.Drawing.Size(215, 381);
            this.listBox_dictionary.TabIndex = 8;
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(448, 159);
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(70, 20);
            this.numUpDown.TabIndex = 9;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(534, 156);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(135, 23);
            this.btn_Generate.TabIndex = 10;
            this.btn_Generate.Text = "Сгенерировать кубики";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // textBox_Word
            // 
            this.textBox_Word.Location = new System.Drawing.Point(448, 97);
            this.textBox_Word.Name = "textBox_Word";
            this.textBox_Word.Size = new System.Drawing.Size(100, 20);
            this.textBox_Word.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "К-во кубиков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Словарь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(288, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Кубики";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(448, 218);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 16;
            this.btn_Run.Text = "Выполнить";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // listBox_Result
            // 
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.Location = new System.Drawing.Point(551, 268);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(115, 147);
            this.listBox_Result.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.listBox_Result);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.listBox_dictionary);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Word);
            this.Controls.Add(this.dataGridView_Cubes);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_About);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cubes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView_Cubes;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox listBox_dictionary;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox textBox_Word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.ListBox listBox_Result;
    }
}

