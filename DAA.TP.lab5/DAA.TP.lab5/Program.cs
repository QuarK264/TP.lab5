namespace DAA.TP.lab5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Path = FileSearch.CheckPath();
                string FilePath = FileSearch.CheckFile(Path);
                Console.WriteLine(FilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
