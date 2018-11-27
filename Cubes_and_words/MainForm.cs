using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cubes_and_words
{
    public partial class MainForm : Form
    {
        //Объект модуля с вспомогательными методами
        CubesHandler Handler = new CubesHandler();
        //Список слов в словаре
        List<string> words = new List<string>();
        //Количество кубиков
        int cubes_amount;
        //матрица для кубиков
        char[,] cubes = new char[100,6];
        const String chars = "abcdefghijklmnopqrstuvwxyz";
        List<string> result_words = new List<string>(); //список слов, которые можно выложить кубиками

        public MainForm()
        {
            InitializeComponent();
            btn_Run.Enabled = false;
            btn_Generate.Enabled = false;
        }

        //Условие задачи
        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "7. На детских кубиках с шести сторон изображены буквы. \n" +
                "Дан список слов, образующий словарь.\n" +
                "Необходимо подсчитать сколько слов из словаря можно выложить кубиками.\n" + 
                "b) Необходимо использовать все кубики.", "Кубики и слово.");
        }

        //Выход
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Очистить поля
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox_Result.Items.Clear();
            listBox_dictionary.Items.Clear();
            dataGridView_Cubes.Rows.Clear();
            words.Clear();
            result_words.Clear();
            textBox_Word.Clear();
            textBox_Result.Clear();
            btn_Run.Enabled = false;
        }

        //Загрузить словарь из текстового файла
        private void btn_LoadFromFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл|*.txt";
            openFile.Title = "Выберите текстовый файл со словарем";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                var fileStream = openFile.OpenFile();
            }
            StreamReader reader = new StreamReader(filePath);

            fileContent = reader.ReadLine();
            while (fileContent != null)
            {
                listBox_dictionary.Items.Add(fileContent);
                words.Add(fileContent.ToLower());
                fileContent = reader.ReadLine();
            }
            btn_Generate.Enabled = true;
        }

        //Добавить слово в словарь
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string word = textBox_Word.Text;
            if (word == "")
            {
                MessageBox.Show(this, "Поле ввода не может быть пустым", "Ошибка ввода!");
                textBox_Word.Focus();
            }
            else
            {
                bool success = true;
                for (int i = 0; i < word.Length && success; i++)
                {
                    //Если у нас символы не буквы
                    if (!Char.IsLetter(word[i]))
                    {
                        success = false;
                        MessageBox.Show(this, "Слово не может состоять из цифр или иных служебных символов!", "Ошибка ввода!");
                        textBox_Word.Clear();
                        textBox_Word.Focus();
                    }
                }
                if (success)
                {
                    listBox_dictionary.Items.Add(word);
                    words.Add(word.ToLower());
                    textBox_Word.Clear();
                    textBox_Word.Focus();
                    btn_Generate.Enabled = true;
                }
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cubes_amount; i++)
            {
                dataGridView_Cubes.Rows.Clear();
            }
            btn_Run.Enabled = true;
            words.Clear();
            result_words.Clear();
            listBox_Result.Items.Clear();
            textBox_Result.Clear();
            cubes_amount = (int)(numUpDown.Value);

            Random rnd = new Random();
            for (int i = 0; i < cubes_amount; i++)
            {
                dataGridView_Cubes.Rows.Add();
                for (int j = 0; j < 6; j++)
                {
                    char c = chars[rnd.Next(chars.Length)];
                    cubes[i, j] = c;
                    dataGridView_Cubes.Rows[i].Cells[j].Value = c;
                }                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView_Cubes.RowCount = 1;
            dataGridView_Cubes.ColumnCount = 6;
            dataGridView_Cubes.AutoResizeColumns();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            listBox_Result.Items.Clear();
            result_words.Clear();
            textBox_Result.Clear();
            Handler.InputParametrs(words, cubes, cubes_amount);
            textBox_Result.Text = Handler.Run(ref result_words).ToString();
            if (result_words.Count > 0)
            {
                foreach (string wrd in result_words)
                    listBox_Result.Items.Add(wrd);
            }
        }
    }
    
}
