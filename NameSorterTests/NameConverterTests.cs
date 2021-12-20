using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameSorter.Tests
{
    [TestClass()]
    public class NameConverterTests
    {
        [TestMethod()]
        public void nameSpilterTest()
        {
            string fullName = "Billy Thorne";
            string firstName = "Billy";
            string lastName = "Thorne";
            Name actual = new Name(firstName, lastName);
            NameConverter nameConverter = new NameConverter();
            Name expected = nameConverter.splitToName(fullName);

            Assert.AreEqual(expected.getFullName(), actual.getFullName());
        }
    }
}