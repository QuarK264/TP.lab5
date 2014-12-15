namespace DAA.TP.lab5
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        private static void WordCount(List<string> ListWithoutCommas)
        {
            string pattern = @"\w+(?>[\s\.])";
            uint counter = 0;
            StreamWriter OutputText = new StreamWriter(File.Create(@"C:\Users\1\Documents\2 курс 3 семестр - Технология программирования\Лаб5\Result.txt"));
            foreach (string line in ListWithoutCommas)
            {                
                counter = (uint) Regex.Matches(line, pattern).Count;
                OutputText.WriteLine("{0} {1}", line, counter);
                
                counter = 0;
            }
            OutputText.Close();
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
                WordCount(Text.ListWithoutCommas);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
