namespace DAA.TP.lab5
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    class SearchInFile
    {
        public List<string> ListText;
        public List<string> ListWithoutCommas;

        internal List<string> CreateStream(string FilePath)
        {
            StreamReader IncomingFile = new StreamReader(FilePath, Encoding.Unicode);
            string line;
            string pattern = @".+?[.!?]";
            ListText = new List<string>();
            line = IncomingFile.ReadToEnd();
            foreach (Match sentence in Regex.Matches(line, pattern, RegexOptions.IgnoreCase))
            {
                ListText.Add(sentence.Value.Trim());
            }

            return ListText;
        }

        internal List<string> CommasExclusion()
        {
            ListWithoutCommas = new List<string>();
            foreach (string line in ListText)
            {
                if (!line.Contains(","))
                {
                    ListWithoutCommas.Add(line);
                }
            }
            return ListWithoutCommas;
        }

    }
}
