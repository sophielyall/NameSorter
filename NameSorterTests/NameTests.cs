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
    public class NameTests
    {
        [TestMethod()]
        public void getFullNameTest()
        {
            string fullName = "Steven Smith";
            string firstName = "Steven";
            string lastName = "Smith";
            Name testName = new Name(firstName, lastName);

            Assert.AreEqual(fullName, testName.getFullName());
        }
    }
}