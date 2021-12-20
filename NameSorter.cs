using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class NameSorter
    {
        public List<Name> sortName(List<Name> unsortedNames)
        {
            var sortedNames = unsortedNames.OrderBy(name => name.lastName).ThenBy(Name => Name.firstName).ToList();
            return sortedNames;
        }
    }
}