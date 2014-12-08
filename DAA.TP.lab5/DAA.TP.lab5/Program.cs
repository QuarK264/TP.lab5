namespace DAA.TP.lab5
{
    using System;

    class Program
    {      
        static void Main(string[] args)
        {
            try
            {
                string Path = FileSearch.CheckPath();
                string FilePath = FileSearch.CheckFile(Path);
                SearchInFile.CreateStream(FilePath);
                //string Text = SearchInFile.CreateStream(FilePath);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadKey();
        }
    }
}
