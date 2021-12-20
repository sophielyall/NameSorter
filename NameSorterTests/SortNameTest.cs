using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Tests
{
    [TestClass()]
    public class NameSorterTests
    {
        [TestMethod()]
        public void SortNameTest()
        {
            Name name1 = new Name("Steven Joe", "Smith");
            Name name2 = new Name("Peter", "Jones");
            Name name3 = new Name("Mikayla", "Lopez");
            List<Name> testNames = new List<Name>();
            testNames.Add(name1);
            testNames.Add(name2);
            testNames.Add(name3);

            NameSorter sorter = new NameSorter();
            var sortedNames = sorter.sortName(testNames);

            List<Name> expected = new List<Name>();
            expected.Add(name2);
            expected.Add(name3);
            expected.Add(name1);

            CollectionAssert.AreEqual(expected, sortedNames);
        }
    }
}