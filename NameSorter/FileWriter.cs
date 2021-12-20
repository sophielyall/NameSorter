using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class FileWriter
    {
        private StreamWriter writer;

        public FileWriter(String fileName)
        {
            writer = new StreamWriter(fileName);
        }

        public void WriteNames(List<Name> listOfNames)
        {
            foreach (Name name in listOfNames)
            {
                writer.WriteLine(name.getFullName());
            }
            writer.Close();
        }


    }
}
