namespace DAA.TP.lab5
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class SearchInFile
    {
        public static List<string> CreateStream(string FilePath)
        {
            StreamReader IncomingFile = new StreamReader(FilePath, Encoding.Unicode);
            StringBuilder Text = new StringBuilder(IncomingFile.ToString());
            List<string> ListText = new List<string>();
            while (Text != null)
            {
                
            }
        }
    }
}
