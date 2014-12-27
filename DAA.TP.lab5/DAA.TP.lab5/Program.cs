namespace DAA.TP.lab5
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        private static int WordCount(string sentence)
        {
            string pattern = @"\w+(?>[\s\.])";
            return Regex.Matches(sentence, pattern).Count;
        }

        private static void OutputResult(List<string> ListWithoutCommas)
        {
            StreamWriter OutputText = new StreamWriter(File.Create(@"C:\Users\1\Documents\2 курс 3 семестр - Технология программирования\Лаб5\Result.txt"));
            foreach (string sentence in ListWithoutCommas)
            {
                OutputText.WriteLine(WordCount(sentence));
            }
            OutputText.Close();
            Console.WriteLine("Программа подсчитывает количество слов в предложениях без запятых и выводит результат работы в файл.");
            Console.WriteLine(@"Результат работы программы вы можете найти в папке C:\Users\1\Documents\2 курс 3 семестр - Технология программирования\Лаб5");
        }

        static void Main()
        {
            SearchInFile Text = new SearchInFile();
            try
            {
                string Path = FileSearch.CheckPath();
                string FilePath = FileSearch.CheckFile(Path);
                Text.CreateStream(FilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Text.CommasExclusion();
            try
            {
                OutputResult(Text.ListWithoutCommas);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
