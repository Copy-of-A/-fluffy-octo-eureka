using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubes_and_words
{
    class CubesHandler
    {
        //Список слов в словаре
        List<string> words = new List<string>();
        //матрица для кубиков
        char[,] cubes = new char[100, 6];
        //Количество кубиков
        int cubes_amount;

        //Получаем параметры с формы
        public void InputParametrs(List<string> _words, char[,] _cubes, int _cubes_amount)
        {
            words = _words;
            cubes = _cubes;
            cubes_amount = _cubes_amount;
        }

        //Поскольку нам подойдут только N-буквенные слова, где N - число кубков, то можем удалить (N+M)-буквенные слова (M != 0) 
        public List<string> Delete_words(List<string> list)
        {
            List<string> new_list = new List<string>();
            foreach (string word in list)
            {
                if (word.Length == cubes_amount)
                {
                    new_list.Add(word);
                }
            }
            return new_list;
        }

        public bool CheckHelp(int[,] mas)
        {
            bool flag;
            for (int j = 0; j < cubes_amount; j++) //столбец 
            {
                flag = false;
                for (int i = 0; i < cubes_amount && !flag; i++) //строка
                {
                    flag = mas[i, j] == 1;
                }
                if (!flag) return false;
            }
            return true;
        }

        //можно ли выложить данное слово из кубиков
        public bool Check_word(string listwrd)
        {
            int[,] nums = new int[cubes_amount,cubes_amount]; //номера кубиков, в которых есть текущая буква
            bool result = true;
            for (int i = 0; i < listwrd.Length; i++) // для каждой буквы в слове
            {
                for (int j = 0; j < cubes_amount; j++) //в каждом кубике 
                {
                    bool flag = false; // имеется ли буква хоть на 1 грани кубика
                    for (int k = 0; k < 6 && !flag; k++) //смотрим букву на грани
                        flag = listwrd[i] == cubes[j, k]; // если буква такая же как и на k-грани j-кубика
                    if (flag)
                    {
                        nums[i, j] = 1; //если хоть на одной грани j-кубика есть искомая буква, то запомнили номер кубика 
                    }
                }
            }
            result = CheckHelp(nums);
            return result;
        }

        public int Run(ref List<string> res)
        {
            int result = 0;
            words = Delete_words(words);
            foreach (string wrd in words)
            {
                if (Check_word(wrd))
                {
                    result++;
                    res.Add(wrd);
                }

            }
            return result;
        }
    }
}
