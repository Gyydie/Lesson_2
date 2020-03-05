using System;
using System.Collections.Generic;
using System.Text;

// Архипов Денис


//Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения,  которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив 
//слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
//Здесь требуется использовать класс Dictionary.


namespace ConsoleApp1
{
    static class Message
    {
        static public string text;


        static Message()
        {
            text = "Карл у Клары украл рекламу, а Клара у Карла украла бюджет.";
        }


        static public void GetWordsLenght (int lenght)
        {
            string[] words = text.Split(new Char [] { ',', ';', '-', ' ', '\t', '\n' });

            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length <= lenght)
                {
                    Console.Write(word + " ");
                }
            }
        }

        static public void DeleteWordByEndChar(char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });


            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word == "")
                {
                    continue;
                }
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
        }

        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }

        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }
    }
}
