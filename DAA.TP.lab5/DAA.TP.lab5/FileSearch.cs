namespace DAA.TP.lab5
{
    using System.IO;

    static class FileSearch
    {
        public static string CheckPath()
        {
            DirectoryInfo Path = new DirectoryInfo(@"C:\Users\1\Documents\2 курс 3 семестр - Технология программирования\Лаб5\");
            if (Path.ToString().Length <= 32767)
            {
                if (Path.Exists)
                {
                    return Path.ToString();
                }
                else
                {
                    throw new DirectoryNotFoundException();
                }
            }
            else
            {
                throw new PathTooLongException();
            }
        }

        public static string CheckFile(string Path)
        {
            string FileName = "text.txt";
            FileInfo File = new FileInfo(Path + FileName);
            if (File.Exists)
            {
                return File.ToString();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
