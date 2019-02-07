using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Синицын
/*Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
*/

namespace dz_5._2
{
    /// <summary>
    /// Класс для обработки текста
    /// </summary>
    static class Message
    {
        /// <summary>
        /// Выводит только те слова сообщения,  которые содержат не более n букв
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="maxletters">Максимальное количество символов</param>
        /// <returns>Строка слов соотвествующих заданным параметрам</returns>
        public static string WordFiltr(string text, int maxletters)
        {
            string[] delim = new string[] { ",", " " };
            string[] parts = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < parts.Length; i++)
            {

                if(parts[i].Length <= maxletters)
                {
                    result += parts[i] + " ";
                }
            }
            return result;
        }
        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="letterEnd">Заданный символ</param>
        /// <returns>Строка слов соотвествующих заданным параметрам</returns>
        public static string RemoveAt(string text, char letterEnd)
        {
            string[] delim = new string[] { ",", " " };
            string[] parts = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < parts.Length; i++)
            {
                if (!(parts[i][parts[i].Length -1] == letterEnd))
                {
                    result += parts[i] + " ";
                }
            }
            return result;
        }
        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на заданные символы.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="letterEnd">Массив символов</param>
        /// <returns>Строка слов соотвествующих заданным параметрам</returns>
        public static string RemoveAt(string text, char[] letterEnd)
        {
            string[] delim = new string[] { ",", " " };
            string[] parts = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < parts.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < letterEnd.Length; j++)
                {
                    if (!(parts[i][parts[i].Length - 1] == letterEnd[j]))
                    {
                        count++;
                        if(count == letterEnd.Length) result += parts[i] + " ";
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Ищет самое длинное слово сообщения(если их несколько, то записывает их через пробел)
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <returns>Строка слов соотвествующих заданным параметрам</returns>
        public static string WordMaxLength(string text)
        {
            string[] delim = new string[] { ",", " " };
            string[] parts = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            string result = parts[0];
            string result2 = "";
            int max = parts[0].Length;

            for(int i = 1; i < parts.Length; i++)
            {
                if (parts[i].Length > max)
                {
                    max = parts[i].Length;
                    result = parts[i];
                }
            }
            for(int i = 1; i < parts.Length; i++)
            {
                if (parts[i].Length == max)
                {
                    result2 += parts[i] + " ";
                }
            }
            return result2;
        }
        /// <summary>
        /// Формирует строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <returns>Экземпляр класса StringBuilder</returns>
        public static StringBuilder MaxWordsSB(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append (WordMaxLength(text));
            return sb;
        }
       //// ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается текст и массив слов,
       ////в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.
       //public static int FreqTest(string text, string[] arrword)
       // {
       //     Dictionary<string, string> keys = new Dictionary<string,string>();
       //     keys.
       // }
    }
    class Program
    {
        public static void PrintStrArr(string[] s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        static void Main(string[] args)
        {
            
            string message = "Мяч, еж, голубая ель, перо, пернатая утка, фрукт, длинная трость, одежда, сломанная ветка, новый велосипед";
            string[] delim = new string[] { ",", " " };
            string[] parts = message.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            char[] sep = {'ь','а','о'}; 
            PrintStrArr(parts);

            //Console.WriteLine(Message.WordFiltr(message, 3));
            //Console.ReadLine();

            //Console.WriteLine(Message.RemoveAt(message, 'ь'));
            //Console.ReadLine();

            //Console.WriteLine(Message.RemoveAt(message, sep));
            //Console.ReadLine();

            string message1 = "Яд, мяч, ком, лом, тор, кот, рот, ель";
            Console.WriteLine(Message.WordMaxLength(message1));
            Console.ReadLine();

            var maxwords = Message.MaxWordsSB(message1);
            Console.WriteLine(maxwords);
            Console.ReadLine();

        }
    }
}
