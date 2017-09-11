using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace unScramble.Data
{
    struct MatchedWord
    {
        public string ScrambledWord { get; set; }
        public string Word { get; set; }

        public  string[] Read(string filename)
        {
            string[] fileContent;
            try
            {
                fileContent = File.ReadAllLines(filename);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fileContent;
        }
    }
}
