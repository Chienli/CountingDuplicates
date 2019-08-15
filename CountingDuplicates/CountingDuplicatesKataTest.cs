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
    }
}