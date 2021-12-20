using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorter
{
    public class Program
    {
        static void Main(string[] args)
        {   //read names from file
            FileReader reader = new FileReader(args[0]);
            List<String> allNames = reader.readNames();
            List<Name> unsortedNames = new List<Name>();
            foreach (string line in allNames)
            {

                NameConverter converter = new NameConverter();  
                //add name to 
                Name aName = converter.splitToName(line);
                unsortedNames.Add(aName);

            }
            NameSorter sorter = new NameSorter();
            //sort the names in the file
            var sortedNames = sorter.sortName(unsortedNames);
           
            FileWriter writer = new FileWriter("sorted-name-list.txt");
            writer.WriteNames(sortedNames);
        }


    }
}

