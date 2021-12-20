
using System;
namespace NameSorter { 
public class NameConverter
{
	public Name splitToName(string line)
	{

        string firstName = "";
        string[] names = line.Split(' ');
        int arrayLength = names.Length;
        //get surname from full name
        string lastName = names[arrayLength - 1];

        //get first names from full name
        if (arrayLength == 4)
        {
            firstName = names[0] + " " + names[1] + " " + names[2];

        }
        else if (arrayLength == 3)
        {
            firstName = names[0] + " " + names[1];

        }
        else
        {
            firstName = names[0];
        }

        Name aName = new Name(firstName, lastName);
        return aName;
    }
}
}