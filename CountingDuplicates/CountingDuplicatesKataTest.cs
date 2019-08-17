using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingDuplicates
{
    [TestClass]
    public class CountingDuplicatesKataTest
    {
        private readonly CountingDuplicatesKata _kata = new CountingDuplicatesKata();

        [TestMethod]
        public void Empty_return_0()
        {
            var actual = _kata.DuplicateCount("");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void String_abcde_return_0()
        {
            var actual = _kata.DuplicateCount("abcde");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void String_aabbcde_return_2()
        {
            var actual = _kata.DuplicateCount("aabbcde");

            Assert.AreEqual(2, actual);
        }
    }
}