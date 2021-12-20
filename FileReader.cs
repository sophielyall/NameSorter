using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class FileReader
    {
        private StreamReader reader;
        public FileReader(string fileName)
        {
            reader = new StreamReader(fileName);
        }

        public List<string> readNames()
        {
            List<String> allNames = new List<string>();
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                allNames.Add(line);
            }

            return allNames;
        }


    }
}